namespace DoAnPBL3
{
    partial class FormAddKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddKH));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.msgValidateAddress = new System.Windows.Forms.Label();
            this.msgValidatePhone = new System.Windows.Forms.Label();
            this.msgValidateGender = new System.Windows.Forms.Label();
            this.msgValidateName = new System.Windows.Forms.Label();
            this.rjbtnCancel = new DoAnPBL3.RJButton();
            this.rjbtnOK = new DoAnPBL3.RJButton();
            this.tbPhoneKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAddressKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNameKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhoneKH = new System.Windows.Forms.Label();
            this.lblAddressKH = new System.Windows.Forms.Label();
            this.lblGenderKH = new System.Windows.Forms.Label();
            this.lblNameKH = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cbbGenderKH = new DoAnPBL3.RJComboBox();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(812, 41);
            this.panelTitleBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(195, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thêm khách hàng mới";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.panelContainer.Controls.Add(this.cbbGenderKH);
            this.panelContainer.Controls.Add(this.msgValidateAddress);
            this.panelContainer.Controls.Add(this.msgValidatePhone);
            this.panelContainer.Controls.Add(this.msgValidateGender);
            this.panelContainer.Controls.Add(this.msgValidateName);
            this.panelContainer.Controls.Add(this.rjbtnCancel);
            this.panelContainer.Controls.Add(this.rjbtnOK);
            this.panelContainer.Controls.Add(this.tbPhoneKH);
            this.panelContainer.Controls.Add(this.tbAddressKH);
            this.panelContainer.Controls.Add(this.tbNameKH);
            this.panelContainer.Controls.Add(this.lblPhoneKH);
            this.panelContainer.Controls.Add(this.lblAddressKH);
            this.panelContainer.Controls.Add(this.lblGenderKH);
            this.panelContainer.Controls.Add(this.lblNameKH);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(812, 471);
            this.panelContainer.TabIndex = 1;
            // 
            // msgValidateAddress
            // 
            this.msgValidateAddress.AutoSize = true;
            this.msgValidateAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateAddress.Location = new System.Drawing.Point(194, 332);
            this.msgValidateAddress.Name = "msgValidateAddress";
            this.msgValidateAddress.Size = new System.Drawing.Size(0, 16);
            this.msgValidateAddress.TabIndex = 58;
            // 
            // msgValidatePhone
            // 
            this.msgValidatePhone.AutoSize = true;
            this.msgValidatePhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidatePhone.Location = new System.Drawing.Point(194, 257);
            this.msgValidatePhone.Name = "msgValidatePhone";
            this.msgValidatePhone.Size = new System.Drawing.Size(0, 16);
            this.msgValidatePhone.TabIndex = 57;
            // 
            // msgValidateGender
            // 
            this.msgValidateGender.AutoSize = true;
            this.msgValidateGender.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateGender.Location = new System.Drawing.Point(194, 186);
            this.msgValidateGender.Name = "msgValidateGender";
            this.msgValidateGender.Size = new System.Drawing.Size(0, 16);
            this.msgValidateGender.TabIndex = 56;
            // 
            // msgValidateName
            // 
            this.msgValidateName.AutoSize = true;
            this.msgValidateName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateName.Location = new System.Drawing.Point(194, 113);
            this.msgValidateName.Name = "msgValidateName";
            this.msgValidateName.Size = new System.Drawing.Size(0, 16);
            this.msgValidateName.TabIndex = 55;
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
            this.rjbtnCancel.Location = new System.Drawing.Point(432, 395);
            this.rjbtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnCancel.Name = "rjbtnCancel";
            this.rjbtnCancel.Size = new System.Drawing.Size(145, 36);
            this.rjbtnCancel.TabIndex = 6;
            this.rjbtnCancel.Text = "Hủy";
            this.rjbtnCancel.TextColor = System.Drawing.Color.White;
            this.rjbtnCancel.UseVisualStyleBackColor = false;
            this.rjbtnCancel.Click += new System.EventHandler(this.RjbtnCancel_Click);
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
            this.rjbtnOK.Location = new System.Drawing.Point(232, 395);
            this.rjbtnOK.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnOK.Name = "rjbtnOK";
            this.rjbtnOK.Size = new System.Drawing.Size(145, 36);
            this.rjbtnOK.TabIndex = 5;
            this.rjbtnOK.Text = "OK";
            this.rjbtnOK.TextColor = System.Drawing.Color.White;
            this.rjbtnOK.UseVisualStyleBackColor = false;
            this.rjbtnOK.Click += new System.EventHandler(this.RjbtnOK_Click);
            // 
            // tbPhoneKH
            // 
            this.tbPhoneKH.Animated = true;
            this.tbPhoneKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbPhoneKH.BorderRadius = 6;
            this.tbPhoneKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneKH.DefaultText = "";
            this.tbPhoneKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbPhoneKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbPhoneKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbPhoneKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbPhoneKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbPhoneKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPhoneKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbPhoneKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneKH.Location = new System.Drawing.Point(197, 223);
            this.tbPhoneKH.Name = "tbPhoneKH";
            this.tbPhoneKH.PasswordChar = '\0';
            this.tbPhoneKH.PlaceholderText = "Nhập số điện thoại";
            this.tbPhoneKH.SelectedText = "";
            this.tbPhoneKH.Size = new System.Drawing.Size(487, 30);
            this.tbPhoneKH.TabIndex = 3;
            this.tbPhoneKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPhoneKH_KeyPress);
            // 
            // tbAddressKH
            // 
            this.tbAddressKH.Animated = true;
            this.tbAddressKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressKH.BorderRadius = 6;
            this.tbAddressKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddressKH.DefaultText = "";
            this.tbAddressKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbAddressKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAddressKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressKH.Location = new System.Drawing.Point(197, 299);
            this.tbAddressKH.Name = "tbAddressKH";
            this.tbAddressKH.PasswordChar = '\0';
            this.tbAddressKH.PlaceholderText = "Nhập địa chỉ";
            this.tbAddressKH.SelectedText = "";
            this.tbAddressKH.Size = new System.Drawing.Size(487, 30);
            this.tbAddressKH.TabIndex = 4;
            this.tbAddressKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbAddressKH_KeyPress);
            // 
            // tbNameKH
            // 
            this.tbNameKH.Animated = true;
            this.tbNameKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.BorderRadius = 6;
            this.tbNameKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameKH.DefaultText = "";
            this.tbNameKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbNameKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbNameKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameKH.Location = new System.Drawing.Point(197, 80);
            this.tbNameKH.Name = "tbNameKH";
            this.tbNameKH.PasswordChar = '\0';
            this.tbNameKH.PlaceholderText = "Nhập họ và tên";
            this.tbNameKH.SelectedText = "";
            this.tbNameKH.Size = new System.Drawing.Size(487, 30);
            this.tbNameKH.TabIndex = 1;
            this.tbNameKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNameKH_KeyPress);
            // 
            // lblPhoneKH
            // 
            this.lblPhoneKH.AutoSize = true;
            this.lblPhoneKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneKH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPhoneKH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhoneKH.Location = new System.Drawing.Point(67, 227);
            this.lblPhoneKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneKH.Name = "lblPhoneKH";
            this.lblPhoneKH.Size = new System.Drawing.Size(86, 19);
            this.lblPhoneKH.TabIndex = 27;
            this.lblPhoneKH.Text = "Điện thoại";
            // 
            // lblAddressKH
            // 
            this.lblAddressKH.AutoSize = true;
            this.lblAddressKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressKH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddressKH.Location = new System.Drawing.Point(67, 303);
            this.lblAddressKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressKH.Name = "lblAddressKH";
            this.lblAddressKH.Size = new System.Drawing.Size(61, 19);
            this.lblAddressKH.TabIndex = 25;
            this.lblAddressKH.Text = "Địa chỉ";
            // 
            // lblGenderKH
            // 
            this.lblGenderKH.AutoSize = true;
            this.lblGenderKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderKH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGenderKH.Location = new System.Drawing.Point(67, 156);
            this.lblGenderKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenderKH.Name = "lblGenderKH";
            this.lblGenderKH.Size = new System.Drawing.Size(73, 19);
            this.lblGenderKH.TabIndex = 24;
            this.lblGenderKH.Text = "Giới tính";
            // 
            // lblNameKH
            // 
            this.lblNameKH.AutoSize = true;
            this.lblNameKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameKH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNameKH.Location = new System.Drawing.Point(67, 85);
            this.lblNameKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameKH.Name = "lblNameKH";
            this.lblNameKH.Size = new System.Drawing.Size(81, 19);
            this.lblNameKH.TabIndex = 22;
            this.lblNameKH.Text = "Họ và tên";
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
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this;
            // 
            // cbbGenderKH
            // 
            this.cbbGenderKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.cbbGenderKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cbbGenderKH.BorderSize = 2;
            this.cbbGenderKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenderKH.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGenderKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cbbGenderKH.IconColor = System.Drawing.Color.RoyalBlue;
            this.cbbGenderKH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGenderKH.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.cbbGenderKH.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cbbGenderKH.Location = new System.Drawing.Point(195, 149);
            this.cbbGenderKH.MinimumSize = new System.Drawing.Size(188, 29);
            this.cbbGenderKH.Name = "cbbGenderKH";
            this.cbbGenderKH.Padding = new System.Windows.Forms.Padding(2);
            this.cbbGenderKH.Size = new System.Drawing.Size(489, 32);
            this.cbbGenderKH.TabIndex = 65;
            this.cbbGenderKH.Texts = "Chọn giới tính";
            // 
            // FormAddKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 471);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khách hàng";
            this.Load += new System.EventHandler(this.FormAddKH_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2TextBox tbPhoneKH;
        private Guna.UI2.WinForms.Guna2TextBox tbAddressKH;
        private Guna.UI2.WinForms.Guna2TextBox tbNameKH;
        private System.Windows.Forms.Label lblPhoneKH;
        private System.Windows.Forms.Label lblAddressKH;
        private System.Windows.Forms.Label lblGenderKH;
        private System.Windows.Forms.Label lblNameKH;
        private RJButton rjbtnCancel;
        private RJButton rjbtnOK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label msgValidateName;
        private System.Windows.Forms.Label msgValidateAddress;
        private System.Windows.Forms.Label msgValidatePhone;
        private System.Windows.Forms.Label msgValidateGender;
        private RJComboBox cbbGenderKH;
    }
}