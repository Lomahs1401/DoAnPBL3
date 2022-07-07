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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLNV));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.xuiSegmentNV = new XanderUI.XUISegment();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmployeeQuitJob = new FontAwesome.Sharp.IconButton();
            this.btnDeleteNV = new FontAwesome.Sharp.IconButton();
            this.btnAddNV = new FontAwesome.Sharp.IconButton();
            this.btnSuaNV = new FontAwesome.Sharp.IconButton();
            this.btnTKNV = new Guna.UI2.WinForms.Guna2Button();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.dgvQLNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalEmployee = new System.Windows.Forms.Label();
            this.totalEmployee = new System.Windows.Forms.Label();
            this.lblTotalMaleEmployee = new System.Windows.Forms.Label();
            this.maleEmployee = new System.Windows.Forms.Label();
            this.lblTotalFemaleEmployee = new System.Windows.Forms.Label();
            this.femaleEmployee = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tbTKNV = new DoAnPBL3.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
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
            this.xuiSegmentNV.Click += new System.EventHandler(this.XuiSegmentNV_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnEmployeeQuitJob);
            this.panel1.Controls.Add(this.btnDeleteNV);
            this.panel1.Controls.Add(this.btnAddNV);
            this.panel1.Controls.Add(this.btnSuaNV);
            this.panel1.Location = new System.Drawing.Point(827, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 200);
            this.panel1.TabIndex = 27;
            // 
            // btnEmployeeQuitJob
            // 
            this.btnEmployeeQuitJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployeeQuitJob.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEmployeeQuitJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeQuitJob.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnEmployeeQuitJob.FlatAppearance.BorderSize = 0;
            this.btnEmployeeQuitJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeQuitJob.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeQuitJob.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeQuitJob.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnEmployeeQuitJob.IconColor = System.Drawing.Color.White;
            this.btnEmployeeQuitJob.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmployeeQuitJob.IconSize = 30;
            this.btnEmployeeQuitJob.Location = new System.Drawing.Point(4, 154);
            this.btnEmployeeQuitJob.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployeeQuitJob.Name = "btnEmployeeQuitJob";
            this.btnEmployeeQuitJob.Size = new System.Drawing.Size(143, 44);
            this.btnEmployeeQuitJob.TabIndex = 3;
            this.btnEmployeeQuitJob.Text = "Danh sách nghỉ việc";
            this.btnEmployeeQuitJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeQuitJob.UseVisualStyleBackColor = false;
            this.btnEmployeeQuitJob.Click += new System.EventHandler(this.BtnEmployeeQuitJob_Click);
            this.btnEmployeeQuitJob.MouseEnter += new System.EventHandler(this.BtnEmployeeQuitJob_MouseEnter);
            this.btnEmployeeQuitJob.MouseLeave += new System.EventHandler(this.BtnEmployeeQuitJob_MouseLeave);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteNV.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnDeleteNV.FlatAppearance.BorderSize = 0;
            this.btnDeleteNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNV.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNV.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnDeleteNV.IconColor = System.Drawing.Color.White;
            this.btnDeleteNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteNV.IconSize = 30;
            this.btnDeleteNV.Location = new System.Drawing.Point(4, 104);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(143, 44);
            this.btnDeleteNV.TabIndex = 1;
            this.btnDeleteNV.Text = "Xóa";
            this.btnDeleteNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteNV.UseVisualStyleBackColor = false;
            this.btnDeleteNV.Click += new System.EventHandler(this.BtnDeleteNV_Click);
            this.btnDeleteNV.MouseEnter += new System.EventHandler(this.IconButton1_MouseEnter);
            this.btnDeleteNV.MouseLeave += new System.EventHandler(this.BtnDeleteNV_MouseLeave);
            // 
            // btnAddNV
            // 
            this.btnAddNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNV.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnAddNV.FlatAppearance.BorderSize = 0;
            this.btnAddNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNV.ForeColor = System.Drawing.Color.White;
            this.btnAddNV.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddNV.IconColor = System.Drawing.Color.White;
            this.btnAddNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNV.IconSize = 30;
            this.btnAddNV.Location = new System.Drawing.Point(4, 4);
            this.btnAddNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(143, 44);
            this.btnAddNV.TabIndex = 0;
            this.btnAddNV.Text = "Thêm";
            this.btnAddNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNV.UseVisualStyleBackColor = false;
            this.btnAddNV.Click += new System.EventHandler(this.BtnAddNV_Click);
            this.btnAddNV.MouseEnter += new System.EventHandler(this.BtnAddNV_MouseEnter);
            this.btnAddNV.MouseLeave += new System.EventHandler(this.BtnAddNV_MouseLeave);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaNV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSuaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnSuaNV.FlatAppearance.BorderSize = 0;
            this.btnSuaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.ForeColor = System.Drawing.Color.White;
            this.btnSuaNV.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnSuaNV.IconColor = System.Drawing.Color.White;
            this.btnSuaNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaNV.IconSize = 30;
            this.btnSuaNV.Location = new System.Drawing.Point(4, 54);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(143, 44);
            this.btnSuaNV.TabIndex = 2;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.BtnEditNV_Click);
            this.btnSuaNV.MouseEnter += new System.EventHandler(this.BtnEditNV_MouseEnter);
            this.btnSuaNV.MouseLeave += new System.EventHandler(this.BtnEditNV_MouseLeave);
            // 
            // btnTKNV
            // 
            this.btnTKNV.BorderRadius = 15;
            this.btnTKNV.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnTKNV.Click += new System.EventHandler(this.BtnTKNV_Click);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQLNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.dgvQLNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLNV.ColumnHeadersHeight = 30;
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Employee,
            this.FullNameEmployee,
            this.Email,
            this.DateOfBirth,
            this.Gender,
            this.ID_Card,
            this.Phone,
            this.Address});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLNV.EnableHeadersVisualStyles = false;
            this.dgvQLNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLNV.Location = new System.Drawing.Point(11, 170);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.ReadOnly = true;
            this.dgvQLNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLNV.RowHeadersVisible = false;
            this.dgvQLNV.RowHeadersWidth = 60;
            this.dgvQLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLNV.Size = new System.Drawing.Size(816, 413);
            this.dgvQLNV.TabIndex = 47;
            this.dgvQLNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLNV.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.dgvQLNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLNV.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQLNV.ThemeStyle.ReadOnly = true;
            this.dgvQLNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLNV.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLNV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvQLNV_RowHeaderMouseClick);
            // 
            // ID_Employee
            // 
            this.ID_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Employee.DataPropertyName = "ID_Employee";
            this.ID_Employee.FillWeight = 61.65406F;
            this.ID_Employee.HeaderText = "ID";
            this.ID_Employee.Name = "ID_Employee";
            this.ID_Employee.ReadOnly = true;
            // 
            // FullNameEmployee
            // 
            this.FullNameEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullNameEmployee.DataPropertyName = "FullNameEmployee";
            this.FullNameEmployee.FillWeight = 120.9246F;
            this.FullNameEmployee.HeaderText = "Họ và tên";
            this.FullNameEmployee.Name = "FullNameEmployee";
            this.FullNameEmployee.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 146.5077F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.FillWeight = 91.75087F;
            this.DateOfBirth.HeaderText = "Ngày sinh";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.FillWeight = 83.07114F;
            this.Gender.HeaderText = "Giới tính";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // ID_Card
            // 
            this.ID_Card.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Card.DataPropertyName = "Id_Card";
            this.ID_Card.FillWeight = 83.07114F;
            this.ID_Card.HeaderText = "CMND";
            this.ID_Card.Name = "ID_Card";
            this.ID_Card.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.FillWeight = 83.07114F;
            this.Phone.HeaderText = "SĐT";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 129.9492F;
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // lblTotalEmployee
            // 
            this.lblTotalEmployee.AutoSize = true;
            this.lblTotalEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalEmployee.Location = new System.Drawing.Point(26, 25);
            this.lblTotalEmployee.Name = "lblTotalEmployee";
            this.lblTotalEmployee.Size = new System.Drawing.Size(183, 16);
            this.lblTotalEmployee.TabIndex = 38;
            this.lblTotalEmployee.Text = "Tổng số nhân viên làm việc";
            // 
            // totalEmployee
            // 
            this.totalEmployee.AutoSize = true;
            this.totalEmployee.BackColor = System.Drawing.Color.Transparent;
            this.totalEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEmployee.ForeColor = System.Drawing.Color.White;
            this.totalEmployee.Location = new System.Drawing.Point(101, 51);
            this.totalEmployee.Name = "totalEmployee";
            this.totalEmployee.Size = new System.Drawing.Size(29, 16);
            this.totalEmployee.TabIndex = 39;
            this.totalEmployee.Text = "100";
            // 
            // lblTotalMaleEmployee
            // 
            this.lblTotalMaleEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalMaleEmployee.AutoSize = true;
            this.lblTotalMaleEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMaleEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMaleEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalMaleEmployee.Location = new System.Drawing.Point(371, 25);
            this.lblTotalMaleEmployee.Name = "lblTotalMaleEmployee";
            this.lblTotalMaleEmployee.Size = new System.Drawing.Size(182, 16);
            this.lblTotalMaleEmployee.TabIndex = 40;
            this.lblTotalMaleEmployee.Text = "Số nhân viên nam làm việc";
            // 
            // maleEmployee
            // 
            this.maleEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maleEmployee.AutoSize = true;
            this.maleEmployee.BackColor = System.Drawing.Color.Transparent;
            this.maleEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleEmployee.ForeColor = System.Drawing.Color.White;
            this.maleEmployee.Location = new System.Drawing.Point(440, 51);
            this.maleEmployee.Name = "maleEmployee";
            this.maleEmployee.Size = new System.Drawing.Size(29, 16);
            this.maleEmployee.TabIndex = 41;
            this.maleEmployee.Text = "100";
            // 
            // lblTotalFemaleEmployee
            // 
            this.lblTotalFemaleEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFemaleEmployee.AutoSize = true;
            this.lblTotalFemaleEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFemaleEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFemaleEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalFemaleEmployee.Location = new System.Drawing.Point(697, 25);
            this.lblTotalFemaleEmployee.Name = "lblTotalFemaleEmployee";
            this.lblTotalFemaleEmployee.Size = new System.Drawing.Size(171, 16);
            this.lblTotalFemaleEmployee.TabIndex = 42;
            this.lblTotalFemaleEmployee.Text = "Số nhân viên nữ làm việc";
            // 
            // femaleEmployee
            // 
            this.femaleEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.femaleEmployee.AutoSize = true;
            this.femaleEmployee.BackColor = System.Drawing.Color.Transparent;
            this.femaleEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleEmployee.ForeColor = System.Drawing.Color.White;
            this.femaleEmployee.Location = new System.Drawing.Point(765, 51);
            this.femaleEmployee.Name = "femaleEmployee";
            this.femaleEmployee.Size = new System.Drawing.Size(29, 16);
            this.femaleEmployee.TabIndex = 43;
            this.femaleEmployee.Text = "100";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DoAnPBL3.Properties.Resources.man_1;
            this.pictureBox2.Location = new System.Drawing.Point(549, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DoAnPBL3.Properties.Resources.women;
            this.pictureBox3.Location = new System.Drawing.Point(865, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.division;
            this.pictureBox1.Location = new System.Drawing.Point(215, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblTotalMaleEmployee);
            this.panelHeader.Controls.Add(this.lblTotalEmployee);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.totalEmployee);
            this.panelHeader.Controls.Add(this.pictureBox3);
            this.panelHeader.Controls.Add(this.maleEmployee);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.lblTotalFemaleEmployee);
            this.panelHeader.Controls.Add(this.femaleEmployee);
            this.panelHeader.Location = new System.Drawing.Point(11, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(957, 95);
            this.panelHeader.TabIndex = 48;
            // 
            // tbTKNV
            // 
            this.tbTKNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.tbTKNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.tbTKNV.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.tbTKNV.BorderRadius = 15;
            this.tbTKNV.BorderSize = 1;
            this.tbTKNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTKNV.ForeColor = System.Drawing.Color.Silver;
            this.tbTKNV.Location = new System.Drawing.Point(7, 134);
            this.tbTKNV.Margin = new System.Windows.Forms.Padding(4);
            this.tbTKNV.Multiline = false;
            this.tbTKNV.Name = "tbTKNV";
            this.tbTKNV.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbTKNV.PasswordChar = false;
            this.tbTKNV.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.tbTKNV.PlaceholderText = "Tìm kiếm theo ID, họ và tên hoặc SĐT";
            this.tbTKNV.Size = new System.Drawing.Size(250, 29);
            this.tbTKNV.TabIndex = 14;
            this.tbTKNV.Texts = "";
            this.tbTKNV.UnderlinedStyle = false;
            this.tbTKNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RjtbTKNV_KeyPress);
            // 
            // FormQLNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgvQLNV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTKNV);
            this.Controls.Add(this.xuiSegmentNV);
            this.Controls.Add(this.tbTKNV);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormQLNV";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.FormQLNV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
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
        private RJTextBox tbTKNV;
        private XanderUI.XUISegment xuiSegmentNV;
        private Guna.UI2.WinForms.Guna2Button btnTKNV;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLNV;
        private FontAwesome.Sharp.IconButton btnEmployeeQuitJob;
        private System.Windows.Forms.Label lblTotalEmployee;
        private System.Windows.Forms.Label totalEmployee;
        private System.Windows.Forms.Label lblTotalMaleEmployee;
        private System.Windows.Forms.Label maleEmployee;
        private System.Windows.Forms.Label lblTotalFemaleEmployee;
        private System.Windows.Forms.Label femaleEmployee;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Card;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}