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
    public partial class FormQLBSNV : Form
    {
        FormCart formCart;
        private int ID_Language;
        private int ID_Publisher;
        private int ID_Genre;
        private readonly string theme = "Dark";

        public FormQLBSNV(string accountUsername)
        {
            InitializeComponent();
            formCart = new FormCart(accountUsername);
            formCart.RefreshData += new FormCart.LoadData(FormQLBSNV_Load);
            NotificationCircle.Hide();
            lblNotificationCounter.Hide();
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void FormQLBSNV_Load(object sender, EventArgs e)
        {
            timer1.Start();
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
                totalBooks.Text = "0";
                totalVietnameseBooks.Text = "0";
                totalEnglishBooks.Text = "0";
            }
        }

        private void RjbtnOrder_Click(object sender, EventArgs e)
        {
            formCart.Show();
        }

        private void RjbtnAddCart_Click(object sender, EventArgs e)
        {
            string ID_BookChosen;
            if (dgvQLBSNV.CurrentRow == null)
                RJMessageBox.Show("Hệ thống chưa có sách nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                ID_BookChosen = dgvQLBSNV.CurrentRow.Cells["ID_Book"].Value.ToString();
                formCart.Them_Sach(ID_BookChosen);
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
            DataTable data = new DataTable();
            CreateCol(data);
            if (rjtbTKS.Texts.Trim() == "")
                RJMessageBox.Show("Vui lòng điền thông tin sách cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (rjtbTKS.Texts.Contains("B0"))
            {
                Book book = BLL_QLBS.Instance.GetBookByID(rjtbTKS.Texts);
                if (book == null)
                    RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, book));
                    dgvQLBSNV.DataSource = data;
                }
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
                        foreach (Book book in listBooksByAuthor)
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

        private void DgvQLBSNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new FormTTS(theme, GetID_Book()).ShowDialog();
        }

        private string GetID_Book()
        {
            return dgvQLBSNV.CurrentRow.Cells["ID_Book"].Value.ToString();
        }

        private void GetAllInfoBooks()
        {
            totalBooks.Text = BLL_QLBS.Instance.GetNumberTotalBook().ToString();
            totalVietnameseBooks.Text = BLL_QLBS.Instance.GetNumberTotalVietnameseBook().ToString();
            totalEnglishBooks.Text = BLL_QLBS.Instance.GetNumberTotalEnglishBook().ToString();
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
                new DataColumn("NamePublisher", typeof(string)),
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
            dataRow["NamePublisher"] = BLL_QLBS.Instance.GetNamePublisherByID(book.ID_Publisher);
            dataRow["NameGenre"] = BLL_QLBS.Instance.GetNameGenreByID(book.ID_Genre);
            dataRow["Price"] = book.Price.ToString("##,#") + "VNĐ";
            dataRow["Quantity"] = book.Quantity;
            return dataRow;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (formCart.GetVariety() != 0)
            {
                lblNotificationCounter.Text = formCart.GetVariety().ToString();
                NotificationCircle.Show();
                lblNotificationCounter.Show();
                lblNotificationCounter.BringToFront();
                if (formCart.GetVariety() > 99)
                    lblNotificationCounter.Location = new Point(NotificationCircle.Location.X + 2, NotificationCircle.Location.Y + 7);
                else if (formCart.GetVariety() > 9)
                    lblNotificationCounter.Location = new Point(NotificationCircle.Location.X + 5, NotificationCircle.Location.Y + 7);
                else
                    lblNotificationCounter.Location = new Point(NotificationCircle.Location.X + 8, NotificationCircle.Location.Y + 7);
            }
            else
            {
                lblNotificationCounter.Text = formCart.GetVariety().ToString();
                NotificationCircle.Hide();
                lblNotificationCounter.Hide();
            }
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            formCart.Show();
        }

        private void CbbCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCriteria.SelectedIndex == 0)
            {
                if (cbbCritiaDetail.Items.Count > 0)
                    cbbCritiaDetail.Items.Clear();
                List<Language> languages = BLL_QLBS.Instance.GetAllLanguages();
                if (languages != null)
                {
                    foreach (Language language in languages)
                    {
                        cbbCritiaDetail.Items.Add(language.NameLanguage);
                    }
                }
                else
                    cbbCritiaDetail.Items.Add("");
            }
            else if (cbbCriteria.SelectedIndex == 1)
            {
                if (cbbCritiaDetail.Items.Count > 0)
                    cbbCritiaDetail.Items.Clear();
                List<Publisher> publishers = BLL_QLBS.Instance.GetAllPublishers();
                if (publishers != null)
                {
                    foreach (Publisher publisher in publishers)
                    {
                        cbbCritiaDetail.Items.Add(publisher.NamePublisher);
                    }
                }
                else
                    cbbCritiaDetail.Items.Add("");
            }
            else
            {
                if (cbbCritiaDetail.Items.Count > 0)
                    cbbCritiaDetail.Items.Clear();
                List<Genre> genres = BLL_QLBS.Instance.GetAllGenres();
                if (genres != null)
                {
                    foreach (Genre genre in genres)
                    {
                        cbbCritiaDetail.Items.Add(genre.NameGenre);
                    }
                }
                else
                    cbbCritiaDetail.Items.Add("");
            }
        }

        private void CbbCritiaDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCriteria.SelectedItem.ToString() == "Ngôn ngữ")
                ID_Language = cbbCritiaDetail.SelectedIndex + 1;
            else if (cbbCriteria.SelectedItem.ToString() == "Nhà xuất bản")
                ID_Publisher = cbbCritiaDetail.SelectedIndex + 1;
            else
                ID_Genre = cbbCritiaDetail.SelectedIndex + 1;
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            CreateCol(data);
            if (cbbCritiaDetail.SelectedItem == null)
                RJMessageBox.Show("Vui lòng chọn tiêu chí để lọc danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cbbCriteria.SelectedItem.ToString() == "Ngôn ngữ")
            {
                List<Book> listBooks = BLL_QLBS.Instance.GetBooksByIDLanguage(ID_Language);
                if (listBooks == null)
                    dgvQLBSNV.DataSource = null;
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
            else if (cbbCriteria.SelectedItem.ToString() == "Nhà xuất bản")
            {
                List<Book> listBooks = BLL_QLBS.Instance.GetBooksByIDPublisher(ID_Publisher);
                if (listBooks == null)
                    dgvQLBSNV.DataSource = null;
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
            else
            {
                List<Book> listBooks = BLL_QLBS.Instance.GetBooksByIDGenre(ID_Genre);
                if (listBooks == null)
                    dgvQLBSNV.DataSource = null;
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
        }
    }
}
