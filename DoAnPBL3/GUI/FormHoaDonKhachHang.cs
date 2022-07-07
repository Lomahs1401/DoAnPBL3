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
    public partial class FormHoaDonKhachHang : Form
    {
        private readonly string ID_Customer;
        private readonly string nameCustomer;
        private readonly string theme;
        public FormHoaDonKhachHang(string theme, string ID_Customer, string nameCustomer)
        {
            this.ID_Customer = ID_Customer;
            this.nameCustomer = nameCustomer;
            this.theme = theme;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            switch (theme)
            {
                case "Admin":
                    panelContainer.BackColor = Color.FromArgb(24, 37, 65);
                    panel1.BackColor = Color.FromArgb(30, 30, 70);
                    panelBill.BackColor = Color.FromArgb(30, 30, 70);
                    lblIDKH.ForeColor = Color.WhiteSmoke;
                    lblNameKH.ForeColor = Color.WhiteSmoke;
                    lblTotalBill.ForeColor = Color.WhiteSmoke;
                    totalBill.ForeColor = Color.WhiteSmoke;
                    lblListOrders.ForeColor = Color.WhiteSmoke;
                    lblTotalPrice.ForeColor = Color.WhiteSmoke;
                    tbMaKH.FillColor = Color.FromArgb(15, 27, 57);
                    tbMaKH.ForeColor = Color.FromArgb(193, 200, 207);
                    tbNameKH.FillColor = Color.FromArgb(15, 27, 57);
                    tbNameKH.ForeColor = Color.FromArgb(193, 200, 207);
                    tbTotalPrice.FillColor = Color.FromArgb(15, 27, 57);
                    tbTotalPrice.ForeColor = Color.FromArgb(193, 200, 207);
                    dgvQLHD.BackgroundColor = Color.FromArgb(24, 37, 65);
                    break;
                case "Dark":
                    panelContainer.BackColor = Color.FromArgb(32, 32, 32);
                    panel1.BackColor = Color.FromArgb(38, 38, 40);
                    panelBill.BackColor = Color.FromArgb(38, 38, 40);
                    lblIDKH.ForeColor = Color.WhiteSmoke;
                    lblNameKH.ForeColor = Color.WhiteSmoke;
                    lblTotalBill.ForeColor = Color.WhiteSmoke;
                    totalBill.ForeColor = Color.WhiteSmoke;
                    lblListOrders.ForeColor = Color.WhiteSmoke;
                    lblTotalPrice.ForeColor = Color.WhiteSmoke;
                    tbMaKH.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbMaKH.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbNameKH.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbNameKH.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbTotalPrice.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbTotalPrice.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    dgvQLHD.BackgroundColor = Color.FromArgb(34, 31, 46);
                    break;
                case "Light":
                    panelContainer.BackColor = Color.Gainsboro;
                    panel1.BackColor = Color.FromArgb(210, 200, 210);
                    panelBill.BackColor = Color.FromArgb(210, 200, 210);
                    lblIDKH.ForeColor = Color.Black;
                    lblNameKH.ForeColor = Color.Black;
                    lblTotalBill.ForeColor = Color.Black;
                    lblListOrders.ForeColor = Color.Black;
                    lblTotalPrice.ForeColor = Color.Black;
                    totalBill.ForeColor = Color.Black;
                    tbMaKH.DisabledState.FillColor = Color.Silver;
                    tbMaKH.DisabledState.ForeColor = Color.Black;
                    tbMaKH.DisabledState.PlaceholderForeColor = Color.Black;
                    tbMaKH.DisabledState.BorderColor = Color.Black;
                    tbNameKH.DisabledState.FillColor = Color.Silver;
                    tbNameKH.DisabledState.ForeColor = Color.Black;
                    tbNameKH.DisabledState.PlaceholderForeColor = Color.Black;
                    tbNameKH.DisabledState.BorderColor = Color.Black;
                    tbTotalPrice.DisabledState.FillColor = Color.Silver;
                    tbTotalPrice.DisabledState.ForeColor = Color.Black;
                    tbTotalPrice.DisabledState.PlaceholderForeColor = Color.Black;
                    tbTotalPrice.DisabledState.BorderColor = Color.Black;
                    btnTKHD.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKHD.BackColor = Color.FromArgb(255, 255, 255);
                    rjtbTKHD.BorderColor = Color.FromArgb(180, 180, 180);
                    rjtbTKHD.ForeColor = Color.DimGray;
                    dgvQLHD.BackgroundColor = Color.Silver;
                    break;
            }
        }

        private void FormHoaDonKhachHang_Load(object sender, EventArgs e)
        {
            tbMaKH.Text = ID_Customer;
            tbNameKH.Text = nameCustomer;
            dgvQLHD.RowHeadersVisible = true;
            dgvQLHD.BorderStyle = BorderStyle.FixedSingle;
            dgvQLHD.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLHD.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            List<Order> listOrders = BLL_QLHD.Instance.GetOrdersByIDCustomer(ID_Customer);
            DataTable data = new DataTable();
            CreateCol(data);
            if (listOrders != null)
            {
                foreach (Order order in listOrders)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, order));
                }
                dgvQLHD.DataSource = data;
                totalBill.Text = BLL_QLHD.Instance.GetNumberTotalOrderByIDCustomer(ID_Customer).ToString();
                tbTotalPrice.Text = BLL_QLHD.Instance.GetNumberTotalPriceByIDCustomer(ID_Customer).ToString("##,#") + "VNĐ";
            }
            else
            {
                dgvQLHD.DataSource = null;
                totalBill.Text = "0";
                tbTotalPrice.Text = "0VNĐ";
            }
        }

        private void DgvQLHD_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string orderDate = dgvQLHD.CurrentRow.Cells["OrderDate"].Value.ToString();
            new FormChiTietHoaDon(theme, GetID_Order(), orderDate).Show();
        }
        
        private string GetID_Order()
        {
            return dgvQLHD.CurrentRow.Cells["ID_Order"].Value.ToString();
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void RjtbTKHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTKHD.PerformClick();
                e.Handled = true;
            }
        }

        private void BtnTKHD_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            CreateCol(data);
            if (rjtbTKHD.Texts.Trim() == "")
                RJMessageBox.Show("Vui lòng điền thông tin hóa đơn cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                List<Order> listOrders = BLL_QLHD.Instance.GetOrdersByEmployee(rjtbTKHD.Texts, ID_Customer);
                if (listOrders != null)
                {
                    foreach (Order order in listOrders)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, order));
                    }
                    dgvQLHD.DataSource = data;
                }
                else
                {
                    dgvQLHD.DataSource = null;
                    dgvQLHD.Columns.Clear();
                    SetColumnHeader();
                }
            }
        }

        private void CreateCol(DataTable data)
        {
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Order", typeof(string)),
                new DataColumn("OrderDate", typeof(string)),
                new DataColumn("NameEmployee", typeof(string)),
                new DataColumn("TotalPrice", typeof(string)),
            });
        }

        private DataRow CreateRow(DataRow dataRow, Order order)
        {
            dataRow["ID_Order"] = order.ID_Order;
            dataRow["OrderDate"] = order.OrderDate.ToString("dd/MM/yyyy");
            dataRow["NameEmployee"] = BLL_QLNV.Instance.GetNameEmployeeByID(order.ID_Employee);
            dataRow["TotalPrice"] = order.TotalPrice.ToString("##,#") + "VNĐ";
            return dataRow;
        }

        private void SetColumnHeader()
        {
            dgvQLHD.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn() {HeaderText = "ID Hóa đơn", DataPropertyName = "ID_Order", Name = "ID_Order"},
                new DataGridViewTextBoxColumn() {HeaderText = "Ngày mua", DataPropertyName = "OrderDate", Name = "OrderDate"},
                new DataGridViewTextBoxColumn() {HeaderText = "Thu ngân", DataPropertyName = "NameEmployee", Name = "NameEmployee"},
                new DataGridViewTextBoxColumn() {HeaderText = "Tổng tiền", DataPropertyName = "TotalPrice", Name = "TotalPrice"},
            });
        }
    }
}