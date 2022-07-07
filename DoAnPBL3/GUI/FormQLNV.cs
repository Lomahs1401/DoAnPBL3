using DoAnPBL3.BLL;
using DoAnPBL3.Models;
using DoAnPBL3.Validator;
using FontAwesome.Sharp;
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
    public partial class FormQLNV : Form
    {
        private IconButton btnCurrent;
        private readonly string password;
        private readonly string theme;

        public FormQLNV(string theme, string password)
        {
            InitializeComponent();
            this.theme = theme;
            this.password = password;
            switch (theme)
            {
                case "Admin":
                    btnAddNV.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    lblTotalEmployee.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTotalMaleEmployee.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTotalFemaleEmployee.ForeColor = Color.FromArgb(124, 141, 181);
                    panelHeader.BackColor = Color.FromArgb(30, 30, 70); 
                    totalEmployee.ForeColor = Color.White;
                    femaleEmployee.ForeColor = Color.White;
                    maleEmployee.ForeColor = Color.White;
                    xuiSegmentNV.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentNV.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentNV.SegmentColor = Color.DarkMagenta;
                    xuiSegmentNV.SegmentInactiveTextColor = Color.White;
                    btnTKNV.FillColor = Color.FromArgb(107, 83, 255);
                    tbTKNV.BackColor = Color.FromArgb(23, 21, 35);
                    tbTKNV.BorderColor = Color.FromArgb(23, 21, 35);
                    tbTKNV.ForeColor = Color.Silver;
                    tbTKNV.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    dgvQLNV.BackgroundColor = Color.FromArgb(24, 37, 65);
                    break;
                case "Dark":
                    btnAddNV.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    btnAddNV.Parent.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    lblTotalEmployee.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTotalMaleEmployee.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTotalFemaleEmployee.ForeColor = Color.FromArgb(124, 141, 181);
                    panelHeader.BackColor = Color.FromArgb(38, 38, 40);
                    totalEmployee.ForeColor = Color.White;
                    femaleEmployee.ForeColor = Color.White;
                    maleEmployee.ForeColor = Color.White;
                    xuiSegmentNV.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentNV.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentNV.SegmentColor = Color.DarkMagenta;
                    xuiSegmentNV.SegmentInactiveTextColor = Color.White;
                    btnTKNV.FillColor = Color.FromArgb(107, 83, 255);
                    tbTKNV.BackColor = Color.FromArgb(18, 18, 18);
                    tbTKNV.BorderColor = Color.FromArgb(18, 18, 18);
                    tbTKNV.ForeColor = Color.Silver;
                    tbTKNV.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    dgvQLNV.BackgroundColor = Color.FromArgb(34, 31, 46);
                    break;
                case "Light":
                    btnAddNV.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    btnAddNV.Parent.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    lblTotalEmployee.ForeColor = Color.Black;
                    lblTotalMaleEmployee.ForeColor = Color.Black;
                    lblTotalFemaleEmployee.ForeColor = Color.Black;
                    panelHeader.BackColor = Color.FromArgb(210, 200, 210);
                    totalEmployee.ForeColor = Color.Black;
                    femaleEmployee.ForeColor = Color.Black;
                    maleEmployee.ForeColor = Color.Black;
                    xuiSegmentNV.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentNV.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentNV.SegmentColor = Color.DarkMagenta;
                    xuiSegmentNV.SegmentInactiveTextColor = Color.White;
                    btnTKNV.FillColor = Color.FromArgb(107, 83, 255);
                    tbTKNV.BackColor = Color.FromArgb(255, 255, 255);
                    tbTKNV.BorderColor = Color.FromArgb(180, 180, 180);
                    tbTKNV.ForeColor = Color.DimGray;
                    tbTKNV.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    dgvQLNV.BackgroundColor = Color.Silver;
                    break;
            }
        }

        private void DisableButton()
        {
            if (btnCurrent != null)
            {
                btnCurrent.BackColor = Color.FromArgb(34, 31, 46);
                btnCurrent.ForeColor = Color.Gainsboro;
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                btnCurrent.IconColor = Color.Gainsboro;
                btnCurrent.TextImageRelation = TextImageRelation.Overlay;
                btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                btnCurrent = (IconButton)senderBtn;
                btnCurrent.BackColor = Color.FromArgb(157, 16, 221);
                btnCurrent.ForeColor = color;
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                btnCurrent.IconColor = color;
                btnCurrent.TextImageRelation = TextImageRelation.Overlay;
                btnCurrent.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void BtnAddNV_MouseEnter(object sender, EventArgs e)
        {
            btnAddNV.BackColor = RGBColors.color4;
        }

        private void IconButton1_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteNV.BackColor = RGBColors.color4;
        }

        private void BtnEditNV_MouseEnter(object sender, EventArgs e)
        {
            btnSuaNV.BackColor = RGBColors.color4;
        }

        private void BtnAddNV_MouseLeave(object sender, EventArgs e)
        {
            btnAddNV.BackColor = Color.MediumSeaGreen;
        }

        private void BtnDeleteNV_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteNV.BackColor = Color.Firebrick;
        }

        private void BtnEditNV_MouseLeave(object sender, EventArgs e)
        {
            btnSuaNV.BackColor = Color.DodgerBlue;
        }

        private void BtnEmployeeQuitJob_MouseEnter(object sender, EventArgs e)
        {
            btnEmployeeQuitJob.BackColor = RGBColors.color4;
        }

        private void BtnEmployeeQuitJob_MouseLeave(object sender, EventArgs e)
        {
            btnEmployeeQuitJob.BackColor = Color.MidnightBlue;
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
        }

        private void BtnNam_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
        }

        private void BtnNu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
        }

        private void FormQLNV_Load(object sender, EventArgs e)
        {
            dgvQLNV.RowHeadersVisible = true;
            dgvQLNV.BorderStyle = BorderStyle.FixedSingle;
            dgvQLNV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLNV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            GetInfoEmployeeWorking();
            List<Employee> listEmployees = BLL_QLNV.Instance.GetEmployees();
            DataTable data = new DataTable();
            CreateCol(data);
            if (listEmployees != null)
            {
                foreach (Employee employee in listEmployees)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, employee));
                }
                dgvQLNV.DataSource = data;
            }
            else
            {
                dgvQLNV.DataSource = null;
                totalEmployee.Text = "0";
                maleEmployee.Text = "0";
                femaleEmployee.Text = "0";
            }
        }

        private void BtnAddNV_Click(object sender, EventArgs e)
        {
            FormAddNV formAddNV = new FormAddNV(theme);
            formAddNV.RefreshData += new FormAddNV.LoadData(FormQLNV_Load);
            formAddNV.ShowDialog();
        }

        private void BtnEditNV_Click(object sender, EventArgs e)
        {
            if (dgvQLNV.CurrentRow == null)
                RJMessageBox.Show("Hệ thống chưa có nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                FormSuaNV formSuaNV = new FormSuaNV(theme, GetID_Employee());
                formSuaNV.RefreshData += new FormSuaNV.LoadData(FormQLNV_Load);
                formSuaNV.ShowDialog();
            }
        }

        private void BtnDeleteNV_Click(object sender, EventArgs e)
        {
            if (dgvQLNV.CurrentRow == null)
                RJMessageBox.Show("Hệ thống chưa có nhân viên nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Employee employee = BLL_QLNV.Instance.GetEmployeeByID(GetID_Employee());
                string name = dgvQLNV.CurrentRow.Cells["FullNameEmployee"].Value.ToString();
                if (employee != null)
                {
                    DialogResult result = RJMessageBox.Show("Xác nhận xóa nhân viên " + name + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FormIdentify formIdentify = new FormIdentify(employee.AccountUsername, password, GetID_Employee());
                        formIdentify.RefreshData += new FormIdentify.LoadData(FormQLNV_Load);
                        formIdentify.Show();
                    }
                    else
                        return;
                }
                else
                    RJMessageBox.Show("Nhân viên " + name + " đã nghỉ việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEmployeeQuitJob_Click(object sender, EventArgs e)
        {
            dgvQLNV.RowHeadersVisible = true;
            dgvQLNV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvQLNV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            GetInfoEmployeeQuitJob();
            List<Employee> listEmployees = BLL_QLNV.Instance.GetEmployeesQuitJob();
            DataTable data = new DataTable();
            CreateCol(data);
            if (listEmployees != null)
            {
                foreach (Employee employee in listEmployees)
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, employee));
                }
                dgvQLNV.DataSource = data;
            }
            else
            {
                dgvQLNV.DataSource = null;
                totalEmployee.Text = "0";
                maleEmployee.Text = "0";
                femaleEmployee.Text = "0";
            }
        }

        private void DgvQLNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new FormTTNV(theme, GetID_Employee()).ShowDialog();
        }

        private string GetID_Employee()
        {
            return dgvQLNV.CurrentRow.Cells["ID_Employee"].Value.ToString();
        }

        private void BtnTKNV_Click(object sender, EventArgs e)
        {
            GetInfoEmployeeWorking();
            DataTable data = new DataTable();
            CreateCol(data);
            if (tbTKNV.Texts.Trim() == "")
                RJMessageBox.Show("Vui lòng điền thông tin nhân viên cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (tbTKNV.Texts.Contains("E0"))
            {
                Employee employee = BLL_QLNV.Instance.GetEmployeeByID(tbTKNV.Texts);
                if (employee == null)
                    RJMessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, employee));
                    dgvQLNV.DataSource = data;
                }
            }
            else if (Validators.IsValidPhoneNumber(tbTKNV.Texts, Validators.PHONE_REGEX))
            {
                Employee employee = BLL_QLNV.Instance.GetEmployeeByPhone(tbTKNV.Texts);
                if (employee == null)
                    RJMessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DataRow dataRow = data.NewRow();
                    data.Rows.Add(CreateRow(dataRow, employee));
                    dgvQLNV.DataSource = data;
                }
            }
            else
            {
                List<Employee> employees = BLL_QLNV.Instance.GetEmployeesByName(tbTKNV.Texts);
                if (employees == null)
                    RJMessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    foreach (Employee employee in employees)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, employee));
                    }
                    dgvQLNV.DataSource = data;
                }
            }
        }

        private void RjtbTKNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTKNV.PerformClick();
                e.Handled = true;
            }
        }

        private void XuiSegmentNV_Click(object sender, EventArgs e)
        {
            GetInfoEmployeeWorking();
            DataTable data = new DataTable();
            CreateCol(data);
            if (xuiSegmentNV.SelectedIndex == 0)
            {
                List<Employee> employees = BLL_QLNV.Instance.GetEmployees();
                if (employees == null)
                {
                    dgvQLNV.DataSource = null;
                }
                else
                {
                    foreach (Employee employee in employees)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, employee));
                    }
                    dgvQLNV.DataSource = data;
                }
            }
            // Nam
            else if (xuiSegmentNV.SelectedIndex == 1)
            {
                List<Employee> maleEmployees = BLL_QLNV.Instance.GetMaleEmployees();
                if (maleEmployee == null)
                {
                    dgvQLNV.DataSource = null;
                }
                else
                {
                    foreach (Employee employee in maleEmployees)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, employee));
                    }
                    dgvQLNV.DataSource = data;
                }
            }
            // Nữ
            else
            {
                List<Employee> femaleEmployees = BLL_QLNV.Instance.GetFemaleEmployees();
                if (femaleEmployees == null)
                {
                    dgvQLNV.DataSource = null;
                }
                else
                {
                    foreach (Employee employee in femaleEmployees)
                    {
                        DataRow dataRow = data.NewRow();
                        data.Rows.Add(CreateRow(dataRow, employee));
                    }
                    dgvQLNV.DataSource = data;
                }
            }
        }

        private void GetInfoEmployeeWorking()
        {
            lblTotalEmployee.Text = "Tổng số nhân viên làm việc";
            lblTotalMaleEmployee.Text = "Số nhân viên nam làm việc";
            lblTotalFemaleEmployee.Text = "Số nhân viên nữ làm việc";
            totalEmployee.Text = BLL_QLNV.Instance.GetNumberTotalEmployee().ToString();
            maleEmployee.Text = BLL_QLNV.Instance.GetNumberTotalMaleEmployee().ToString();
            femaleEmployee.Text = BLL_QLNV.Instance.GetNumberTotalFemaleEmployee().ToString();
        }

        private void GetInfoEmployeeQuitJob()
        {
            lblTotalEmployee.Text = "Tổng số nhân viên nghỉ việc";
            lblTotalMaleEmployee.Text = "Số nhân viên nam nghỉ việc";
            lblTotalFemaleEmployee.Text = "Số nhân viên nữ nghỉ việc";
            totalEmployee.Text = BLL_QLNV.Instance.GetNumberTotalEmployeeQuitJob().ToString();
            maleEmployee.Text = BLL_QLNV.Instance.GetNumberTotalMaleEmployeeQuitJob().ToString();
            femaleEmployee.Text = BLL_QLNV.Instance.GetNumberTotalFemaleEmployeeQuitJob().ToString();
        }

        private void CreateCol(DataTable data)
        {
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Employee", typeof(string)),
                new DataColumn("FullNameEmployee", typeof(string)),
                new DataColumn("Email", typeof(string)),
                new DataColumn("DateOfBirth", typeof(string)),
                new DataColumn("Gender", typeof(string)),
                new DataColumn("ID_Card", typeof(string)),
                new DataColumn("Phone", typeof(string)),
                new DataColumn("Address", typeof(string)),
            });
        }

        private DataRow CreateRow(DataRow dataRow, Employee employee)
        {
            dataRow["ID_Employee"] = employee.ID_Employee;
            dataRow["FullNameEmployee"] = employee.FullNameEmployee;
            dataRow["Email"] = employee.Email;
            dataRow["DateOfBirth"] = employee.DateOfBirth.ToString("dd/MM/yyyy");
            dataRow["Gender"] = employee.Gender;
            dataRow["ID_Card"] = employee.Id_Card;
            dataRow["Phone"] = employee.Phone;
            dataRow["Address"] = employee.Address;
            return dataRow;
        }
    }
}