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
    public partial class FormMenuNote : Form
    {
        private readonly string theme;
        private readonly string accountUsername;
        private readonly bool role;
        string[] content = new string[100];
        public FormMenuNote(string theme, string accountUsername, bool role)
        {
            this.theme = theme;
            this.accountUsername = accountUsername;
            this.role = role;
            InitializeComponent();
            switch (theme)
            {
                case "Admin":
                    btnAddNote.Parent.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    dgvQLGC.BackgroundColor = Color.FromArgb(24, 37, 65);
                    break;
                case "Dark":
                    btnAddNote.Parent.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    dgvQLGC.BackgroundColor = Color.FromArgb(34, 31, 46);
                    break;
                case "Light":
                    btnAddNote.Parent.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    btnAddNote.ForeColor = Color.White;
                    btnEditNote.ForeColor = Color.White;
                    btnDeleteNote.ForeColor = Color.White;
                    dgvQLGC.BackgroundColor = Color.Silver;
                    lblNote.ForeColor = Color.Black;
                    break;
            }
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void FormMenuNote_Load(object sender, EventArgs e)
        {
            dgvQLGC.RowHeadersVisible = true;
            dgvQLGC.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLGC.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            List<Note> notes = BLL_QLGC.Instance.GetAllNoteByAccountUsername(accountUsername);
            DataTable data = new DataTable();
            CreateCol(data);
            if (notes != null)
            {
                foreach (Note note in notes)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, note));
                }
                dgvQLGC.DataSource = data;
            }
            else
            {
                dgvQLGC.DataSource = null;
                dgvQLGC.Columns.Clear();
                SetColumnHeader();
            }
        }

        private void CreateCol(DataTable data)
        {
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Title", typeof(string)),
                new DataColumn("Date", typeof(string)),
            });
        }

        private DataRow CreateRow(DataRow dataRow, Note note)
        {
            dataRow["ID"] = note.ID;
            dataRow["Title"] = note.Title;
            dataRow["Date"] = note.Date.ToString("dd/MM/yyyy");
            return dataRow;
        }

        private void SetColumnHeader()
        {
            dgvQLGC.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn() {HeaderText = "ID", DataPropertyName = "ID", Name = "ID", Visible = false},
                new DataGridViewTextBoxColumn() {HeaderText = "Tiêu đề", DataPropertyName = "Title", Name = "Title"},
                new DataGridViewTextBoxColumn() {HeaderText = "Ngày tạo", DataPropertyName = "Date", Name = "Date"},
            });
        }

        private void DgvQLGC_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new FormNoteInfo(theme, GetIDNote()).Show();
        }

        private int GetIDNote()
        {
            return Convert.ToInt32(dgvQLGC.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void BtnAddNote_Click(object sender, EventArgs e)
        {
            FormNote formNote = new FormNote(theme, accountUsername, role);
            formNote.RefreshData += new FormNote.LoadData(FormMenuNote_Load);
            formNote.Show();
        }

        private void BtnEditNote_Click(object sender, EventArgs e)
        {
            if (dgvQLGC.CurrentRow == null)
                RJMessageBox.Show("Chưa có ghi chú nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                FormNote formNote = new FormNote(theme, accountUsername, role, GetIDNote());
                formNote.RefreshData += new FormNote.LoadData(FormMenuNote_Load);
                formNote.Show();
            }
        }

        private void BtnDeleteNote_Click(object sender, EventArgs e)
        {
            if (dgvQLGC.CurrentRow == null)
                RJMessageBox.Show("Chưa có ghi chú nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Note note = BLL_QLGC.Instance.GetNoteByID(GetIDNote());
                DialogResult result = RJMessageBox.Show("Xác nhận xóa ghi chú", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BLL_QLGC.Instance.DeleteNote(note))
                    {
                        Alert("Xóa ghi chú thành công", Form_Alert.EnmType.Success);
                        FormMenuNote_Load(sender, e);
                    }
                    else
                    {
                        Alert("Xóa ghi chú thất bại. Vui lòng thử lại", Form_Alert.EnmType.Error);
                        return;
                    }
                }
                else
                    return;
            }
        }
    }
}
