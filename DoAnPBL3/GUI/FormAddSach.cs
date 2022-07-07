using DoAnPBL3.BLL;
using DoAnPBL3.Models;
using DoAnPBL3.Validator;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormAddSach : Form
    {
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }

        //Constructor
        public FormAddSach()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }
        private void FormAddSach_Load(object sender, EventArgs e)
        {
            ShowAllLanguages();
            ShowAllPublishers();
            ShowAllGenres();
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            bool isValidIDBook, isValidNameBook, isValidPublishDate, isValidLanguage, isValidAuthor, isValidPublisher,
                isValidGenre, isValidPrice, isValidQuantity;
            string ID_Book, nameBook, publishDate, nameAuthor, price, quantity;
            // Validate id book
            ID_Book = tbIDBook.Text;
            isValidIDBook = !BLL_QLBS.Instance.ValidateIDBook(ID_Book);
            if (ID_Book == "")
            {
                msgValidateIDBook.ForeColor = Color.Red;
                msgValidateIDBook.Text = "Mã sách không được để trống";
                isValidIDBook = false;
            }
            else
            {
                if (!isValidIDBook)
                {
                    msgValidateIDBook.ForeColor = Color.Red;
                    msgValidateIDBook.Text = "Mã sách đã tồn tại";
                }
                else
                {
                    msgValidateIDBook.ForeColor = Color.White;
                    msgValidateIDBook.Text = "";
                }
            }
            // Validate name of book
            nameBook = tbNameBook.Text;
            isValidNameBook = BLL_QLBS.Instance.ValidateName(nameBook);
            if (!isValidNameBook)
            {
                msgValidateNameBook.ForeColor = Color.Red;
                msgValidateNameBook.Text = "Tên sách không được để trống";
            }
            else
            {
                msgValidateNameBook.ForeColor = Color.White;
                msgValidateNameBook.Text = "";
            }
            // Validate publish date
            publishDate = tbPublishDate.Text;
            string msgPublishDate = BLL_QLBS.Instance.ValidatePublishDate(publishDate);
            if (msgPublishDate != "")
            {
                isValidPublishDate = false;
                switch (msgPublishDate)
                {
                    case "Ngày xuất bản không được để trống":
                        msgValidatePublishDate.Text = msgPublishDate;
                        msgValidatePublishDate.ForeColor = Color.Red;
                        break;
                    case "Ngày xuất bản không hợp lệ":
                        msgValidatePublishDate.Text = msgPublishDate;
                        msgValidatePublishDate.ForeColor = Color.Red;
                        break;
                    case "Ngày xuất bản phải theo định dạng dd/MM/yyyy":
                        msgValidatePublishDate.Text = msgPublishDate;
                        msgValidatePublishDate.ForeColor = Color.Red;
                        break;
                    case "Ngày xuất bản không được lớn hơn ngày hiện tại":
                        msgValidatePublishDate.Text = msgPublishDate;
                        msgValidatePublishDate.ForeColor = Color.Red;
                        break;
                    default:
                        msgValidatePublishDate.Text = msgPublishDate;
                        msgValidatePublishDate.ForeColor = Color.Red;
                        break;
                }
            }
            else
            {
                isValidPublishDate = true;
                msgValidatePublishDate.Text = "";
                msgValidatePublishDate.ForeColor = Color.White;
            }
            nameAuthor = tbAuthor.Text;
            isValidAuthor = BLL_QLBS.Instance.ValidateNameAuthor(nameAuthor);
            if (!isValidAuthor)
            {
                msgValidateAuthor.ForeColor = Color.Red;
                msgValidateAuthor.Text = "Tên tác giả không được để trống";
            }
            else
            {
                msgValidateAuthor.ForeColor = Color.White;
                msgValidateAuthor.Text = "";
            }
            // Validate language
            isValidLanguage = BLL_QLBS.Instance.ValidateLanguage(cbbLanguage.SelectedItem);
            if (!isValidLanguage)
            {
                msgValidateLanguage.ForeColor = Color.Red;
                msgValidateLanguage.Text = "Ngôn ngữ không được để trống";
            }
            else
            {
                msgValidateLanguage.ForeColor = Color.White;
                msgValidateLanguage.Text = "";
            }
            // Validate publisher
            isValidPublisher = BLL_QLBS.Instance.ValidatePublisher(cbbPublisher.SelectedItem);
            if (!isValidPublisher)
            {
                msgValidatePublisher.ForeColor = Color.Red;
                msgValidatePublisher.Text = "Nhà xuất bản không được để trống";
            }
            else
            {
                msgValidatePublisher.ForeColor = Color.White;
                msgValidatePublisher.Text = "";
            }
            // Validate genre
            isValidGenre = BLL_QLBS.Instance.ValidateGenre(cbbGenre.SelectedItem);
            if (!isValidGenre)
            {
                msgValidateGenre.ForeColor = Color.Red;
                msgValidateGenre.Text = "Thể loại không được để trống";
            }
            else
            {
                msgValidateGenre.ForeColor = Color.White;
                msgValidateGenre.Text = "";
            }
            // Validate price
            price = tbPrice.Text;
            isValidPrice = BLL_QLBS.Instance.ValidatePrice(price);
            if (!isValidPrice)
            {
                msgValidatePrice.ForeColor = Color.Red;
                msgValidatePrice.Text = "Giá không được để trống";
            }
            else
            {
                msgValidatePrice.ForeColor = Color.White;
                msgValidatePrice.Text = "";
            }
            // Validate quantity
            quantity = tbQuantity.Text;
            isValidQuantity = BLL_QLBS.Instance.ValidateQuantity(quantity);
            if (quantity == "")
            {
                msgValidateQuantity.ForeColor = Color.Red;
                msgValidateQuantity.Text = "Số lượng không được để trống";
                isValidQuantity = false;
            }
            else
            {
                if (!isValidQuantity)
                {
                    msgValidateQuantity.ForeColor = Color.Red;
                    msgValidateQuantity.Text = "Số lượng sách không hợp lệ";
                }
                else
                {
                    msgValidateQuantity.ForeColor = Color.White;
                    msgValidateQuantity.Text = "";
                }
            }

            if (isValidIDBook && isValidNameBook && isValidPublishDate && isValidLanguage
                && isValidAuthor && isValidPublisher && isValidGenre && isValidPrice && isValidQuantity)
            {
                if (BLL_QLBS.Instance.AddNewBook(GetAllInfo()))
                {
                    Alert("Thêm mặt hàng sách mới thành công", Form_Alert.EnmType.Success);
                    RefreshData(sender, e);
                    Dispose();
                }
                else
                    Alert("Thêm thất bại. Vui lòng thử lại", Form_Alert.EnmType.Error);
            }
            else
                Alert("Dữ liệu không hợp lệ", Form_Alert.EnmType.Error);
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            string ID_Book, nameBook, publishDate, author, price, quantity;
            ID_Book = tbIDBook.Text;
            nameBook = tbNameBook.Text;
            publishDate = tbPublishDate.Text;
            author = tbAuthor.Text;
            price = tbPrice.Text;
            quantity = tbQuantity.Text;
            if (ID_Book != "" || nameBook != "" || publishDate != "" || cbbLanguage.SelectedItem != null || author != ""
                || cbbPublisher.SelectedItem != null || cbbGenre.SelectedItem != null || price != "" || quantity != "0"
                || gpbBookImg.Image != null)
            {
                DialogResult result = RJMessageBox.Show("Dữ liệu chưa được lưu. Bạn vẫn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    Close();
                else
                    return;
            }
            else
                Close();
        }

        private Book GetAllInfo()
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string path;
            if (gpbBookImg.Image == null)
                path = null;
            else
                path = gpbBookImg.ImageLocation.Remove(0, projectDirectory.Length + 3);
            return new Book
            {
                ID_Book = tbIDBook.Text,
                NameBook = tbNameBook.Text,
                PublishDate = BLL_QLBS.Instance.GetPublishDate(tbPublishDate.Text),
                NameAuthor = tbAuthor.Text,
                ID_Language = cbbLanguage.SelectedIndex + 1,
                ID_Publisher = cbbPublisher.SelectedIndex + 1,
                ID_Genre = cbbGenre.SelectedIndex + 1,
                Price = Convert.ToInt32(tbPrice.Text),
                Quantity = Convert.ToInt32(tbQuantity.Text),
                Image = path,
                SaleStatus = true
            };
        }

        private void BtnBookImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh",
                Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                gpbBookImg.ImageLocation = openFileDialog.FileName;
            }
        }

        private void BtnDeleteImg_Click(object sender, EventArgs e)
        {
            if (gpbBookImg.ImageLocation != null)
            {
                gpbBookImg.ImageLocation = "";
                gpbBookImg.Image = null;
            }
        }

        private void ShowAllLanguages()
        {
            List<Language> languages = BLL_QLBS.Instance.GetAllLanguages();
            if (languages != null)
            {
                foreach (Language language in languages)
                {
                    cbbLanguage.Items.Add(language.NameLanguage);
                }
            }
            else
                cbbLanguage.Items.Add("");
        }

        private void ShowAllPublishers()
        {
            List<Publisher> publishers = BLL_QLBS.Instance.GetAllPublishers();
            if (publishers != null)
            {
                foreach (Publisher publisher in publishers)
                {
                    cbbPublisher.Items.Add(publisher.NamePublisher);
                }
            }
            else
                cbbPublisher.Items.Add("");
        }

        private void ShowAllGenres()
        {
            List<Genre> genres = BLL_QLBS.Instance.GetAllGenres();
            if (genres != null)
            {
                foreach (Genre genre in genres)
                {
                    cbbGenre.Items.Add(genre.NameGenre);
                }
            }
            else
                cbbGenre.Items.Add("");
        }

        private void TbNameNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbCMNDNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }


        private void TbAddressNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void TbEmailNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}
