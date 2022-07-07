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
    public partial class FormTTKH : Form
    {
        private readonly string ID_Customer;
        public FormTTKH(string theme, string ID_Customer)
        {
            InitializeComponent();
            this.ID_Customer = ID_Customer;
            switch (theme)
            {
                case "Admin":
                    panelContainer.BackColor = Color.FromArgb(24, 37, 65);
                    lblNameKH.ForeColor = Color.WhiteSmoke;
                    lblGenderKH.ForeColor = Color.WhiteSmoke;
                    lblPhoneKH.ForeColor = Color.WhiteSmoke;
                    lblAddressKH.ForeColor = Color.WhiteSmoke;
                    lblNumberOrder.ForeColor = Color.WhiteSmoke;
                    lblTotalPrice.ForeColor = Color.WhiteSmoke;
                    tbNameKH.FillColor = Color.FromArgb(15, 27, 57);
                    tbNameKH.ForeColor = Color.FromArgb(193, 200, 207);
                    tbGenderKH.FillColor = Color.FromArgb(15, 27, 57);
                    tbGenderKH.ForeColor = Color.FromArgb(193, 200, 207);
                    tbPhoneKH.FillColor = Color.FromArgb(15, 27, 57);
                    tbPhoneKH.ForeColor = Color.FromArgb(193, 200, 207);
                    tbAddressKH.FillColor = Color.FromArgb(15, 27, 57);
                    tbAddressKH.ForeColor = Color.FromArgb(193, 200, 207);
                    tbStartDate.FillColor = Color.FromArgb(15, 27, 57);
                    tbStartDate.ForeColor = Color.FromArgb(193, 200, 207);
                    tbNumberOrder.FillColor = Color.FromArgb(15, 27, 57);
                    tbNumberOrder.ForeColor = Color.FromArgb(193, 200, 207);
                    tbTotalPrice.FillColor = Color.FromArgb(15, 27, 57);
                    tbTotalPrice.ForeColor = Color.FromArgb(193, 200, 207);
                    break;
                case "Dark":
                    panelContainer.BackColor = Color.FromArgb(32, 32, 32);
                    lblNameKH.ForeColor = Color.WhiteSmoke;
                    lblGenderKH.ForeColor = Color.WhiteSmoke;
                    lblPhoneKH.ForeColor = Color.WhiteSmoke;
                    lblAddressKH.ForeColor = Color.WhiteSmoke;
                    lblNumberOrder.ForeColor = Color.WhiteSmoke;
                    lblTotalPrice.ForeColor = Color.WhiteSmoke;
                    tbNameKH.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbNameKH.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbGenderKH.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbGenderKH.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbPhoneKH.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbPhoneKH.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbAddressKH.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbAddressKH.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbStartDate.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbStartDate.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbNumberOrder.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbNumberOrder.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbTotalPrice.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbTotalPrice.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    break;
                case "Light":
                    panelContainer.BackColor = Color.Gainsboro;
                    lblNameKH.ForeColor = Color.Black;
                    lblGenderKH.ForeColor = Color.Black;
                    lblPhoneKH.ForeColor = Color.Black;
                    lblAddressKH.ForeColor = Color.Black;
                    lblStartDate.ForeColor = Color.Black;
                    lblNumberOrder.ForeColor = Color.Black;
                    lblTotalPrice.ForeColor = Color.Black;
                    tbNameKH.DisabledState.FillColor = Color.Silver;
                    tbNameKH.DisabledState.ForeColor = Color.Black;
                    tbNameKH.DisabledState.PlaceholderForeColor = Color.Black;
                    tbNameKH.DisabledState.BorderColor = Color.Black;
                    tbGenderKH.DisabledState.FillColor = Color.Silver;
                    tbGenderKH.DisabledState.ForeColor = Color.Black;
                    tbGenderKH.DisabledState.PlaceholderForeColor = Color.Black;
                    tbGenderKH.DisabledState.BorderColor = Color.Black;
                    tbPhoneKH.DisabledState.FillColor = Color.Silver;
                    tbPhoneKH.DisabledState.ForeColor = Color.Black;
                    tbPhoneKH.DisabledState.PlaceholderForeColor = Color.Black;
                    tbPhoneKH.DisabledState.BorderColor = Color.Black;
                    tbAddressKH.DisabledState.FillColor = Color.Silver;
                    tbAddressKH.DisabledState.ForeColor = Color.Black;
                    tbAddressKH.DisabledState.PlaceholderForeColor = Color.Black;
                    tbAddressKH.DisabledState.BorderColor = Color.Black;
                    tbStartDate.DisabledState.FillColor = Color.Silver;
                    tbStartDate.DisabledState.ForeColor = Color.Black;
                    tbStartDate.DisabledState.PlaceholderForeColor = Color.Black;
                    tbStartDate.DisabledState.BorderColor = Color.Black;
                    tbNumberOrder.DisabledState.FillColor = Color.Silver;
                    tbNumberOrder.DisabledState.ForeColor = Color.Black;
                    tbNumberOrder.DisabledState.PlaceholderForeColor = Color.Black;
                    tbNumberOrder.DisabledState.BorderColor = Color.Black;
                    tbTotalPrice.DisabledState.FillColor = Color.Silver;
                    tbTotalPrice.DisabledState.ForeColor = Color.Black;
                    tbTotalPrice.DisabledState.PlaceholderForeColor = Color.Black;
                    tbTotalPrice.DisabledState.BorderColor = Color.Black;
                    break;
            }
        }

        private void FormTTKH_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            ShowInfo(BLL_QLKH.Instance.GetCustomerByID(ID_Customer));
        }

        private void ShowInfo(Customer customer)
        {
            tbNameKH.Text = customer.FullNameCustomer;
            tbGenderKH.Text = customer.Gender;
            tbPhoneKH.Text = customer.Phone;
            tbAddressKH.Text = customer.Address;
            tbStartDate.Text = BLL_QLKH.Instance.GetStartDate(ID_Customer).ToString("dd/MM/yyyy");
            tbNumberOrder.Text = BLL_QLHD.Instance.GetNumberTotalOrderByIDCustomer(ID_Customer).ToString();
            tbTotalPrice.Text = BLL_QLHD.Instance.GetNumberTotalPriceByIDCustomer(ID_Customer).ToString("##,#") + "VNĐ";
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
