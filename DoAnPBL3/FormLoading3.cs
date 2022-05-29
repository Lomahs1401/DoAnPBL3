using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormLoading3 : Form
    {
       
       
        public FormLoading3()
        {
            InitializeComponent();
           
            
        }
        int percent = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            rocket.Left += 4;
            panel2.Width += 4;
            
            percent = (panel2.Width / 7) - 3;
            status.Text = percent.ToString() + "%";
            if (panel2.Width >= 720)
            {
                status.Location = new Point(449, 145);
                status.Text = "Complete";
                iconButton1.Show();
                timer1.Stop();
                timer2.Start();


                
                
            }
        }

        private void FormLoading3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            guna2ShadowForm1.SetShadowForm(this);
            iconButton1.Hide();
            
        }

        

        
        int wait_time = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            wait_time += 5;
            if(wait_time == 20)
            {
                new FormLogin().Show();
                new FormIntro().Show();
                
                this.Close();
            }
            
        }
    }
}
