using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnPBL3.BLL;
using FontAwesome.Sharp;

namespace DoAnPBL3
{
    public partial class MainMenuQTV : Form
    {
        private IconButton btnCurrent;
        private readonly Panel btnLeftBorder;
        private Form currentChildForm;
        private string theme = "Admin";
        private readonly string accountUsername;
        private readonly string password;
        private readonly bool role;
        public MainMenuQTV(string accountUsername, string password, bool role, string nameAdmin)
        {
            InitializeComponent();
            btnLeftBorder = new Panel
            {
                Size = new Size(7, 77)
            };
            panelMenu.Controls.Add(btnLeftBorder);
            lblAdminName.Text = nameAdmin;
            lblAdminUsername.Text = accountUsername;
            this.accountUsername = accountUsername;
            this.password = password;
            this.role = role;
            //Form
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        // Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {

                DisableButton();
                // Button
                switch (theme)
                {
                    case "Admin":
                        btnCurrent = (IconButton)senderBtn;
                        btnCurrent.BackColor = Color.FromArgb(37, 36, 81);
                        btnCurrent.ForeColor = color;
                        btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                        btnCurrent.IconColor = color;
                        btnCurrent.TextImageRelation = TextImageRelation.TextBeforeImage;
                        btnCurrent.ImageAlign = ContentAlignment.MiddleRight;
                        break;
                    case "Dark":
                        btnCurrent = (IconButton)senderBtn;
                        btnCurrent.BackColor = Color.FromArgb(71, 71, 71);
                        btnCurrent.ForeColor = color;
                        btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                        btnCurrent.IconColor = color;
                        btnCurrent.TextImageRelation = TextImageRelation.TextBeforeImage;
                        btnCurrent.ImageAlign = ContentAlignment.MiddleRight;
                        break;
                    case "Light":
                        btnCurrent = (IconButton)senderBtn;
                        btnCurrent.BackColor = Color.Silver;
                        btnCurrent.ForeColor = color;
                        btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                        btnCurrent.IconColor = color;
                        btnCurrent.TextImageRelation = TextImageRelation.TextBeforeImage;
                        btnCurrent.ImageAlign = ContentAlignment.MiddleRight;
                        break;
                }
                // Left Border Button
                btnLeftBorder.BackColor = color;
                btnLeftBorder.Location = new Point(0, btnCurrent.Location.Y);
                btnLeftBorder.Visible = true;
                btnLeftBorder.BringToFront();

                // Icon Current Child Form
                iconCurrentChildForm.IconChar = btnCurrent.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (btnCurrent != null)
            {
                switch (theme)
                {
                    case "Admin":
                        btnCurrent.BackColor = Color.FromArgb(31, 30, 68);
                        btnCurrent.ForeColor = Color.Gainsboro;
                        btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                        btnCurrent.IconColor = Color.Gainsboro;
                        btnCurrent.TextImageRelation = TextImageRelation.ImageBeforeText;
                        btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
                        break;
                    case "Dark":
                        btnCurrent.BackColor = Color.FromArgb(26, 26, 26);
                        btnCurrent.ForeColor = Color.Gainsboro;
                        btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                        btnCurrent.IconColor = Color.Gainsboro;
                        btnCurrent.TextImageRelation = TextImageRelation.ImageBeforeText;
                        btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
                        break;
                    case "Light":
                        btnCurrent.BackColor = Color.FromArgb(210, 210, 210);
                        btnCurrent.ForeColor = Color.Black;
                        btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                        btnCurrent.IconColor = Color.Black;
                        btnCurrent.TextImageRelation = TextImageRelation.ImageBeforeText;
                        btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
                        break;
                }
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Open only form
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            if (childForm.Text == "Admin" || childForm.Text == "Dark" || childForm.Text == "Light" || childForm.Text == "")
                lblTitleChildForm.Text = "Theme";
            else
                lblTitleChildForm.Text = childForm.Text;
        }

        private void BtnQLNV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormQLNV(theme, password));
        }

        private void BtnQLBS_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormQLBS(theme));
        }

        private void BtnQLDT_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormQLDT(theme));
        }

        private void BtnQLKH_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormQLKH(theme));
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            btnLeftBorder.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        // Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else WindowState = FormWindowState.Normal;
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = RGBColors.color5;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnMaximize_MouseEnter(object sender, EventArgs e)
        {
            btnMaximize.BackColor = RGBColors.color1;
        }

        private void BtnMaximize_MouseLeave(object sender, EventArgs e)
        {
            btnMaximize.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = RGBColors.color6;
        }

        private void BtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainMenuQTV_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
            rjddmAdminSettingMenu.IsMainMenu = true;
            guna2ShadowForm1.SetShadowForm(this);
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            string avatar = BLL_QLNV.Instance.GetAvatar(accountUsername);
            if (avatar == null)
                AdminPicture.Image = null;
            else
                AdminPicture.Image = Image.FromFile(Path.Combine(projectDirectory, avatar));
        }

        private void AdminPicture_Click(object sender, EventArgs e)
        {
            rjddmAdminSettingMenu.Show(AdminPicture, new Point(0, AdminPicture.Height));
        }

        private void LblAdminUsername_Click(object sender, EventArgs e)
        {
            AdminPicture_Click(sender, e);
        }

        private void RjddmAdminSettingMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (đăngXuấtToolStripMenuItem.Selected == true)
            {
                Hide();
                new FormLogin().ShowDialog();
                Close();
            }
            if (chỉnhSửaTàiKhoảnToolStripMenuItem.Selected == true)
            {
                DisableButton();
                iconCurrentChildForm.IconChar = IconChar.Cog;
                btnLeftBorder.Visible = false;
                FormSettingAccountQTV formSettingAccountQTV = new FormSettingAccountQTV(theme, accountUsername, password, true);
                formSettingAccountQTV.RefreshData += new FormSettingAccountQTV.LoadData(MainMenuQTV_Load);
                OpenChildForm(formSettingAccountQTV);
            }
            if (thayĐổiThemeToolStripMenuItem.Selected == true)
            {
                DisableButton();
                iconCurrentChildForm.IconChar = IconChar.Moon;
                btnLeftBorder.Visible = false;
                OpenChildForm(new FormTheme(theme));
            }

            if (ghiChúToolStripMenuItem.Selected == true)
            {
                DisableButton();
                iconCurrentChildForm.IconChar = IconChar.Pen;
                btnLeftBorder.Visible = false;
                OpenChildForm(new FormMenuNote(theme, accountUsername, role));
            }
        }

        public void ChangeTheme(string theme)
        {
            this.theme = theme;
        }

        public void ApplyTheme(string theme)
        {
            if (theme == "Dark")
            {
                ApplyThemeDark();
            }
            else
                if (theme == "Light")
            {
                ApplyThemeLight();

            }
            else
                if (theme == "Admin")
            {
                ApplyThemeAdmin();
            }
        }

        public void ApplyThemeDark()
        {
            lblTitleChildForm.ForeColor = Color.Gainsboro;
            panelMenu.BackColor = Color.FromArgb(26, 26, 26);
            panelTitleBar.BackColor = Color.FromArgb(20, 20, 20);
            panelDesktop.BackColor = Color.FromArgb(32, 32, 32);
            panelShadow.BackColor = Color.FromArgb(20, 20, 20);
            btnQLBS.BackColor = Color.FromArgb(26, 26, 26);
            btnQLBS.ForeColor = Color.Gainsboro;
            btnQLBS.IconColor = Color.Gainsboro;
            btnQLNV.BackColor = Color.FromArgb(26, 26, 26);
            btnQLNV.ForeColor = Color.Gainsboro;
            btnQLNV.IconColor = Color.Gainsboro;
            btnQLDT.BackColor = Color.FromArgb(26, 26, 26);
            btnQLDT.ForeColor = Color.Gainsboro;
            btnQLDT.IconColor = Color.Gainsboro;
            btnQLKH.BackColor = Color.FromArgb(26, 26, 26);
            btnQLKH.ForeColor = Color.Gainsboro;
            btnQLKH.IconColor = Color.Gainsboro;
            rjddmAdminSettingMenu.BackColor = Color.FromArgb(26, 26, 26);
            lblDate.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            lblAdminName.ForeColor = Color.White;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox2.IconColor = Color.White;
            lblAdminUsername.ForeColor = Color.White;
        }

        public void ApplyThemeLight()
        {
            lblTitleChildForm.ForeColor = Color.Black;
            panelMenu.BackColor = Color.FromArgb(210, 210, 210);
            panelTitleBar.BackColor = Color.FromArgb(240, 240, 240);
            panelDesktop.BackColor = Color.FromArgb(220, 220, 220);
            panelShadow.BackColor = Color.FromArgb(235, 235, 235);
            btnQLBS.BackColor = Color.FromArgb(210, 210, 210);
            btnQLBS.ForeColor = Color.Black;
            btnQLBS.IconColor = Color.Black;
            btnQLNV.BackColor = Color.FromArgb(210, 210, 210);
            btnQLNV.ForeColor = Color.Black;
            btnQLNV.IconColor = Color.Black;
            btnQLDT.BackColor = Color.FromArgb(210, 210, 210);
            btnQLDT.ForeColor = Color.Black;
            btnQLDT.IconColor = Color.Black;
            btnQLKH.BackColor = Color.FromArgb(210, 210, 210);
            btnQLKH.ForeColor = Color.Black;
            btnQLKH.IconColor = Color.Black;
            rjddmAdminSettingMenu.BackColor = Color.FromArgb(190, 190, 190);
            lblDate.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            lblAdminName.ForeColor = Color.Black;
            iconPictureBox1.IconColor = Color.Black;
            iconPictureBox2.IconColor = Color.Black;
            lblAdminUsername.ForeColor = Color.Black;
        }

        public void ApplyThemeAdmin()
        {
            lblTitleChildForm.ForeColor = Color.White;
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelShadow.BackColor = Color.FromArgb(26, 25, 62);
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            btnQLBS.BackColor = Color.FromArgb(31, 30, 68);
            btnQLBS.ForeColor = Color.White;
            btnQLBS.IconColor = Color.White;
            btnQLNV.BackColor = Color.FromArgb(31, 30, 68);
            btnQLNV.ForeColor = Color.White;
            btnQLNV.IconColor = Color.White;
            btnQLDT.BackColor = Color.FromArgb(31, 30, 68);
            btnQLDT.ForeColor = Color.White;
            btnQLDT.IconColor = Color.White;
            btnQLKH.BackColor = Color.FromArgb(31, 30, 68);
            btnQLKH.ForeColor = Color.White;
            btnQLKH.IconColor = Color.White;
            rjddmAdminSettingMenu.BackColor = Color.DarkSlateBlue;
            lblDate.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            lblAdminName.ForeColor = Color.White;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox2.IconColor = Color.White;
            lblAdminUsername.ForeColor = Color.White;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                if (currentChildForm.Text == "Dark" || currentChildForm.Text == "Admin" || currentChildForm.Text == "Light")
                {
                    ChangeTheme(currentChildForm.Text);
                    ApplyTheme(currentChildForm.Text);
                }
            }
        }
    }
}

