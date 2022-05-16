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

namespace DoAnPBL3
{
    public partial class FormAddNV : Form
    {

        //Constructor
        public FormAddNV()
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
            bool isDateContainsAlpha, isValidFormatDateOfBirth, isValidAge = false,
                isGreaterThanCurrentDate, isValidEmail, isValidPhone, isValidIdCard;
            string name, email, dateOfBirth, gender, phone, idCard, address;
            byte[] ava;
            // Validate name
            name = tbNameNV.Text;
            if (name == "")
            {
                msgValidateName.ForeColor = Color.Red;
                msgValidateName.Text = "Trường này không được để trống";
            }
            else
            {
                msgValidateName.ForeColor = Color.White;
                msgValidateName.Text = "";
            }
            // Validate email
            email = tbEmailNV.Text;
            isValidEmail = EmployeeValidator.IsValidEmail(email);
            if (email == "")
            {
                msgValidateEmail.ForeColor = Color.Red;
                msgValidateEmail.Text = "Trường này không được để trống";
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
            // Validate value of input date of birth
            dateOfBirth = tbBD.Text;
            if (dateOfBirth == "")
            {
                msgValidateDateOfBirth.ForeColor = Color.Red;
                msgValidateDateOfBirth.Text = "Trường này không được để trống";
            }
            else
            {
                msgValidateDateOfBirth.ForeColor = Color.White;
                msgValidateDateOfBirth.Text = "";

                // Validatge date contains alphabet
                isDateContainsAlpha = EmployeeValidator.IsDateContainsAlphabet(dateOfBirth);
                if (isDateContainsAlpha)
                {
                    msgValidateDateOfBirth.ForeColor = Color.Red;
                    msgValidateDateOfBirth.Text = "Ngày sinh không hợp lệ";
                }
                else
                {
                    msgValidateDateOfBirth.ForeColor = Color.White;
                    msgValidateDateOfBirth.Text = "";

                    // Validate format date of birth
                    isValidFormatDateOfBirth = EmployeeValidator.IsValidFormatDateOfBirth(dateOfBirth, EmployeeValidator.DATE_TIME_REGEX);
                    if (!isValidFormatDateOfBirth)
                    {
                        msgValidateDateOfBirth.ForeColor = Color.Red;
                        msgValidateDateOfBirth.Text = "Ngày sinh phải theo định dạng dd/MM/yyyy";
                    }
                    else
                    {
                        // Check date
                        string msgValidate = EmployeeValidator.CheckDateOfBirth(dateOfBirth, EmployeeValidator.DATE_TIME_REGEX);
                        if (msgValidate != "")
                        {
                            msgValidateDateOfBirth.ForeColor = Color.Red;
                            msgValidateDateOfBirth.Text = msgValidate;
                        }
                        else
                        {
                            msgValidateDateOfBirth.ForeColor = Color.White;
                            msgValidateDateOfBirth.Text = "";

                            // Validate curent date
                            isGreaterThanCurrentDate = EmployeeValidator.IsValidDateOfBirth(dateOfBirth, EmployeeValidator.DATE_TIME_REGEX);
                            if (!isGreaterThanCurrentDate)
                            {
                                msgValidateDateOfBirth.ForeColor = Color.Red;
                                msgValidateDateOfBirth.Text = "Ngày sinh không được lớn hơn ngày hiện tại";
                            }
                            else
                            {
                                msgValidateDateOfBirth.ForeColor = Color.White;
                                msgValidateDateOfBirth.Text = "";

                                // Validate age
                                isValidAge = EmployeeValidator.IsValidAge(dateOfBirth, EmployeeValidator.DATE_TIME_REGEX);
                                if (!isValidAge)
                                {
                                    msgValidateDateOfBirth.ForeColor = Color.Red;
                                    msgValidateDateOfBirth.Text = "Nhân viên ít nhất phải đủ 18 tuổi";
                                }
                                else
                                {
                                    msgValidateDateOfBirth.ForeColor = Color.White;
                                    msgValidateDateOfBirth.Text = "";
                                }
                            }
                        }
                    }
                }
            }
            // Validate gender
            if (cbGenderNV.SelectedItem == null)
            {
                gender = "";
                msgValidateGender.ForeColor = Color.Red;
                msgValidateGender.Text = "Trường này không được để trống";
            }
            else
            {
                gender = cbGenderNV.SelectedItem.ToString();
                msgValidateGender.ForeColor = Color.White;
                msgValidateGender.Text = "";
            }
            // Validate phone number
            phone = tbSDTNV.Text;
            isValidPhone = EmployeeValidator.IsValidPhoneNumber(phone, EmployeeValidator.PHONE_REGEX);
            if (phone == "")
            {
                msgValidatePhone.ForeColor = Color.Red;
                msgValidatePhone.Text = "Trường này không được để trống";
            }
            else
            {
                if (!isValidPhone)
                {
                    msgValidatePhone.ForeColor = Color.Red;
                    msgValidatePhone.Text = "SĐT không hợp lệ";
                }
                else
                {
                    msgValidatePhone.ForeColor = Color.White;
                    msgValidatePhone.Text = "";
                }
            }
            // Validate ID Card
            idCard = tbCMNDNV.Text;
            isValidIdCard = EmployeeValidator.IsValidIdCard(idCard, EmployeeValidator.ID_CARD_REGEX);
            if (idCard == "")
            {
                msgValidateIDCard.ForeColor = Color.Red;
                msgValidateIDCard.Text = "Trường này không được để trống";
            }
            else
            {
                if (!isValidIdCard)
                {
                    msgValidateIDCard.ForeColor = Color.Red;
                    msgValidateIDCard.Text = "CMND không hợp lệ";
                }
                else
                {
                    msgValidateIDCard.ForeColor = Color.White;
                    msgValidateIDCard.Text = "";
                }
            }
            // Validate address
            if (tbAddressNV.Text == "")
            {
                address = "";
                msgValidateAddress.ForeColor = Color.Red;
                msgValidateAddress.Text = "Trường này không được để trống";
            }
            else
            {
                address = tbAddressNV.Text;
                msgValidateAddress.ForeColor = Color.White;
                msgValidateAddress.Text = "";
            }
            // Validate image
            if (avatar.ImageLocation == null)
            {
                ava = null;
            }
            else
            {
                try
                {
                    ava = ImageToByteArray(avatar);
                } catch(ExternalException)
                {
                    return;
                }
            }

            if (isValidEmail && isValidIdCard && isValidPhone && isValidAge)
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    var listID = context.Employees
                                    .OrderBy(em => em.ID_Employee)
                                    .Select(em => em.ID_Employee);
                    String id = listID.ToList().Last(); // E0006
                    String code = id.Substring(1, id.Length - 1); // 0006
                    int num = Convert.ToInt32(code); // 6
                    num++; // 6 + 1 -> 7
                    string numStr = num.ToString(); // "7"
                    int lenNumStr = numStr.Length; // 1
                    StringBuilder newEmployeeId = new StringBuilder(id); // E0006
                    newEmployeeId = newEmployeeId.Remove(newEmployeeId.Length - lenNumStr, lenNumStr);// E000
                    newEmployeeId.Append(numStr); // E000 + 7 => E0007

                    DateTime birthday = new DateTime(
                        Convert.ToInt32(dateOfBirth.Substring(6, 4)),
                        Convert.ToInt32(dateOfBirth.Substring(3, 2)),
                        Convert.ToInt32(dateOfBirth.Substring(0, 2))
                    );

                    Employee employee = new Employee(newEmployeeId.ToString(), name, email, birthday, gender, phone, idCard, address, ava, null);
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    char[] c = name.ToCharArray();
                    foreach (char item in c)
                    {
                        Console.WriteLine(item);
                    }
                    Alert("Thêm nhân viên mới thành công", Form_Alert.enmType.Success);
                    Close();
                }
            }
            else
            {
                Alert("Dữ liệu không hợp lệ", Form_Alert.enmType.Error);
            }
        }

        private void rjbtnCancel_Click(object sender, EventArgs e)
        {
            string name, email, dateOfBirth, phone, idCard, address;
            name = tbNameNV.Text;
            email = tbEmailNV.Text;
            dateOfBirth = tbBD.Text;
            phone = tbSDTNV.Text;
            idCard = tbCMNDNV.Text;
            address = tbAddressNV.Text;
            if (name != "" || email != "" || dateOfBirth != "" 
                || cbGenderNV.SelectedItem != null || phone != "" || idCard != "" || address != "" || avatar.Image != null)
            {
                DialogResult result = RJMessageBox.Show("Dữ liệu chưa được lưu. Bạn vẫn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                    Close();
                else
                    return;
            }
            else
                Close();
        }

        private byte[] ImageToByteArray(Guna2PictureBox pictureBox)
        {
            using (Bitmap bitmap = new Bitmap(avatar.ImageLocation))
            {
                MemoryStream memoryStream = new MemoryStream();
                try
                {
                    bitmap.Save(memoryStream, ImageFormat.Bmp);
                }
                catch (ExternalException)
                {
                    RJMessageBox.Show("Lỗi không thể lưu được ảnh. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                return memoryStream.ToArray();
            } 
        }

        private void btnNVImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatar.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnDeleteImg_Click(object sender, EventArgs e)
        {
            avatar.Image = null;
        }

        private void tbNameNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void tbEmailNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void tbBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void tbSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void tbCMNDNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void tbAddressNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}