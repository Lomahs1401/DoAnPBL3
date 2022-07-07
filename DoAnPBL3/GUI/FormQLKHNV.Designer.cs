
namespace DoAnPBL3
{
    partial class FormQLKHNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLKHNV));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rjtbTKKH = new DoAnPBL3.RJTextBox();
            this.btnTKKH = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.totalFemaleCustomers = new System.Windows.Forms.Label();
            this.lblTotalFemaleCustomers = new System.Windows.Forms.Label();
            this.totalMaleCustomers = new System.Windows.Forms.Label();
            this.lblTotalMaleCustomers = new System.Windows.Forms.Label();
            this.totalCustomers = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.xuiSegmentKH = new XanderUI.XUISegment();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHDKH = new FontAwesome.Sharp.IconButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.dgvQLKHNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKHNV)).BeginInit();
            this.SuspendLayout();
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
            this.rjtbTKKH.Location = new System.Drawing.Point(5, 133);
            this.rjtbTKKH.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbTKKH.Multiline = false;
            this.rjtbTKKH.Name = "rjtbTKKH";
            this.rjtbTKKH.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbTKKH.PasswordChar = false;
            this.rjtbTKKH.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.rjtbTKKH.PlaceholderText = "Tìm kiếm theo ID, họ và tên hoặc SĐT";
            this.rjtbTKKH.Size = new System.Drawing.Size(250, 31);
            this.rjtbTKKH.TabIndex = 52;
            this.rjtbTKKH.Texts = "";
            this.rjtbTKKH.UnderlinedStyle = false;
            this.rjtbTKKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RjtbTKKH_KeyPress);
            // 
            // btnTKKH
            // 
            this.btnTKKH.BorderRadius = 15;
            this.btnTKKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKKH.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnTKKH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTKKH.ForeColor = System.Drawing.Color.White;
            this.btnTKKH.Image = global::DoAnPBL3.Properties.Resources.icons8_search_20px;
            this.btnTKKH.Location = new System.Drawing.Point(262, 133);
            this.btnTKKH.Name = "btnTKKH";
            this.btnTKKH.Size = new System.Drawing.Size(141, 32);
            this.btnTKKH.TabIndex = 54;
            this.btnTKKH.Text = "Tìm kiếm";
            this.btnTKKH.Click += new System.EventHandler(this.BtnTKKH_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DoAnPBL3.Properties.Resources.women;
            this.pictureBox3.Location = new System.Drawing.Point(886, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::DoAnPBL3.Properties.Resources.man_1;
            this.pictureBox2.Location = new System.Drawing.Point(529, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // totalFemaleCustomers
            // 
            this.totalFemaleCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalFemaleCustomers.AutoSize = true;
            this.totalFemaleCustomers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFemaleCustomers.ForeColor = System.Drawing.Color.White;
            this.totalFemaleCustomers.Location = new System.Drawing.Point(814, 54);
            this.totalFemaleCustomers.Name = "totalFemaleCustomers";
            this.totalFemaleCustomers.Size = new System.Drawing.Size(29, 16);
            this.totalFemaleCustomers.TabIndex = 60;
            this.totalFemaleCustomers.Text = "100";
            // 
            // lblTotalFemaleCustomers
            // 
            this.lblTotalFemaleCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFemaleCustomers.AutoSize = true;
            this.lblTotalFemaleCustomers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFemaleCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalFemaleCustomers.Location = new System.Drawing.Point(765, 23);
            this.lblTotalFemaleCustomers.Name = "lblTotalFemaleCustomers";
            this.lblTotalFemaleCustomers.Size = new System.Drawing.Size(124, 16);
            this.lblTotalFemaleCustomers.TabIndex = 59;
            this.lblTotalFemaleCustomers.Text = "Số khach hàng nữ";
            // 
            // totalMaleCustomers
            // 
            this.totalMaleCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalMaleCustomers.AutoSize = true;
            this.totalMaleCustomers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMaleCustomers.ForeColor = System.Drawing.Color.White;
            this.totalMaleCustomers.Location = new System.Drawing.Point(447, 54);
            this.totalMaleCustomers.Name = "totalMaleCustomers";
            this.totalMaleCustomers.Size = new System.Drawing.Size(29, 16);
            this.totalMaleCustomers.TabIndex = 58;
            this.totalMaleCustomers.Text = "100";
            // 
            // lblTotalMaleCustomers
            // 
            this.lblTotalMaleCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalMaleCustomers.AutoSize = true;
            this.lblTotalMaleCustomers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMaleCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalMaleCustomers.Location = new System.Drawing.Point(398, 23);
            this.lblTotalMaleCustomers.Name = "lblTotalMaleCustomers";
            this.lblTotalMaleCustomers.Size = new System.Drawing.Size(135, 16);
            this.lblTotalMaleCustomers.TabIndex = 57;
            this.lblTotalMaleCustomers.Text = "Số khách hàng nam";
            // 
            // totalCustomers
            // 
            this.totalCustomers.AutoSize = true;
            this.totalCustomers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCustomers.ForeColor = System.Drawing.Color.White;
            this.totalCustomers.Location = new System.Drawing.Point(74, 54);
            this.totalCustomers.Name = "totalCustomers";
            this.totalCustomers.Size = new System.Drawing.Size(29, 16);
            this.totalCustomers.TabIndex = 56;
            this.totalCustomers.Text = "100";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalCustomers.Location = new System.Drawing.Point(22, 23);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(136, 16);
            this.lblTotalCustomers.TabIndex = 55;
            this.lblTotalCustomers.Text = "Tổng số khách hàng";
            // 
            // xuiSegmentKH
            // 
            this.xuiSegmentKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiSegmentKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiSegmentKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSegmentKH.Items = "Tất cả, Nam, Nữ";
            this.xuiSegmentKH.Location = new System.Drawing.Point(512, 130);
            this.xuiSegmentKH.Margin = new System.Windows.Forms.Padding(2);
            this.xuiSegmentKH.Name = "xuiSegmentKH";
            this.xuiSegmentKH.SegmentActiveTextColor = System.Drawing.SystemColors.Highlight;
            this.xuiSegmentKH.SegmentBackColor = System.Drawing.Color.CornflowerBlue;
            this.xuiSegmentKH.SegmentColor = System.Drawing.Color.Blue;
            this.xuiSegmentKH.SegmentInactiveTextColor = System.Drawing.Color.White;
            this.xuiSegmentKH.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.xuiSegmentKH.SelectedIndex = 0;
            this.xuiSegmentKH.Size = new System.Drawing.Size(314, 34);
            this.xuiSegmentKH.TabIndex = 50;
            this.xuiSegmentKH.Click += new System.EventHandler(this.XuiSegmentKH_Click);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnHDKH);
            this.panel1.Location = new System.Drawing.Point(832, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 51);
            this.panel1.TabIndex = 64;
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
            this.btnHDKH.TabIndex = 11;
            this.btnHDKH.Text = " Hóa đơn khách hàng";
            this.btnHDKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHDKH.UseVisualStyleBackColor = false;
            this.btnHDKH.Click += new System.EventHandler(this.BtnHDKH_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblTotalMaleCustomers);
            this.panelHeader.Controls.Add(this.lblTotalCustomers);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.totalCustomers);
            this.panelHeader.Controls.Add(this.pictureBox3);
            this.panelHeader.Controls.Add(this.totalMaleCustomers);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Controls.Add(this.lblTotalFemaleCustomers);
            this.panelHeader.Controls.Add(this.totalFemaleCustomers);
            this.panelHeader.Location = new System.Drawing.Point(12, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(957, 95);
            this.panelHeader.TabIndex = 65;
            // 
            // dgvQLKHNV
            // 
            this.dgvQLKHNV.AllowUserToAddRows = false;
            this.dgvQLKHNV.AllowUserToDeleteRows = false;
            this.dgvQLKHNV.AllowUserToResizeColumns = false;
            this.dgvQLKHNV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQLKHNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLKHNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLKHNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLKHNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLKHNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLKHNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLKHNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLKHNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLKHNV.ColumnHeadersHeight = 30;
            this.dgvQLKHNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLKHNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvQLKHNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLKHNV.EnableHeadersVisualStyles = false;
            this.dgvQLKHNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.dgvQLKHNV.Location = new System.Drawing.Point(11, 170);
            this.dgvQLKHNV.Name = "dgvQLKHNV";
            this.dgvQLKHNV.ReadOnly = true;
            this.dgvQLKHNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLKHNV.RowHeadersVisible = false;
            this.dgvQLKHNV.RowHeadersWidth = 60;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQLKHNV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLKHNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLKHNV.Size = new System.Drawing.Size(816, 413);
            this.dgvQLKHNV.TabIndex = 66;
            this.dgvQLKHNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLKHNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLKHNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLKHNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLKHNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLKHNV.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLKHNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.dgvQLKHNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLKHNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLKHNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLKHNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLKHNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLKHNV.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQLKHNV.ThemeStyle.ReadOnly = true;
            this.dgvQLKHNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLKHNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLKHNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLKHNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dgvQLKHNV.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLKHNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLKHNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLKHNV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvQLKH_RowHeaderMouseClick);
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
            // FormQLKHNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.dgvQLKHNV);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTKKH);
            this.Controls.Add(this.rjtbTKKH);
            this.Controls.Add(this.xuiSegmentKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLKHNV";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.FormQLKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKHNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RJTextBox rjtbTKKH;
        private Guna.UI2.WinForms.Guna2Button btnTKKH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label totalFemaleCustomers;
        private System.Windows.Forms.Label lblTotalFemaleCustomers;
        private System.Windows.Forms.Label totalMaleCustomers;
        private System.Windows.Forms.Label lblTotalMaleCustomers;
        private System.Windows.Forms.Label totalCustomers;
        private System.Windows.Forms.Label lblTotalCustomers;
        private XanderUI.XUISegment xuiSegmentKH;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton btnHDKH;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLKHNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}