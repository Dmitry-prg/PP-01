using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equipment.Forms.AutorizationForms
{
    public partial class CaptchaForm : Form
    {
        public CaptchaForm()
        {
            InitializeComponent();
        }
        private string text = String.Empty;
        public static bool check = false;

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            Bitmap result = new Bitmap(Width, Height);

            int Xpos = rnd.Next(15, Width - 100);
            //int Ypos = rnd.Next(10, Height - 25);

            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            Graphics g = Graphics.FromImage(result);

            g.Clear(Color.Gray);

            text = String.Empty;
            char b;
            string alf = "1QWE2RTY3UIO4PAS5DFG6HJK7LZX8CVB9NM0";
            for (int i = 0; i < 5; ++i)
            {
                b = alf[rnd.Next(alf.Length)];
                text += b;
                g.DrawString(b.ToString(),
                        new Font("Arial", 18),
                        colors[rnd.Next(colors.Length)],
                        new PointF(Xpos, rnd.Next(35, Height - 35)));
                Xpos += 20;

            }


            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }
        private void CaptchaForm_Load(object sender, EventArgs e)
        {
            pictureBoxCaptcha.Image = this.CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);


        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtCheckCaptcha.Text == this.text)
            {
                MessageBox.Show("Верно!");
                check = true;
                this.Close();
            }
            else
            {
                txtCheckCaptcha.Clear();
                MessageBox.Show("Ошибка!\r\nПопробуйте ещё раз");
                pictureBoxCaptcha.Image = this.CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
                txtCheckCaptcha.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            check = false;
            this.Close();
        }

        private void CaptchaForm_Activated(object sender, EventArgs e)
        {
            txtCheckCaptcha.Focus();
        }
    }
}
