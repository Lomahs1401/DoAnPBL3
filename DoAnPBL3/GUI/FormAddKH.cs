using DoAnPBL3.Models;
using DoAnPBL3.Validator;
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
        private readonly string phoneNumber;

        //Constructor
        public FormAddKH(string phoneNumber = "")
        {
            InitializeComponent();
            this.phoneNumber = phoneNumber;
        }

        private void FormAddKH_Load(object sender, EventArgs e)
        {
            tbPhoneKH.Text = phoneNumber;
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            bool isValidName, isValidGender, isValidPhone, isValidAddress;
            string name, gender, phone, address;
            // Validate name
            name = tbNameKH.Text;
            if (name == "")
            {
                msgValidateName.ForeColor = Color.Red;
                msgValidateName.Text = "Họ và tên khách hàng không được để trống";
                isValidName = false;
            }
            else
            {
                msgValidateName.ForeColor = Color.White;
                msgValidateName.Text = "";
                isValidName = true;
            }
            // Validate gender
            if (cbbGenderKH.SelectedItem == null)
            {
                gender = "";
                msgValidateGender.ForeColor = Color.Red;
                msgValidateGender.Text = "Giới tính không được để trống";
                isValidGender = false;
            }
            else
            {
                gender = cbbGenderKH.SelectedItem.ToString();
                msgValidateGender.ForeColor = Color.White;
                msgValidateGender.Text = "";
                isValidGender = true;
            }
            // Validate phone number
            phone = tbPhoneKH.Text;
            isValidPhone = Validators.IsValidPhoneNumber(phone, Validators.PHONE_REGEX);
            if (phone == "")
            {
                msgValidatePhone.ForeColor = Color.Red;
                msgValidatePhone.Text = "SĐT khách hàng không được để trống";
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
            // Validate address
            if (tbAddressKH.Text == "")
            {
                address = "";
                msgValidateAddress.ForeColor = Color.Red;
                msgValidateAddress.Text = "Địa chỉ không được để trống";
                isValidAddress = false;
            }
            else
            {
                address = tbAddressKH.Text;
                msgValidateAddress.ForeColor = Color.White;
                msgValidateAddress.Text = "";
                isValidAddress = true;
            }

            if (isValidName && isValidGender && isValidPhone && isValidAddress)
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    Customer customer;
                    var lastID_Customer = context.Customers
                        .OrderBy(cus => cus.ID_Customer)
                        .Select(cus => cus.ID_Customer)
                        .ToList()
                        .LastOrDefault();
                    if (lastID_Customer == null)
                    {
                        customer = new Customer("KH0000", name, gender, phone, address);
                        FormCart.ID_Customer = "KH0000";
                    }
                    else
                    {
                        string id = lastID_Customer; // KH0006
                        string code = id.Substring(2, id.Length - 2); // 0006
                        int num = Convert.ToInt32(code); // 6
                        num++; // 6 + 1 -> 7
                        string numStr = num.ToString(); // "7"
                        int lenNumStr = numStr.Length; // 1
                        StringBuilder newID_Customer = new StringBuilder(id.Remove(id.Length - lenNumStr, lenNumStr)); // KH000
                        newID_Customer.Append(numStr); // KH000 + 7 => KH0007

                        customer = new Customer(newID_Customer.ToString(), name, gender, phone, address);
                        FormCart.ID_Customer = newID_Customer.ToString();
                    }
                    context.Customers.Add(customer);
                    context.SaveChanges();
                    Alert("Thêm mới khách hàng thành công", Form_Alert.EnmType.Success);
                    Close();
                }
            }
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            string nameCustomer, phone, address;
            nameCustomer = tbNameKH.Text;
            phone = tbPhoneKH.Text;
            address = tbAddressKH.Text;
            if (nameCustomer != "" || cbbGenderKH.SelectedItem != null || phone != "" || address != "")
            {
                DialogResult result = RJMessageBox.Show("Dữ liệu chưa được lưu. Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    Close();
                else
                    return;
            }
            else
                Close();
        }

            private void TbNameKH_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    rjbtnOK.PerformClick();
                    e.Handled = true;
                }
            }

            private void TbPhoneKH_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    rjbtnOK.PerformClick();
                    e.Handled = true;
                }
            }

            private void TbAddressKH_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    rjbtnOK.PerformClick();
                    e.Handled = true;
                }
            }
    }
}