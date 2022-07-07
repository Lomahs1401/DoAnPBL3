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
    public partial class FormIntro : Form
    {
        public FormIntro()
        {
            InitializeComponent();
            btnPrevious.Hide();
            label2.Hide();
            label7.Hide();
            label8.Hide();
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void Guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            btnPrevious.Show();
            btnNext.Hide();

            label2.Show();
            label7.Show();
            label8.Show();
            label10.Hide();
            label9.Hide();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            btnNext.Show();
            btnPrevious.Hide();

            label10.Show();
            label9.Show();
            label2.Hide();
            label7.Hide();
            label8.Hide();
        }
    }
}