using DoAnPBL3.BLL;
using DoAnPBL3.Models;
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
    public partial class FormIdentify : Form
    {
        private readonly string accountUsername;
        private readonly string password;
        private readonly string id;
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }

        public FormIdentify(string accountUsername, string password, string id)
        {
            InitializeComponent();
            this.accountUsername = accountUsername;
            this.password = password;
            this.id = id;
        }

        private void FormIdentify_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            if (tbConfirmPass.Text.Trim() == "")
                RJMessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (password != tbConfirmPass.Text)
                RJMessageBox.Show("Sai mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (accountUsername != "")
                {
                    if (BLL_QLNV.Instance.DeleteEmployee(id))
                    {
                        Alert("Xóa nhân viên thành công", Form_Alert.EnmType.Success);
                        RefreshData(sender, e);
                        Dispose();
                    }
                    else
                    {
                        Alert("Xóa thất bại. Vui lòng thử lại", Form_Alert.EnmType.Error);
                        Dispose();
                    }
                }
                else
                {
                    if (BLL_QLBS.Instance.DeleteBook(id))
                    {
                        Alert("Xóa mặt hàng sách thành công", Form_Alert.EnmType.Success);
                        RefreshData(sender, e);
                        Dispose();
                    }
                    else
                    {
                        Alert("Xóa thất bại. Vui lòng thử lại", Form_Alert.EnmType.Error);
                        Dispose();
                    }
                }
            }
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}