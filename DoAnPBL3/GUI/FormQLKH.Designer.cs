namespace DoAnPBL3
{
    partial class FormQLKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLKH));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xuiSegmentKH = new XanderUI.XUISegment();
            this.btnTKKH = new Guna.UI2.WinForms.Guna2Button();
            this.totalFemaleCustomers = new System.Windows.Forms.Label();
            this.lblTotalFemaleCustomers = new System.Windows.Forms.Label();
            this.totalMaleCustomers = new System.Windows.Forms.Label();
            this.lblTotalMaleCustomers = new System.Windows.Forms.Label();
            this.totalCustomers = new System.Windows.Forms.Label();
            this.lblTotalCustomer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnHDKH = new FontAwesome.Sharp.IconButton();
            this.rjtbTKKH = new DoAnPBL3.RJTextBox();
            this.dgvQLKH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKH)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiSegmentKH
            // 
            this.xuiSegmentKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiSegmentKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiSegmentKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSegmentKH.Items = "Tất cả,Nam,Nữ";
            this.xuiSegmentKH.Location = new System.Drawing.Point(512, 130);
            this.xuiSegmentKH.Name = "xuiSegmentKH";
            this.xuiSegmentKH.SegmentActiveTextColor = System.Drawing.Color.HotPink;
            this.xuiSegmentKH.SegmentBackColor = System.Drawing.Color.SlateBlue;
            this.xuiSegmentKH.SegmentColor = System.Drawing.Color.DarkMagenta;
            this.xuiSegmentKH.SegmentInactiveTextColor = System.Drawing.Color.White;
            this.xuiSegmentKH.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.xuiSegmentKH.SelectedIndex = 0;
            this.xuiSegmentKH.Size = new System.Drawing.Size(314, 34);
            this.xuiSegmentKH.TabIndex = 18;
            this.xuiSegmentKH.Click += new System.EventHandler(this.XuiSegmentKH_Click);
            // 
            // btnTKKH
            // 
            this.btnTKKH.BorderRadius = 15;
            this.btnTKKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnTKKH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTKKH.ForeColor = System.Drawing.Color.White;
            this.btnTKKH.Image = global::DoAnPBL3.Properties.Resources.icons8_search_20px;
            this.btnTKKH.Location = new System.Drawing.Point(264, 132);
            this.btnTKKH.Name = "btnTKKH";
            this.btnTKKH.Size = new System.Drawing.Size(141, 31);
            this.btnTKKH.TabIndex = 19;
            this.btnTKKH.Text = "Tìm kiếm";
            this.btnTKKH.Click += new System.EventHandler(this.BtnTKKH_Click);
            // 
            // totalFemaleCustomers
            // 
            this.totalFemaleCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalFemaleCustomers.AutoSize = true;
            this.totalFemaleCustomers.BackColor = System.Drawing.Color.Transparent;
            this.totalFemaleCustomers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFemaleCustomers.ForeColor = System.Drawing.Color.White;
            this.totalFemaleCustomers.Location = new System.Drawing.Point(810, 56);
            this.totalFemaleCustomers.Name = "totalFemaleCustomers";
            this.totalFemaleCustomers.Size = new System.Drawing.Size(29, 16);
            this.totalFemaleCustomers.TabIndex = 29;
            this.totalFemaleCustomers.Text = "100";
            // 
            // lblTotalFemaleCustomers
            // 
            this.lblTotalFemaleCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFemaleCustomers.AutoSize = true;
            this.lblTotalFemaleCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFemaleCustomers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFemaleCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalFemaleCustomers.Location = new System.Drawing.Point(761, 25);
            this.lblTotalFemaleCustomers.Name = "lblTotalFemaleCustomers";
            this.lblTotalFemaleCustomers.Size = new System.Drawing.Size(124, 16);
            this.lblTotalFemaleCustomers.TabIndex = 28;
            this.lblTotalFemaleCustomers.Text = "Số khách hàng nữ";
            // 
            // totalMaleCustomers
            // 
            this.totalMaleCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalMaleCustomers.AutoSize = true;
            this.totalMaleCustomers.BackColor = System.Drawing.Color.Transparent;
            this.totalMaleCustomers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMaleCustomers.ForeColor = System.Drawing.Color.White;
            this.totalMaleCustomers.Location = new System.Drawing.Point(454, 56);
            this.totalMaleCustomers.Name = "totalMaleCustomers";
            this.totalMaleCustomers.Size = new System.Drawing.Size(29, 16);
            this.totalMaleCustomers.TabIndex = 27;
            this.totalMaleCustomers.Text = "100";
            // 
            // lblTotalMaleCustomers
            // 
            this.lblTotalMaleCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalMaleCustomers.AutoSize = true;
            this.lblTotalMaleCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMaleCustomers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMaleCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalMaleCustomers.Location = new System.Drawing.Point(405, 25);
            this.lblTotalMaleCustomers.Name = "lblTotalMaleCustomers";
            this.lblTotalMaleCustomers.Size = new System.Drawing.Size(135, 16);
            this.lblTotalMaleCustomers.TabIndex = 26;
            this.lblTotalMaleCustomers.Text = "Số khách hàng nam";
            // 
            // totalCustomers
            // 
            this.totalCustomers.AutoSize = true;
            this.totalCustomers.BackColor = System.Drawing.Color.Transparent;
            this.totalCustomers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCustomers.ForeColor = System.Drawing.Color.White;
            this.totalCustomers.Location = new System.Drawing.Point(92, 56);
            this.totalCustomers.Name = "totalCustomers";
            this.totalCustomers.Size = new System.Drawing.Size(29, 16);
            this.totalCustomers.TabIndex = 25;
            this.totalCustomers.Text = "100";
            // 
            // lblTotalCustomer
            // 
            this.lblTotalCustomer.AutoSize = true;
            this.lblTotalCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalCustomer.Location = new System.Drawing.Point(40, 25);
            this.lblTotalCustomer.Name = "lblTotalCustomer";
            this.lblTotalCustomer.Size = new System.Drawing.Size(136, 16);
            this.lblTotalCustomer.TabIndex = 24;
            this.lblTotalCustomer.Text = "Tổng số khách hàng";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DoAnPBL3.Properties.Resources.man_1;
            this.pictureBox2.Location = new System.Drawing.Point(536, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DoAnPBL3.Properties.Resources.women;
            this.pictureBox3.Location = new System.Drawing.Point(882, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this.xuiSegmentKH;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 5;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 5;
            this.guna2Elipse3.TargetControl = this.btnHDKH;
            // 
            // btnHDKH
            // 
            this.btnHDKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHDKH.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHDKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHDKH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnHDKH.FlatAppearance.BorderSize = 0;
            this.btnHDKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHDKH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDKH.ForeColor = System.Drawing.Color.White;
            this.btnHDKH.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnHDKH.IconColor = System.Drawing.Color.White;
            this.btnHDKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHDKH.IconSize = 30;
            this.btnHDKH.Location = new System.Drawing.Point(0, 0);
            this.btnHDKH.Name = "btnHDKH";
            this.btnHDKH.Size = new System.Drawing.Size(142, 47);
            this.btnHDKH.TabIndex = 10;
            this.btnHDKH.Text = " Hóa đơn khách hàng";
            this.btnHDKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHDKH.UseVisualStyleBackColor = false;
            this.btnHDKH.Click += new System.EventHandler(this.BtnHDKH_Click);
            this.btnHDKH.MouseEnter += new System.EventHandler(this.BtnHDKH_MouseEnter);
            this.btnHDKH.MouseLeave += new System.EventHandler(this.BtnHDKH_MouseLeave);
            // 
            // rjtbTKKH
            // 
            this.rjtbTKKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.rjtbTKKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.rjtbTKKH.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.rjtbTKKH.BorderRadius = 15;
            this.rjtbTKKH.BorderSize = 1;
            this.rjtbTKKH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbTKKH.ForeColor = System.Drawing.Color.Silver;
            this.rjtbTKKH.Location = new System.Drawing.Point(6, 133);
            this.rjtbTKKH.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbTKKH.Multiline = false;
            this.rjtbTKKH.Name = "rjtbTKKH";
            this.rjtbTKKH.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbTKKH.PasswordChar = false;
            this.rjtbTKKH.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.rjtbTKKH.PlaceholderText = "Tìm kiếm theo ID, họ và tên hoặc SĐT";
            this.rjtbTKKH.Size = new System.Drawing.Size(250, 31);
            this.rjtbTKKH.TabIndex = 17;
            this.rjtbTKKH.Texts = "";
            this.rjtbTKKH.UnderlinedStyle = false;
            this.rjtbTKKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RjtbTKKH_KeyPress);
            // 
            // dgvQLKH
            // 
            this.dgvQLKH.AllowUserToAddRows = false;
            this.dgvQLKH.AllowUserToDeleteRows = false;
            this.dgvQLKH.AllowUserToResizeColumns = false;
            this.dgvQLKH.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQLKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.dgvQLKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLKH.ColumnHeadersHeight = 30;
            this.dgvQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Customer,
            this.FullNameCustomer,
            this.Gender,
            this.Phone,
            this.Address});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLKH.EnableHeadersVisualStyles = false;
            this.dgvQLKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLKH.Location = new System.Drawing.Point(11, 170);
            this.dgvQLKH.Name = "dgvQLKH";
            this.dgvQLKH.ReadOnly = true;
            this.dgvQLKH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLKH.RowHeadersVisible = false;
            this.dgvQLKH.RowHeadersWidth = 60;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQLKH.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLKH.Size = new System.Drawing.Size(816, 413);
            this.dgvQLKH.TabIndex = 39;
            this.dgvQLKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLKH.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.dgvQLKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLKH.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQLKH.ThemeStyle.ReadOnly = true;
            this.dgvQLKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dgvQLKH.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLKH.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvQLKH_RowHeaderMouseClick);
            // 
            // ID_Customer
            // 
            this.ID_Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Customer.DataPropertyName = "ID_Customer";
            this.ID_Customer.FillWeight = 44.67005F;
            this.ID_Customer.HeaderText = "ID";
            this.ID_Customer.Name = "ID_Customer";
            this.ID_Customer.ReadOnly = true;
            // 
            // FullNameCustomer
            // 
            this.FullNameCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullNameCustomer.DataPropertyName = "FullNameCustomer";
            this.FullNameCustomer.FillWeight = 118.4433F;
            this.FullNameCustomer.HeaderText = "Họ và tên";
            this.FullNameCustomer.Name = "FullNameCustomer";
            this.FullNameCustomer.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới tính";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.FillWeight = 118.4433F;
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 118.4433F;
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblTotalMaleCustomers);
            this.panelHeader.Controls.Add(this.lblTotalCustomer);
            this.panelHeader.Controls.Add(this.totalCustomers);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.totalMaleCustomers);
            this.panelHeader.Controls.Add(this.pictureBox3);
            this.panelHeader.Controls.Add(this.lblTotalFemaleCustomers);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.totalFemaleCustomers);
            this.panelHeader.Location = new System.Drawing.Point(11, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(957, 95);
            this.panelHeader.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnHDKH);
            this.panel1.Location = new System.Drawing.Point(833, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 49);
            this.panel1.TabIndex = 38;
            // 
            // FormQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgvQLKH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTKKH);
            this.Controls.Add(this.xuiSegmentKH);
            this.Controls.Add(this.rjtbTKKH);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLKH";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.FormQLKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKH)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RJTextBox rjtbTKKH;
        private XanderUI.XUISegment xuiSegmentKH;
        private Guna.UI2.WinForms.Guna2Button btnTKKH;
        private System.Windows.Forms.Label totalFemaleCustomers;
        private System.Windows.Forms.Label lblTotalFemaleCustomers;
        private System.Windows.Forms.Label totalMaleCustomers;
        private System.Windows.Forms.Label lblTotalMaleCustomers;
        private System.Windows.Forms.Label totalCustomers;
        private System.Windows.Forms.Label lblTotalCustomer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLKH;
        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton btnHDKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}