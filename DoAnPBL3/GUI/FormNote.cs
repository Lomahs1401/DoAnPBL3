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
    public partial class FormNote : Form
    {
        private readonly string accountUsername;
        private readonly bool role;
        private readonly int id;
        public delegate void LoadData(object sender, EventArgs e);
        public LoadData RefreshData { get; set; }
        public FormNote(string theme, string accountUsername, bool role, int id = 0)
        {
            InitializeComponent();
            this.accountUsername = accountUsername;
            this.role = role;
            this.id = id;
            Text = "Ghi chú";
            switch (theme)
            {
                case "Admin":
                    panelContainer.BackColor = Color.FromArgb(34, 33, 74);
                    lblTitle.ForeColor = Color.White;
                    tbTitle.ForeColor = Color.White;
                    tbTitle.PlaceholderForeColor = Color.White;
                    lblContent.ForeColor = Color.White;
                    tbContent.ForeColor = Color.White;
                    tbContent.PlaceholderForeColor = Color.White;
                    break;
                case "Dark":
                    panelContainer.BackColor = Color.FromArgb(32, 32, 32);
                    lblTitle.ForeColor = Color.White;
                    tbTitle.ForeColor = Color.White;
                    tbTitle.FillColor = Color.FromArgb(40, 35, 40);
                    tbTitle.PlaceholderForeColor = Color.White;
                    lblContent.ForeColor = Color.White;
                    tbContent.ForeColor = Color.White;
                    tbContent.FillColor = Color.FromArgb(40, 35, 40);
                    tbContent.PlaceholderForeColor = Color.White;
                    break;
                case "Light":
                    panelContainer.BackColor = Color.Gainsboro;
                    lblTitle.ForeColor = Color.Black;
                    tbTitle.ForeColor = Color.Black;
                    tbTitle.BorderColor = Color.Black;
                    tbTitle.PlaceholderForeColor = Color.Black;
                    tbTitle.FillColor = Color.Silver;
                    lblContent.ForeColor = Color.Black;
                    tbContent.ForeColor = Color.Black;
                    tbContent.BorderColor = Color.Black;
                    tbContent.FillColor = Color.Silver;
                    tbContent.PlaceholderForeColor = Color.Black;
                    break;
            }
            if (id != 0)
            {
                Note note = BLL_QLGC.Instance.GetNoteByID(id);
                tbTitle.Text = note.Title;
                tbContent.Text = note.Content;
            }
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                if (BLL_QLGC.Instance.AddNewNote(GetAllInfo()))
                {
                    Alert("Thêm ghi chú mới thành công", Form_Alert.EnmType.Success);
                    RefreshData(sender, e);
                    Dispose();
                }
                else
                {
                    Alert("Thêm ghi chú thất bại. Vui lòng thử lại", Form_Alert.EnmType.Error);
                    return;
                }
            }
            else
            {
                Note note = new Note(id, tbTitle.Text, tbContent.Text, DateTime.Now, accountUsername);
                if (BLL_QLGC.Instance.UpdateNote(note))
                {
                    Alert("Cập nhật ghi chú thành công", Form_Alert.EnmType.Success);
                    RefreshData(sender, e);
                    Dispose();
                }
                else
                {
                    Alert("Cập nhật ghi chú thất bại vì dữ liệu chưa được cập nhật", Form_Alert.EnmType.Error);
                    return;
                }
            }
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                if (tbTitle.Text != "" || tbContent.Text != "")
                {
                    DialogResult result = RJMessageBox.Show("Ghi chú chưa được lưu. Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                        Hide();
                    else
                        return;
                }
                else
                    Dispose();
            }
            else
            {
                Note note = BLL_QLGC.Instance.GetNoteByID(id);
                if (tbTitle.Text != note.Title || tbContent.Text != note.Content)
                {
                    DialogResult result = RJMessageBox.Show("Thay đổi ghi chú chưa được lưu. Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                        Hide();
                    else
                        return;
                }
                else
                    Dispose();
            }
        }

        private Note GetAllInfo()
        {
            return new Note
            {
                Title = tbTitle.Text,
                Content = tbContent.Text,
                Date = DateTime.Now,
                AccountUsername = accountUsername
            };
        }
    }
}
