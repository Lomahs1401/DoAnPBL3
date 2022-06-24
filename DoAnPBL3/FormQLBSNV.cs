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
        FormCart b;

        public FormQLBSNV(string accountUsername)
        {
            
            InitializeComponent();
            this.accountUsername = accountUsername;
            b = new FormCart(accountUsername);

        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void FormQLBSNV_Load(object sender, EventArgs e)
        {
            dgvQLBSNV.RowHeadersVisible = true;
            dgvQLBSNV.BorderStyle = BorderStyle.FixedSingle;
            dgvQLBSNV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLBSNV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            using (BookStoreContext context = new BookStoreContext())
            {
                var listBooks = context.Books
                    .Join(
                        context.Languages,
                        book => book.ID_Language,
                        language => language.ID_Language,
                        (book, language) => new
                        {
                            book.ID_Book,
                            book.NameBook,
                            language.NameLanguage,
                            book.Quantity,
                            book.Price
                        })
                    .ToList();
                var listVietnameseBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Việt");
                var listEnglishBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Anh");
                dgvQLBSNV.DataSource = listBooks;
                dgvQLBSNV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                lblTSSDB.Text = listBooks.Count().ToString();
                lblSSTV.Text = listVietnameseBooks.Count().ToString();
                lblSSTA.Text = listEnglishBooks.Count().ToString();
            }
        }

        private void RjbtnBuy_Click(object sender, EventArgs e)
        {
            b.Show();
            FormQLBSNV_Load(sender, e);
        }

        private void RjbtnOrder_Click(object sender, EventArgs e)
        {
            b.Show();
        }

        private void RjbtnAddCart_Click(object sender, EventArgs e)
        {
            string ID_BookChosen;
            if (dgvQLBSNV.CurrentRow == null)
            {
                RJMessageBox.Show("Hệ thống chưa có sách nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                 ID_BookChosen = dgvQLBSNV.CurrentRow.Cells["ID_Book"].Value.ToString();
                b.Them_Sach(ID_BookChosen);
            }
            
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
            using (BookStoreContext context = new BookStoreContext())
            {
                if (rjtbTKS.Texts.Trim() == "")
                    RJMessageBox.Show("Vui lòng điền thông tin sách cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    var listBooks = context.Books
                            .Join(
                                context.Languages,
                                book => book.ID_Language,
                                lang => lang.ID_Language,
                                (book, lang) => new
                                {
                                    book.ID_Book,
                                    book.NameBook,
                                    lang.NameLanguage,
                                    book.Quantity,
                                    book.Price
                                })
                            .Select(book => book);
                    if (rjtbTKS.Texts.Length == 5)
                    {
                        int numFindBook = listBooks
                            .Where(book => book.ID_Book == rjtbTKS.Texts)
                            .Count();
                        if (numFindBook == 0)
                            RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            dgvQLBSNV.DataSource = listBooks
                                .Where(book => book.ID_Book == rjtbTKS.Texts)
                                .ToList();
                    }
                    else
                    {
                        int numFindBook = listBooks
                            .Where(book => book.NameBook.Contains(rjtbTKS.Texts))
                            .Count();
                        if (numFindBook == 0)
                            RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            dgvQLBSNV.DataSource = listBooks
                                .Where(book => book.NameBook.Contains(rjtbTKS.Texts))
                                .ToList();
                    }
                }
            }
        }

        private void XuiSegmentSach_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var listBooks = context.Books
                        .Join(
                            context.Languages,
                            book => book.ID_Language,
                            language => language.ID_Language,
                            (book, language) => new
                            {
                                book.ID_Book,
                                book.NameBook,
                                language.NameLanguage,
                                book.Quantity,
                                book.Price
                            })
                        .ToList();
                var listVietnameseBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Việt").ToList();
                var listEnglishBooks = listBooks.Where(book => book.NameLanguage == "Tiếng Anh").ToList();
                lblTSSDB.Text = listBooks.Count().ToString();
                lblSSTV.Text = listVietnameseBooks.Count().ToString();
                lblSSTA.Text = listEnglishBooks.Count().ToString();
                // Tất cả
                if (xuiSegmentSach.SelectedIndex == 0)
                    dgvQLBSNV.DataSource = listBooks;
                // Sách tiếng việt
                else if (xuiSegmentSach.SelectedIndex == 1)
                    dgvQLBSNV.DataSource = listVietnameseBooks;
                // Sách tiếng anh
                else
                    dgvQLBSNV.DataSource = listEnglishBooks;
            }
        }

        private void DgvQLBSNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ID_Book = dgvQLBSNV.CurrentRow.Cells["ID_Book"].Value.ToString();
            new FormTTS(ID_Book).ShowDialog();
        }
    }
}
