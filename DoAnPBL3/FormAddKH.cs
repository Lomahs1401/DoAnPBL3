using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormAddKH : Form
    {

        //Constructor
        public FormAddKH()
        {
            InitializeComponent();

        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void rjbtnOK_Click(object sender, EventArgs e)
        {
            if (tbNameKH.Text == "" || tbCMNDKH.Text == "" || tbBDKH.Text == "" || tbAddressKH.Text == "" || tbSDTKH.Text == "")
            {
                RJMessageBox.Show("Vui lòng nhập các thông tin cần thiết trước khi thêm khách hàng mới", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Alert("Thêm khách hàng mới thành công", Form_Alert.enmType.Success);
                this.Close();
            }
        }
        private void rjbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}