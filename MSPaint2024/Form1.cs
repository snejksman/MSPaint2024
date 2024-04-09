
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPaint2024
{
    public partial class fOkno : Form
    {
        // kreslici objekt grafiky - pointer
        Graphics mobjGrafika;

        // kreslici objekt v pameti
        Bitmap mobjBitmapa;
        Graphics mobjGrafikaVram;
        
        // nastroj na kresleni
        enum enTools { Line, Rectangle, Ellipse, Pen }
        enTools menActualTool;
        bool mbjImDrawing;

        // barvy kresleni
        Color mobjForeColor;
        Color mobjBackColor;

        // souradnice kresleneho objektu
        Point mobjDrawingCoordsStart;
        Point mobjDrawingCoordsEnd;

        // rozmery obdelniku
        Rectangle mobjDrawingRectangle;
        Size mobjDrawingSize;

        //
        // konstruktor
        //

        public fOkno()
        {
            InitializeComponent();

            // nastavení proměnných
            menActualTool = enTools.Line;
            mobjBackColor = Color.White;
            mobjForeColor = Color.Black;
            mbjImDrawing = false;
        }

        //
        // nahrani okna do pameti
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            //vytvoreni grafiky na pictureboxu
            mobjGrafika = pbPlatno.CreateGraphics();

            // vytvoreni grafiky v pameti
            mobjBitmapa = new Bitmap(pbPlatno.Width, pbPlatno.Height);
            mobjGrafikaVram = Graphics.FromImage(mobjBitmapa);
            mobjGrafikaVram.Clear(Color.White);
        }

        //
        // souradnice mysi na platnu
        //
        private void pbPlatno_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                //souřadnice myši do statusu
                tsSouradniceMysi.Text = "x:" + e.X.ToString() + "y:" + e.Y.ToString();
                if (e.Button == MouseButtons.Left)
                {
                    //zaznamenat souřadnice
                    mobjDrawingCoordsEnd.X = e.X;
                    mobjDrawingCoordsEnd.Y = e.Y;

                    //nakopírovat na picturebox
                    mobjGrafika.DrawImage(mobjBitmapa, 0, 0);
                    //Nakresli
                    NakresliObjekt(mobjGrafika);

                    // kresleni perem
                    if (menActualTool == enTools.Pen)
                    {
                        if (mbjImDrawing == true)
                        {
                            // nakresleni cary
                            NakresliObjekt(mobjGrafikaVram);
                            mobjGrafika.DrawImage(mobjBitmapa, 0, 0);
                        }
                        // posunuti souradnic 
                        mobjDrawingCoordsStart = mobjDrawingCoordsEnd;
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(":(");
            }
        }
        //
        // stisk mysi na picturebox
        //
        private void pbPlatno_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                // test na leve tlacitko
                if (e.Button== MouseButtons.Left)
                {
                    // zaznamenat souradnice
                    mobjDrawingCoordsStart.X = e.X;  
                    mobjDrawingCoordsStart.Y = e.Y;

                    //kreslim
                    mbjImDrawing = true;
                }
            }
            catch (Exception ex)
            {
                // nekreslim
                mbjImDrawing = false;
            }

        }

        private void pbPlatno_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                // test na leve tlacitko
                if (e.Button == MouseButtons.Left)
                {
                    // zaznamenat souradnice
                    mobjDrawingCoordsEnd.X = e.X;
                    mobjDrawingCoordsEnd.Y = e.Y;

                    // nakresli objekt do pameti
                    NakresliObjekt(mobjGrafikaVram);
                    mobjGrafika.DrawImage(mobjBitmapa, 0, 0);

                    mbjImDrawing = false;

                }

            }
            catch (Exception ex)
            {
                // nekreslim
                mbjImDrawing = false;
            }
        }

        //
        // nakresleni objektu
        //
        private void NakresliObjekt(Graphics objGrafika)
        {
            try
            {
                // vytvoreni potrebnych per, stetcu a rectanglu
                Pen lobjPero;
                lobjPero = new Pen(mobjForeColor);
                lobjPero.Width = tbWidth.Value;

                SolidBrush lobjStetecForeColor;
                lobjStetecForeColor = new SolidBrush(mobjForeColor);

                Pen lobjPeroBackColor;
                lobjPeroBackColor = new Pen(mobjBackColor);
                lobjPeroBackColor.Width = tbWidth.Value;

                mobjDrawingSize.Width = mobjDrawingCoordsEnd.X - mobjDrawingCoordsStart.X;
                mobjDrawingSize.Height = mobjDrawingCoordsEnd.Y - mobjDrawingCoordsStart.Y;
                mobjDrawingRectangle = new Rectangle(mobjDrawingCoordsStart, mobjDrawingSize);

                // vybrat co kreslim
                switch (menActualTool)
                {
                    case enTools.Line:

                        // nakresli caru
                        objGrafika.DrawLine(lobjPero, mobjDrawingCoordsStart, mobjDrawingCoordsEnd);
                        break;

                    case enTools.Rectangle:

                        // vypln obdelnik
                        objGrafika.FillRectangle(lobjStetecForeColor, mobjDrawingRectangle);
                        objGrafika.DrawRectangle(lobjPeroBackColor, mobjDrawingRectangle);
                        break;

                    case enTools.Ellipse:

                        // vypln elipsu
                        objGrafika.FillEllipse(lobjStetecForeColor, mobjDrawingRectangle);
                        objGrafika.DrawEllipse(lobjPeroBackColor, mobjDrawingRectangle);
                        break;

                        // kresli perem
                    case enTools.Pen:
                        objGrafika.DrawLine(lobjPero, mobjDrawingCoordsStart, mobjDrawingCoordsEnd);
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(":(");
            }

        }

        //
        // vyber barvy pro kresleni
        //
        private void pnColor_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Panel lobjPanel;

                // nastavit kdo mi to posila
                lobjPanel = (Panel)sender;

                // nastavit ForeColor barvu
                if (e.Button == MouseButtons.Left)
                {
                    // zobrazit
                    pnForeColor.BackColor = lobjPanel.BackColor;

                    // zapsat
                    mobjForeColor=lobjPanel.BackColor;
                }

                // nastavit BackColor barvu
                if (e.Button == MouseButtons.Right)
                {
                    pnBackColor.BackColor = lobjPanel.BackColor;

                    mobjBackColor=lobjPanel.BackColor;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(":(");
            }
        }

        //
        // vybrani nastroje
        //
        private void rbTool_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // stanoveni radio buttonu jako sendera
                RadioButton lobjTool = (RadioButton)sender;

                // ktery nastroj je vybrany
                switch (lobjTool.Text)
                {
                    case "Line":
                        menActualTool = enTools.Line;
                        break;

                    case "Rectangle":
                        menActualTool = enTools.Rectangle;
                        break;

                    case "Pen":
                        menActualTool = enTools.Pen;
                        break;

                    case "Ellipse":
                        menActualTool = enTools.Ellipse;
                        break;
                }
            }
            catch (Exception ex)           
            {
                MessageBox.Show(":(");
            }
        }

        //
        // konec aplikace
        //
        private void tsmiKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //
        // ulozit nakresleny obrazek
        //
        private void tsmiUlozit_Click(object sender, EventArgs e)
        {
            try
            {
                //výběr formátů
                saveFileDialog.Filter = "PNG|*.png;|JPEG|*.jpeg;|BMP|*.bmp;|GIF|*.gif;";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string selectedFilePath = saveFileDialog.FileName;

                    // jaký formát byl vybrán
                    ImageFormat format;
                    switch (Path.GetExtension(selectedFilePath).ToLower())
                    {
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".jpeg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".gif":
                            format = ImageFormat.Gif;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(":(");
            }
        }

        //
        // otevreni obrazku
        //
        private void tsmiOtevrit_Click(object sender, EventArgs e)
        {
            Bitmap mobjBitmapOF;
            try
            {
                // vyfiltrovani formatu souboru
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

                // nacteni obrazku z uloziste
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // nahrani obrazku na bitmapu
                    mobjBitmapOF = new Bitmap(openFileDialog.FileName);
                    mobjGrafikaVram.DrawImage(mobjBitmapOF, 0, 0);
                    mobjGrafika.DrawImage(mobjBitmapOF, 0, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(":(");
            }
        }

        //
        // smazat vsechno nakreslene
        //
        private void btClear_Click(object sender, EventArgs e)
        {
            // vyplni pozadi bilou barvou
            pbPlatno.BackColor = Color.White;
        }
    }
}