
namespace DoAnPBL3
{
    partial class FormTTKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTTKH));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tbStartDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.tbTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tbNumberOrder = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumberOrder = new System.Windows.Forms.Label();
            this.tbGenderKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPhoneKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAddressKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNameKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhoneKH = new System.Windows.Forms.Label();
            this.lblAddressKH = new System.Windows.Forms.Label();
            this.lblGenderKH = new System.Windows.Forms.Label();
            this.lblNameKH = new System.Windows.Forms.Label();
            this.rjbtnOK = new DoAnPBL3.RJButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
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
            this.panelTitleBar.Size = new System.Drawing.Size(812, 41);
            this.panelTitleBar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.customer_information;
            this.pictureBox1.Location = new System.Drawing.Point(181, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
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
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.panelContainer.Controls.Add(this.tbStartDate);
            this.panelContainer.Controls.Add(this.lblStartDate);
            this.panelContainer.Controls.Add(this.tbTotalPrice);
            this.panelContainer.Controls.Add(this.lblTotalPrice);
            this.panelContainer.Controls.Add(this.tbNumberOrder);
            this.panelContainer.Controls.Add(this.lblNumberOrder);
            this.panelContainer.Controls.Add(this.tbGenderKH);
            this.panelContainer.Controls.Add(this.tbPhoneKH);
            this.panelContainer.Controls.Add(this.tbAddressKH);
            this.panelContainer.Controls.Add(this.tbNameKH);
            this.panelContainer.Controls.Add(this.lblPhoneKH);
            this.panelContainer.Controls.Add(this.lblAddressKH);
            this.panelContainer.Controls.Add(this.lblGenderKH);
            this.panelContainer.Controls.Add(this.lblNameKH);
            this.panelContainer.Controls.Add(this.rjbtnOK);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.Location = new System.Drawing.Point(0, 41);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(812, 694);
            this.panelContainer.TabIndex = 4;
            // 
            // tbStartDate
            // 
            this.tbStartDate.AutoRoundedCorners = true;
            this.tbStartDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbStartDate.BorderRadius = 14;
            this.tbStartDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStartDate.DefaultText = "";
            this.tbStartDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbStartDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbStartDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbStartDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbStartDate.Enabled = false;
            this.tbStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbStartDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStartDate.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbStartDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStartDate.Location = new System.Drawing.Point(249, 385);
            this.tbStartDate.Name = "tbStartDate";
            this.tbStartDate.PasswordChar = '\0';
            this.tbStartDate.PlaceholderText = "Ngày tạo tài khoản";
            this.tbStartDate.SelectedText = "";
            this.tbStartDate.Size = new System.Drawing.Size(487, 30);
            this.tbStartDate.TabIndex = 76;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStartDate.Location = new System.Drawing.Point(82, 392);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(151, 19);
            this.lblStartDate.TabIndex = 77;
            this.lblStartDate.Text = "Ngày tạo tài khoản";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.AutoRoundedCorners = true;
            this.tbTotalPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbTotalPrice.BorderRadius = 14;
            this.tbTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotalPrice.DefaultText = "";
            this.tbTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbTotalPrice.Enabled = false;
            this.tbTotalPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotalPrice.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotalPrice.Location = new System.Drawing.Point(249, 540);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.PasswordChar = '\0';
            this.tbTotalPrice.PlaceholderText = "Tổng tiền";
            this.tbTotalPrice.SelectedText = "";
            this.tbTotalPrice.Size = new System.Drawing.Size(487, 30);
            this.tbTotalPrice.TabIndex = 5;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalPrice.Location = new System.Drawing.Point(82, 547);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(81, 19);
            this.lblTotalPrice.TabIndex = 75;
            this.lblTotalPrice.Text = "Tổng tiền";
            // 
            // tbNumberOrder
            // 
            this.tbNumberOrder.AutoRoundedCorners = true;
            this.tbNumberOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbNumberOrder.BorderRadius = 14;
            this.tbNumberOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNumberOrder.DefaultText = "";
            this.tbNumberOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNumberOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNumberOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNumberOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNumberOrder.Enabled = false;
            this.tbNumberOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbNumberOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumberOrder.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbNumberOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNumberOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumberOrder.Location = new System.Drawing.Point(249, 463);
            this.tbNumberOrder.Name = "tbNumberOrder";
            this.tbNumberOrder.PasswordChar = '\0';
            this.tbNumberOrder.PlaceholderText = "Số hóa đơn";
            this.tbNumberOrder.SelectedText = "";
            this.tbNumberOrder.Size = new System.Drawing.Size(487, 30);
            this.tbNumberOrder.TabIndex = 4;
            // 
            // lblNumberOrder
            // 
            this.lblNumberOrder.AutoSize = true;
            this.lblNumberOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOrder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumberOrder.Location = new System.Drawing.Point(82, 470);
            this.lblNumberOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOrder.Name = "lblNumberOrder";
            this.lblNumberOrder.Size = new System.Drawing.Size(98, 19);
            this.lblNumberOrder.TabIndex = 73;
            this.lblNumberOrder.Text = "Số hóa đơn";
            // 
            // tbGenderKH
            // 
            this.tbGenderKH.AutoRoundedCorners = true;
            this.tbGenderKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbGenderKH.BorderRadius = 14;
            this.tbGenderKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGenderKH.DefaultText = "";
            this.tbGenderKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbGenderKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbGenderKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbGenderKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbGenderKH.Enabled = false;
            this.tbGenderKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbGenderKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGenderKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbGenderKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbGenderKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGenderKH.Location = new System.Drawing.Point(249, 152);
            this.tbGenderKH.Name = "tbGenderKH";
            this.tbGenderKH.PasswordChar = '\0';
            this.tbGenderKH.PlaceholderText = "Giới tính";
            this.tbGenderKH.SelectedText = "";
            this.tbGenderKH.Size = new System.Drawing.Size(487, 30);
            this.tbGenderKH.TabIndex = 1;
            // 
            // tbPhoneKH
            // 
            this.tbPhoneKH.AutoRoundedCorners = true;
            this.tbPhoneKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbPhoneKH.BorderRadius = 14;
            this.tbPhoneKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhoneKH.DefaultText = "";
            this.tbPhoneKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbPhoneKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbPhoneKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbPhoneKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbPhoneKH.Enabled = false;
            this.tbPhoneKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbPhoneKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbPhoneKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbPhoneKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhoneKH.Location = new System.Drawing.Point(249, 228);
            this.tbPhoneKH.Name = "tbPhoneKH";
            this.tbPhoneKH.PasswordChar = '\0';
            this.tbPhoneKH.PlaceholderText = "Số điện thoại";
            this.tbPhoneKH.SelectedText = "";
            this.tbPhoneKH.Size = new System.Drawing.Size(487, 30);
            this.tbPhoneKH.TabIndex = 2;
            // 
            // tbAddressKH
            // 
            this.tbAddressKH.AutoRoundedCorners = true;
            this.tbAddressKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbAddressKH.BorderRadius = 14;
            this.tbAddressKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddressKH.DefaultText = "";
            this.tbAddressKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbAddressKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressKH.Enabled = false;
            this.tbAddressKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbAddressKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbAddressKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbAddressKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddressKH.Location = new System.Drawing.Point(249, 308);
            this.tbAddressKH.Name = "tbAddressKH";
            this.tbAddressKH.PasswordChar = '\0';
            this.tbAddressKH.PlaceholderText = "Địa chỉ";
            this.tbAddressKH.SelectedText = "";
            this.tbAddressKH.Size = new System.Drawing.Size(487, 30);
            this.tbAddressKH.TabIndex = 3;
            // 
            // tbNameKH
            // 
            this.tbNameKH.AutoRoundedCorners = true;
            this.tbNameKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbNameKH.BorderRadius = 14;
            this.tbNameKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameKH.DefaultText = "";
            this.tbNameKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.Enabled = false;
            this.tbNameKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.tbNameKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbNameKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameKH.Location = new System.Drawing.Point(249, 79);
            this.tbNameKH.Name = "tbNameKH";
            this.tbNameKH.PasswordChar = '\0';
            this.tbNameKH.PlaceholderText = "Họ và tên";
            this.tbNameKH.SelectedText = "";
            this.tbNameKH.Size = new System.Drawing.Size(487, 30);
            this.tbNameKH.TabIndex = 0;
            // 
            // lblPhoneKH
            // 
            this.lblPhoneKH.AutoSize = true;
            this.lblPhoneKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneKH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPhoneKH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhoneKH.Location = new System.Drawing.Point(82, 232);
            this.lblPhoneKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneKH.Name = "lblPhoneKH";
            this.lblPhoneKH.Size = new System.Drawing.Size(86, 19);
            this.lblPhoneKH.TabIndex = 66;
            this.lblPhoneKH.Text = "Điện thoại";
            // 
            // lblAddressKH
            // 
            this.lblAddressKH.AutoSize = true;
            this.lblAddressKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressKH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddressKH.Location = new System.Drawing.Point(82, 312);
            this.lblAddressKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressKH.Name = "lblAddressKH";
            this.lblAddressKH.Size = new System.Drawing.Size(61, 19);
            this.lblAddressKH.TabIndex = 65;
            this.lblAddressKH.Text = "Địa chỉ";
            // 
            // lblGenderKH
            // 
            this.lblGenderKH.AutoSize = true;
            this.lblGenderKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderKH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGenderKH.Location = new System.Drawing.Point(82, 155);
            this.lblGenderKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenderKH.Name = "lblGenderKH";
            this.lblGenderKH.Size = new System.Drawing.Size(73, 19);
            this.lblGenderKH.TabIndex = 64;
            this.lblGenderKH.Text = "Giới tính";
            // 
            // lblNameKH
            // 
            this.lblNameKH.AutoSize = true;
            this.lblNameKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameKH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNameKH.Location = new System.Drawing.Point(82, 84);
            this.lblNameKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameKH.Name = "lblNameKH";
            this.lblNameKH.Size = new System.Drawing.Size(81, 19);
            this.lblNameKH.TabIndex = 63;
            this.lblNameKH.Text = "Họ và tên";
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
            this.rjbtnOK.Location = new System.Drawing.Point(318, 620);
            this.rjbtnOK.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnOK.Name = "rjbtnOK";
            this.rjbtnOK.Size = new System.Drawing.Size(145, 36);
            this.rjbtnOK.TabIndex = 6;
            this.rjbtnOK.Text = "OK";
            this.rjbtnOK.TextColor = System.Drawing.Color.White;
            this.rjbtnOK.UseVisualStyleBackColor = false;
            this.rjbtnOK.Click += new System.EventHandler(this.RjbtnOK_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelContainer;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.panelTitleBar;
            this.guna2DragControl2.UseTransparentDrag = true;
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
            // 
            // FormTTKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 735);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTTKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormTTKH_Load);
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
        private RJButton rjbtnOK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox tbPhoneKH;
        private Guna.UI2.WinForms.Guna2TextBox tbAddressKH;
        private Guna.UI2.WinForms.Guna2TextBox tbNameKH;
        private System.Windows.Forms.Label lblPhoneKH;
        private System.Windows.Forms.Label lblAddressKH;
        private System.Windows.Forms.Label lblGenderKH;
        private System.Windows.Forms.Label lblNameKH;
        private Guna.UI2.WinForms.Guna2TextBox tbGenderKH;
        private Guna.UI2.WinForms.Guna2TextBox tbNumberOrder;
        private System.Windows.Forms.Label lblNumberOrder;
        private Guna.UI2.WinForms.Guna2TextBox tbTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbStartDate;
        private System.Windows.Forms.Label lblStartDate;
    }
}