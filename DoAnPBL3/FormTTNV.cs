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
        string ID_Employee;
        public FormTTNV(string ID_Employee)
        {
            InitializeComponent();
            this.ID_Employee = ID_Employee;
        }

        private void rjbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormTTNV_Load(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var employee = context.Employees.Where(em => em.ID_Employee == this.ID_Employee).ToList().First();
                tbNameNV.Text = employee.NameEmployee;
                tbEmailNV.Text = employee.Email;
                tbBD.Text = employee.DateOfBirth.ToString("dd/MM/yyyy");
                tbGender.Text = employee.Gender;
                tbSDTNV.Text = employee.Phone;
                tbCMNDNV.Text = employee.Id_Card;
                tbAddressNV.Text = employee.Address;
                if (employee.Avatar != null)
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])employee.Avatar);
                    avatar.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    avatar.Image = null;
                }
            }
        }
    }
}
