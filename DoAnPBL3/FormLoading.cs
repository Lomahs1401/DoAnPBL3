using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace DoAnPBL3
{
    public partial class FormLoading : Form
    {   private int time = 0;
        Image[] images = new Image[65];
        Image img;
        public FormLoading()
        {
            InitializeComponent();
            LoadImages();
            //PictureBox1.Image = Image.FromFile(@"C:\Users\ASUS\Desktop\DoAnPBL3\DoAnPBL3\Img\j3IISku.gif");
            
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            guna2ProgressBar1.Value += 1;
            time += 1;
            label1.BackColor = label1.Parent.BackColor;
            label1.Text = guna2ProgressBar1.Value.ToString() + "%";
            if (guna2ProgressBar1.Value == 100)
            {
                label1.Location = new Point(345, 363);
                label1.Text = "Complete!";
            }
            //if (time == 125)
               // this.Close();
        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void LoadImages()
        {
            for (int i = 1; i <= 65; i++)
            {
                string path = $@"C:\Users\ASUS\Desktop\DoAnPBL3\DoAnPBL3\Img\j3IISku.gif";
                Image image = Image.FromFile(path);
                images[i - 1] = image;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            i = i % 65;
            PictureBox1.Image = images[i];
            i += 1;
        }
    }
}
