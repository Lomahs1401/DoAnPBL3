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
    public partial class FormNhapMua : Form
    {
        private int index;
        public FormNhapMua(int index)
        {
            InitializeComponent();
            this.index = index;
            Index.Text = index.ToString();
            if(index > 9)
            {
                Index.Location = new Point(3, 16);
            }
        }

        private void TbIDBook_TextChanged(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var book = context.Books
                    .Where(b => b.ID_Book == tbIDBook.Text)
                    .Select(b => new { b.NameBook, b.Price })
                    .ToList()
                    .FirstOrDefault();
                if (book != null)
                {
                    tbNameBook.Text = book.NameBook;
                    tbPrice.Text = book.Price.ToString();
                }
                else
                {
                    tbNameBook.Text = "";
                    tbPrice.Text = "";
                }    
            }
        }

        private void TbQuantity_TextChanged(object sender, EventArgs e)
        {
            bool flag = true;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(tbQuantity.Text);
            foreach (byte b in asciiBytes)
            {
                if (b > 57 || b < 47)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == false)
            {

                RJMessageBox.Show("Chỉ được nhập số", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbQuantity.Text = "";
            }
            else
            {
                if (tbQuantity.Text != "")
                {
                    if (tbPrice.Text == "")
                    {
                        RJMessageBox.Show("ID sách không hợp lệ", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbQuantity.Text = "";
                    }
                    else
                        tbAmount.Text = (Convert.ToInt64(tbQuantity.Text) * Convert.ToInt64(tbPrice.Text)).ToString();
                }
                else
                    tbAmount.Text = "";
                Parent.Refresh();
            }
            Parent.Refresh();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Close();
        }

        public long GetAmount()
        {
            if (tbAmount.Text != "")
                return Convert.ToInt64(tbAmount.Text);
            else
                return 0;
        }

        public int GetQuantity()
        {
            if (tbQuantity.Text != "")
                return Convert.ToInt32(tbQuantity.Text);
            else
                return 0;
        }

        public string GetAmountText()
        {
            return tbAmount.Text;
        }
        
        public string GetQuantityText()
        {
            return tbQuantity.Text;
        }

        public void SetIndex(int index)
        {
            this.index = index;
        }

        public string GetIndex()
        {
            return Index.Text;
        }

        public string GetID_Book()
        {
            return tbIDBook.Text;
        }

        public string GetNameBook()
        {
            return tbNameBook.Text;
        }

        public int GetPrice()
        {
            if (tbPrice.Text != "")
                return Convert.ToInt32(tbPrice.Text);
            else
                return 0;
        }

        public void SetIndexText()
        {
            Index.Text = index.ToString();
        }

        private void Index_Paint(object sender, PaintEventArgs e)
        {
            Index.Text = index.ToString();
        }

        public void SetIDBook(string ID)
        {
            tbIDBook.Text = ID;
        }

        public void QuantityByOne()
        {
            tbQuantity.Text = "1";
        }

        public void AddOneQuantity()
        {
            tbQuantity.Text = (Convert.ToInt32(tbQuantity.Text) + 1).ToString();
        }
    }
}
