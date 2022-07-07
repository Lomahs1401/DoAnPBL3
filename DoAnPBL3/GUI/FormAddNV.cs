using DoAnPBL3.Models;
using DoAnPBL3.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing.Imaging;
using DoAnPBL3.Properties;
using DoAnPBL3.BLL;

namespace DoAnPBL3
{
    public partial class FormAddNV : Form
    {
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }
        private readonly string theme;

        //Constructor
        public FormAddNV(string theme)
        {
            this.theme = theme;
            InitializeComponent();
            switch (theme)
            {
                case "Admin":
                    panelContainer.BackColor = Color.FromArgb(24, 37, 65);
                    lblNameNV.ForeColor = Color.WhiteSmoke;
                    lblEmail.ForeColor = Color.WhiteSmoke;
                    lblBD.ForeColor = Color.WhiteSmoke;
                    lblStartDate.ForeColor = Color.WhiteSmoke;
                    lblGender.ForeColor = Color.WhiteSmoke;
                    lblSDT.ForeColor = Color.WhiteSmoke;
                    lblCMND.ForeColor = Color.WhiteSmoke;
                    lblAddress.ForeColor = Color.WhiteSmoke;
                    tbNameNV.FillColor = Color.FromArgb(15, 27, 57);
                    tbNameNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbEmailNV.FillColor = Color.FromArgb(15, 27, 57);
                    tbEmailNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbBD.FillColor = Color.FromArgb(15, 27, 57);
                    tbBD.ForeColor = Color.FromArgb(193, 200, 207);
                    tbStartDate.FillColor = Color.FromArgb(15, 27, 57);
                    tbStartDate.ForeColor = Color.FromArgb(193, 200, 207);
                    cbGenderNV.BackColor = Color.FromArgb(15, 27, 57);
                    cbGenderNV.BorderColor = Color.FromArgb(193, 200, 207);
                    cbGenderNV.ListBackColor = Color.FromArgb(15, 27, 57);
                    cbGenderNV.ListTextColor = Color.FromArgb(193, 200, 207);
                    cbGenderNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbSDTNV.FillColor = Color.FromArgb(15, 27, 57);
                    tbSDTNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbCMNDNV.FillColor = Color.FromArgb(15, 27, 57);
                    tbCMNDNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbAddressNV.FillColor = Color.FromArgb(15, 27, 57);
                    tbAddressNV.ForeColor = Color.FromArgb(193, 200, 207);
                    break;
                case "Dark":
                    panelContainer.BackColor = Color.FromArgb(32, 32, 32);
                    lblNameNV.ForeColor = Color.WhiteSmoke;
                    lblEmail.ForeColor = Color.WhiteSmoke;
                    lblBD.ForeColor = Color.WhiteSmoke;
                    lblStartDate.ForeColor = Color.WhiteSmoke;
                    lblGender.ForeColor = Color.WhiteSmoke;
                    lblSDT.ForeColor = Color.WhiteSmoke;
                    lblCMND.ForeColor = Color.WhiteSmoke;
                    lblAddress.ForeColor = Color.WhiteSmoke;
                    tbNameNV.FillColor = Color.FromArgb(40, 35, 40);
                    tbNameNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbEmailNV.FillColor = Color.FromArgb(40, 35, 40);
                    tbEmailNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbBD.FillColor = Color.FromArgb(40, 35, 40);
                    tbBD.ForeColor = Color.FromArgb(193, 200, 207);
                    tbStartDate.FillColor = Color.FromArgb(40, 35, 40);
                    tbStartDate.ForeColor = Color.FromArgb(193, 200, 207);
                    cbGenderNV.BackColor = Color.FromArgb(40, 35, 40);
                    cbGenderNV.ForeColor = Color.FromArgb(193, 200, 207);
                    cbGenderNV.BorderColor = Color.FromArgb(193, 200, 207);
                    cbGenderNV.ListBackColor = Color.FromArgb(40, 35, 40);
                    cbGenderNV.ListTextColor = Color.FromArgb(193, 200, 207);
                    tbSDTNV.FillColor = Color.FromArgb(40, 35, 40);
                    tbSDTNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbCMNDNV.FillColor = Color.FromArgb(40, 35, 40);
                    tbCMNDNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbAddressNV.FillColor = Color.FromArgb(40, 35, 40);
                    tbAddressNV.ForeColor = Color.FromArgb(193, 200, 207);
                    break;
                case "Light":
                    panelContainer.BackColor = Color.Gainsboro;
                    lblNameNV.ForeColor = Color.Black;
                    lblEmail.ForeColor = Color.Black;
                    lblBD.ForeColor = Color.Black;
                    lblStartDate.ForeColor = Color.Black;
                    lblGender.ForeColor = Color.Black;
                    lblSDT.ForeColor = Color.Black;
                    lblCMND.ForeColor = Color.Black;
                    lblAddress.ForeColor = Color.Black;
                    tbNameNV.FillColor = Color.Silver;
                    tbNameNV.ForeColor = Color.Black;
                    tbNameNV.PlaceholderForeColor = Color.Black;
                    tbNameNV.BorderColor = Color.Black;
                    tbEmailNV.FillColor = Color.Silver;
                    tbEmailNV.ForeColor = Color.Black;
                    tbEmailNV.PlaceholderForeColor = Color.Black;
                    tbEmailNV.BorderColor = Color.Black;
                    tbBD.FillColor = Color.Silver;
                    tbBD.ForeColor = Color.Black;
                    tbBD.PlaceholderForeColor = Color.Black;
                    tbBD.BorderColor = Color.Black;
                    tbStartDate.FillColor = Color.Silver;
                    tbStartDate.ForeColor = Color.Black;
                    tbStartDate.PlaceholderForeColor = Color.Black;
                    tbStartDate.BorderColor = Color.Black;
                    cbGenderNV.BackColor = Color.Silver;
                    cbGenderNV.BorderColor = Color.Black;
                    cbGenderNV.ListBackColor = Color.Silver;
                    cbGenderNV.ListTextColor = Color.Black;
                    cbGenderNV.ForeColor = Color.Black;
                    tbSDTNV.FillColor = Color.Silver;
                    tbSDTNV.ForeColor = Color.Black;
                    tbSDTNV.PlaceholderForeColor = Color.Black;
                    tbSDTNV.BorderColor = Color.Black;
                    tbCMNDNV.FillColor = Color.Silver;
                    tbCMNDNV.ForeColor = Color.Black;
                    tbCMNDNV.PlaceholderForeColor = Color.Black;
                    tbCMNDNV.BorderColor = Color.Black;
                    tbAddressNV.FillColor = Color.Silver;
                    tbAddressNV.ForeColor = Color.Black;
                    tbAddressNV.PlaceholderForeColor = Color.Black;
                    tbAddressNV.BorderColor = Color.Black;
                    break;
            }
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            bool isValidName, isValidEmail, isValidDateOfBirth, isValidStartDate, 
                isValidGender, isValidPhone, isValidIdCard, isValidAddress;
            string name, email, dateOfBirth, startDate, gender, phone, idCard, address;
            // Validate name
            name = tbNameNV.Text;
            isValidName = BLL_QLNV.Instance.ValidateName(name);
            if (!isValidName)
            {
                msgValidateName.ForeColor = Color.Red;
                msgValidateName.Text = "Họ và tên nhân viên không được để trống";
            }
            else
            {
                msgValidateName.ForeColor = Color.White;
                msgValidateName.Text = "";
            }
            // Validate email
            email = tbEmailNV.Text;
            isValidEmail = Validators.IsValidEmail(email);
            if (email == "")
            {
                msgValidateEmail.ForeColor = Color.Red;
                msgValidateEmail.Text = "Email không được để trống";
            }
            else
            {
                if (!isValidEmail)
                {
                    msgValidateEmail.ForeColor = Color.Red;
                    msgValidateEmail.Text = "Email không hợp lệ";
                }
                else
                {
                    msgValidateEmail.ForeColor = Color.White;
                    msgValidateEmail.Text = "";
                }
            }
            // Validate date of birth
            dateOfBirth = tbBD.Text;
            string msgBirthDate = BLL_QLNV.Instance.ValidateDateOfBirth(dateOfBirth);
            if (msgBirthDate != "")
            {
                isValidDateOfBirth = false;
                switch (msgBirthDate)
                {
                    case "Ngày sinh không được để trống":
                        msgValidateDateOfBirth.Text = msgBirthDate;
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        break;
                    case "Ngày sinh không hợp lệ":
                        msgValidateDateOfBirth.Text = msgBirthDate;
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        break;
                    case "Ngày sinh phải theo định dạng dd/MM/yyyy":
                        msgValidateDateOfBirth.Text = msgBirthDate;
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        break;
                    case "Ngày sinh không được lớn hơn ngày hiện tại":
                        msgValidateDateOfBirth.Text = msgBirthDate;
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        break;
                    case "Nhân viên ít nhất phải đủ 18 tuổi":
                        msgValidateDateOfBirth.Text = msgBirthDate;
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        break;
                    default:
                        msgValidateDateOfBirth.Text = msgBirthDate;
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        break;
                }
            }
            else
            {
                isValidDateOfBirth = true;
                msgValidateDateOfBirth.Text = "";
                msgValidateDateOfBirth.ForeColor = Color.White;
            }
            // Validate start date
            startDate = tbStartDate.Text;
            string msgStartDate = BLL_QLNV.Instance.ValidateStartDate(startDate);
            if (msgStartDate != "")
            {
                isValidStartDate = false;
                switch (msgBirthDate)
                {
                    case "Ngày vào làm không được để trống":
                        msgValidateStartDate.Text = msgStartDate;
                        msgValidateStartDate.ForeColor = Color.Red;
                        break;
                    case "Ngày vào làm không hợp lệ":
                        msgValidateStartDate.Text = msgStartDate;
                        msgValidateStartDate.ForeColor = Color.Red;
                        break;
                    case "Ngày vào làm phải theo định dạng dd/MM/yyyy":
                        msgValidateStartDate.Text = msgStartDate;
                        msgValidateStartDate.ForeColor = Color.Red;
                        break;
                    case "Ngày vào làm không được lớn hơn ngày hiện tại":
                        msgValidateStartDate.Text = msgStartDate;
                        msgValidateStartDate.ForeColor = Color.Red;
                        break;
                    default:
                        msgValidateStartDate.Text = msgStartDate;
                        msgValidateStartDate.ForeColor = Color.Red;
                        break;
                }
            }
            else
            {
                isValidStartDate = true;
                msgValidateStartDate.Text = "";
                msgValidateStartDate.ForeColor = Color.White;
            }
            // Validate gender
            isValidGender = BLL_QLNV.Instance.ValidateGender(cbGenderNV.SelectedItem);
            if (!isValidGender)
            {
                gender = "";
                msgValidateGender.Text = "Giới tính không được để trống";
                msgValidateGender.ForeColor = Color.Red;
            }
            else
            {
                gender = cbGenderNV.SelectedItem.ToString();
                msgValidateGender.Text = "";
                msgValidateGender.ForeColor = Color.White;
            }
            // Validate ID Card
            idCard = tbCMNDNV.Text;
            isValidIdCard = BLL_QLNV.Instance.ValidateID_Card(idCard);
            if (idCard == "")
            {
                msgValidateIDCard.Text = "CMND không được để trống";
                msgValidateIDCard.ForeColor = Color.Red;
                isValidIdCard = false;
            }
            else
            {
                if (!BLL_QLNV.Instance.ValidateID_Card(idCard))
                {
                    msgValidateIDCard.Text = "CMND không hợp lệ";
                    msgValidateIDCard.ForeColor = Color.Red;
                }
                else
                {
                    msgValidateIDCard.Text = "";
                    msgValidateIDCard.ForeColor = Color.White;
                }
            }
            // Validate phone
            phone = tbSDTNV.Text;
            isValidPhone = BLL_QLNV.Instance.ValidatePhone(phone);
            if (phone == "")
            {
                msgValidatePhone.Text = "Số điện thoại không được để trống";
                msgValidatePhone.ForeColor = Color.Red;
                isValidPhone = false;
            }
            else
            {
                if (!BLL_QLNV.Instance.ValidatePhone(phone))
                {
                    msgValidatePhone.Text = "Số điện thoại không hợp lệ";
                    msgValidatePhone.ForeColor = Color.Red;
                }
                else
                {
                    msgValidatePhone.Text = "";
                    msgValidatePhone.ForeColor = Color.White;
                }
            }
            // Validate address
            address = tbAddressNV.Text;
            isValidAddress = BLL_QLNV.Instance.ValidateAddress(address);
            if (!isValidAddress)
            {
                msgValidateAddress.Text = "Địa chỉ không được để trống";
                msgValidateAddress.ForeColor = Color.Red;
            }
            else
            {
                msgValidateAddress.Text = "";
                msgValidateAddress.ForeColor = Color.White;
            }

            if (isValidName && isValidEmail && isValidDateOfBirth && isValidStartDate
                && isValidGender && isValidIdCard && isValidPhone && isValidAddress)
            {
                string lastEmployeeID = BLL_QLNV.Instance.GetLastID();
                string newEmployeeID = BLL_QLNV.Instance.CreateNewEmployeeID(lastEmployeeID);
                string newUsername = BLL_QLNV.Instance.CreateNewAccount(name, newEmployeeID);
                string newPassword = newUsername;

                DateTime birthday = BLL_QLNV.Instance.GetDateOfBirth(dateOfBirth);
                DateTime startDateTime = BLL_QLNV.Instance.GetStartDate(startDate);

                Account newAccount = new Account(newUsername, newPassword, false, gender == "Nam" ? 
                    Path.Combine(InitialData.projectDirectory, InitialData.pathEmployeeMan) : 
                    Path.Combine(InitialData.projectDirectory, InitialData.pathEmployeeWoman)); ;
                if (!BLL_QLTK.Instance.AddNewAccount(newAccount))
                {
                    RJMessageBox.Show("Thêm tài khoản thất bại. Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (BLL_QLNV.Instance.AddEmployee(GetAllInfo(newEmployeeID.ToString(), newUsername)))
                {
                    Alert("Thêm nhân viên mới thành công", Form_Alert.EnmType.Success);
                    RefreshData(sender, e);
                    Dispose();
                }
                else
                    Alert("Thêm thất bại. Vui lòng thử lại", Form_Alert.EnmType.Error);
            }
            else
            {
                Alert("Dữ liệu không hợp lệ", Form_Alert.EnmType.Error);
            }
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            string name, email, dateOfBirth, startDate, phone, idCard, address;
            name = tbNameNV.Text;
            email = tbEmailNV.Text;
            dateOfBirth = tbBD.Text;
            startDate = tbStartDate.Text;
            phone = tbSDTNV.Text;
            idCard = tbCMNDNV.Text;
            address = tbAddressNV.Text;
            if (name != "" || email != "" || dateOfBirth != "" || startDate != ""
                || cbGenderNV.SelectedItem != null || phone != "" || idCard != "" || address != "" || avatar.Image != null)
            {
                DialogResult result = RJMessageBox.Show("Dữ liệu chưa được lưu. Bạn vẫn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    Close();
                else
                    return;
            }
            else
                Close();
        }

        private Employee GetAllInfo(string newID_Employee, string username)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string path;
            if (avatar.Image == null)
                path = null;
            else
                path = avatar.ImageLocation.Remove(0, projectDirectory.Length + 3);
            return new Employee
            {
                ID_Employee = newID_Employee,
                FullNameEmployee = tbNameNV.Text,
                Email = tbEmailNV.Text,
                DateOfBirth = new DateTime(
                        Convert.ToInt32(tbBD.Text.Substring(6, 4)),
                        Convert.ToInt32(tbBD.Text.Substring(3, 2)),
                        Convert.ToInt32(tbBD.Text.Substring(0, 2))
                ),
                StartDate = new DateTime(
                        Convert.ToInt32(tbStartDate.Text.Substring(6, 4)),
                        Convert.ToInt32(tbStartDate.Text.Substring(3, 2)),
                        Convert.ToInt32(tbStartDate.Text.Substring(0, 2))
                ),
                EndDate = null,
                Gender = cbGenderNV.SelectedItem?.ToString(),
                Phone = tbSDTNV.Text,
                Id_Card = tbCMNDNV.Text,
                Address = tbAddressNV.Text,
                Avatar = path,
                AccountUsername = username,
                WorkStatus = true
            };
        }

        private void BtnNVImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh",
                Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatar.ImageLocation = openFileDialog.FileName;
            }
        }

        private void BtnDeleteImg_Click(object sender, EventArgs e)
        {
            if (avatar.ImageLocation != null)
            {
                avatar.ImageLocation = "";
                avatar.Image = null;
            }
        }

        private void TbNameNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbEmailNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbCMNDNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbAddressNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}