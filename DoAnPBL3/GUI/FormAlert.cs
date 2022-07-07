using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class Form_Alert : Form
    {
        public enum EnmAction
        {
            wait,
            start,
            close
        }

        public enum EnmType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private EnmAction action;
        private int x, y;

        public Form_Alert()
        {
            InitializeComponent();
        }

        public void ShowAlert(string msg, EnmType type)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    break;

                }
            }
            x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            switch (type)
            {
                case EnmType.Success:
                    pictureBox1.Image = Image.FromFile(Path.Combine(projectDirectory, @"Img\Icon\success.png"));
                    BackColor = Color.SeaGreen;
                    break;
                case EnmType.Error:
                    pictureBox1.Image = Image.FromFile(Path.Combine(projectDirectory, @"Img\Icon\error.png"));
                    BackColor = Color.DarkRed;
                    break;
                case EnmType.Info:
                    pictureBox1.Image = Image.FromFile(Path.Combine(projectDirectory, @"Img\Icon\info.png"));
                    BackColor = Color.RoyalBlue;
                    break;
                case EnmType.Warning:
                    pictureBox1.Image = Image.FromFile(Path.Combine(projectDirectory, @"Img\Icon\warning.png"));
                    BackColor = Color.DarkOrange;
                    break;
            }
            lblMsg.Text = msg;
            Show();
            action = EnmAction.start;
            timer1.Interval = 1;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case EnmAction.wait:
                    timer1.Interval = 5000;
                    action = EnmAction.close;
                    break;
                case EnmAction.start:
                    timer1.Interval = 1;
                    Opacity += 0.1;
                    if (x < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            action = EnmAction.wait;
                        }
                    }
                    break;
                case EnmAction.close:
                    timer1.Interval = 1;
                    Opacity -= 0.1;
                    Left -= 3;
                    if (Opacity == 0.0)
                    {
                        Close();
                    }
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Alert(string msg, EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }
    }
}
