using DoAnPBL3.BLL;
using DoAnPBL3.Models;
using DoAnPBL3.Validator;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormSuaSach : Form
    {
        private readonly string ID_Book;
        private string oldPath;
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }

        public FormSuaSach(string ID_Book)
        {
            InitializeComponent();
            this.ID_Book = ID_Book;
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void FormSuaSach_Load(object sender, EventArgs e)
        {
            ShowAllLanguages();
            ShowAllPublishers();
            ShowAllGenres();
            ShowInfo(BLL_QLBS.Instance.GetBookByID(ID_Book));
        }

        private void ShowInfo(Book book)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            tbNameBook.Text = book.NameBook;
            tbPublishDate.Text = book.PublishDate.ToString("dd/MM/yyyy");
            tbAuthor.Text = book.NameAuthor;
            cbbLanguage.SelectedItem = BLL_QLBS.Instance.GetNameLanguageByID(book.ID_Language);
            cbbPublisher.SelectedItem = BLL_QLBS.Instance.GetNamePublisherByID(book.ID_Publisher);
            cbbGenre.SelectedItem = BLL_QLBS.Instance.GetNameGenreByID(book.ID_Genre);
            tbPrice.Text = book.Price.ToString();
            tbQuantity.Text = book.Quantity.ToString();
            if (book.Image == null)
                gpbBookImg.Image = null;
            else
            {
                gpbBookImg.ImageLocation = book.Image;
                oldPath = gpbBookImg.ImageLocation;
                gpbBookImg.Image = Image.FromFile(Path.Combine(projectDirectory, book.Image));
            }
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            bool isValidNameBook, isValidPublishDate, isValidLanguage, isValidAuthor, isValidPublisher,
                isValidGenre, isValidPrice, isValidQuantity;
            string nameBook, publishDate, nameAuthor, price, quantity;
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

            if (isValidNameBook && isValidPublishDate && isValidLanguage && isValidAuthor
                && isValidPublisher && isValidGenre && isValidPrice && isValidQuantity)
            {
                DialogResult result = RJMessageBox.Show("Xác nhận lưu mới dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BLL_QLBS.Instance.UpdateBook(GetAllInfo(ID_Book)))
                    {
                        Alert("Sửa thông tin sách thành công", Form_Alert.EnmType.Success);
                        RefreshData(sender, e);
                        Dispose();
                    }
                    else
                        Alert("Sửa thông tin thất bại vì dữ liệu chưa được cập nhật", Form_Alert.EnmType.Error);
                }
                else
                    return;
            }
            else
                Alert("Dữ liệu không hợp lệ", Form_Alert.EnmType.Error);
        }

        private Book GetAllInfo(string ID_Book)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string path;
            if (gpbBookImg.Image == null)
                path = null;
            else
            {
                if (oldPath == gpbBookImg.ImageLocation)
                    path = oldPath;
                else
                    path = gpbBookImg.ImageLocation.Remove(0, projectDirectory.Length + 3);
            }
            return new Book
            {
                ID_Book = ID_Book,
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

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            bool isNewNameBook, isNewPublishDate, isNewNameAuthor, isNewLanguage, isNewPublisher,
                    isNewGenre, isNewQuantity, isNewPrice, isNewImage = false;
            Book book = BLL_QLBS.Instance.GetBookByID(ID_Book);

            isNewNameBook = tbNameBook.Text != book.NameBook;
            isNewPublishDate = tbPublishDate.Text != book.PublishDate.ToString("dd/MM/yyyy");
            isNewNameAuthor = tbAuthor.Text != book.NameAuthor;
            isNewLanguage = cbbLanguage.SelectedIndex + 1 != book.ID_Language;
            isNewPublisher = cbbPublisher.SelectedIndex + 1 != book.ID_Publisher;
            isNewGenre = cbbGenre.SelectedIndex + 1 != book.ID_Genre;
            isNewQuantity = Convert.ToInt32(tbQuantity.Text) != book.Quantity;
            isNewPrice = Convert.ToInt32(tbPrice.Text) != book.Price;
            if (book.Image == null)
            {
                if (book.Image != null)
                    isNewImage = true;
            }
            else
            {
                if (gpbBookImg.ImageLocation != book.Image)
                    isNewImage = true;
            }
            if (isNewNameBook || isNewPublishDate || isNewNameAuthor || isNewLanguage || isNewPublisher
                || isNewGenre || isNewQuantity || isNewPrice || isNewImage)
            {
                DialogResult result = RJMessageBox.Show("Thông tin cũ đã thay đổi nhưng chưa được lưu. Bạn vẫn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                    Close();
                else
                    return;
            }
            else
                Close();
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
    }
}