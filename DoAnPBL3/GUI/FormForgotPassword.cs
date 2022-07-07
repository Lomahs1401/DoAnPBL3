using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormForgotPassword : Form
    {

        public static string toAddress; // Địa chỉ Email (from -> to)
        private const string EMAIL_REGEX = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";

        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSendCode_ClickAsync(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "" && txtEmailPassword.Text.Trim() == "")
                RJMessageBox.Show("Vui lòng nhập email và mật khẩu email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtEmail.Text.Trim() == "")
                RJMessageBox.Show("Vui lòng nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtEmailPassword.Text.Trim() == "")
                RJMessageBox.Show("Vui lòng nhập mật khẩu email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (!Regex.IsMatch(txtEmail.Text, EMAIL_REGEX))
                    RJMessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    using (var bookStore = new BookStoreContext())
                    {
                        var listEmail = bookStore.Accounts
                            .Join(
                                bookStore.Employees,
                                account => account.Username,
                                employee => employee.AccountUsername,
                                (account, employee) => new { employee.Email, account.Password });
                        if (listEmail.ToList().Count == 0)
                            RJMessageBox.Show("Không tìm thấy email trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                        {
                            string password = listEmail.FirstOrDefault().Password;
                            MailMessage mailMessage = new MailMessage
                            {
                                From = new MailAddress("BookShop@gmail.com")
                            };
                            mailMessage.To.Add(txtEmail.Text);
                            mailMessage.Body = "Mật khẩu của bạn là: " + password;
                            mailMessage.Subject = "Nhắc nhở mật khẩu";

                            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                            {
                                EnableSsl = true,
                                DeliveryMethod = SmtpDeliveryMethod.Network,
                                Credentials = new NetworkCredential(txtEmail.Text, txtEmailPassword.Text)
                            };
                            try
                            {
                                smtp.Send(mailMessage);
                                RJMessageBox.Show("Gửi mã thành công. Vui lòng check mail", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception)
                            {
                                RJMessageBox.Show("Hệ thống gửi mail đang bảo trì. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                    }
                }
            }
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSendCode.PerformClick();
        }

        private void TxtEmailPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSendCode.PerformClick();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            if (txtEmailPassword.PasswordChar == '●')
            {
                txtEmailPassword.PasswordChar = '\0';
                ShowPass.BringToFront();
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (txtEmailPassword.PasswordChar == '\0')
            {
                txtEmailPassword.PasswordChar = '●';
                HidePass.BringToFront();
            }
        }
    }
}
