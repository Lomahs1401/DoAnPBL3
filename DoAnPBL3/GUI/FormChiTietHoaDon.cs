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
    public partial class FormChiTietHoaDon : Form
    {
        private readonly string ID_Order;
        private readonly string orderDate;
        private readonly string theme;
        public FormChiTietHoaDon(string theme, string ID_Order, string orderDate)
        {
            this.ID_Order = ID_Order;
            this.orderDate = orderDate;
            this.theme = theme;
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
            switch (theme)
            {
                case "Admin":
                    panelContainer.BackColor = Color.FromArgb(24, 37, 65);
                    lblIDHD.ForeColor = Color.WhiteSmoke;
                    lblOrderDate.ForeColor = Color.WhiteSmoke;
                    tbOrderDate.ForeColor = Color.WhiteSmoke;
                    lblListBillDetail.ForeColor = Color.WhiteSmoke;
                    lblTotalNumberBook.ForeColor = Color.WhiteSmoke;
                    lblTotal.ForeColor = Color.WhiteSmoke;
                    lblQuantity.ForeColor = Color.WhiteSmoke;
                    tbIDHD.FillColor = Color.FromArgb(15, 27, 57);
                    tbIDHD.ForeColor = Color.FromArgb(193, 200, 207);
                    tbNumDiverse.FillColor = Color.FromArgb(15, 27, 57);
                    tbNumDiverse.ForeColor = Color.FromArgb(193, 200, 207);
                    tbQuantity.FillColor = Color.FromArgb(15, 27, 57);
                    tbQuantity.ForeColor = Color.FromArgb(193, 200, 207);
                    tbTotal.FillColor = Color.FromArgb(15, 27, 57);
                    tbTotal.ForeColor = Color.FromArgb(193, 200, 207);
                    dgvQLCTHD.BackgroundColor = Color.FromArgb(45, 66, 91);
                    break;
                case "Dark":
                    panelContainer.BackColor = Color.FromArgb(32, 32, 32);
                    lblIDHD.ForeColor = Color.WhiteSmoke;
                    lblOrderDate.ForeColor = Color.WhiteSmoke;
                    tbOrderDate.ForeColor = Color.WhiteSmoke;
                    lblListBillDetail.ForeColor = Color.WhiteSmoke;
                    lblTotalNumberBook.ForeColor = Color.WhiteSmoke;
                    lblTotal.ForeColor = Color.WhiteSmoke;
                    lblQuantity.ForeColor = Color.WhiteSmoke;
                    tbIDHD.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbIDHD.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbNumDiverse.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbNumDiverse.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbQuantity.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbQuantity.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbTotal.DisabledState.FillColor = Color.FromArgb(40, 35, 40);
                    tbTotal.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    dgvQLCTHD.BackgroundColor = Color.FromArgb(34, 31, 46);
                    break;
                case "Light":
                    panelContainer.BackColor = Color.Gainsboro;
                    lblIDHD.ForeColor = Color.Black;
                    lblOrderDate.ForeColor = Color.Black;
                    tbOrderDate.ForeColor = Color.Black;
                    lblListBillDetail.ForeColor = Color.Black;
                    lblTotalNumberBook.ForeColor = Color.Black;
                    lblTotal.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    tbIDHD.DisabledState.FillColor = Color.Silver;
                    tbIDHD.DisabledState.ForeColor = Color.Black;
                    tbIDHD.DisabledState.BorderColor = Color.Black;
                    tbNumDiverse.DisabledState.FillColor = Color.Silver;
                    tbNumDiverse.DisabledState.ForeColor = Color.Black;
                    tbNumDiverse.DisabledState.BorderColor = Color.Black;
                    tbQuantity.DisabledState.FillColor = Color.Silver;
                    tbQuantity.DisabledState.ForeColor = Color.Black;
                    tbQuantity.DisabledState.BorderColor = Color.Black;
                    tbTotal.DisabledState.FillColor = Color.Silver;
                    tbTotal.DisabledState.ForeColor = Color.Black;
                    tbTotal.DisabledState.BorderColor = Color.Black;
                    dgvQLCTHD.BackgroundColor = Color.Silver;
                    break;
            }
        }

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dgvQLCTHD.RowHeadersVisible = true;
            dgvQLCTHD.BorderStyle = BorderStyle.FixedSingle;
            dgvQLCTHD.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLCTHD.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            tbIDHD.Text = ID_Order;
            tbOrderDate.Text = orderDate;
            List<OrderDetail> listOrderDetails = BLL_QLHD.Instance.GetOrderDetailsByIDOrder(ID_Order);
            DataTable data = new DataTable();
            CreateCol(data);
            if (listOrderDetails != null)
            {
                foreach (OrderDetail orderDetail in listOrderDetails)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, orderDetail));
                }
                dgvQLCTHD.DataSource = data;
                tbNumDiverse.Text = dgvQLCTHD.RowCount.ToString();
                tbQuantity.Text = BLL_QLHD.Instance.GetTotalQuantity(ID_Order).ToString();
                tbTotal.Text = BLL_QLHD.Instance.GetTotalAmount(ID_Order).ToString("##,#") + "VNĐ";
            }
            else
                dgvQLCTHD.DataSource = null;
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private string GetID_Book()
        {
            return dgvQLCTHD.CurrentRow.Cells["ID_Book"].Value.ToString();
        }

        private void CreateCol(DataTable data)
        {
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Book", typeof(string)),
                new DataColumn("NameBook", typeof(string)),
                new DataColumn("UnitPrice", typeof(string)),
                new DataColumn("Quantity", typeof(int)),
                new DataColumn("TotalAmount", typeof(string)),
            });
        }

        private DataRow CreateRow(DataRow dataRow, OrderDetail orderDetail)
        {
            dataRow["ID_Book"] = orderDetail.ID_Book;
            dataRow["NameBook"] = orderDetail.NameBook;
            dataRow["UnitPrice"] = orderDetail.UnitPrice.ToString("##,#") + "VNĐ";
            dataRow["Quantity"] = orderDetail.Quantity;
            dataRow["TotalAmount"] = orderDetail.TotalAmount.ToString("##,#") + "VNĐ";
            return dataRow;
        }

        private void DgvQLCTHD_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nameBook = dgvQLCTHD.CurrentRow.Cells["NameBook"].Value.ToString();
            int quantity = Convert.ToInt32(dgvQLCTHD.CurrentRow.Cells["Quantity"].Value.ToString());
            string price = dgvQLCTHD.CurrentRow.Cells["UnitPrice"].Value.ToString();
            price = price.Remove(price.Length - 3, 3);
            var charsToRemove = new string[] { "@", ",", ".", ";", "'" };
            foreach (var c in charsToRemove)
            {
                price = price.Replace(c, string.Empty);
            }
            int unitPrice = Convert.ToInt32(price);
            new FormTTS(theme, GetID_Book(), nameBook, unitPrice, quantity).Show();
        }
    }
}