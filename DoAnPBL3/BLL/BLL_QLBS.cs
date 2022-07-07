using DoAnPBL3.DAL;
using DoAnPBL3.Models;
using DoAnPBL3.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    // Quản lý bán sách
    class BLL_QLBS
    {
        private static BLL_QLBS _Instance;
        public static BLL_QLBS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLBS();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private BLL_QLBS()
        {

        }

        public List<Book> GetBooks()
        {
            return DAL_QLBS.Instance.GetListBooks();
        }

        public List<Book> GetBooksByIDLanguage(int ID_Language)
        {
            return DAL_QLBS.Instance.GetListBooksByIDLanguage(ID_Language);
        }

        public List<Book> GetBooksByIDPublisher(int ID_Publisher)
        {
            return DAL_QLBS.Instance.GetListBooksByIDPublisher(ID_Publisher);
        }

        public List<Book> GetBooksByIDGenre(int ID_Genre)
        {
            return DAL_QLBS.Instance.GetListBooksByIDGenre(ID_Genre);
        }

        public List<Book> GetVietnameseBooks()
        {
            return DAL_QLBS.Instance.GetListVietnameseBooks();
        }

        public List<Book> GetEnglishBooks()
        {
            return DAL_QLBS.Instance.GetListEnglishBooks();
        }

        public List<Book> GetBooksByNameBook(string nameBook)
        {
            return DAL_QLBS.Instance.GetBooksByNameBook(nameBook);
        }

        public List<Book> GetBooksByNameAuthor(string nameAuthor)
        {
            return DAL_QLBS.Instance.GetBooksByNameAuthor(nameAuthor);
        }

        public void Swap(List<Book> books, int i, int j)
        {
            Book temp = books[i];
            books[i] = books[j];
            books[j] = temp;
        }

        public List<Book> SortNameASC(List<Book> books)
        {
            int n = books.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (string.Compare(books[j - 1].NameBook, books[j].NameBook) < 0)
                    {
                        Swap(books, j - 1, j);
                    }
                }
            }
            return books;
        }

        public List<Book> SortNameDESC(List<Book> books)
        {
            int n = books.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (string.Compare(books[j - 1].NameBook, books[j].NameBook) > 0)
                    {
                        Swap(books, j - 1, j);
                    }
                }
            }
            return books;
        }

        public List<Book> SortPriceASC(List<Book> books)
        {
            int n = books.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (books[j - 1].Price > books[j].Price)
                    {
                        Swap(books, j - 1, j);
                    }
                }
            }
            return books;
        }

        public List<Book> SortPriceDESC(List<Book> books)
        {
            int n = books.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (books[j - 1].Price < books[j].Price)
                    {
                        Swap(books, j - 1, j);
                    }
                }
            }
            return books;
        }

        public List<Book> SortQuantityASC(List<Book> books)
        {
            int n = books.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (books[j - 1].Quantity > books[j].Quantity)
                    {
                        Swap(books, j - 1, j);
                    }
                }
            }
            return books;
        }

        public List<Book> SortQuantityDESC(List<Book> books)
        {
            int n = books.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (books[j - 1].Quantity < books[j].Quantity)
                    {
                        Swap(books, j - 1, j);
                    }
                }
            }
            return books;
        }

        public Book GetBookByID(string ID_Book)
        {
            return DAL_QLBS.Instance.GetBookByID(ID_Book);
        }

        public int GetNumberTotalBook()
        {
            return DAL_QLBS.Instance.GetNumberTotalBook();
        }

        public int GetNumberTotalVietnameseBook()
        {
            return DAL_QLBS.Instance.GetNumberTotalVietnameseBook();
        }

        public int GetNumberTotalEnglishBook()
        {
            return DAL_QLBS.Instance.GetNumberTotalEnglishBook();
        }

        public string GetNameLanguageByID(int ID_Language)
        {
            return DAL_QLBS.Instance.GetNameLanguageByID(ID_Language);
        }

        public string GetNamePublisherByID(int ID_Publisher)
        {
            return DAL_QLBS.Instance.GetNamePublisherByID(ID_Publisher);
        }

        public string GetNameGenreByID(int ID_Genre)
        {
            return DAL_QLBS.Instance.GetNameGenreByID(ID_Genre);
        }

        public DateTime GetPublishDate(string publishDate)
        {
            return new DateTime(
                Convert.ToInt32(publishDate.Substring(6, 4)),
                Convert.ToInt32(publishDate.Substring(3, 2)),
                Convert.ToInt32(publishDate.Substring(0, 2))
            );
        }

        public List<Language> GetAllLanguages()
        {
            return DAL_QLBS.Instance.GetAllLanguages();
        }

        public List<Publisher> GetAllPublishers()
        {
            return DAL_QLBS.Instance.GetAllPublishers();
        }

        public List<Genre> GetAllGenres()
        {
            return DAL_QLBS.Instance.GetAllGenres();
        }

        public bool ValidateIDBook(string ID_Book)
        {
            if (DAL_QLBS.Instance.IsExistIDBook(ID_Book))
                return true;
            else
                return false;
        }

        public bool ValidateName(string name)
        {
            if (name == "")
                return false;
            else
                return true;
        }

        public string ValidatePublishDate(string publishDate)
        {
            if (publishDate == "")
                return "Ngày xuất bản không được để trống";
            else
            {
                // Validate publish date contains alphabet
                if (Validators.IsDateContainsAlphabet(publishDate))
                    return "Ngày xuất bản không hợp lệ";
                else
                {
                    // Validate format publish date
                    if (!Validators.IsValidFormatDate(publishDate, Validators.DATE_TIME_REGEX))
                        return "Ngày xuất bản phải theo định dạng dd/MM/yyyy";
                    else
                    {
                        // Check publish date
                        string msgValidate = Validators.CheckDate(publishDate, Validators.DATE_TIME_REGEX);
                        if (msgValidate != "")
                            return msgValidate;
                        else
                        {
                            // Validate current date
                            if (!Validators.IsValidDate(publishDate, Validators.DATE_TIME_REGEX))
                                return "Ngày xuất bản không được lớn hơn ngày hiện tại";
                            else
                                return "";
                        }
                    }
                }
            }
        }

        public bool ValidateNameAuthor(string nameAuthor)
        {
            if (nameAuthor == "")
                return false;
            else
                return true;
        }

        public bool ValidateLanguage(object language)
        {
            if (language == null)
                return false;
            else
                return true;
        }

        public bool ValidatePublisher(object publisher)
        {
            if (publisher == null)
                return false;
            else
                return true;
        }

        public bool ValidateGenre(object genre)
        {
            if (genre == null)
                return false;
            else
                return true;
        }

        public bool ValidatePrice(string price)
        {
            if (price == "")
                return false;
            else
                return true;
        }

        public bool ValidateQuantity(string quantity)
        {
            if (quantity == "0")
                return false;
            else
                return true;
        }

        public bool ValidateUnit(object unit)
        {
            if (unit == null)
                return false;
            else
                return true;
        }

        public bool AddNewBook(Book book)
        {
            if (DAL_QLBS.Instance.AddNewBook(book))
                return true;
            else
                return false;
        }

        public bool UpdateBook(Book book)
        {
            if (DAL_QLBS.Instance.UpdateBook(book))
                return true;
            else
                return false;
        }

        public bool UpdateQuantityBook(string ID_Book, int quantitySold)
        {
            if (DAL_QLBS.Instance.UpdateQuantityBook(ID_Book, quantitySold))
                return true;
            else
                return false;
        }

        public bool DeleteBook(string ID_Book)
        {
            return DAL_QLBS.Instance.DeleteBook(ID_Book);
        }
    }
}
