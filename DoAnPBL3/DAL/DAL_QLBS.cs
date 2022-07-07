using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.DAL
{
    // Quản lý bán sách
    class DAL_QLBS
    {
        private static DAL_QLBS _Instance;
        public static DAL_QLBS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QLBS();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }

        private DAL_QLBS()
        {

        }

        public List<Book> GetListBooks()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();

                listBooks = db.Books
                    .Where(book => book.SaleStatus == true)
                    .Select(book => book)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> GetListBooksByIDLanguage(int ID_Language)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();

                listBooks = db.Books
                    .Where(book => book.ID_Language == ID_Language)
                    .Where(book => book.SaleStatus == true)
                    .Select(book => book)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> GetListBooksByIDPublisher(int ID_Publisher)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();

                listBooks = db.Books
                    .Where(book => book.ID_Publisher == ID_Publisher)
                    .Where(book => book.SaleStatus == true)
                    .Select(book => book)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> GetListBooksByIDGenre(int ID_Genre)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();

                listBooks = db.Books
                    .Where(book => book.ID_Genre == ID_Genre)
                    .Where(book => book.SaleStatus == true)
                    .Select(book => book)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> GetListVietnameseBooks()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listVietnameseBooks = new List<Book>();
                int ID_Language = db.Languages
                    .Where(language => language.NameLanguage == "Tiếng Việt")
                    .Select(language => new { language.ID_Language })
                    .FirstOrDefault()
                    .ID_Language;
                listVietnameseBooks = db.Books
                    .Where(book => book.ID_Language == ID_Language)
                    .Where(book => book.SaleStatus == true)
                    .Select(book => book)
                    .ToList();
                if (listVietnameseBooks.Count > 0)
                    return listVietnameseBooks;
                else
                    return null;
            }
        }

        public List<Book> GetListEnglishBooks()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listEnglishBooks = new List<Book>();
                int ID_Language = db.Languages
                    .Where(language => language.NameLanguage == "Tiếng Anh")
                    .Select(language => new { language.ID_Language })
                    .FirstOrDefault()
                    .ID_Language;
                listEnglishBooks = db.Books
                    .Where(book => book.ID_Language == ID_Language)
                    .Where(book => book.SaleStatus == true)
                    .Select(book => book)
                    .ToList();
                if (listEnglishBooks.Count > 0)
                    return listEnglishBooks;
                else
                    return null;
            }
        }

        public List<Book> GetBooksByNameBook(string nameBook)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();

                listBooks = db.Books
                    .Where(book => book.NameBook.Contains(nameBook))
                    .Where(book => book.SaleStatus == true)
                    .Select(book => book)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> GetBooksByNameAuthor(string nameAuthor)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();

                listBooks = db.Books
                    .Where(book => book.NameAuthor.Contains(nameAuthor))
                    .Where(book => book.SaleStatus == true)
                    .Select(book => book)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> SortByNameBookASC()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();
                listBooks = db.Books
                    .Select(book => book)
                    .OrderBy(book => book.NameBook)
                    .Where(book => book.SaleStatus == true)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> SortByNameBookDESC()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();
                listBooks = db.Books
                    .Select(book => book)
                    .OrderByDescending(book => book.NameBook)
                    .Where(book => book.SaleStatus == true)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> SortByPriceASC()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();
                listBooks = db.Books
                    .Select(book => book)
                    .OrderBy(book => book.Price)
                    .Where(book => book.SaleStatus == true)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> SortByPriceDESC()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();
                listBooks = db.Books
                    .Select(book => book)
                    .OrderByDescending(book => book.Price)
                    .Where(book => book.SaleStatus == true)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> SortByQuantityASC()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();
                listBooks = db.Books
                    .Select(book => book)
                    .OrderBy(book => book.Quantity)
                    .Where(book => book.SaleStatus == true)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public List<Book> SortByQuantityDESC()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Book> listBooks = new List<Book>();
                listBooks = db.Books
                    .Select(book => book)
                    .OrderByDescending(book => book.Quantity)
                    .Where(book => book.SaleStatus == true)
                    .ToList();
                if (listBooks.Count > 0)
                    return listBooks;
                else
                    return null;
            }
        }

        public Book GetBookByID(string ID_Book)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Books
                    .Where(book => book.ID_Book == ID_Book)
                    .Select(book => book)
                    .FirstOrDefault();
            }
        }

        public int GetNumberTotalBook()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Books
                    .Where(book => book.SaleStatus == true)
                    .Count();
            }
        }

        public int GetNumberTotalVietnameseBook()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Books
                    .Join(
                        db.Languages,
                        book => book.ID_Language,
                        lang => lang.ID_Language,
                        (book, lang) => new { book.ID_Book, book.SaleStatus, lang.NameLanguage })
                    .Where(book => book.NameLanguage == "Tiếng Việt")
                    .Where(book => book.SaleStatus == true)
                    .Count();
            }
        }

        public int GetNumberTotalEnglishBook()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Books
                    .Join(
                        db.Languages,
                        book => book.ID_Language,
                        lang => lang.ID_Language,
                        (book, lang) => new { book.ID_Book, book.SaleStatus, lang.NameLanguage })
                    .Where(book => book.NameLanguage == "Tiếng Anh")
                    .Where(book => book.SaleStatus == true)
                    .Count();
            }
        }

        public string GetNameLanguageByID(int ID_Language)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Languages
                    .Where(language => language.ID_Language == ID_Language)
                    .Select(language => new { language.NameLanguage })
                    .FirstOrDefault()
                    .NameLanguage;
            }
        }

        public string GetNamePublisherByID(int ID_Publisher)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Publishers
                    .Where(publisher => publisher.ID_Publisher == ID_Publisher)
                    .Select(publisher => new { publisher.NamePublisher })
                    .FirstOrDefault()
                    .NamePublisher;
            }
        }

        public string GetNameGenreByID(int ID_Genre)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                return db.Genres
                    .Where(genre => genre.ID_Genre == ID_Genre)
                    .Select(genre => new { genre.NameGenre })
                    .FirstOrDefault()
                    .NameGenre;
            }
        }

        public List<Language> GetAllLanguages()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Language> listLanguages = db.Languages
                                    .OrderBy(lang => lang.ID_Language)
                                    .Select(lang => lang)
                                    .ToList();
                if (listLanguages.Count > 0)
                    return listLanguages;
                else
                    return null;
            }
        }

        public List<Publisher> GetAllPublishers()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Publisher> listPublishers = db.Publishers
                                    .OrderBy(publisher => publisher.ID_Publisher)
                                    .Select(publisher => publisher)
                                    .ToList();
                if (listPublishers.Count > 0)
                    return listPublishers;
                else
                    return null;
            }
        }

        public List<Genre> GetAllGenres()
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                List<Genre> listGenres = db.Genres
                                    .OrderBy(genre => genre.ID_Genre)
                                    .Select(genre => genre)
                                    .ToList();
                if (listGenres.Count > 0)
                    return listGenres;
                else
                    return null;
            }
        }

        public bool IsExistIDBook(string ID_Book)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                var id = db.Books.Where(book => book.ID_Book == ID_Book);
                if (id.Count() > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool AddNewBook(Book book)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                db.Books.Add(book);
                int result = db.SaveChanges();
                return result > 0;
            }
        }

        public bool UpdateBook(Book newBookInfo)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                Book oldBook = db.Books.Find(newBookInfo.ID_Book);
                oldBook.NameBook = newBookInfo.NameBook;
                oldBook.PublishDate = newBookInfo.PublishDate;
                oldBook.NameAuthor = newBookInfo.NameAuthor;
                oldBook.ID_Language = newBookInfo.ID_Language;
                oldBook.ID_Publisher = newBookInfo.ID_Publisher;
                oldBook.ID_Genre = newBookInfo.ID_Genre;
                oldBook.Quantity = newBookInfo.Quantity;
                oldBook.Price = newBookInfo.Price;
                oldBook.Image = newBookInfo.Image;
                int result = db.SaveChanges();
                return result > 0;
            }
        }

        public bool UpdateQuantityBook(string ID_Book, int quantitySold)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                Book book = db.Books.Find(ID_Book);
                book.Quantity -= quantitySold;
                int result = db.SaveChanges();
                return result > 0;
            }
        }

        public bool DeleteBook(string ID_Book)
        {
            using (BookStoreContext db = new BookStoreContext())
            {
                Book book = db.Books.Find(ID_Book);
                book.SaleStatus = false;
                int result = db.SaveChanges();
                return result > 0;
            }
        }
    }
}
