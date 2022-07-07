using DoAnPBL3.BLL;
using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormTTNV : Form
    {
        private readonly string ID_Employee;

        public FormTTNV(string theme, string ID_Employee)
        {
            InitializeComponent();
            this.ID_Employee = ID_Employee;
            switch (theme)
            {
                case "Admin":
                    panelContainer.BackColor = Color.FromArgb(24, 37, 65);
                    lblIDNV.ForeColor = Color.WhiteSmoke;
                    lblNameNV.ForeColor = Color.WhiteSmoke;
                    lblEmail.ForeColor = Color.WhiteSmoke;
                    lblBD.ForeColor = Color.WhiteSmoke;
                    lblStartDate.ForeColor = Color.WhiteSmoke;
                    lblEndDate.ForeColor = Color.WhiteSmoke;
                    lblGender.ForeColor = Color.WhiteSmoke;
                    lblSDT.ForeColor = Color.WhiteSmoke;
                    lblCMND.ForeColor = Color.WhiteSmoke;
                    lblAddress.ForeColor = Color.WhiteSmoke;
                    tbIDNV.FillColor = Color.FromArgb(15, 27, 57);
                    tbIDNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbIDNV.BorderColor = Color.FromArgb(193, 200, 207);
                    tbNameNV.FillColor = Color.FromArgb(15, 27, 57);
                    tbNameNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbNameNV.BorderColor = Color.FromArgb(193, 200, 207);
                    tbEmailNV.FillColor = Color.FromArgb(15, 27, 57);
                    tbEmailNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbEmailNV.BorderColor = Color.FromArgb(193, 200, 207);
                    tbBD.FillColor = Color.FromArgb(15, 27, 57);
                    tbBD.ForeColor = Color.FromArgb(193, 200, 207);
                    tbBD.BorderColor = Color.FromArgb(193, 200, 207);
                    tbStartDate.FillColor = Color.FromArgb(15, 27, 57);
                    tbStartDate.ForeColor = Color.FromArgb(193, 200, 207);
                    tbStartDate.BorderColor = Color.FromArgb(193, 200, 207);
                    tbEndDate.FillColor = Color.FromArgb(15, 27, 57);
                    tbEndDate.ForeColor = Color.FromArgb(193, 200, 207);
                    tbEndDate.BorderColor = Color.FromArgb(193, 200, 207);
                    tbGender.FillColor = Color.FromArgb(15, 27, 57);
                    tbGender.ForeColor = Color.FromArgb(193, 200, 207);
                    tbGender.BorderColor = Color.FromArgb(193, 200, 207);
                    tbSDTNV.FillColor = Color.FromArgb(15, 27, 57);
                    tbSDTNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbSDTNV.BorderColor = Color.FromArgb(193, 200, 207);
                    tbCMNDNV.FillColor = Color.FromArgb(15, 27, 57);
                    tbCMNDNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbCMNDNV.BorderColor = Color.FromArgb(193, 200, 207);
                    tbAddressNV.FillColor = Color.FromArgb(15, 27, 57);
                    tbAddressNV.ForeColor = Color.FromArgb(193, 200, 207);
                    tbAddressNV.BorderColor = Color.FromArgb(193, 200, 207);
                    break;
                case "Dark":
                    panelContainer.BackColor = Color.FromArgb(32, 32, 32);
                    lblIDNV.ForeColor = Color.WhiteSmoke;
                    lblNameNV.ForeColor = Color.WhiteSmoke;
                    lblEmail.ForeColor = Color.WhiteSmoke;
                    lblBD.ForeColor = Color.WhiteSmoke;
                    lblStartDate.ForeColor = Color.WhiteSmoke;
                    lblEndDate.ForeColor = Color.WhiteSmoke;
                    lblGender.ForeColor = Color.WhiteSmoke;
                    lblSDT.ForeColor = Color.WhiteSmoke;
                    lblCMND.ForeColor = Color.WhiteSmoke;
                    lblAddress.ForeColor = Color.WhiteSmoke;
                    tbIDNV.DisabledState.BorderColor = Color.FromArgb(40, 35, 40);
                    tbIDNV.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbIDNV.DisabledState.BorderColor = Color.FromArgb(193, 200, 207);
                    tbIDNV.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbNameNV.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbNameNV.DisabledState.BorderColor = Color.FromArgb(193, 200, 207);
                    tbNameNV.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbEmailNV.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbEmailNV.DisabledState.BorderColor = Color.FromArgb(193, 200, 207);
                    tbEmailNV.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbBD.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbBD.DisabledState.BorderColor = Color.FromArgb(193, 200, 207);
                    tbBD.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbStartDate.DisabledState.FillColor = Color.FromArgb(40, 35, 40);                    
                    tbStartDate.DisabledState.BorderColor = Color.FromArgb(193, 200, 207);
                    tbStartDate.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbEndDate.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbEndDate.DisabledState.BorderColor = Color.FromArgb(193, 200, 207);
                    tbEndDate.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbGender.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbGender.DisabledState.BorderColor = Color.FromArgb(193, 200, 207);
                    tbGender.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbSDTNV.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbSDTNV.DisabledState.BorderColor = Color.FromArgb(193, 200, 207);
                    tbSDTNV.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbCMNDNV.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbCMNDNV.DisabledState.BorderColor = Color.FromArgb(193, 200, 207);
                    tbCMNDNV.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbAddressNV.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbAddressNV.DisabledState.BorderColor = Color.FromArgb(193, 200, 207);
                    tbAddressNV.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    break;
                case "Light":
                    panelContainer.BackColor = Color.Gainsboro;
                    lblIDNV.ForeColor = Color.Black;
                    lblNameNV.ForeColor = Color.Black;
                    lblEmail.ForeColor = Color.Black;
                    lblBD.ForeColor = Color.Black;
                    lblStartDate.ForeColor = Color.Black;
                    lblEndDate.ForeColor = Color.Black;
                    lblGender.ForeColor = Color.Black;
                    lblSDT.ForeColor = Color.Black;
                    lblCMND.ForeColor = Color.Black;
                    lblAddress.ForeColor = Color.Black;
                    tbIDNV.DisabledState.FillColor = Color.Silver;
                    tbIDNV.DisabledState.ForeColor = Color.Black;
                    tbIDNV.DisabledState.PlaceholderForeColor = Color.Black;
                    tbIDNV.DisabledState.BorderColor = Color.Black;
                    tbNameNV.DisabledState.FillColor = Color.Silver;
                    tbNameNV.DisabledState.ForeColor = Color.Black;
                    tbNameNV.DisabledState.PlaceholderForeColor = Color.Black;
                    tbNameNV.DisabledState.BorderColor = Color.Black;
                    tbEmailNV.DisabledState.FillColor = Color.Silver;
                    tbEmailNV.DisabledState.ForeColor = Color.Black;
                    tbEmailNV.DisabledState.PlaceholderForeColor = Color.Black;
                    tbEmailNV.DisabledState.BorderColor = Color.Black;
                    tbBD.DisabledState.FillColor = Color.Silver;
                    tbBD.DisabledState.ForeColor = Color.Black;
                    tbBD.DisabledState.PlaceholderForeColor = Color.Black;
                    tbBD.DisabledState.BorderColor = Color.Black;
                    tbStartDate.DisabledState.FillColor = Color.Silver;
                    tbStartDate.DisabledState.ForeColor = Color.Black;
                    tbStartDate.DisabledState.PlaceholderForeColor = Color.Black;
                    tbStartDate.DisabledState.BorderColor = Color.Black;
                    tbEndDate.DisabledState.FillColor = Color.Silver;
                    tbEndDate.DisabledState.ForeColor = Color.Black;
                    tbEndDate.DisabledState.PlaceholderForeColor = Color.Black;
                    tbEndDate.DisabledState.BorderColor = Color.Black;
                    tbGender.DisabledState.FillColor = Color.Silver;
                    tbGender.DisabledState.ForeColor = Color.Black;
                    tbGender.DisabledState.PlaceholderForeColor = Color.Black;
                    tbGender.DisabledState.BorderColor = Color.Black;
                    tbSDTNV.DisabledState.FillColor = Color.Silver;
                    tbSDTNV.DisabledState.ForeColor = Color.Black;
                    tbSDTNV.DisabledState.PlaceholderForeColor = Color.Black;
                    tbSDTNV.DisabledState.BorderColor = Color.Black;
                    tbCMNDNV.DisabledState.FillColor = Color.Silver;
                    tbCMNDNV.DisabledState.ForeColor = Color.Black;
                    tbCMNDNV.DisabledState.PlaceholderForeColor = Color.Black;
                    tbCMNDNV.DisabledState.BorderColor = Color.Black;
                    tbAddressNV.DisabledState.FillColor = Color.Silver;
                    tbAddressNV.DisabledState.ForeColor = Color.Black;
                    tbAddressNV.DisabledState.PlaceholderForeColor = Color.Black;
                    tbAddressNV.DisabledState.BorderColor = Color.Black;
                    break;
            }
        }

        private void FormTTNV_Load(object sender, EventArgs e)
        {
             guna2ShadowForm1.SetShadowForm(this);
             ShowInfo(BLL_QLNV.Instance.GetEmployeeByID(ID_Employee));
        }

        private void ShowInfo(Employee employee)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            tbIDNV.Text = employee.ID_Employee;
            tbNameNV.Text = employee.FullNameEmployee;
            tbEmailNV.Text = employee.Email;
            tbBD.Text = employee.DateOfBirth.ToString("dd/MM/yyyy");
            tbStartDate.Text = employee.StartDate.ToString("dd/MM/yyyy");
            if (employee.EndDate == null || employee.EndDate.Value.ToString("dd/MM/yyyy") == "01/01/1900")
                tbEndDate.Text = "";
            else
                tbEndDate.Text = employee.EndDate.Value.ToString("dd/MM/yyyy");
            tbGender.Text = employee.Gender;
            tbCMNDNV.Text = employee.Id_Card;
            tbAddressNV.Text = employee.Address;
            tbSDTNV.Text = employee.Phone;
            if (employee.Avatar == null)
                avatar.Image = null;
            else
                avatar.Image = Image.FromFile(Path.Combine(projectDirectory, employee.Avatar));
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
