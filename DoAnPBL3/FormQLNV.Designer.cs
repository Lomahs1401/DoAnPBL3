namespace DoAnPBL3
{
    partial class FormQLNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLNV));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DataSetListEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.xuiSegmentNV = new XanderUI.XUISegment();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteNV = new FontAwesome.Sharp.IconButton();
            this.btnAddNV = new FontAwesome.Sharp.IconButton();
            this.btnSuaNV = new FontAwesome.Sharp.IconButton();
            this.btnTKNV = new Guna.UI2.WinForms.Guna2Button();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.dgvQLNV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rjtbTKNV = new DoAnPBL3.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSNVNu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSNVNam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTSNV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetListEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(939, 567);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 9);
            this.label1.TabIndex = 4;
            this.label1.Text = "PBL3";
            // 
            // xuiSegmentNV
            // 
            this.xuiSegmentNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiSegmentNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiSegmentNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSegmentNV.Items = "Tất cả,Nam,Nữ";
            this.xuiSegmentNV.Location = new System.Drawing.Point(513, 129);
            this.xuiSegmentNV.Margin = new System.Windows.Forms.Padding(2);
            this.xuiSegmentNV.Name = "xuiSegmentNV";
            this.xuiSegmentNV.SegmentActiveTextColor = System.Drawing.Color.HotPink;
            this.xuiSegmentNV.SegmentBackColor = System.Drawing.Color.SlateBlue;
            this.xuiSegmentNV.SegmentColor = System.Drawing.Color.DarkMagenta;
            this.xuiSegmentNV.SegmentInactiveTextColor = System.Drawing.Color.White;
            this.xuiSegmentNV.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.xuiSegmentNV.SelectedIndex = 0;
            this.xuiSegmentNV.Size = new System.Drawing.Size(314, 34);
            this.xuiSegmentNV.TabIndex = 16;
            this.xuiSegmentNV.Click += new System.EventHandler(this.xuiSegmentNV_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnDeleteNV);
            this.panel1.Controls.Add(this.btnAddNV);
            this.panel1.Controls.Add(this.btnSuaNV);
            this.panel1.Location = new System.Drawing.Point(827, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 149);
            this.panel1.TabIndex = 27;
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteNV.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteNV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnDeleteNV.FlatAppearance.BorderSize = 0;
            this.btnDeleteNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNV.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNV.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnDeleteNV.IconColor = System.Drawing.Color.White;
            this.btnDeleteNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteNV.IconSize = 30;
            this.btnDeleteNV.Location = new System.Drawing.Point(4, 98);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(143, 44);
            this.btnDeleteNV.TabIndex = 1;
            this.btnDeleteNV.Text = "Xóa";
            this.btnDeleteNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteNV.UseVisualStyleBackColor = false;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            this.btnDeleteNV.MouseEnter += new System.EventHandler(this.iconButton1_MouseEnter);
            this.btnDeleteNV.MouseLeave += new System.EventHandler(this.btnDeleteNV_MouseLeave);
            // 
            // btnAddNV
            // 
            this.btnAddNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNV.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnAddNV.FlatAppearance.BorderSize = 0;
            this.btnAddNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNV.ForeColor = System.Drawing.Color.White;
            this.btnAddNV.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddNV.IconColor = System.Drawing.Color.White;
            this.btnAddNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNV.IconSize = 30;
            this.btnAddNV.Location = new System.Drawing.Point(4, 2);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(143, 44);
            this.btnAddNV.TabIndex = 0;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNV.UseVisualStyleBackColor = false;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            this.btnAddNV.MouseEnter += new System.EventHandler(this.btnAddNV_MouseEnter);
            this.btnAddNV.MouseLeave += new System.EventHandler(this.btnAddNV_MouseLeave);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaNV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSuaNV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnSuaNV.FlatAppearance.BorderSize = 0;
            this.btnSuaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.ForeColor = System.Drawing.Color.White;
            this.btnSuaNV.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnSuaNV.IconColor = System.Drawing.Color.White;
            this.btnSuaNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaNV.IconSize = 30;
            this.btnSuaNV.Location = new System.Drawing.Point(4, 50);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(143, 44);
            this.btnSuaNV.TabIndex = 2;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            this.btnSuaNV.MouseEnter += new System.EventHandler(this.btnSuaNV_MouseEnter);
            this.btnSuaNV.MouseLeave += new System.EventHandler(this.btnSuaNV_MouseLeave);
            // 
            // btnTKNV
            // 
            this.btnTKNV.BorderRadius = 15;
            this.btnTKNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnTKNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTKNV.ForeColor = System.Drawing.Color.White;
            this.btnTKNV.Image = global::DoAnPBL3.Properties.Resources.icons8_search_20px;
            this.btnTKNV.Location = new System.Drawing.Point(264, 132);
            this.btnTKNV.Name = "btnTKNV";
            this.btnTKNV.Size = new System.Drawing.Size(141, 31);
            this.btnTKNV.TabIndex = 17;
            this.btnTKNV.Text = "Tìm kiếm";
            this.btnTKNV.Click += new System.EventHandler(this.btnTKNV_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Microsoft;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 16;
            this.iconPictureBox2.Location = new System.Drawing.Point(963, 567);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(18, 16);
            this.iconPictureBox2.TabIndex = 5;
            this.iconPictureBox2.TabStop = false;
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.AllowUserToAddRows = false;
            this.dgvQLNV.AllowUserToDeleteRows = false;
            this.dgvQLNV.AllowUserToResizeColumns = false;
            this.dgvQLNV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.dgvQLNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLNV.ColumnHeadersHeight = 30;
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Gender,
            this.Email,
            this.Phone});
            this.dgvQLNV.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLNV.EnableHeadersVisualStyles = false;
            this.dgvQLNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLNV.Location = new System.Drawing.Point(11, 170);
            this.dgvQLNV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.ReadOnly = true;
            this.dgvQLNV.RowHeadersWidth = 51;
            this.dgvQLNV.RowTemplate.Height = 30;
            this.dgvQLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLNV.Size = new System.Drawing.Size(816, 413);
            this.dgvQLNV.TabIndex = 30;
            this.dgvQLNV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvQLNV_RowHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID_Employee";
            this.ID.FillWeight = 72.53177F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "NameEmployee";
            this.Name.FillWeight = 139.5939F;
            this.Name.HeaderText = "Họ và tên";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.FillWeight = 68.39316F;
            this.Gender.HeaderText = "Giới tính";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 112.803F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.FillWeight = 106.6781F;
            this.Phone.HeaderText = "SĐT";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // rjtbTKNV
            // 
            this.rjtbTKNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.rjtbTKNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.rjtbTKNV.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.rjtbTKNV.BorderRadius = 15;
            this.rjtbTKNV.BorderSize = 1;
            this.rjtbTKNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbTKNV.ForeColor = System.Drawing.Color.Silver;
            this.rjtbTKNV.Location = new System.Drawing.Point(7, 134);
            this.rjtbTKNV.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbTKNV.Multiline = false;
            this.rjtbTKNV.Name = "rjtbTKNV";
            this.rjtbTKNV.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.rjtbTKNV.PasswordChar = false;
            this.rjtbTKNV.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.rjtbTKNV.PlaceholderText = "Tìm kiếm theo tên hoặc SĐT";
            this.rjtbTKNV.Size = new System.Drawing.Size(250, 29);
            this.rjtbTKNV.TabIndex = 14;
            this.rjtbTKNV.Texts = "";
            this.rjtbTKNV.UnderlinedStyle = false;
            this.rjtbTKNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rjtbTKNV_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.division;
            this.pictureBox1.Location = new System.Drawing.Point(181, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DoAnPBL3.Properties.Resources.women;
            this.pictureBox3.Location = new System.Drawing.Point(889, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DoAnPBL3.Properties.Resources.man_1;
            this.pictureBox2.Location = new System.Drawing.Point(542, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // lblSNVNu
            // 
            this.lblSNVNu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSNVNu.AutoSize = true;
            this.lblSNVNu.BackColor = System.Drawing.Color.Transparent;
            this.lblSNVNu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNVNu.ForeColor = System.Drawing.Color.White;
            this.lblSNVNu.Location = new System.Drawing.Point(817, 49);
            this.lblSNVNu.Name = "lblSNVNu";
            this.lblSNVNu.Size = new System.Drawing.Size(29, 16);
            this.lblSNVNu.TabIndex = 43;
            this.lblSNVNu.Text = "100";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label7.Location = new System.Drawing.Point(768, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Số nhân viên nữ";
            // 
            // lblSNVNam
            // 
            this.lblSNVNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSNVNam.AutoSize = true;
            this.lblSNVNam.BackColor = System.Drawing.Color.Transparent;
            this.lblSNVNam.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNVNam.ForeColor = System.Drawing.Color.White;
            this.lblSNVNam.Location = new System.Drawing.Point(460, 49);
            this.lblSNVNam.Name = "lblSNVNam";
            this.lblSNVNam.Size = new System.Drawing.Size(29, 16);
            this.lblSNVNam.TabIndex = 41;
            this.lblSNVNam.Text = "100";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label5.Location = new System.Drawing.Point(411, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Số nhân viên nam";
            // 
            // lblTSNV
            // 
            this.lblTSNV.AutoSize = true;
            this.lblTSNV.BackColor = System.Drawing.Color.Transparent;
            this.lblTSNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSNV.ForeColor = System.Drawing.Color.White;
            this.lblTSNV.Location = new System.Drawing.Point(97, 49);
            this.lblTSNV.Name = "lblTSNV";
            this.lblTSNV.Size = new System.Drawing.Size(29, 16);
            this.lblTSNV.TabIndex = 39;
            this.lblTSNV.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(45, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tổng số nhân viên";
            // 
            // FormQLNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSNVNu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSNVNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTSNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvQLNV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTKNV);
            this.Controls.Add(this.xuiSegmentNV);
            this.Controls.Add(this.rjtbTKNV);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.FormQLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetListEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddNV;
        private FontAwesome.Sharp.IconButton btnDeleteNV;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton btnSuaNV;
        private RJTextBox rjtbTKNV;
        private XanderUI.XUISegment xuiSegmentNV;
        private Guna.UI2.WinForms.Guna2Button btnTKNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource DataSetListEmployees;
        private System.Windows.Forms.DataGridView dgvQLNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblSNVNu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSNVNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTSNV;
        private System.Windows.Forms.Label label2;
    }
}