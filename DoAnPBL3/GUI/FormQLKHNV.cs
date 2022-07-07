using DoAnPBL3.BLL;
using DoAnPBL3.Models;
using DoAnPBL3.Validator;
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
    public partial class FormQLKHNV : Form
    {
        private string theme = "Admin";
        public FormQLKHNV()
        {
            InitializeComponent();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void BtnHDKH_MouseEnter(object sender, EventArgs e)
        {
            btnHDKH.BackColor = RGBColors.color4;
        }

        private void BtnHDKH_MouseLeave(object sender, EventArgs e)
        {
            btnHDKH.BackColor = Color.RoyalBlue;
        }

        private void FormQLKH_Load(object sender, EventArgs e)
        {
            GetInfoCustomer();
            dgvQLKHNV.RowHeadersVisible = true;
            dgvQLKHNV.BorderStyle = BorderStyle.FixedSingle;
            dgvQLKHNV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLKHNV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            List<Customer> listCustomers = BLL_QLKH.Instance.GetCustomers();
            DataTable data = new DataTable();
            CreateCol(data);
            if (listCustomers != null)
            {
                foreach (Customer customer in listCustomers)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, customer));
                }
                dgvQLKHNV.DataSource = data;
            }
            else
            {
                dgvQLKHNV.DataSource = null;
                totalCustomers.Text = "0";
                totalMaleCustomers.Text = "0";
                totalFemaleCustomers.Text = "0";
            }
        }

        private void XuiSegmentKH_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            CreateCol(data);
            if (xuiSegmentKH.SelectedIndex == 0)
            {
                List<Customer> customers = BLL_QLKH.Instance.GetCustomers();
                if (customers == null)
                {
                    dgvQLKHNV.DataSource = null;
                }
                else
                {
                    foreach (Customer customer in customers)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, customer));
                    }
                    dgvQLKHNV.DataSource = data;
                }
            }
            // Nam
            else if (xuiSegmentKH.SelectedIndex == 1)
            {
                List<Customer> maleCustomers = BLL_QLKH.Instance.GetMaleCustomers();
                if (maleCustomers == null)
                {
                    dgvQLKHNV.DataSource = null;
                }
                else
                {
                    foreach (Customer customer in maleCustomers)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, customer));
                    }
                    dgvQLKHNV.DataSource = data;
                }
            }
            // Nữ
            else
            {
                List<Customer> femaleCustomers = BLL_QLKH.Instance.GetFemaleCustomers();
                if (femaleCustomers == null)
                {
                    dgvQLKHNV.DataSource = null;
                }
                else
                {
                    foreach (Customer customer in femaleCustomers)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, customer));
                    }
                    dgvQLKHNV.DataSource = data;
                }
            }
        }

        private void BtnHDKH_Click(object sender, EventArgs e)
        {
            string nameCustomer = dgvQLKHNV.CurrentRow.Cells["FullNameCustomer"].Value.ToString();
            new FormHoaDonKhachHang(theme, GetID_Customer(), nameCustomer).Show();
        }

        private void RjtbTKKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTKKH.PerformClick();
                e.Handled = true;
            }
        }

        private void BtnTKKH_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            CreateCol(data);
            if (rjtbTKKH.Texts.Trim() == "")
                RJMessageBox.Show("Vui lòng điền thông tin khách hàng cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rjtbTKKH.Texts.Contains("KH0"))
            {
                Customer customer = BLL_QLKH.Instance.GetCustomerByID(rjtbTKKH.Texts);
                if (customer == null)
                    RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, customer));
                    dgvQLKHNV.DataSource = data;
                }
            }
            else if (Validators.IsValidPhoneNumber(rjtbTKKH.Texts, Validators.PHONE_REGEX))
            {
                Customer customer = BLL_QLKH.Instance.GetCustomerByPhone(rjtbTKKH.Texts);
                if (customer == null)
                    RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, customer));
                    dgvQLKHNV.DataSource = data;
                }
            }
            else
            {
                List<Customer> listCustomers = BLL_QLKH.Instance.GetCustomersByName(rjtbTKKH.Texts);
                if (listCustomers == null)
                    RJMessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    foreach (Customer customer in listCustomers)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, customer));
                    }
                    dgvQLKHNV.DataSource = data;
                }
            }
        }

        private void DgvQLKH_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new FormTTKH(theme, GetID_Customer()).ShowDialog();
        }

        private string GetID_Customer()
        {
            return dgvQLKHNV.CurrentRow.Cells["ID_Customer"].Value.ToString();
        }

        private void GetInfoCustomer()
        {
            totalCustomers.Text = BLL_QLKH.Instance.GetNumberTotalCustomer().ToString();
            totalMaleCustomers.Text = BLL_QLKH.Instance.GetNumberTotalMaleCustomer().ToString();
            totalFemaleCustomers.Text = BLL_QLKH.Instance.GetNumberTotalFemaleCustomer().ToString();
        }

        private void CreateCol(DataTable data)
        {
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Customer", typeof(string)),
                new DataColumn("FullNameCustomer", typeof(string)),
                new DataColumn("Gender", typeof(string)),
                new DataColumn("Phone", typeof(string)),
                new DataColumn("Address", typeof(string)),
            });
        }

        private DataRow CreateRow(DataRow dataRow, Customer customer)
        {
            dataRow["ID_Customer"] = customer.ID_Customer;
            dataRow["FullNameCustomer"] = customer.FullNameCustomer;
            dataRow["Gender"] = customer.Gender;
            dataRow["Phone"] = customer.Phone;
            dataRow["Address"] = customer.Address;
            return dataRow;
        }
    }
}
