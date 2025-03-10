using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int rotation = 0;
        private int hiz = 5;
        private PictureBox yem;
        private Random rnd = new Random();
        private bool oyunBitti = false;

        List<PictureBox> yilanParcalari = new List<PictureBox>();


        private void Form1_Load(object sender, EventArgs e)
        {
            yilansBasi.Location = new Point(200, 200);
            yilansBasi.Width = 20;
            yilansBasi.Height = 20;
            yilanParcalari.Add(yilansBasi);
            this.Controls.Add(yilansBasi);

            YemOlustur();
            
            timer1.Start();

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                // üst yön
                if (rotation != 1)
                {
                    rotation = 0;
                }

            } else if(e.KeyCode == Keys.S)
            {
                // alt yön
                if (rotation != 0)
                {
                    rotation = 1;
                }

            } else if(e.KeyCode == Keys.D)
            {
                // sağa dönüş
                if (rotation != 3)
                {
                    rotation = 2;
                }


            } else if(e.KeyCode == Keys.A)
            {
                // sola dönüş !! Dikkat burada sağa gidiyorken aniden sola dönemez ÇAKIŞMA gerçekleşir
                if (rotation != 2)
                {
                   rotation = 3;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox yilanBasi = yilanParcalari[0];
            Point yeniKonum = yilanBasi.Location;

            if (rotation == 0) yeniKonum.Y -= hiz;
            if (rotation == 1) yeniKonum.Y += hiz;
            if (rotation == 2) yeniKonum.X += hiz;
            if (rotation == 3) yeniKonum.X -= hiz;

            yilanBasi.Location = yeniKonum;


            for (int i = yilanParcalari.Count - 1; i > 0; i--)
            {
                yilanParcalari[i].Location = yilanParcalari[i - 1].Location;
            }


            if (yilanBasi.Location.X < 0 || yilanBasi.Location.X > this.Width - hiz ||
               yilanBasi.Location.Y < 0 || yilanBasi.Location.Y > this.Height - hiz)
            {
                OyunBitir();
                return;
            }

            // yem yeme
            if (yilanBasi.Bounds.IntersectsWith(yem.Bounds))
            {
                YemYe();
            }
        }


        // yem olusturam
        private void YemOlustur()
        {
            yem = new PictureBox
            {
                Size = new Size(20, 20),
                BackColor = Color.Red,
                Location = new Point(rnd.Next(1, this.Width / hiz) * hiz, rnd.Next(1, this.Height / hiz) * hiz)
            };

            this.Controls.Add(yem);
        }

        // yemece
        private void YemYe()
        {
            PictureBox sonParca = yilanParcalari[yilanParcalari.Count - 1];
            Point yeniParcaKonum = sonParca.Location;

            if (rotation == 0) yeniParcaKonum.Y += 40;
            if (rotation == 1) yeniParcaKonum.Y -= 40; 
            if (rotation == 2) yeniParcaKonum.X -= 40;
            if (rotation == 3) yeniParcaKonum.X += 40;

            PictureBox yeniParca = new PictureBox
            {
                Size = new Size(20, 20),
                Image = yilanGovde.Image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = yeniParcaKonum
            };

            yilanParcalari.Add(yeniParca);
            this.Controls.Add(yeniParca);

            this.Controls.Remove(yem);
            YemOlustur();
        }


        // bye bye
        private void OyunBitir()
        {
            oyunBitti = true;
            timer1.Stop();
            MessageBox.Show("Oyun Bitti!");
        }


    }
}
