
namespace DoAnPBL3
{
    partial class FormSuaNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuaNV));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rjbtnOK = new DoAnPBL3.RJButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.msgValidateStartDate = new System.Windows.Forms.Label();
            this.tbStartDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnDeleteImg = new DoAnPBL3.RJButton();
            this.rjbtnCancel = new DoAnPBL3.RJButton();
            this.avatar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.msgValidateAddress = new System.Windows.Forms.Label();
            this.msgValidateIDCard = new System.Windows.Forms.Label();
            this.msgValidatePhone = new System.Windows.Forms.Label();
            this.msgValidateGender = new System.Windows.Forms.Label();
            this.msgValidateDateOfBirth = new System.Windows.Forms.Label();
            this.msgValidateEmail = new System.Windows.Forms.Label();
            this.msgValidateName = new System.Windows.Forms.Label();
            this.btnNVImg = new DoAnPBL3.RJButton();
            this.tbEmailNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSDTNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAddressNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCMNDNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbBD = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNameNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbGenderNV = new DoAnPBL3.RJComboBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblNameNV = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(851, 41);
            this.panelTitleBar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.pencil;
            this.pictureBox1.Location = new System.Drawing.Point(204, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sửa thông tin nhân viên";
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
            this.rjbtnOK.Location = new System.Drawing.Point(240, 617);
            this.rjbtnOK.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnOK.Name = "rjbtnOK";
            this.rjbtnOK.Size = new System.Drawing.Size(145, 36);
            this.rjbtnOK.TabIndex = 10;
            this.rjbtnOK.Text = "Lưu";
            this.rjbtnOK.TextColor = System.Drawing.Color.White;
            this.rjbtnOK.UseVisualStyleBackColor = false;
            this.rjbtnOK.Click += new System.EventHandler(this.RjbtnOK_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.panelContainer.Controls.Add(this.msgValidateStartDate);
            this.panelContainer.Controls.Add(this.tbStartDate);
            this.panelContainer.Controls.Add(this.lblStartDate);
            this.panelContainer.Controls.Add(this.btnDeleteImg);
            this.panelContainer.Controls.Add(this.rjbtnCancel);
            this.panelContainer.Controls.Add(this.avatar);
            this.panelContainer.Controls.Add(this.msgValidateAddress);
            this.panelContainer.Controls.Add(this.msgValidateIDCard);
            this.panelContainer.Controls.Add(this.msgValidatePhone);
            this.panelContainer.Controls.Add(this.msgValidateGender);
            this.panelContainer.Controls.Add(this.msgValidateDateOfBirth);
            this.panelContainer.Controls.Add(this.msgValidateEmail);
            this.panelContainer.Controls.Add(this.msgValidateName);
            this.panelContainer.Controls.Add(this.btnNVImg);
            this.panelContainer.Controls.Add(this.tbEmailNV);
            this.panelContainer.Controls.Add(this.tbSDTNV);
            this.panelContainer.Controls.Add(this.tbAddressNV);
            this.panelContainer.Controls.Add(this.tbCMNDNV);
            this.panelContainer.Controls.Add(this.tbBD);
            this.panelContainer.Controls.Add(this.tbNameNV);
            this.panelContainer.Controls.Add(this.cbGenderNV);
            this.panelContainer.Controls.Add(this.lblCMND);
            this.panelContainer.Controls.Add(this.lblEmail);
            this.panelContainer.Controls.Add(this.lblSDT);
            this.panelContainer.Controls.Add(this.lblAddress);
            this.panelContainer.Controls.Add(this.lblGender);
            this.panelContainer.Controls.Add(this.lblBD);
            this.panelContainer.Controls.Add(this.lblNameNV);
            this.panelContainer.Controls.Add(this.rjbtnOK);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.Location = new System.Drawing.Point(0, 41);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(851, 700);
            this.panelContainer.TabIndex = 4;
            // 
            // msgValidateStartDate
            // 
            this.msgValidateStartDate.AutoSize = true;
            this.msgValidateStartDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateStartDate.Location = new System.Drawing.Point(405, 278);
            this.msgValidateStartDate.Name = "msgValidateStartDate";
            this.msgValidateStartDate.Size = new System.Drawing.Size(0, 16);
            this.msgValidateStartDate.TabIndex = 79;
            // 
            // tbStartDate
            // 
            this.tbStartDate.Animated = true;
            this.tbStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbStartDate.BorderRadius = 6;
            this.tbStartDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStartDate.DefaultText = "";
            this.tbStartDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbStartDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbStartDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbStartDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbStartDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStartDate.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbStartDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStartDate.Location = new System.Drawing.Point(396, 245);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.PasswordChar = '\0';
            this.tbStartDate.PlaceholderText = "Nhập ngày bắt đầu";
            this.tbStartDate.SelectedText = "";
            this.tbStartDate.Size = new System.Drawing.Size(409, 30);
            this.tbStartDate.TabIndex = 3;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStartDate.Location = new System.Drawing.Point(287, 251);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(101, 18);
            this.lblStartDate.TabIndex = 77;
            this.lblStartDate.Text = "Ngày vào làm";
            // 
            // btnDeleteImg
            // 
            this.btnDeleteImg.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteImg.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnDeleteImg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteImg.BorderRadius = 20;
            this.btnDeleteImg.BorderSize = 0;
            this.btnDeleteImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteImg.FlatAppearance.BorderSize = 0;
            this.btnDeleteImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteImg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteImg.ForeColor = System.Drawing.Color.White;
            this.btnDeleteImg.Image = global::DoAnPBL3.Properties.Resources.delete_30px;
            this.btnDeleteImg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteImg.Location = new System.Drawing.Point(143, 313);
            this.btnDeleteImg.Name = "btnDeleteImg";
            this.btnDeleteImg.Size = new System.Drawing.Size(110, 40);
            this.btnDeleteImg.TabIndex = 9;
            this.btnDeleteImg.Text = "Xóa ảnh";
            this.btnDeleteImg.TextColor = System.Drawing.Color.White;
            this.btnDeleteImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteImg.UseVisualStyleBackColor = false;
            this.btnDeleteImg.Click += new System.EventHandler(this.BtnDeleteImg_Click);
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
            this.rjbtnCancel.Location = new System.Drawing.Point(444, 617);
            this.rjbtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnCancel.Name = "rjbtnCancel";
            this.rjbtnCancel.Size = new System.Drawing.Size(145, 36);
            this.rjbtnCancel.TabIndex = 11;
            this.rjbtnCancel.Text = "Hủy";
            this.rjbtnCancel.TextColor = System.Drawing.Color.White;
            this.rjbtnCancel.UseVisualStyleBackColor = false;
            this.rjbtnCancel.Click += new System.EventHandler(this.RjbtnCancel_Click);
            // 
            // avatar
            // 
            this.avatar.ErrorImage = null;
            this.avatar.ImageRotate = 0F;
            this.avatar.Location = new System.Drawing.Point(11, 42);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(242, 240);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 74;
            this.avatar.TabStop = false;
            // 
            // msgValidateAddress
            // 
            this.msgValidateAddress.AutoSize = true;
            this.msgValidateAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateAddress.Location = new System.Drawing.Point(405, 559);
            this.msgValidateAddress.Name = "msgValidateAddress";
            this.msgValidateAddress.Size = new System.Drawing.Size(0, 16);
            this.msgValidateAddress.TabIndex = 73;
            // 
            // msgValidateIDCard
            // 
            this.msgValidateIDCard.AutoSize = true;
            this.msgValidateIDCard.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateIDCard.Location = new System.Drawing.Point(405, 491);
            this.msgValidateIDCard.Name = "msgValidateIDCard";
            this.msgValidateIDCard.Size = new System.Drawing.Size(0, 16);
            this.msgValidateIDCard.TabIndex = 72;
            // 
            // msgValidatePhone
            // 
            this.msgValidatePhone.AutoSize = true;
            this.msgValidatePhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidatePhone.Location = new System.Drawing.Point(405, 419);
            this.msgValidatePhone.Name = "msgValidatePhone";
            this.msgValidatePhone.Size = new System.Drawing.Size(0, 16);
            this.msgValidatePhone.TabIndex = 71;
            // 
            // msgValidateGender
            // 
            this.msgValidateGender.AutoSize = true;
            this.msgValidateGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateGender.Location = new System.Drawing.Point(405, 351);
            this.msgValidateGender.Name = "msgValidateGender";
            this.msgValidateGender.Size = new System.Drawing.Size(0, 16);
            this.msgValidateGender.TabIndex = 70;
            // 
            // msgValidateDateOfBirth
            // 
            this.msgValidateDateOfBirth.AutoSize = true;
            this.msgValidateDateOfBirth.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateDateOfBirth.Location = new System.Drawing.Point(405, 209);
            this.msgValidateDateOfBirth.Name = "msgValidateDateOfBirth";
            this.msgValidateDateOfBirth.Size = new System.Drawing.Size(0, 16);
            this.msgValidateDateOfBirth.TabIndex = 69;
            // 
            // msgValidateEmail
            // 
            this.msgValidateEmail.AutoSize = true;
            this.msgValidateEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateEmail.Location = new System.Drawing.Point(405, 139);
            this.msgValidateEmail.Name = "msgValidateEmail";
            this.msgValidateEmail.Size = new System.Drawing.Size(0, 16);
            this.msgValidateEmail.TabIndex = 68;
            // 
            // msgValidateName
            // 
            this.msgValidateName.AutoSize = true;
            this.msgValidateName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateName.Location = new System.Drawing.Point(405, 70);
            this.msgValidateName.Name = "msgValidateName";
            this.msgValidateName.Size = new System.Drawing.Size(0, 16);
            this.msgValidateName.TabIndex = 67;
            // 
            // btnNVImg
            // 
            this.btnNVImg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNVImg.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnNVImg.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNVImg.BorderRadius = 20;
            this.btnNVImg.BorderSize = 0;
            this.btnNVImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNVImg.FlatAppearance.BorderSize = 0;
            this.btnNVImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNVImg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVImg.ForeColor = System.Drawing.Color.White;
            this.btnNVImg.Image = global::DoAnPBL3.Properties.Resources.icons8_picture_30px;
            this.btnNVImg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNVImg.Location = new System.Drawing.Point(10, 313);
            this.btnNVImg.Name = "btnNVImg";
            this.btnNVImg.Size = new System.Drawing.Size(110, 40);
            this.btnNVImg.TabIndex = 8;
            this.btnNVImg.Text = "Chọn ảnh";
            this.btnNVImg.TextColor = System.Drawing.Color.White;
            this.btnNVImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNVImg.UseVisualStyleBackColor = false;
            this.btnNVImg.Click += new System.EventHandler(this.BtnNVImg_Click);
            // 
            // tbEmailNV
            // 
            this.tbEmailNV.Animated = true;
            this.tbEmailNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailNV.BorderRadius = 6;
            this.tbEmailNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmailNV.DefaultText = "";
            this.tbEmailNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbEmailNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailNV.Location = new System.Drawing.Point(396, 106);
            this.tbEmailNV.Name = "tbEmailNV";
            this.tbEmailNV.PasswordChar = '\0';
            this.tbEmailNV.PlaceholderText = "Nhập email";
            this.tbEmailNV.SelectedText = "";
            this.tbEmailNV.Size = new System.Drawing.Size(409, 30);
            this.tbEmailNV.TabIndex = 1;
            this.tbEmailNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbEmailNV_KeyPress);
            // 
            // tbSDTNV
            // 
            this.tbSDTNV.Animated = true;
            this.tbSDTNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTNV.BorderRadius = 6;
            this.tbSDTNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSDTNV.DefaultText = "";
            this.tbSDTNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSDTNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbSDTNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSDTNV.Location = new System.Drawing.Point(396, 386);
            this.tbSDTNV.Name = "tbSDTNV";
            this.tbSDTNV.PasswordChar = '\0';
            this.tbSDTNV.PlaceholderText = "Nhập số điện thoại";
            this.tbSDTNV.SelectedText = "";
            this.tbSDTNV.Size = new System.Drawing.Size(409, 30);
            this.tbSDTNV.TabIndex = 5;
            this.tbSDTNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSDTNV_KeyPress);
            // 
            // tbAddressNV
            // 
            this.tbAddressNV.Animated = true;
            this.tbAddressNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressNV.BorderRadius = 6;
            this.tbAddressNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddressNV.DefaultText = "";
            this.tbAddressNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAddressNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressNV.Location = new System.Drawing.Point(396, 526);
            this.tbAddressNV.Name = "tbAddressNV";
            this.tbAddressNV.PasswordChar = '\0';
            this.tbAddressNV.PlaceholderText = "Nhập địa chỉ";
            this.tbAddressNV.SelectedText = "";
            this.tbAddressNV.Size = new System.Drawing.Size(409, 30);
            this.tbAddressNV.TabIndex = 7;
            this.tbAddressNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbAddressNV_KeyPress);
            // 
            // tbCMNDNV
            // 
            this.tbCMNDNV.Animated = true;
            this.tbCMNDNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDNV.BorderRadius = 6;
            this.tbCMNDNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCMNDNV.DefaultText = "";
            this.tbCMNDNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMNDNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbCMNDNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMNDNV.Location = new System.Drawing.Point(396, 458);
            this.tbCMNDNV.Name = "tbCMNDNV";
            this.tbCMNDNV.PasswordChar = '\0';
            this.tbCMNDNV.PlaceholderText = "Nhập CMND";
            this.tbCMNDNV.SelectedText = "";
            this.tbCMNDNV.Size = new System.Drawing.Size(409, 30);
            this.tbCMNDNV.TabIndex = 6;
            this.tbCMNDNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCMNDNV_KeyPress);
            // 
            // tbBD
            // 
            this.tbBD.Animated = true;
            this.tbBD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbBD.BorderRadius = 6;
            this.tbBD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBD.DefaultText = "";
            this.tbBD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbBD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbBD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBD.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbBD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBD.Location = new System.Drawing.Point(396, 176);
            this.tbBD.Name = "tbBD";
            this.tbBD.PasswordChar = '\0';
            this.tbBD.PlaceholderText = "Nhập ngày sinh";
            this.tbBD.SelectedText = "";
            this.tbBD.Size = new System.Drawing.Size(409, 30);
            this.tbBD.TabIndex = 2;
            this.tbBD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbBD_KeyPress);
            // 
            // tbNameNV
            // 
            this.tbNameNV.Animated = true;
            this.tbNameNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameNV.BorderRadius = 6;
            this.tbNameNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameNV.DefaultText = "";
            this.tbNameNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbNameNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameNV.Location = new System.Drawing.Point(396, 37);
            this.tbNameNV.Name = "tbNameNV";
            this.tbNameNV.PasswordChar = '\0';
            this.tbNameNV.PlaceholderText = "Nhập họ và tên";
            this.tbNameNV.SelectedText = "";
            this.tbNameNV.Size = new System.Drawing.Size(409, 30);
            this.tbNameNV.TabIndex = 0;
            this.tbNameNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNameNV_KeyPress);
            // 
            // cbGenderNV
            // 
            this.cbGenderNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.cbGenderNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cbGenderNV.BorderSize = 2;
            this.cbGenderNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGenderNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenderNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenderNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cbGenderNV.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbGenderNV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGenderNV.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.cbGenderNV.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cbGenderNV.Location = new System.Drawing.Point(396, 316);
            this.cbGenderNV.MinimumSize = new System.Drawing.Size(188, 29);
            this.cbGenderNV.Name = "cbGenderNV";
            this.cbGenderNV.Padding = new System.Windows.Forms.Padding(2);
            this.cbGenderNV.Size = new System.Drawing.Size(409, 32);
            this.cbGenderNV.TabIndex = 4;
            this.cbGenderNV.Texts = "Giới tính";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCMND.Location = new System.Drawing.Point(287, 464);
            this.lblCMND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(54, 18);
            this.lblCMND.TabIndex = 61;
            this.lblCMND.Text = "CMND";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Location = new System.Drawing.Point(287, 111);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 18);
            this.lblEmail.TabIndex = 63;
            this.lblEmail.Text = "Email";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSDT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSDT.Location = new System.Drawing.Point(287, 390);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(80, 18);
            this.lblSDT.TabIndex = 60;
            this.lblSDT.Text = "Điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddress.Location = new System.Drawing.Point(287, 529);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 18);
            this.lblAddress.TabIndex = 58;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGender.Location = new System.Drawing.Point(287, 321);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(70, 18);
            this.lblGender.TabIndex = 56;
            this.lblGender.Text = "Giới tính";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBD.Location = new System.Drawing.Point(287, 181);
            this.lblBD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(77, 18);
            this.lblBD.TabIndex = 55;
            this.lblBD.Text = "Ngày sinh";
            // 
            // lblNameNV
            // 
            this.lblNameNV.AutoSize = true;
            this.lblNameNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameNV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNameNV.Location = new System.Drawing.Point(287, 42);
            this.lblNameNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameNV.Name = "lblNameNV";
            this.lblNameNV.Size = new System.Drawing.Size(76, 18);
            this.lblNameNV.TabIndex = 52;
            this.lblNameNV.Text = "Họ và tên";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTitleBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.panelContainer;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // FormSuaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 741);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSuaNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSuaNV";
            this.Load += new System.EventHandler(this.FormSuaNV_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private RJButton rjbtnOK;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2PictureBox avatar;
        private System.Windows.Forms.Label msgValidateAddress;
        private System.Windows.Forms.Label msgValidateIDCard;
        private System.Windows.Forms.Label msgValidatePhone;
        private System.Windows.Forms.Label msgValidateGender;
        private System.Windows.Forms.Label msgValidateDateOfBirth;
        private System.Windows.Forms.Label msgValidateEmail;
        private System.Windows.Forms.Label msgValidateName;
        private RJButton btnNVImg;
        private Guna.UI2.WinForms.Guna2TextBox tbEmailNV;
        private Guna.UI2.WinForms.Guna2TextBox tbSDTNV;
        private Guna.UI2.WinForms.Guna2TextBox tbAddressNV;
        private Guna.UI2.WinForms.Guna2TextBox tbCMNDNV;
        private Guna.UI2.WinForms.Guna2TextBox tbBD;
        private Guna.UI2.WinForms.Guna2TextBox tbNameNV;
        private RJComboBox cbGenderNV;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblNameNV;
        private RJButton rjbtnCancel;
        private RJButton btnDeleteImg;
        private System.Windows.Forms.Label msgValidateStartDate;
        private Guna.UI2.WinForms.Guna2TextBox tbStartDate;
        private System.Windows.Forms.Label lblStartDate;
    }
}