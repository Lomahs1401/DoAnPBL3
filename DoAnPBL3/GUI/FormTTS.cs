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
    public partial class FormTTS : Form
    {
        private readonly string ID_Book;
        private readonly string nameBook;
        private readonly int unitPrice;
        private readonly int quantity;
        public FormTTS(string theme, string ID_Book, string nameBook = "", int unitPrice = 0, int quantity = 0)
        {
            InitializeComponent();
            this.ID_Book = ID_Book;
            this.nameBook = nameBook;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            switch (theme)
            {
                case "Admin":
                    panelContainer.BackColor = Color.FromArgb(24, 37, 65);
                    lbIDBook.ForeColor = Color.WhiteSmoke;
                    lblNameBook.ForeColor = Color.WhiteSmoke;
                    lbPublishDate.ForeColor = Color.WhiteSmoke;
                    lbLanguage.ForeColor = Color.WhiteSmoke;
                    lbAuthor.ForeColor = Color.WhiteSmoke;
                    lbPublisher.ForeColor = Color.WhiteSmoke;
                    lbGenre.ForeColor = Color.WhiteSmoke;
                    lbPrice.ForeColor = Color.WhiteSmoke;
                    lblQuantity.ForeColor = Color.WhiteSmoke;
                    tbIDBook.DisabledState.FillColor = Color.FromArgb(15, 27, 57);
                    tbIDBook.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbNameBook.DisabledState.FillColor = Color.FromArgb(15, 27, 57);
                    tbNameBook.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbPublishDate.DisabledState.FillColor = Color.FromArgb(15, 27, 57);
                    tbPublishDate.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbLanguage.DisabledState.FillColor = Color.FromArgb(15, 27, 57);
                    tbLanguage.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbAuthor.DisabledState.FillColor = Color.FromArgb(15, 27, 57);
                    tbAuthor.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbPublisher.DisabledState.FillColor = Color.FromArgb(15, 27, 57);
                    tbPublisher.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbGenre.DisabledState.FillColor = Color.FromArgb(15, 27, 57);
                    tbGenre.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbQuantity.DisabledState.FillColor = Color.FromArgb(15, 27, 57);
                    tbQuantity.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbPrice.DisabledState.FillColor = Color.FromArgb(15, 27, 57);
                    tbPrice.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    break;
                case "Dark":
                    panelContainer.BackColor = Color.FromArgb(44, 53, 70);
                    lbIDBook.ForeColor = Color.WhiteSmoke;
                    lblNameBook.ForeColor = Color.WhiteSmoke;
                    lbPublishDate.ForeColor = Color.WhiteSmoke;
                    lbLanguage.ForeColor = Color.WhiteSmoke;
                    lbAuthor.ForeColor = Color.WhiteSmoke;
                    lbPublisher.ForeColor = Color.WhiteSmoke;
                    lbGenre.ForeColor = Color.WhiteSmoke;
                    lbPrice.ForeColor = Color.WhiteSmoke;
                    lblQuantity.ForeColor = Color.WhiteSmoke;
                    tbIDBook.DisabledState.FillColor = Color.FromArgb(22, 33, 49);
                    tbIDBook.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbNameBook.DisabledState.FillColor = Color.FromArgb(22, 33, 49);
                    tbNameBook.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbPublishDate.DisabledState.FillColor = Color.FromArgb(22, 33, 49);
                    tbPublishDate.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbLanguage.DisabledState.FillColor = Color.FromArgb(22, 33, 49);
                    tbLanguage.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbAuthor.DisabledState.FillColor = Color.FromArgb(22, 33, 49);
                    tbAuthor.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbPublisher.DisabledState.FillColor = Color.FromArgb(22, 33, 49);
                    tbPublisher.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbGenre.DisabledState.FillColor = Color.FromArgb(22, 33, 49);
                    tbGenre.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbQuantity.DisabledState.FillColor = Color.FromArgb(22, 33, 49);
                    tbQuantity.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    tbPrice.DisabledState.FillColor = Color.FromArgb(22, 33, 49);
                    tbPrice.DisabledState.ForeColor = Color.FromArgb(193, 200, 207);
                    break;
                case "Light":
                    panelContainer.BackColor = Color.Gainsboro;
                    lbIDBook.ForeColor = Color.Black;
                    lblNameBook.ForeColor = Color.Black;
                    lbPublishDate.ForeColor = Color.Black;
                    lbLanguage.ForeColor = Color.Black;
                    lbAuthor.ForeColor = Color.Black;
                    lbPublisher.ForeColor = Color.Black;
                    lbGenre.ForeColor = Color.Black;
                    lbPrice.ForeColor = Color.Black;
                    lblQuantity.ForeColor = Color.Black;
                    tbIDBook.DisabledState.FillColor = Color.Silver;
                    tbIDBook.DisabledState.ForeColor = Color.Black;
                    tbIDBook.DisabledState.BorderColor = Color.Black;
                    tbNameBook.DisabledState.FillColor = Color.Silver;
                    tbNameBook.DisabledState.ForeColor = Color.Black;
                    tbNameBook.DisabledState.BorderColor = Color.Black;
                    tbPublishDate.DisabledState.FillColor = Color.Silver;
                    tbPublishDate.DisabledState.ForeColor = Color.Black;
                    tbPublishDate.DisabledState.BorderColor = Color.Black;
                    tbLanguage.DisabledState.FillColor = Color.Silver;
                    tbLanguage.DisabledState.ForeColor = Color.Black;
                    tbLanguage.DisabledState.BorderColor = Color.Black;
                    tbAuthor.DisabledState.FillColor = Color.Silver;
                    tbAuthor.DisabledState.ForeColor = Color.Black;
                    tbAuthor.DisabledState.BorderColor = Color.Black;
                    tbPublisher.DisabledState.FillColor = Color.Silver;
                    tbPublisher.DisabledState.ForeColor = Color.Black;
                    tbPublisher.DisabledState.BorderColor = Color.Black;
                    tbGenre.DisabledState.FillColor = Color.Silver;
                    tbGenre.DisabledState.ForeColor = Color.Black;
                    tbGenre.DisabledState.BorderColor = Color.Black;
                    tbQuantity.DisabledState.FillColor = Color.Silver;
                    tbQuantity.DisabledState.ForeColor = Color.Black;
                    tbQuantity.DisabledState.BorderColor = Color.Black;
                    tbPrice.DisabledState.FillColor = Color.Silver;
                    tbPrice.DisabledState.ForeColor = Color.Black;
                    tbPrice.DisabledState.BorderColor = Color.Black;
                    break;
            }
        }

        private void FormTTS_Load(object sender, EventArgs e)
        {
            ShowInfo(BLL_QLBS.Instance.GetBookByID(ID_Book));
        }

        private void ShowInfo(Book book)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            tbIDBook.Text = book.ID_Book;
            if (nameBook != book.NameBook)
                tbNameBook.Text = book.NameBook;
            else
                tbNameBook.Text = nameBook;
            tbPublishDate.Text = book.PublishDate.ToString("dd/MM/yyyy");
            tbAuthor.Text = book.NameAuthor;
            tbLanguage.Text = BLL_QLBS.Instance.GetNameLanguageByID(book.ID_Language);
            tbPublisher.Text = BLL_QLBS.Instance.GetNamePublisherByID(book.ID_Publisher);
            tbGenre.Text = BLL_QLBS.Instance.GetNameGenreByID(book.ID_Genre);
            if (quantity != 0)
                tbQuantity.Text = quantity.ToString();
            else
                tbQuantity.Text = book.Quantity.ToString();
            if (unitPrice != 0)
                tbPrice.Text = unitPrice.ToString("##,#") + "VNĐ";
            else
                tbPrice.Text = book.Price.ToString("##,#") + "VNĐ";
            if (book.Image == null)
                gpbBookImg.Image = null;
            else
                gpbBookImg.Image = Image.FromFile(Path.Combine(projectDirectory, book.Image));
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
