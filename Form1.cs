using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintClone
{
    public class TPanel:Panel
    {
        public TPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

    }
    public partial class Form1 : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public Graphics g;
        public Pen p = new Pen(Color.Black, 5);
        Bitmap btm;
        Graphics graph;

        public Form1()
        {
            InitializeComponent();
            ChangeCursor();
            g = ZonaScris.CreateGraphics();

          
          
            
            btm = new Bitmap(ZonaScris.Width, ZonaScris.Height);

            graph = Graphics.FromImage(btm);
            ZonaScris.BackgroundImage = btm;
            ZonaScris.BackgroundImageLayout = ImageLayout.Stretch;
            graph.Clear(Color.White);       
        }
        private void Form1_Load(object sender, EventArgs e)
        {
              
        }

      
         
        //white
        private void button1_Click(object sender, EventArgs e)
        {
            currentColor.BackColor = Color.White;
            p.Color = Color.White;
        }

        private void RedCol_Click(object sender, EventArgs e)
        {
            currentColor.BackColor = Color.Red;
            p.Color = Color.Red;
        }
        //blue
        private void button3_Click(object sender, EventArgs e)
        {
            currentColor.BackColor = Color.Blue;
            p.Color = Color.Blue;
        }

        private void YellowCol_Click(object sender, EventArgs e)
        {
            currentColor.BackColor = Color.Yellow;
            p.Color = Color.Yellow;
        }

        private void GreenCol_Click(object sender, EventArgs e)
        {
            currentColor.BackColor = Color.Green;
            p.Color = Color.Green;
        }

        private void PurpleCol_Click(object sender, EventArgs e)
        {
            currentColor.BackColor = Color.Purple;
            p.Color = Color.Purple;
        }

        private void PinkCol_Click(object sender, EventArgs e)
        {
            currentColor.BackColor = Color.Pink;
            p.Color = Color.Pink;
        }
        private void BlackCol_Click(object sender, EventArgs e)
        {
            currentColor.BackColor = Color.Black;
            p.Color = Color.Black;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }
        void ChangeCursor()
        {
            Bitmap bmp = new Bitmap(Properties.Resources.penu);
            Cursor c = new Cursor(bmp.GetHicon());
            ZonaScris.Cursor = c;
            ZonaMeniu.Cursor = c;
        }

        private void button7_Click(object sender, EventArgs e)
        {
               
                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "JPG(*.JPG)|*.jpg";
             
                if (f.ShowDialog() == DialogResult.OK)
                {
                    btm.Save(f.FileName);
                }
        }

        private void ZonaScris_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void ZonaScris_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                current = e.Location;
                graph.DrawLine(p, old, current);
                old = current;
                ZonaScris.Invalidate();
            }
        }
    }
}
