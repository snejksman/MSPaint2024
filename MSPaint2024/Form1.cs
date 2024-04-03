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
                // souradnice mysi do statusu
                tsSouradniceMysi.Text = "x:" + e.X.ToString() + " y:" + e.Y.ToString();

                mobjDrawingCoordsStart.X = e.X;
                mobjDrawingCoordsStart.Y = e.Y;


                // volne kresleni
                if (menActualTool == enTools.Pen)
                { 
                    if (mbjImDrawing == true)
                    {
                        mobjDrawingCoordsStart.X = e.X;
                        mobjDrawingCoordsStart.Y = e.Y;

                        // nakresli objekt na picturebox
                        mobjGrafika.DrawImage(mobjBitmapa, 0, 0);


                        NakresliObjekt(mobjGrafikaVram);

;
                    }
                }
                // nakresli objekt na picturebox
                /* mobjGrafika.Clear(Color.White);
                mobjGrafika.DrawImage(mobjBitmapa, 0, 0);
                NakresliObjekt(mobjGrafika); */
            }
            catch(Exception ex) 
            {
                
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

                    mobjGrafika.DrawImage(mobjBitmapa,0,0);

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
                // vytvoreni potrebnych per a stetcu
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

                    case enTools.Pen:

                        // volne kresleni perem
                        objGrafika.DrawLine(lobjPero, mobjDrawingCoordsStart, mobjDrawingCoordsEnd);
                        mobjDrawingCoordsEnd = mobjDrawingCoordsStart;
                        break;
                    // DOPLNIT VYNULOVNI KONCOVE COORD
                }
            }
            catch (Exception ex)
            {
                
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
              
            }
        }

        //
        // vybrani nastroje
        //

        private void rbTool_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                RadioButton lobjTool = (RadioButton)sender;

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
                saveFileDialog1.ShowDialog();

                // mobjBitmapa.Save("c:\\temp\\obrazek.jpg", ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {

            }
        }
        private void tsmiOtevrit_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            // mobjGrafika.DrawImage(, 0, 0);
        }
    }
}
