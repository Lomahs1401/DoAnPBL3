﻿using DoAnPBL3.BLL;
using DoAnPBL3.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormSettingAccountNV : Form
    {
        private readonly string accountUsername;
        private readonly string oldPassword;
        private readonly bool role;
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }

        public FormSettingAccountNV(string accountUsername, string oldPassword, bool role)
        {
            this.accountUsername = accountUsername;
            this.oldPassword = oldPassword;
            this.role = role;
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void FormSettingAccountNV_Load(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string image = BLL_QLTK.Instance.GetImage(accountUsername);
            if (image == null)
                pbAvatar.Image = null;
            else
                pbAvatar.Image = Image.FromFile(Path.Combine(projectDirectory, image));
        }

        private void BtnEditImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh",
                Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.ImageLocation = openFileDialog.FileName;
            }
        }

        private void BtnDeleteImg_Click(object sender, EventArgs e)
        {
            if (pbAvatar.ImageLocation != null)
            {
                pbAvatar.ImageLocation = "";
                pbAvatar.Image = null;
            }
        }

        private void BtnSaveChange_Click(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string path;
            if (pbAvatar.Image == null)
                path = null;
            else
                path = pbAvatar.ImageLocation.Remove(0, projectDirectory.Length + 1);
            string newPassword = tbPassword.Text;
            string confirmPassword = tbConfirmPassword.Text;
            bool isEqualToOldPassword, isConfirmPassMatchToNewPass, isNewAvatar;
            if (newPassword == "")
            {
                msgValidateNewPassword.ForeColor = Color.Red;
                msgValidateNewPassword.Text = "Mật khẩu mới không được để trống";
            }
            else
            {
                if (oldPassword == newPassword)
                {
                    msgValidateNewPassword.ForeColor = Color.Red;
                    msgValidateNewPassword.Text = "Mật khẩu mới không được trùng mật khẩu cũ";
                    isEqualToOldPassword = true;
                }
                else
                {
                    msgValidateNewPassword.ForeColor = Color.Black;
                    msgValidateNewPassword.Text = "";
                    isEqualToOldPassword = false;
                }
                if (confirmPassword != newPassword)
                {
                    msgValidateConfirmPassword.ForeColor = Color.Red;
                    msgValidateConfirmPassword.Text = "Mật khẩu xác nhận không khớp";
                    isConfirmPassMatchToNewPass = false;
                }
                else
                {
                    msgValidateConfirmPassword.ForeColor = Color.Black;
                    msgValidateConfirmPassword.Text = "";
                    isConfirmPassMatchToNewPass = true;
                }
                isNewAvatar = pbAvatar.ImageLocation != BLL_QLTK.Instance.GetImage(accountUsername);
                if ((!isEqualToOldPassword && isConfirmPassMatchToNewPass) || isNewAvatar)
                {
                    DialogResult dialogResult = RJMessageBox.Show("Xác nhận lưu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Account account = new Account(accountUsername, newPassword, role, pbAvatar.Image == null ? null : path);
                        if (BLL_QLTK.Instance.SaveNewInfo(account))
                        {
                            RJMessageBox.Show("Lưu mới dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshData(sender, e);
                            Close();
                        }
                        else
                        {
                            RJMessageBox.Show("Lưu dữ liệu thất bại. Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                        return;
                }
            }
        }
    }
}
