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
        public FormQLNV(string theme)
        {
            InitializeComponent();
            switch (theme)
            {
                case "Admin":
                    btnAddNV.Parent.BackColor = Color.FromArgb(34, 33, 74);
                    label2.ForeColor = Color.FromArgb(124, 141, 181);
                    label5.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTSNV.ForeColor = Color.White;
                    lblSNVNu.ForeColor = Color.White;
                    lblSNVNam.ForeColor = Color.White;
                    xuiSegmentNV.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentNV.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentNV.SegmentColor = Color.DarkMagenta;
                    xuiSegmentNV.SegmentInactiveTextColor = Color.White;
                    btnTKNV.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKNV.BackColor = Color.FromArgb(23, 21, 35);
                    rjtbTKNV.BorderColor = Color.FromArgb(23, 21, 35);
                    rjtbTKNV.ForeColor = Color.Silver;
                    rjtbTKNV.PlaceholderColor = Color.FromArgb(87, 83, 103);

                    break;

                case "Dark":
                    btnAddNV.Parent.BackColor = Color.FromArgb(32, 32, 32);
                    label2.ForeColor = Color.FromArgb(124, 141, 181);
                    label5.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTSNV.ForeColor = Color.White;
                    lblSNVNu.ForeColor = Color.White;
                    lblSNVNam.ForeColor = Color.White;
                    xuiSegmentNV.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentNV.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentNV.SegmentColor = Color.DarkMagenta;
                    xuiSegmentNV.SegmentInactiveTextColor = Color.White;
                    btnTKNV.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKNV.BackColor = Color.FromArgb(18, 18, 18);
                    rjtbTKNV.BorderColor = Color.FromArgb(18, 18, 18);
                    rjtbTKNV.ForeColor = Color.Silver;
                    rjtbTKNV.PlaceholderColor = Color.FromArgb(87, 83, 103);
                    break;

                case "Light":
                    btnAddNV.Parent.BackColor = Color.FromArgb(220, 220, 220);
                    label2.ForeColor = Color.FromArgb(124, 141, 181);
                    label5.ForeColor = Color.FromArgb(124, 141, 181);
                    label7.ForeColor = Color.FromArgb(124, 141, 181);
                    lblTSNV.ForeColor = Color.Black;
                    lblSNVNu.ForeColor = Color.Black;
                    lblSNVNam.ForeColor = Color.Black;
                    xuiSegmentNV.SegmentActiveTextColor = Color.HotPink;
                    xuiSegmentNV.SegmentBackColor = Color.SlateBlue;
                    xuiSegmentNV.SegmentColor = Color.DarkMagenta;
                    xuiSegmentNV.SegmentInactiveTextColor = Color.White;
                    btnTKNV.FillColor = Color.FromArgb(107, 83, 255);
                    rjtbTKNV.BackColor = Color.FromArgb(255, 255, 255);
                    rjtbTKNV.BorderColor = Color.FromArgb(180, 180, 180);
                    rjtbTKNV.ForeColor = Color.DimGray;
                    rjtbTKNV.PlaceholderColor = Color.FromArgb(87, 83, 103);

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

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void btnAddNV_MouseEnter(object sender, EventArgs e)
        {
            btnAddNV.BackColor = RGBColors.color4;
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteNV.BackColor = RGBColors.color4;
        }

        private void btnSuaNV_MouseEnter(object sender, EventArgs e)
        {
            btnSuaNV.BackColor = RGBColors.color4;
        }

        private void btnAddNV_MouseLeave(object sender, EventArgs e)
        {
            btnAddNV.BackColor = Color.MediumSeaGreen;
        }

        private void btnDeleteNV_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteNV.BackColor = Color.Firebrick;
        }

        private void btnSuaNV_MouseLeave(object sender, EventArgs e)
        {
            btnSuaNV.BackColor = Color.DodgerBlue;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
        }

        private void btnNu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gainsboro);
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            new FormAddNV().Show();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            string ID_Employee = dgvQLNV.CurrentRow.Cells["ID"].Value.ToString();
            new FormSuaNV(ID_Employee).Show();
        }
        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            string ID_Employee = dgvQLNV.CurrentRow.Cells["ID"].Value.ToString();
            string name = dgvQLNV.CurrentRow.Cells["Name"].Value.ToString();
            DialogResult result = RJMessageBox.Show("Xác nhận xóa nhân viên " + name + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    Employee employee = context.Employees.Find(ID_Employee);
                    context.Employees.Remove(employee);
                    context.SaveChanges();
                }
                FormQLNV_Load(sender, e);
                Alert("Xóa nhân viên thành công", Form_Alert.enmType.Success);
            }
            else
                return;
        }

        private void dgvQLNV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ID_Employee = dgvQLNV.CurrentRow.Cells["ID"].Value.ToString();
            new FormTTNV(ID_Employee).Show();
        }

        private void FormQLNV_Load(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                var listEmployees = context.Employees
                                    .Select(employee => new
                                    {
                                        employee.ID_Employee,
                                        employee.NameEmployee,
                                        employee.Gender,
                                        employee.Email,
                                        employee.Phone
                                    });
                var listMaleEmployees = context.Employees
                                        .Where(employee => employee.Gender == "Nam")
                                        .Select(employee => new
                                        {
                                            employee.ID_Employee,
                                            employee.NameEmployee,
                                            employee.Gender,
                                            employee.Email,
                                            employee.Phone
                                        });
                var listFemaleEmployees = context.Employees
                                        .Where(employee => employee.Gender == "Nữ")
                                        .Select(employee => new
                                        {
                                            employee.ID_Employee,
                                            employee.NameEmployee,
                                            employee.Gender,
                                            employee.Email,
                                            employee.Phone
                                        });
                dgvQLNV.DataSource = listEmployees.ToList();
                lblTSNV.Text = listEmployees.ToList().Count().ToString();
                lblSNVNam.Text = listMaleEmployees.ToList().Count().ToString();
                lblSNVNu.Text = listFemaleEmployees.ToList().Count().ToString();
            }
        }

        private void btnTKNV_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                if (EmployeeValidator.IsValidPhoneNumber(rjtbTKNV.Texts, EmployeeValidator.PHONE_REGEX))
                {
                    var listEmployees = context.Employees
                                        .Where(employee => employee.Phone == rjtbTKNV.Texts)
                                        .Select(employee => new
                                        {
                                            employee.ID_Employee,
                                            employee.NameEmployee,
                                            employee.Gender,
                                            employee.Email,
                                            employee.Phone
                                        });
                    if (listEmployees.ToList().Count == 0)
                        RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        dgvQLNV.DataSource = listEmployees.ToList();
                }
                else
                {
                    var listEmployees = context.Employees
                                        .Where(employee => employee.NameEmployee.Contains(rjtbTKNV.Texts))
                                        .Select(employee => new
                                        {
                                            employee.ID_Employee,
                                            employee.NameEmployee,
                                            employee.Gender,
                                            employee.Email,
                                            employee.Phone
                                        });
                    if (listEmployees.ToList().Count == 0)
                        RJMessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        dgvQLNV.DataSource = listEmployees.ToList();
                }
            }
        }

        private void rjtbTKNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                btnTKNV.PerformClick();
                e.Handled = true;
            }
        }

        private void xuiSegmentNV_Click(object sender, EventArgs e)
        {
            using (BookStoreContext context = new BookStoreContext())
            {
                // Tất cả
                if (xuiSegmentNV.SelectedIndex == 0)
                {
                    dgvQLNV.DataSource = context.Employees
                                        .Select(employee => new
                                        {
                                            employee.ID_Employee,
                                            employee.NameEmployee,
                                            employee.Gender,
                                            employee.Email,
                                            employee.Phone
                                        }).ToList();
                }
                // Nam
                else if (xuiSegmentNV.SelectedIndex == 1)
                {
                    dgvQLNV.DataSource = context.Employees
                                        .Where(employee => employee.Gender == "Nam")
                                        .Select(employee => new
                                        {
                                            employee.ID_Employee,
                                            employee.NameEmployee,
                                            employee.Gender,
                                            employee.Email,
                                            employee.Phone
                                        }).ToList();
                }
                // Nữ
                else
                {
                    dgvQLNV.DataSource = context.Employees
                                        .Where(employee => employee.Gender == "Nữ")
                                        .Select(employee => new
                                        {
                                            employee.ID_Employee,
                                            employee.NameEmployee,
                                            employee.Gender,
                                            employee.Email,
                                            employee.Phone
                                        }).ToList();
                }
            }
        }
    }
}