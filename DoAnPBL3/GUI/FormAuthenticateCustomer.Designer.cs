
namespace DoAnPBL3
{
    partial class FormAuthenticateCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbConfirmPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.rjbtnOK = new DoAnPBL3.RJButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.lblConfirmPhone = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rjbtnCancel = new DoAnPBL3.RJButton();
            this.msgValidatePass = new System.Windows.Forms.Label();
            this.rjbtnAdd = new DoAnPBL3.RJButton();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbConfirmPhone
            // 
            this.tbConfirmPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbConfirmPhone.BorderRadius = 6;
            this.tbConfirmPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPhone.DefaultText = "";
            this.tbConfirmPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbConfirmPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbConfirmPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbConfirmPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPhone.Location = new System.Drawing.Point(188, 190);
            this.tbConfirmPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConfirmPhone.Name = "tbConfirmPhone";
            this.tbConfirmPhone.PasswordChar = '\0';
            this.tbConfirmPhone.PlaceholderText = "Nhập SĐT khách hàng";
            this.tbConfirmPhone.SelectedText = "";
            this.tbConfirmPhone.Size = new System.Drawing.Size(467, 36);
            this.tbConfirmPhone.TabIndex = 0;
            this.tbConfirmPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbConfirmPass_KeyPress);
            // 
            // rjbtnOK
            // 
            this.rjbtnOK.BackColor = System.Drawing.Color.SeaGreen;
            this.rjbtnOK.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.rjbtnOK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnOK.BorderRadius = 15;
            this.rjbtnOK.BorderSize = 0;
            this.rjbtnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnOK.FlatAppearance.BorderSize = 0;
            this.rjbtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnOK.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnOK.ForeColor = System.Drawing.Color.White;
            this.rjbtnOK.Location = new System.Drawing.Point(93, 370);
            this.rjbtnOK.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnOK.Name = "rjbtnOK";
            this.rjbtnOK.Size = new System.Drawing.Size(145, 36);
            this.rjbtnOK.TabIndex = 1;
            this.rjbtnOK.Text = "Xác nhận";
            this.rjbtnOK.TextColor = System.Drawing.Color.White;
            this.rjbtnOK.UseVisualStyleBackColor = false;
            this.rjbtnOK.Click += new System.EventHandler(this.RjbtnOK_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.White;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // lblConfirmPhone
            // 
            this.lblConfirmPhone.AutoSize = true;
            this.lblConfirmPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPhone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConfirmPhone.Location = new System.Drawing.Point(73, 197);
            this.lblConfirmPhone.Name = "lblConfirmPhone";
            this.lblConfirmPhone.Size = new System.Drawing.Size(87, 19);
            this.lblConfirmPhone.TabIndex = 12;
            this.lblConfirmPhone.Text = "Nhập SĐT";
            this.lblConfirmPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.label2);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(749, 41);
            this.panelTitleBar.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.shield;
            this.pictureBox1.Location = new System.Drawing.Point(183, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xác thực khách hàng";
            // 
            // rjbtnCancel
            // 
            this.rjbtnCancel.BackColor = System.Drawing.Color.DimGray;
            this.rjbtnCancel.BackgroundColor = System.Drawing.Color.DimGray;
            this.rjbtnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnCancel.BorderRadius = 15;
            this.rjbtnCancel.BorderSize = 0;
            this.rjbtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnCancel.FlatAppearance.BorderSize = 0;
            this.rjbtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnCancel.ForeColor = System.Drawing.Color.White;
            this.rjbtnCancel.Location = new System.Drawing.Point(510, 370);
            this.rjbtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnCancel.Name = "rjbtnCancel";
            this.rjbtnCancel.Size = new System.Drawing.Size(145, 36);
            this.rjbtnCancel.TabIndex = 3;
            this.rjbtnCancel.Text = "Hủy";
            this.rjbtnCancel.TextColor = System.Drawing.Color.White;
            this.rjbtnCancel.UseVisualStyleBackColor = false;
            this.rjbtnCancel.Click += new System.EventHandler(this.RjbtnCancel_Click);
            // 
            // msgValidatePass
            // 
            this.msgValidatePass.AutoSize = true;
            this.msgValidatePass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidatePass.Location = new System.Drawing.Point(185, 205);
            this.msgValidatePass.Name = "msgValidatePass";
            this.msgValidatePass.Size = new System.Drawing.Size(0, 16);
            this.msgValidatePass.TabIndex = 55;
            // 
            // rjbtnAdd
            // 
            this.rjbtnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rjbtnAdd.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.rjbtnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnAdd.BorderRadius = 15;
            this.rjbtnAdd.BorderSize = 0;
            this.rjbtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnAdd.FlatAppearance.BorderSize = 0;
            this.rjbtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnAdd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnAdd.ForeColor = System.Drawing.Color.White;
            this.rjbtnAdd.Location = new System.Drawing.Point(297, 370);
            this.rjbtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnAdd.Name = "rjbtnAdd";
            this.rjbtnAdd.Size = new System.Drawing.Size(145, 36);
            this.rjbtnAdd.TabIndex = 2;
            this.rjbtnAdd.Text = "Thêm mới";
            this.rjbtnAdd.TextColor = System.Drawing.Color.White;
            this.rjbtnAdd.UseVisualStyleBackColor = false;
            this.rjbtnAdd.Click += new System.EventHandler(this.RjbtnAdd_Click);
            // 
            // FormAuthenticateCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.rjbtnAdd);
            this.Controls.Add(this.msgValidatePass);
            this.Controls.Add(this.rjbtnCancel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.lblConfirmPhone);
            this.Controls.Add(this.rjbtnOK);
            this.Controls.Add(this.tbConfirmPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAuthenticateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAuthenticateCustomer_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbConfirmPhone;
        private RJButton rjbtnOK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label lblConfirmPhone;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private RJButton rjbtnCancel;
        private System.Windows.Forms.Label msgValidatePass;
        private RJButton rjbtnAdd;
    }
}