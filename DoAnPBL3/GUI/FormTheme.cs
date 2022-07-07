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
    public partial class FormTheme : Form
    {
        
        public FormTheme(string theme)
        {
            InitializeComponent();

            btnSave.Hide();
            switch (theme)
            {
                case "Admin":
                    cbTheme.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    cbTheme.FillColor = Color.FromArgb(15, 27, 57);
                    cbTheme.BorderColor = Color.FromArgb(15, 27, 57);
                    label1.ForeColor = Color.White;
                    cbTheme.ForeColor = Color.RoyalBlue;
                    break;
                case "Dark":
                    cbTheme.Parent.BackColor = Color.FromArgb(24, 24, 24);
                    cbTheme.FillColor = Color.FromArgb(15, 27, 57);
                    cbTheme.BorderColor = Color.FromArgb(15, 27, 57);
                    label1.ForeColor = Color.White;
                    cbTheme.ForeColor = Color.Gainsboro;
                    break;
                case "Light":
                    cbTheme.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    cbTheme.FillColor = Color.FromArgb(44, 53, 70);
                    cbTheme.BorderColor = Color.FromArgb(44, 53, 70);
                    label1.ForeColor = Color.Black;
                    cbTheme.ForeColor = Color.White;
                    break;
            }
        }

        private void CbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            cbTheme.Parent.Text = cbTheme.SelectedItem.ToString();
            switch (cbTheme.Parent.Text)
            {
                case "Admin":
                    cbTheme.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    cbTheme.FillColor = Color.FromArgb(15, 27, 57);
                    cbTheme.BorderColor = Color.FromArgb(15, 27, 57);
                    label1.ForeColor = Color.White;
                    cbTheme.ForeColor = Color.RoyalBlue;
                    break;
                case "Dark":
                    cbTheme.Parent.BackColor = Color.FromArgb(24, 24, 24);
                    cbTheme.FillColor = Color.FromArgb(15, 27, 57);
                    cbTheme.BorderColor = Color.FromArgb(15, 27, 57);
                    label1.ForeColor = Color.White;
                    cbTheme.ForeColor = Color.Gainsboro;
                    break;
                case "Light":
                    cbTheme.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    cbTheme.FillColor = Color.FromArgb(44, 53, 70);
                    cbTheme.BorderColor = Color.FromArgb(44, 53, 70);
                    label1.ForeColor = Color.Black;
                    cbTheme.ForeColor = Color.White; 
                    break;
            }
            btnSave.Hide();
        }
    }
}
