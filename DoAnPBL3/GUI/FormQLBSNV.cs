﻿using DoAnPBL3.BLL;
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
    public partial class FormQLBSNV : Form
    {
        private readonly string accountUsername;

        public FormQLBSNV(string accountUsername)
        {
            InitializeComponent();
            this.accountUsername = accountUsername;
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void FormQLBSNV_Load(object sender, EventArgs e)
        {
            GetAllInfoBooks();
            dgvQLBSNV.RowHeadersVisible = true;
            dgvQLBSNV.BorderStyle = BorderStyle.FixedSingle;
            dgvQLBSNV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLBSNV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            List<Book> listBooks = BLL_QLBS.Instance.GetBooks();
            DataTable data = new DataTable();
            CreateCol(data);
            if (listBooks != null)
            {
                foreach (Book book in listBooks)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, book));
                }
                dgvQLBSNV.DataSource = data;
            }
            else
            {
                dgvQLBSNV.DataSource = null;
                totalBook.Text = "0";
                vietnameseBook.Text = "0";
                englishBook.Text = "0";
            }
        }

        private void RjbtnBuy_Click(object sender, EventArgs e)
        {
            new FormCart(accountUsername).ShowDialog();
            FormQLBSNV_Load(sender, e);
        }

        private void RjbtnOrder_Click(object sender, EventArgs e)
        {
            RJMessageBox.Show("Đặt hàng");
        }

        private void RjbtnAddCart_Click(object sender, EventArgs e)
        {
            RJMessageBox.Show("Thêm vào giỏ hàng");
        }

        private void RjtbTKS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTKS.PerformClick();
                e.Handled = true;
            }
        }

        private void BtnTKS_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            CreateCol(data);
            if (rjtbTKS.Texts.Trim() == "")
                RJMessageBox.Show("Vui lòng điền thông tin sách cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rjtbTKS.Texts.Contains(""))
            {

            }
            else
            {
                List<Book> listBooksByName = BLL_QLBS.Instance.GetBooksByNameBook(rjtbTKS.Texts);
                if (listBooksByName != null)
                {
                    foreach (Book book in listBooksByName)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, book));
                    }
                    dgvQLBSNV.DataSource = data;
                }
                else
                {
                    List<Book> listBooksByAuthor = BLL_QLBS.Instance.GetBooksByNameAuthor(rjtbTKS.Texts);
                    if (listBooksByAuthor != null)
                    {
                        foreach (Book book in listBooksByName)
                        {
                            DataRow dataRow = data.NewRow();
                            data.Rows.Add(CreateRow(dataRow, book));
                        }
                        dgvQLBSNV.DataSource = data;
                    }
                    else
                        RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void XuiSegmentSach_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            CreateCol(data);
            if (xuiSegmentSach.SelectedIndex == 0)
            {
                List<Book> listBooks = BLL_QLBS.Instance.GetBooks();
                if (listBooks == null)
                {
                    dgvQLBSNV.DataSource = null;
                }
                else
                {
                    foreach (Book book in listBooks)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, book));
                    }
                    dgvQLBSNV.DataSource = data;
                }
            }
            // Sách tiếng việt
            else if (xuiSegmentSach.SelectedIndex == 1)
            {
                List<Book> listVietnameseBooks = BLL_QLBS.Instance.GetVietnameseBooks();
                if (listVietnameseBooks == null)
                {
                    dgvQLBSNV.DataSource = null;
                }
                else
                {
                    foreach (Book book in listVietnameseBooks)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, book));
                    }
                    dgvQLBSNV.DataSource = data;
                }
            }
            // Sách tiếng anh
            else
            {
                List<Book> listEnglishBooks = BLL_QLBS.Instance.GetEnglishBooks();
                if (listEnglishBooks == null)
                {
                    dgvQLBSNV.DataSource = null;
                }
                else
                {
                    foreach (Book book in listEnglishBooks)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, book));
                    }
                    dgvQLBSNV.DataSource = data;
                }
            }
        }

        private void DgvQLBSNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new FormTTS(GetID_Book()).ShowDialog();
        }

        private string GetID_Book()
        {
            return dgvQLBSNV.CurrentRow.Cells["ID_Book"].Value.ToString();
        }

        private void GetAllInfoBooks()
        {
            totalBook.Text = BLL_QLBS.Instance.GetNumberTotalBook().ToString();
            vietnameseBook.Text = BLL_QLBS.Instance.GetNumberTotalVietnameseBook().ToString();
            englishBook.Text = BLL_QLBS.Instance.GetNumberTotalEnglishBook().ToString();
        }

        private void CreateCol(DataTable data)
        {
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Book", typeof(string)),
                new DataColumn("NameBook", typeof(string)),
                new DataColumn("PublishDate", typeof(string)),
                new DataColumn("NameAuthor", typeof(string)),
                new DataColumn("NameLanguage", typeof(string)),
                new DataColumn("NameGenre", typeof(string)),
                new DataColumn("Price", typeof(string)),
                new DataColumn("Quantity", typeof(int)),
            });
        }

        private DataRow CreateRow(DataRow dataRow, Book book)
        {
            dataRow["ID_Book"] = book.ID_Book;
            dataRow["NameBook"] = book.NameBook;
            dataRow["PublishDate"] = book.PublishDate.ToString("dd/MM/yyyy");
            dataRow["NameAuthor"] = book.NameAuthor;
            dataRow["NameLanguage"] = BLL_QLBS.Instance.GetNameLanguageByID(book.ID_Language);
            dataRow["NameGenre"] = BLL_QLBS.Instance.GetNameGenreByID(book.ID_Genre);
            dataRow["Price"] = book.Price.ToString("##,#") + "VNĐ";
            dataRow["Quantity"] = book.Quantity;
            return dataRow;
        }
    }
}