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
         
        public Form1()
        {
            InitializeComponent();
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
            Pen vtuzka = new Pen(Color.ForestGreen, 3);
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

        private void pbPlatno_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                // souradnice mysi do statusu
                tsSouradniceMysi.Text = "x:" + e.X.ToString();
                tsSouradniceMysi.Text = "y:" + e.Y.ToString();
            }
            catch(Exception ex) 
            {
                
            }
        }
    }
}
