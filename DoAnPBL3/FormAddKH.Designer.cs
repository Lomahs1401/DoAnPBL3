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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.rjbtnCancel = new DoAnPBL3.RJButton();
            this.rjbtnOK = new DoAnPBL3.RJButton();
            this.tbEmailKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSDTKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAddressKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCMNDKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbBDKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNameKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbGenderKh = new DoAnPBL3.RJComboBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblNameNV = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
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
            this.panelContainer.Controls.Add(this.rjbtnCancel);
            this.panelContainer.Controls.Add(this.rjbtnOK);
            this.panelContainer.Controls.Add(this.tbEmailKH);
            this.panelContainer.Controls.Add(this.tbSDTKH);
            this.panelContainer.Controls.Add(this.tbAddressKH);
            this.panelContainer.Controls.Add(this.tbCMNDKH);
            this.panelContainer.Controls.Add(this.tbBDKH);
            this.panelContainer.Controls.Add(this.tbNameKH);
            this.panelContainer.Controls.Add(this.cbGenderKh);
            this.panelContainer.Controls.Add(this.lblCMND);
            this.panelContainer.Controls.Add(this.lblEmail);
            this.panelContainer.Controls.Add(this.lblSDT);
            this.panelContainer.Controls.Add(this.lblAddress);
            this.panelContainer.Controls.Add(this.lblGender);
            this.panelContainer.Controls.Add(this.lblBD);
            this.panelContainer.Controls.Add(this.lblNameNV);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(812, 686);
            this.panelContainer.TabIndex = 1;
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
            this.rjbtnCancel.Location = new System.Drawing.Point(444, 605);
            this.rjbtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnCancel.Name = "rjbtnCancel";
            this.rjbtnCancel.Size = new System.Drawing.Size(145, 36);
            this.rjbtnCancel.TabIndex = 37;
            this.rjbtnCancel.Text = "Hủy";
            this.rjbtnCancel.TextColor = System.Drawing.Color.White;
            this.rjbtnCancel.UseVisualStyleBackColor = false;
            this.rjbtnCancel.Click += new System.EventHandler(this.rjbtnCancel_Click);
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
            this.rjbtnOK.Location = new System.Drawing.Point(240, 605);
            this.rjbtnOK.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnOK.Name = "rjbtnOK";
            this.rjbtnOK.Size = new System.Drawing.Size(145, 36);
            this.rjbtnOK.TabIndex = 36;
            this.rjbtnOK.Text = "OK";
            this.rjbtnOK.TextColor = System.Drawing.Color.White;
            this.rjbtnOK.UseVisualStyleBackColor = false;
            this.rjbtnOK.Click += new System.EventHandler(this.rjbtnOK_Click);
            // 
            // tbEmailKH
            // 
            this.tbEmailKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbEmailKH.BorderRadius = 6;
            this.tbEmailKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmailKH.DefaultText = "";
            this.tbEmailKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbEmailKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbEmailKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbEmailKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbEmailKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailKH.Location = new System.Drawing.Point(197, 470);
            this.tbEmailKH.Name = "tbEmailKH";
            this.tbEmailKH.PasswordChar = '\0';
            this.tbEmailKH.PlaceholderText = "Nhập email";
            this.tbEmailKH.SelectedText = "";
            this.tbEmailKH.Size = new System.Drawing.Size(487, 30);
            this.tbEmailKH.TabIndex = 35;
            // 
            // tbSDTKH
            // 
            this.tbSDTKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbSDTKH.BorderRadius = 6;
            this.tbSDTKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSDTKH.DefaultText = "";
            this.tbSDTKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbSDTKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbSDTKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSDTKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbSDTKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbSDTKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSDTKH.Location = new System.Drawing.Point(197, 404);
            this.tbSDTKH.Name = "tbSDTKH";
            this.tbSDTKH.PasswordChar = '\0';
            this.tbSDTKH.PlaceholderText = "Nhập số điện thoại";
            this.tbSDTKH.SelectedText = "";
            this.tbSDTKH.Size = new System.Drawing.Size(487, 30);
            this.tbSDTKH.TabIndex = 34;
            // 
            // tbAddressKH
            // 
            this.tbAddressKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
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
            this.tbAddressKH.Location = new System.Drawing.Point(197, 338);
            this.tbAddressKH.Name = "tbAddressKH";
            this.tbAddressKH.PasswordChar = '\0';
            this.tbAddressKH.PlaceholderText = "Nhập địa chỉ";
            this.tbAddressKH.SelectedText = "";
            this.tbAddressKH.Size = new System.Drawing.Size(487, 30);
            this.tbAddressKH.TabIndex = 33;
            // 
            // tbCMNDKH
            // 
            this.tbCMNDKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbCMNDKH.BorderRadius = 6;
            this.tbCMNDKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCMNDKH.DefaultText = "";
            this.tbCMNDKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbCMNDKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbCMNDKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMNDKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbCMNDKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbCMNDKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCMNDKH.Location = new System.Drawing.Point(197, 270);
            this.tbCMNDKH.Name = "tbCMNDKH";
            this.tbCMNDKH.PasswordChar = '\0';
            this.tbCMNDKH.PlaceholderText = "Nhập CMND";
            this.tbCMNDKH.SelectedText = "";
            this.tbCMNDKH.Size = new System.Drawing.Size(487, 30);
            this.tbCMNDKH.TabIndex = 32;
            // 
            // tbBDKH
            // 
            this.tbBDKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbBDKH.BorderRadius = 6;
            this.tbBDKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBDKH.DefaultText = "";
            this.tbBDKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBDKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbBDKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbBDKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbBDKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbBDKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBDKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbBDKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbBDKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBDKH.Location = new System.Drawing.Point(197, 142);
            this.tbBDKH.Name = "tbBDKH";
            this.tbBDKH.PasswordChar = '\0';
            this.tbBDKH.PlaceholderText = "Nhập ngày sinh";
            this.tbBDKH.SelectedText = "";
            this.tbBDKH.Size = new System.Drawing.Size(487, 30);
            this.tbBDKH.TabIndex = 31;
            // 
            // tbNameKH
            // 
            this.tbNameKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
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
            this.tbNameKH.TabIndex = 30;
            // 
            // cbGenderKh
            // 
            this.cbGenderKh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.cbGenderKh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.cbGenderKh.BorderSize = 2;
            this.cbGenderKh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenderKh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenderKh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cbGenderKh.IconColor = System.Drawing.Color.RoyalBlue;
            this.cbGenderKh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Giới tính thứ 3"});
            this.cbGenderKh.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.cbGenderKh.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.cbGenderKh.Location = new System.Drawing.Point(197, 204);
            this.cbGenderKh.MinimumSize = new System.Drawing.Size(188, 29);
            this.cbGenderKh.Name = "cbGenderKh";
            this.cbGenderKh.Padding = new System.Windows.Forms.Padding(2);
            this.cbGenderKh.Size = new System.Drawing.Size(487, 32);
            this.cbGenderKh.TabIndex = 29;
            this.cbGenderKh.Texts = "Giới tính";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCMND.Location = new System.Drawing.Point(67, 275);
            this.lblCMND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(58, 19);
            this.lblCMND.TabIndex = 26;
            this.lblCMND.Text = "CMND";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Location = new System.Drawing.Point(67, 475);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 19);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSDT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSDT.Location = new System.Drawing.Point(67, 408);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(86, 19);
            this.lblSDT.TabIndex = 27;
            this.lblSDT.Text = "Điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddress.Location = new System.Drawing.Point(67, 342);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 19);
            this.lblAddress.TabIndex = 25;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGender.Location = new System.Drawing.Point(67, 209);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(73, 19);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "Giới tính";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBD.Location = new System.Drawing.Point(67, 147);
            this.lblBD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(86, 19);
            this.lblBD.TabIndex = 23;
            this.lblBD.Text = "Ngày sinh";
            // 
            // lblNameNV
            // 
            this.lblNameNV.AutoSize = true;
            this.lblNameNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameNV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNameNV.Location = new System.Drawing.Point(67, 85);
            this.lblNameNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameNV.Name = "lblNameNV";
            this.lblNameNV.Size = new System.Drawing.Size(81, 19);
            this.lblNameNV.TabIndex = 22;
            this.lblNameNV.Text = "Họ và tên";
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
            this.guna2Elipse1.TargetControl = this.cbGenderKh;
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
            // FormAddKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 686);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm khách hàng";
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
        private Guna.UI2.WinForms.Guna2TextBox tbEmailKH;
        private Guna.UI2.WinForms.Guna2TextBox tbSDTKH;
        private Guna.UI2.WinForms.Guna2TextBox tbAddressKH;
        private Guna.UI2.WinForms.Guna2TextBox tbCMNDKH;
        private Guna.UI2.WinForms.Guna2TextBox tbBDKH;
        private Guna.UI2.WinForms.Guna2TextBox tbNameKH;
        private RJComboBox cbGenderKh;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblNameNV;
        private RJButton rjbtnCancel;
        private RJButton rjbtnOK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}