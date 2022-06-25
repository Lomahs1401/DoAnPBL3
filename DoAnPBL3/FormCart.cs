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
    public partial class FormCart : Form
    {
        private int Count = 0;
        private int z = 0;
        public static string ID_Customer = "";
        readonly FormNhapMua[] currentChildForm = new FormNhapMua[100];
        private readonly string accountUsername;

        public FormCart(string accountUsername)
        {
            InitializeComponent();
            this.accountUsername = accountUsername;
        }

        private void OpenChildForm(FormNhapMua childForm)
        {
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Top;
            panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Tinh();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (tbNumber.Texts == "")
                RJMessageBox.Show("Vui lòng nhập số lượng loại sách muốn mua", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                int Num = Convert.ToInt32(tbNumber.Texts);
                Count += Num;
                if (Count <= 100)
                {
                    for (int j = 0; j < Num; j++)
                    {
                        currentChildForm[z] = new FormNhapMua(z + 1);
                        OpenChildForm(currentChildForm[z]);
                        z++;
                    }
                }
                else if (Count > 100)
                {
                    RJMessageBox.Show("Số lượng loại sách vượt quá giới hạn cho phép", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Count -= Num;
                }
            }
            tbNumber.Texts = "";
            panelDesktop.Focus();
        }

        public void Them_Sach(string ID)
        {
            bool check = true;
            Count++;
            if (Count <= 100)
            {   
                {
                    foreach (FormNhapMua b in panelDesktop.Controls)
                    {
                        if (b.GetIDBook() == ID)
                        { b.AddOneQuantity();
                            check = false;
                            break;
                        }
                        
                    }
                }
                if (check)
                {
                    currentChildForm[z] = new FormNhapMua(z + 1);
                    OpenChildForm(currentChildForm[z]);
                    currentChildForm[z].SetIDBook(ID);
                    currentChildForm[z].QuantityByOne();
                    z++;
                }
            }
            else if (Count > 100)
            {
                RJMessageBox.Show("Số lượng loại sách vượt quá giới hạn cho phép", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Count --;

            }

        }

        

        private void TbNumber__TextChanged(object sender, EventArgs e)
        {
            bool flag = true;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(tbNumber.Texts);
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
                RJMessageBox.Show("Chỉ được nhập số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNumber.Texts = "";
            }
        }

        private void RjbtnBuy_Click(object sender, EventArgs e)
        {
            bool check = true;
            int[] error = new int[100];
            int indexError = 0;
            using (BookStoreContext context = new BookStoreContext())
            {
                if (panelDesktop.Controls.Count != 0)
                {
                    foreach (FormNhapMua b in panelDesktop.Controls)
                    {
                        string ID_Book = b.GetID_Book();
                        var book = context.Books
                            .Where(bk => bk.ID_Book == ID_Book)
                            .Select(bk => new { bk.NameBook, bk.Quantity })
                            .ToList()
                            .FirstOrDefault();
                        if (b.GetQuantityText() == "0" || b.GetQuantityText() == "")
                        {
                            check = false;
                            error[indexError] = panelDesktop.Controls.Count - panelDesktop.Controls.GetChildIndex(b);
                            indexError++;
                        }
                        if (book.Quantity - b.GetQuantity() < 0)
                        {
                            check = false;
                            error[indexError] = panelDesktop.Controls.Count - panelDesktop.Controls.GetChildIndex(b);
                            indexError++;
                            RJMessageBox.Show("Số lượng sách " + book.NameBook + " không đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (book.Quantity == 0)
                        {
                            check = false;
                            error[indexError] = panelDesktop.Controls.Count - panelDesktop.Controls.GetChildIndex(b);
                            indexError++;
                            RJMessageBox.Show("Sách " + book.NameBook + " đã bán hết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (check == true)
                    {
                        new FormAuthenticateCustomer().ShowDialog();
                        if (ID_Customer == "")
                            return;
                        else
                        {
                            var ID_Order = context.Orders
                                .OrderBy(order => order.ID_Order)
                                .Select(order => order.ID_Order)
                                .ToList()
                                .LastOrDefault();
                            var ID_Employee = context.Accounts
                                .Join(
                                    context.Employees,
                                    account => account.Username,
                                    employee => employee.AccountUsername,
                                    (account, employee) => new
                                    {
                                        account.Username,
                                        employee.ID_Employee
                                    })
                                .Where(account => account.Username == accountUsername)
                                .Select(employee => employee.ID_Employee)
                                .ToList()
                                .FirstOrDefault();
                            StringBuilder newID_Order;
                            // Chua co hoa don nao
                            if (ID_Order == null)
                            {
                                newID_Order = new StringBuilder("HD0000");
                            }
                            else
                            {
                                string id = ID_Order; // HD0001
                                string code = id.Substring(2, id.Length - 2); // 0001
                                int num = Convert.ToInt32(code); // 1
                                num++; // 1 + 1 -> 2
                                string numStr = num.ToString(); // "2"
                                int lenNumStr = numStr.Length; // 1
                                newID_Order = new StringBuilder(id.Remove(id.Length - lenNumStr, lenNumStr));// HD000
                                newID_Order.Append(numStr); // HD000 + 2 => HD0002
                            }

                            string total = tbTotal.Text;


                            Order newOrder = new Order(newID_Order.ToString(), DateTime.Now, Convert.ToInt32(total.Remove(total.Length - 3, 3)), ID_Customer, ID_Employee);
                            context.Orders.Add(newOrder);
                            context.SaveChanges();

                            OrderDetail newOrderDetail;

                            for (int i = 0; i < Convert.ToInt32(tbNumDiverse.Text); i++)
                            {
                                newOrderDetail = new OrderDetail(newID_Order.ToString(), currentChildForm[i].GetID_Book(), currentChildForm[i].GetNameBook(),
                                    currentChildForm[i].GetPrice(), currentChildForm[i].GetQuantity(), (int)currentChildForm[i].GetAmount());
                                context.OrderDetails.Add(newOrderDetail);
                                context.SaveChanges();

                                Book book = context.Books.Find(currentChildForm[i].GetID_Book());
                                book.Quantity -= currentChildForm[i].GetQuantity();
                                context.SaveChanges();
                            }

                            Alert("Mua sách thành công", Form_Alert.EnmType.Success);
                            panelDesktop.Controls.Clear();
                            this.Hide();
                        }
                        z = 0;
                        ID_Customer = "";
                    }
                    else
                    {
                        int o = 0;
                        int[] v = new int[indexError];
                        for (int i = indexError - 1; i >= 0; i--)
                        {
                            v[i] = error[o];
                            o++;
                        }
                        RJMessageBox.Show("Xuất hiện sai sót tại dòng: " + string.Join(", ", v), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    RJMessageBox.Show("Chưa có sách nào trong giỏ hàng của bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void TbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOK.PerformClick();
                e.Handled = true;
            }
        }

        private void PanelDesktop_ControlAdded(object sender, ControlEventArgs e)
        {
            Tinh();
            
        }

        private void PanelDesktop_ControlRemoved(object sender, ControlEventArgs e)
        {
            z = panelDesktop.Controls.Count;
            Count--;
            foreach (FormNhapMua b in panelDesktop.Controls)
            {
                b.SetIndex(panelDesktop.Controls.Count - panelDesktop.Controls.GetChildIndex(b));
                b.SetIndexText();
            }
            Tinh();
            
        }

        private void PanelDesktop_Paint(object sender, PaintEventArgs e)
        {
            Tinh();
        }

        private void Tinh()
        {
            int quantity = 0;
            long total = 0;
            foreach (FormNhapMua b in panelDesktop.Controls)
            {
                if (b.GetQuantityText() == "")
                    quantity += 0;
                else
                    quantity += b.GetQuantity();
                if (b.GetAmountText() == "")
                    total += 0;
                else
                    total += b.GetAmount();
            }
            tbTotal.Text = total.ToString() + "VNĐ";
            tbNumDiverse.Text = panelDesktop.Controls.Count.ToString();
            tbQuantity.Text = quantity.ToString();
        }

        public int GetVariety()
        {
            return panelDesktop.Controls.Count;
        }



    }
}