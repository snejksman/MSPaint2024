using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPaint2024
{
    public partial class Form1 : Form
    {
        // kreslici objekt grafiky - pointer
        Graphics mobjGrafika;
        
        // nastroj na kresleni
        enum enTools { Line, Box, Circle }
        enTools menActualTool;
        bool mbjImDrawing;

        // barvy kresleni
        Color mobjForeColor;
        Color mobjBackColor;

        // souradnice kresleneho objektu
        Point mobjDrawingCoordsStart;
        Point mobjDrawingCoordsEnd;

        //
        // konstruktor
        //

        public Form1()
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
        }

        //
        // test tlacitko  - smazat
        //
        private void button1_Click(object sender, EventArgs e)
        {
            Pen tuzka = new Pen(Color.ForestGreen, 3);
            mobjGrafika.DrawLine(Pens.Aqua, 45, 87, 620, 540);

            mobjGrafika.FillEllipse(Brushes.Bisque, 200, 200, 200, 200);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ssBottom_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

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

                    NakresliObjekt();

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
        private void NakresliObjekt()
        {
            try
            {
                Pen lobjPero;
                lobjPero = new Pen(mobjForeColor);

                Brush lobjStetec;
   //lobjStetec = new Brush(mobjForeColor);
                // vybrat co kreslim
                switch (menActualTool)
                {
                    case enTools.Line:

                        // nakresli caru
                         mobjGrafika.DrawLine(lobjPero, mobjDrawingCoordsStart, mobjDrawingCoordsEnd);
                        break;

                    case enTools.Box:
     // mobjGrafika.FillRectangle(, mobjDrawingCoordsStart, mobjDrawingCoordsEnd);
                        break;

                }
            }
            catch 
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

                // nastavit spravnou barvu
                if (e.Button == MouseButtons.Left)
                {
                    //zobrazit
                    pnForeColor.BackColor = lobjPanel.BackColor;

                    // zapsat
                    mobjForeColor=lobjPanel.BackColor;
                }
            }
            catch (Exception ex)
            {
              
            }
        }
    }
}
