using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace PaintMateuszMróz54307
{
    
    public partial class Form1 : Form
    {
        private Bitmap panelR;
        bool startPaint = false;
        Graphics g;
        int? initX = null;
        int? initXx = null;
        int? initY = null;
        int? initYy = null;
        bool rysProstokat = false;
        bool rysKolo = false;
        bool rysEllipsa = false;
        bool rysLinia = false;
        bool rysGumka = false;
        bool rysTrujkat = false;
        bool rysTrujkat1 = false;
        public Form1()
        {
            InitializeComponent();
            panelR = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(panelR);
            g.Clear(Color.White);
            pictureBox1.Image = panelR;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //g = panel1.CreateGraphics();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy zamknąć program?", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            switch(dr)
            {
                case DialogResult.Yes: ; break;
                case DialogResult.No: e.Cancel = true; break;
                default: e.Cancel = true; break;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            initXx = e.X;
            initYy = e.Y;
            startPaint = true;
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint==true)
            {
                if (rysLinia == true)
                {
                    Pen pen = new Pen(button_PenKolor.BackColor, float.Parse(comboBox_WielkoscP.Text));
                    g.DrawLine(pen, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                    pictureBox1.Refresh();
                }
                if (rysGumka == true)
                {
                    Pen pen = new Pen(buttonTlo.BackColor, (float)100.0);
                    g.DrawLine(pen, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                    pictureBox1.Refresh();
                }
                initX = e.X;
                initY = e.Y;
            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int szerokosc = 0;
            int dlugosc =0;
            szerokosc= (int)(initXx - initX);
            dlugosc= (int)(initYy - initY);
            
            if(szerokosc>=0 && dlugosc>=0)
            {
                if (rysProstokat == true)
                {

                    //Console.WriteLine(dlugosc);
                    //Console.WriteLine(szerokosc);
                    SolidBrush sb = new SolidBrush(button_PenKolor.BackColor);
                    g.FillRectangle(sb, (int)initX, (int)initY, szerokosc, dlugosc);
                    startPaint = false;
                    pictureBox1.Refresh();
                }

                if (rysEllipsa == true)
                {
                    SolidBrush sb = new SolidBrush(button_PenKolor.BackColor);
                    g.FillEllipse(sb, (int)initX, (int)initY, szerokosc, dlugosc);
                    startPaint = false;
                    pictureBox1.Refresh();
                }
                if (rysKolo == true)
                {
                    SolidBrush sb = new SolidBrush(button_PenKolor.BackColor);
                    g.FillEllipse(sb, (int)initX, (int)initY, szerokosc, dlugosc);
                    startPaint = false;
                    pictureBox1.Refresh();
                }
                if(rysTrujkat==true)
                {
                    PointF point1 = new PointF((float)initX, (float)initYy);
                    PointF point2 = new PointF((float)initXx, (float)initYy);
                    PointF point3 = new PointF((float)((initX+initXx)/2), (float)initY);
                    PointF[] Points ={point1,point2,point3};
                    Pen sb = new Pen(button_PenKolor.BackColor, float.Parse(comboBox_WielkoscP.Text));
                    g.DrawPolygon(sb, Points);
                    pictureBox1.Refresh();
                }
                if (rysTrujkat1 == true)
                {
                    PointF point1 = new PointF((float)initX, (float)initYy);
                    PointF point2 = new PointF((float)initXx, (float)initYy);
                    PointF point3 = new PointF((float)(initXx), (float)initY);
                    PointF[] Points = { point1, point2, point3 };
                    Pen sb = new Pen(button_PenKolor.BackColor, float.Parse(comboBox_WielkoscP.Text));
                    g.DrawPolygon(sb, Points);
                    pictureBox1.Refresh();
                }

            }
            if (szerokosc <= 0 && dlugosc <= 0)
            {
                if (rysProstokat == true)
                {
                    szerokosc = szerokosc * (-1);
                    dlugosc = dlugosc * (-1);
                    //Console.WriteLine(dlugosc);
                    //Console.WriteLine(szerokosc);
                    SolidBrush sb = new SolidBrush(button_PenKolor.BackColor);
                    g.FillRectangle(sb, (int)initXx, (int)initYy, szerokosc, dlugosc);
                    startPaint = false;
                    pictureBox1.Refresh();
                }

                if (rysEllipsa == true)
                {
                    szerokosc = szerokosc * (-1);
                    dlugosc = dlugosc * (-1);
                    SolidBrush sb = new SolidBrush(button_PenKolor.BackColor);
                    g.FillEllipse(sb, (int)initXx, (int)initYy, szerokosc, dlugosc);
                    startPaint = false;
                    pictureBox1.Refresh();
                }

                if (rysKolo == true)
                {
                    szerokosc = szerokosc * (-1);
                    dlugosc = dlugosc * (-1);
                    SolidBrush sb = new SolidBrush(button_PenKolor.BackColor);
                    g.FillEllipse(sb, (int)initXx, (int)initYy, szerokosc, dlugosc);
                    startPaint = false;
                    pictureBox1.Refresh();
                }
                if (rysTrujkat == true)
                {
                    PointF point1 = new PointF((float)initX, (float)initYy);
                    PointF point2 = new PointF((float)initXx, (float)initYy);
                    PointF point3 = new PointF((float)((initX + initXx) / 2), (float)initY);
                    PointF[] Points = { point1, point2, point3 };
                    Pen sb = new Pen(button_PenKolor.BackColor, float.Parse(comboBox_WielkoscP.Text));
                    g.DrawPolygon(sb, Points);
                    pictureBox1.Refresh();
                }
                if (rysTrujkat1 == true)
                {
                    PointF point1 = new PointF((float)initX, (float)initYy);
                    PointF point2 = new PointF((float)initXx, (float)initYy);
                    PointF point3 = new PointF((float)(initXx), (float)initY);
                    PointF[] Points = { point1, point2, point3 };
                    Pen sb = new Pen(button_PenKolor.BackColor, float.Parse(comboBox_WielkoscP.Text));
                    g.DrawPolygon(sb, Points);
                    pictureBox1.Refresh();
                }
            }
            if (szerokosc <= 0 && dlugosc >= 0)
            {
                if (rysProstokat == true)
                {
                    szerokosc = szerokosc * (-1);
                    //Console.WriteLine(dlugosc);
                    //Console.WriteLine(szerokosc);
                    SolidBrush sb = new SolidBrush(button_PenKolor.BackColor);
                    g.FillRectangle(sb, (int)initXx, (int)initY, szerokosc, dlugosc);
                    startPaint = false;
                    pictureBox1.Refresh();
                }

                if (rysEllipsa == true)
                {
                    szerokosc = szerokosc * (-1);
                    SolidBrush sb = new SolidBrush(button_PenKolor.BackColor);
                    g.FillEllipse(sb, (int)initXx, (int)initY, szerokosc, dlugosc);
                    startPaint = false;
                    pictureBox1.Refresh();
                }
                if (rysKolo == true)
                {
                    szerokosc = szerokosc * (-1);
                    SolidBrush sb = new SolidBrush(button_PenKolor.BackColor);
                    g.FillEllipse(sb, (int)initXx, (int)initY, szerokosc, dlugosc);
                    startPaint = false;
                    pictureBox1.Refresh();
                }
                if (rysTrujkat == true)
                {
                    PointF point1 = new PointF((float)initX, (float)initYy);
                    PointF point2 = new PointF((float)initXx, (float)initYy);
                    PointF point3 = new PointF((float)((initX + initXx) / 2), (float)initY);
                    PointF[] Points = { point1, point2, point3 };
                    Pen sb = new Pen(button_PenKolor.BackColor, float.Parse(comboBox_WielkoscP.Text));
                    g.DrawPolygon(sb, Points);
                    pictureBox1.Refresh();
                }
                if (rysTrujkat1 == true)
                {
                    PointF point1 = new PointF((float)initX, (float)initYy);
                    PointF point2 = new PointF((float)initXx, (float)initYy);
                    PointF point3 = new PointF((float)(initXx), (float)initY);
                    PointF[] Points = { point1, point2, point3 };
                    Pen sb = new Pen(button_PenKolor.BackColor, float.Parse(comboBox_WielkoscP.Text));
                    g.DrawPolygon(sb, Points);
                    pictureBox1.Refresh();
                }
            }
            if (szerokosc >= 0 && dlugosc <= 0)
            {
                if (rysProstokat == true)
                {
                    dlugosc = dlugosc * (-1);
                    //Console.WriteLine(dlugosc);
                    //Console.WriteLine(szerokosc);
                    SolidBrush sb = new SolidBrush(button_PenKolor.BackColor);
                    g.FillRectangle(sb, (int)initX, (int)initYy, szerokosc, dlugosc);
                    startPaint = false;
                    pictureBox1.Refresh();
                }

                if (rysEllipsa == true)
                {
                    dlugosc = dlugosc * (-1);
                    SolidBrush sb = new SolidBrush(button_PenKolor.BackColor);
                    g.FillEllipse(sb, (int)initX, (int)initYy, szerokosc, dlugosc);
                    startPaint = false;
                    pictureBox1.Refresh();
                }
                if (rysKolo == true)
                {
                    dlugosc = dlugosc * (-1);
                    SolidBrush sb = new SolidBrush(button_PenKolor.BackColor);
                    g.FillEllipse(sb, (int)initX, (int)initYy, szerokosc, dlugosc);
                    startPaint = false;
                    pictureBox1.Refresh();
                }
                if (rysTrujkat == true)
                {
                    PointF point1 = new PointF((float)initX, (float)initYy);
                    PointF point2 = new PointF((float)initXx, (float)initYy);
                    PointF point3 = new PointF((float)((initX + initXx) / 2), (float)initY);
                    PointF[] Points = { point1, point2, point3 };
                    Pen sb = new Pen(button_PenKolor.BackColor, float.Parse(comboBox_WielkoscP.Text));
                    g.DrawPolygon(sb, Points);
                    pictureBox1.Refresh();
                }
                if (rysTrujkat1 == true)
                {
                    PointF point1 = new PointF((float)initX, (float)initYy);
                    PointF point2 = new PointF((float)initXx, (float)initYy);
                    PointF point3 = new PointF((float)(initXx), (float)initY);
                    PointF[] Points = { point1, point2, point3 };
                    Pen sb = new Pen(button_PenKolor.BackColor, float.Parse(comboBox_WielkoscP.Text));
                    g.DrawPolygon(sb, Points);
                    pictureBox1.Refresh();
                }
            }


            startPaint = false;
            initX = null;
            initXx = null;
            initY = null;
            initYy = null;
        }

        private void button_PenKolor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                button_PenKolor.BackColor = color.Color;
            }
        }

        private void button_Prostokat_Click(object sender, EventArgs e)
        {
            rysProstokat = true;
            rysKolo = false;
            rysEllipsa = false;
            rysLinia = false;
            rysGumka = false;
            rysTrujkat = false;
            rysTrujkat1 = false;
        }

        private void buttonKolo_Click(object sender, EventArgs e)
        {
            rysProstokat = false;
            rysKolo = true;
            rysEllipsa = false;
            rysLinia = false;
            rysGumka = false;
            rysTrujkat = false;
            rysTrujkat1 = false;
        }
        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            rysProstokat = false;
            rysKolo = false;
            rysEllipsa = true;
            rysLinia = false;
            rysGumka = false;
            rysTrujkat = false;
            rysTrujkat1 = false;
        }
        private void Linia_Click(object sender, EventArgs e)
        {
            rysProstokat = false;
            rysKolo = false;
            rysEllipsa = false;
            rysLinia = true;
            rysGumka = false;
            rysTrujkat = false;
            rysTrujkat1 = false;
        }
        private void Gumka_Click(object sender, EventArgs e)
        {
            rysProstokat = false;
            rysKolo = false;
            rysEllipsa = false;
            rysLinia = false;
            rysGumka = true;
            rysTrujkat = false;
            rysTrujkat1 = false;
        }
        private void Trujkat_Click(object sender, EventArgs e)
        {
            rysProstokat = false;
            rysKolo = false;
            rysEllipsa = false;
            rysLinia = false;
            rysGumka = false;
            rysTrujkat = true;
            rysTrujkat1 = false;
        }
        private void Trujkat1_Click(object sender, EventArgs e)
        {
            rysProstokat = false;
            rysKolo = false;
            rysEllipsa = false;
            rysLinia = false;
            rysGumka = false;
            rysTrujkat = false;
            rysTrujkat1 = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            pictureBox1.BackColor = Color.White;
            buttonTlo.BackColor = Color.White;
        }

        private void buttonTlo_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = c.Color;
                buttonTlo.BackColor = c.Color;
            }
        }
        private void comboBox_WielkoscP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "JPEG files|*.jpg|PNG files|*.png|GIF files|*.gif|Bitmaps|*.bmp";
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                string format = Path.GetFileName(sfd.FileName);
                Stream fc = sfd.OpenFile();
                var pic = panelR.Clone(new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height),panelR.PixelFormat);
                if(format.Contains(".png"))
                {
                    pic.Save(fc, ImageFormat.Png);
                }
                if (format.Contains(".jpg"))
                {
                    pic.Save(fc, ImageFormat.Jpeg);
                }
                if (format.Contains(".gif"))
                {
                    pic.Save(fc, ImageFormat.Gif);
                }
                if (format.Contains(".bmp"))
                {
                    pic.Save(fc, ImageFormat.Bmp);
                }
            }
        }
        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "JPEG files|*.jpg|PNG files|*.png|GIF files|*.gif|Bitmaps|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = new Bitmap(ofd.FileName);
                pictureBox1.Image = img;
            }
            }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
