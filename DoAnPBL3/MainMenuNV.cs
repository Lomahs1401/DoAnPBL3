using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace DoAnPBL3
{
    public partial class MainMenuNV : Form
    {
        private IconButton btnCurrent;
        private Panel btnLeftBorder;
        private Form currentChildForm;

        public MainMenuNV()
        {
            InitializeComponent();
            btnLeftBorder = new Panel();
            btnLeftBorder.Size = new Size(7, 77);
            panelMenu.Controls.Add(btnLeftBorder);




            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            
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
                btnCurrent = (IconButton)senderBtn;
                btnCurrent.BackColor = Color.FromArgb(37, 36, 81);
                btnCurrent.ForeColor = color;
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                btnCurrent.IconColor = color;
                btnCurrent.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnCurrent.ImageAlign = ContentAlignment.MiddleRight;

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
                btnCurrent.BackColor = Color.FromArgb(22, 33, 49);
                btnCurrent.ForeColor = Color.Gainsboro;
                btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                btnCurrent.IconColor = Color.Gainsboro;
                btnCurrent.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;

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
            lblTitleChildForm.Text = childForm.Text;

        }

        private void btnQLS_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormQLS());
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormQLBSNV());
        }



        private void btnQLKH_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormQLKHNV());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {   if (currentChildForm != null)
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
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }

            else WindowState = FormWindowState.Normal;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = RGBColors.color5;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnMaximize_MouseEnter(object sender, EventArgs e)
        {
            btnMaximize.BackColor = RGBColors.color1;

        }

        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            btnMaximize.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = RGBColors.color6;

        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainMenuQTV_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            rjddmUserSettingMenu.IsMainMenu = true;
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

            rjddmUserSettingMenu.Show(btnAdmin, new Point(0, btnAdmin.Height));

        }

        private void btnAdmin_MouseEnter(object sender, EventArgs e)
        {
            btnAdmin.BackColor = RGBColors.color4;

        }

        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.FromArgb(26, 25, 62);

        }

        private void AdminPicture_Click(object sender, EventArgs e)
        {

            btnAdmin_Click(sender, e);
        }

        private void AdminPicture_MouseEnter(object sender, EventArgs e)
        {
            btnAdmin.BackColor = RGBColors.color4;

        }

        private void AdminPicture_MouseLeave(object sender, EventArgs e)
        {
            btnAdmin.BackColor = Color.FromArgb(26, 25, 62);

        }

        private void rjddmUserSettingMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            
            
                if (đăngXuấtToolStripMenuItem.Selected == true)
                {
                    this.Hide();
                    new FormLogin().ShowDialog();
                    this.Close();

                
            }

            if (chỉnhSửaTàiKhoảnToolStripMenuItem.Selected == true)
            {
                DisableButton();
                btnLeftBorder.Visible = false;
                OpenChildForm(new FormSettingAccountNV());

            }
        }

        
    }
}
