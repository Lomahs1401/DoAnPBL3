using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnPBL3.BLL;
using DoAnPBL3.Models;

namespace DoAnPBL3
{
    public partial class FormLogin : Form
    {
        private readonly string username;
        private readonly string password;
        private Form currentChildForm;

        public FormLogin(string username = "", string password = "")
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            using (BookStoreContext context = new BookStoreContext())
            {
                // tương tác với DB 1 lần để rend ra CSDL
                context.Languages.ToList();
            }
            cbSaveAcc.Checked = true;
            if (username != "" || password != "")
            {
                txtUserName.Text = username;
                txtPassword.Text = password;
            }
            else
            {
                txtUserName.Text = Properties.Settings.Default.username;
                txtPassword.Text = Properties.Settings.Default.password;
            }
            if (Properties.Settings.Default.role == "Quản Trị")
                radioAdmin.Checked = true;
            else
                radioEmployee.Checked = true;
        }

        private void LinkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new FormForgotPassword());
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            // true: quản trị, false: nhân viên
            Account account = new Account { Username = username, Password = password, Role = radioAdmin.Checked };
            string msg = BLL_Login.Instance.CheckLogin(account);
            switch (msg)
            {
                case "Vui lòng nhập tên tài khoản và mật khẩu":
                    RJMessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case "Vui lòng nhập tên tài khoản":
                    RJMessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case "Vui lòng nhập mật khẩu":
                    RJMessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                case "Đăng nhập thất bại":
                    RJMessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            string nameStaff = BLL_Login.Instance.GetNameStaff(account);
            // Quản trị
            if (account.Role)
            {
                if (cbSaveAcc.Checked)
                {
                    Properties.Settings.Default.username = username;
                    Properties.Settings.Default.password = password;
                    Properties.Settings.Default.role = radioAdmin.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
                Hide();
                new MainMenuQTV(account.Username, password, true, nameStaff).Show();
                Dispose();
            }
            // Nhân viên
            else
            {
                if (cbSaveAcc.Checked)
                {
                    Properties.Settings.Default.username = username;
                    Properties.Settings.Default.password = password;
                    Properties.Settings.Default.role = radioEmployee.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
                Hide();
                new MainMenuNV(account.Username, password, false, nameStaff).Show();
                Dispose();
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                txtPassword.PasswordChar = '\0';
                ShowPass.BringToFront();
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '●';
                HidePass.BringToFront();
            }
        }

        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
