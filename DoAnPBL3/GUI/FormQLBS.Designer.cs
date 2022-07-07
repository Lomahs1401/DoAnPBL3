namespace DoAnPBL3
{
    partial class FormQLBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLBS));
            this.englishBook = new System.Windows.Forms.Label();
            this.lblEnglishBook = new System.Windows.Forms.Label();
            this.vietnameseBook = new System.Windows.Forms.Label();
            this.lblVietnameseBook = new System.Windows.Forms.Label();
            this.totalBook = new System.Windows.Forms.Label();
            this.lblTotalBook = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSXS = new FontAwesome.Sharp.IconButton();
            this.dgvQLBS = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cbbCritiaDetail = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbCriteria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnFind = new FontAwesome.Sharp.IconButton();
            this.btnTKS = new Guna.UI2.WinForms.Guna2Button();
            this.rjtbTKS = new DoAnPBL3.RJTextBox();
            this.rjDropDownMenuSXS = new DoAnPBL3.RJDropDownMenu(this.components);
            this.chữCáiTăngDầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chữCáiGiảmDầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáMuaSáchTăngDầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáMuaSáchGiảmDầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sốLượngSáchHiệnCóTăngDầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sốLượngSáchHiệnCóGiảmDầnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBS)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.rjDropDownMenuSXS.SuspendLayout();
            this.SuspendLayout();
            // 
            // englishBook
            // 
            this.englishBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.englishBook.AutoSize = true;
            this.englishBook.BackColor = System.Drawing.Color.Transparent;
            this.englishBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishBook.ForeColor = System.Drawing.Color.White;
            this.englishBook.Location = new System.Drawing.Point(801, 56);
            this.englishBook.Name = "englishBook";
            this.englishBook.Size = new System.Drawing.Size(29, 16);
            this.englishBook.TabIndex = 35;
            this.englishBook.Text = "100";
            // 
            // lblEnglishBook
            // 
            this.lblEnglishBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnglishBook.AutoSize = true;
            this.lblEnglishBook.BackColor = System.Drawing.Color.Transparent;
            this.lblEnglishBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglishBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblEnglishBook.Location = new System.Drawing.Point(757, 25);
            this.lblEnglishBook.Name = "lblEnglishBook";
            this.lblEnglishBook.Size = new System.Drawing.Size(123, 16);
            this.lblEnglishBook.TabIndex = 34;
            this.lblEnglishBook.Text = "Số sách tiếng Anh";
            // 
            // vietnameseBook
            // 
            this.vietnameseBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vietnameseBook.AutoSize = true;
            this.vietnameseBook.BackColor = System.Drawing.Color.Transparent;
            this.vietnameseBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vietnameseBook.ForeColor = System.Drawing.Color.White;
            this.vietnameseBook.Location = new System.Drawing.Point(444, 56);
            this.vietnameseBook.Name = "vietnameseBook";
            this.vietnameseBook.Size = new System.Drawing.Size(29, 16);
            this.vietnameseBook.TabIndex = 33;
            this.vietnameseBook.Text = "100";
            // 
            // lblVietnameseBook
            // 
            this.lblVietnameseBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVietnameseBook.AutoSize = true;
            this.lblVietnameseBook.BackColor = System.Drawing.Color.Transparent;
            this.lblVietnameseBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVietnameseBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblVietnameseBook.Location = new System.Drawing.Point(401, 25);
            this.lblVietnameseBook.Name = "lblVietnameseBook";
            this.lblVietnameseBook.Size = new System.Drawing.Size(123, 16);
            this.lblVietnameseBook.TabIndex = 32;
            this.lblVietnameseBook.Text = "Số sách tiếng Việt";
            // 
            // totalBook
            // 
            this.totalBook.AutoSize = true;
            this.totalBook.BackColor = System.Drawing.Color.Transparent;
            this.totalBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBook.ForeColor = System.Drawing.Color.White;
            this.totalBook.Location = new System.Drawing.Point(92, 56);
            this.totalBook.Name = "totalBook";
            this.totalBook.Size = new System.Drawing.Size(29, 16);
            this.totalBook.TabIndex = 31;
            this.totalBook.Text = "100";
            // 
            // lblTotalBook
            // 
            this.lblTotalBook.AutoSize = true;
            this.lblTotalBook.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalBook.Location = new System.Drawing.Point(36, 25);
            this.lblTotalBook.Name = "lblTotalBook";
            this.lblTotalBook.Size = new System.Drawing.Size(155, 16);
            this.lblTotalBook.TabIndex = 30;
            this.lblTotalBook.Text = "Tổng số sách đang bán";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnSXS);
            this.panel1.Location = new System.Drawing.Point(833, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 49);
            this.panel1.TabIndex = 39;
            // 
            // btnSXS
            // 
            this.btnSXS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSXS.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSXS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSXS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnSXS.FlatAppearance.BorderSize = 0;
            this.btnSXS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSXS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSXS.ForeColor = System.Drawing.Color.White;
            this.btnSXS.IconChar = FontAwesome.Sharp.IconChar.SortAmountDownAlt;
            this.btnSXS.IconColor = System.Drawing.Color.White;
            this.btnSXS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSXS.IconSize = 30;
            this.btnSXS.Location = new System.Drawing.Point(0, 2);
            this.btnSXS.Name = "btnSXS";
            this.btnSXS.Size = new System.Drawing.Size(142, 47);
            this.btnSXS.TabIndex = 12;
            this.btnSXS.Text = "Sắp xếp";
            this.btnSXS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSXS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSXS.UseVisualStyleBackColor = false;
            this.btnSXS.Click += new System.EventHandler(this.BtnSXS_Click);
            this.btnSXS.MouseEnter += new System.EventHandler(this.BtnSXS_MouseEnter);
            this.btnSXS.MouseLeave += new System.EventHandler(this.BtnSXS_MouseLeave);
            // 
            // dgvQLBS
            // 
            this.dgvQLBS.AllowUserToAddRows = false;
            this.dgvQLBS.AllowUserToDeleteRows = false;
            this.dgvQLBS.AllowUserToResizeColumns = false;
            this.dgvQLBS.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQLBS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLBS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLBS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLBS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.dgvQLBS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLBS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLBS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLBS.ColumnHeadersHeight = 30;
            this.dgvQLBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Book,
            this.NameBook,
            this.PublishDate,
            this.NameAuthor,
            this.NameLanguage,
            this.NamePublisher,
            this.NameGenre,
            this.Price,
            this.Quantity});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLBS.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLBS.EnableHeadersVisualStyles = false;
            this.dgvQLBS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLBS.Location = new System.Drawing.Point(12, 170);
            this.dgvQLBS.Name = "dgvQLBS";
            this.dgvQLBS.ReadOnly = true;
            this.dgvQLBS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLBS.RowHeadersVisible = false;
            this.dgvQLBS.RowHeadersWidth = 60;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQLBS.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLBS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLBS.Size = new System.Drawing.Size(816, 416);
            this.dgvQLBS.TabIndex = 40;
            this.dgvQLBS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLBS.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLBS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLBS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLBS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLBS.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.dgvQLBS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLBS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLBS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLBS.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLBS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLBS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLBS.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQLBS.ThemeStyle.ReadOnly = true;
            this.dgvQLBS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLBS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLBS.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLBS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dgvQLBS.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLBS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLBS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLBS.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvQLBS_RowHeaderMouseClick);
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblVietnameseBook);
            this.panelHeader.Controls.Add(this.lblTotalBook);
            this.panelHeader.Controls.Add(this.totalBook);
            this.panelHeader.Controls.Add(this.vietnameseBook);
            this.panelHeader.Controls.Add(this.pictureBox3);
            this.panelHeader.Controls.Add(this.lblEnglishBook);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.englishBook);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Location = new System.Drawing.Point(11, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(957, 95);
            this.panelHeader.TabIndex = 41;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(197, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.united_kingdom_flag;
            this.pictureBox1.Location = new System.Drawing.Point(878, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::DoAnPBL3.Properties.Resources.vietnam_flag;
            this.pictureBox2.Location = new System.Drawing.Point(522, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // lblSort
            // 
            this.lblSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSort.AutoSize = true;
            this.lblSort.BackColor = System.Drawing.Color.Transparent;
            this.lblSort.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblSort.Location = new System.Drawing.Point(456, 138);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(31, 16);
            this.lblSort.TabIndex = 43;
            this.lblSort.Text = "Lọc";
            // 
            // cbbCritiaDetail
            // 
            this.cbbCritiaDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCritiaDetail.BackColor = System.Drawing.Color.Transparent;
            this.cbbCritiaDetail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCritiaDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCritiaDetail.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCritiaDetail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCritiaDetail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbCritiaDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbCritiaDetail.ItemHeight = 30;
            this.cbbCritiaDetail.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbbCritiaDetail.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gainsboro;
            this.cbbCritiaDetail.Location = new System.Drawing.Point(649, 128);
            this.cbbCritiaDetail.Name = "cbbCritiaDetail";
            this.cbbCritiaDetail.Size = new System.Drawing.Size(96, 36);
            this.cbbCritiaDetail.TabIndex = 42;
            this.cbbCritiaDetail.SelectedIndexChanged += new System.EventHandler(this.CbbCritiaDetail_SelectedIndexChanged);
            // 
            // cbbCriteria
            // 
            this.cbbCriteria.BackColor = System.Drawing.Color.Transparent;
            this.cbbCriteria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCriteria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCriteria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbCriteria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbCriteria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbCriteria.ItemHeight = 30;
            this.cbbCriteria.Items.AddRange(new object[] {
            "Ngôn ngữ",
            "Nhà xuất bản",
            "Thể loại"});
            this.cbbCriteria.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.cbbCriteria.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gainsboro;
            this.cbbCriteria.Location = new System.Drawing.Point(493, 128);
            this.cbbCriteria.Name = "cbbCriteria";
            this.cbbCriteria.Size = new System.Drawing.Size(150, 36);
            this.cbbCriteria.TabIndex = 42;
            this.cbbCriteria.SelectedIndexChanged += new System.EventHandler(this.CbbCriteria_SelectedIndexChanged);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.IconChar = FontAwesome.Sharp.IconChar.SortAmountDownAlt;
            this.btnFind.IconColor = System.Drawing.Color.White;
            this.btnFind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFind.IconSize = 30;
            this.btnFind.Location = new System.Drawing.Point(751, 128);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(77, 36);
            this.btnFind.TabIndex = 44;
            this.btnFind.Text = "OK";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // btnTKS
            // 
            this.btnTKS.BorderRadius = 15;
            this.btnTKS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnTKS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTKS.ForeColor = System.Drawing.Color.White;
            this.btnTKS.Image = global::DoAnPBL3.Properties.Resources.icons8_search_20px;
            this.btnTKS.Location = new System.Drawing.Point(294, 133);
            this.btnTKS.Name = "btnTKS";
            this.btnTKS.Size = new System.Drawing.Size(141, 31);
            this.btnTKS.TabIndex = 22;
            this.btnTKS.Text = "Tìm kiếm";
            this.btnTKS.Click += new System.EventHandler(this.BtnTKS_Click);
            // 
            // rjtbTKS
            // 
            this.rjtbTKS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.rjtbTKS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(35)))));
            this.rjtbTKS.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.rjtbTKS.BorderRadius = 15;
            this.rjtbTKS.BorderSize = 1;
            this.rjtbTKS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjtbTKS.ForeColor = System.Drawing.Color.Silver;
            this.rjtbTKS.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rjtbTKS.Location = new System.Drawing.Point(6, 133);
            this.rjtbTKS.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbTKS.Multiline = false;
            this.rjtbTKS.Name = "rjtbTKS";
            this.rjtbTKS.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbTKS.PasswordChar = false;
            this.rjtbTKS.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.rjtbTKS.PlaceholderText = "Tìm kiếm theo ID, tên sách hoặc tên tác giả";
            this.rjtbTKS.Size = new System.Drawing.Size(281, 31);
            this.rjtbTKS.TabIndex = 16;
            this.rjtbTKS.Texts = "";
            this.rjtbTKS.UnderlinedStyle = false;
            this.rjtbTKS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RjtbTKS_KeyPress);
            // 
            // rjDropDownMenuSXS
            // 
            this.rjDropDownMenuSXS.BackColor = System.Drawing.Color.Silver;
            this.rjDropDownMenuSXS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDropDownMenuSXS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropDownMenuSXS.IsMainMenu = false;
            this.rjDropDownMenuSXS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chữCáiTăngDầnToolStripMenuItem,
            this.chữCáiGiảmDầnToolStripMenuItem,
            this.giáMuaSáchTăngDầnToolStripMenuItem,
            this.giáMuaSáchGiảmDầnToolStripMenuItem,
            this.sốLượngSáchHiệnCóTăngDầnToolStripMenuItem,
            this.sốLượngSáchHiệnCóGiảmDầnToolStripMenuItem});
            this.rjDropDownMenuSXS.MenuItemHeight = 25;
            this.rjDropDownMenuSXS.MenuItemTextColor = System.Drawing.Color.DarkSlateBlue;
            this.rjDropDownMenuSXS.Name = "rjDropDownMenu1";
            this.rjDropDownMenuSXS.PrimaryColor = System.Drawing.Color.DarkSlateBlue;
            this.rjDropDownMenuSXS.Size = new System.Drawing.Size(258, 136);
            // 
            // chữCáiTăngDầnToolStripMenuItem
            // 
            this.chữCáiTăngDầnToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.chữCáiTăngDầnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.chữCáiTăngDầnToolStripMenuItem.Name = "chữCáiTăngDầnToolStripMenuItem";
            this.chữCáiTăngDầnToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.chữCáiTăngDầnToolStripMenuItem.Text = "Chữ cái tăng dần";
            this.chữCáiTăngDầnToolStripMenuItem.Click += new System.EventHandler(this.ChữCáiTăngDầnToolStripMenuItem_Click);
            // 
            // chữCáiGiảmDầnToolStripMenuItem
            // 
            this.chữCáiGiảmDầnToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.chữCáiGiảmDầnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.chữCáiGiảmDầnToolStripMenuItem.Name = "chữCáiGiảmDầnToolStripMenuItem";
            this.chữCáiGiảmDầnToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.chữCáiGiảmDầnToolStripMenuItem.Text = "Chữ cái giảm dần";
            this.chữCáiGiảmDầnToolStripMenuItem.Click += new System.EventHandler(this.ChữCáiGiảmDầnToolStripMenuItem_Click);
            // 
            // giáMuaSáchTăngDầnToolStripMenuItem
            // 
            this.giáMuaSáchTăngDầnToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.giáMuaSáchTăngDầnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.giáMuaSáchTăngDầnToolStripMenuItem.Name = "giáMuaSáchTăngDầnToolStripMenuItem";
            this.giáMuaSáchTăngDầnToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.giáMuaSáchTăngDầnToolStripMenuItem.Text = "Giá mua sách tăng dần";
            this.giáMuaSáchTăngDầnToolStripMenuItem.Click += new System.EventHandler(this.GiáMuaSáchTăngDầnToolStripMenuItem_Click);
            // 
            // giáMuaSáchGiảmDầnToolStripMenuItem
            // 
            this.giáMuaSáchGiảmDầnToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.giáMuaSáchGiảmDầnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.giáMuaSáchGiảmDầnToolStripMenuItem.Name = "giáMuaSáchGiảmDầnToolStripMenuItem";
            this.giáMuaSáchGiảmDầnToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.giáMuaSáchGiảmDầnToolStripMenuItem.Text = "Giá mua sách giảm dần";
            this.giáMuaSáchGiảmDầnToolStripMenuItem.Click += new System.EventHandler(this.GiáMuaSáchGiảmDầnToolStripMenuItem_Click);
            // 
            // sốLượngSáchHiệnCóTăngDầnToolStripMenuItem
            // 
            this.sốLượngSáchHiệnCóTăngDầnToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.sốLượngSáchHiệnCóTăngDầnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sốLượngSáchHiệnCóTăngDầnToolStripMenuItem.Name = "sốLượngSáchHiệnCóTăngDầnToolStripMenuItem";
            this.sốLượngSáchHiệnCóTăngDầnToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.sốLượngSáchHiệnCóTăngDầnToolStripMenuItem.Text = "Số lượng sách hiện có tăng dần";
            this.sốLượngSáchHiệnCóTăngDầnToolStripMenuItem.Click += new System.EventHandler(this.SốLượngSáchHiệnCóTăngDầnToolStripMenuItem_Click);
            // 
            // sốLượngSáchHiệnCóGiảmDầnToolStripMenuItem
            // 
            this.sốLượngSáchHiệnCóGiảmDầnToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.sốLượngSáchHiệnCóGiảmDầnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sốLượngSáchHiệnCóGiảmDầnToolStripMenuItem.Name = "sốLượngSáchHiệnCóGiảmDầnToolStripMenuItem";
            this.sốLượngSáchHiệnCóGiảmDầnToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.sốLượngSáchHiệnCóGiảmDầnToolStripMenuItem.Text = "Số lượng sách hiện có giảm dần";
            this.sốLượngSáchHiệnCóGiảmDầnToolStripMenuItem.Click += new System.EventHandler(this.SốLượngSáchHiệnCóGiảmDầnToolStripMenuItem_Click);
            // 
            // ID_Book
            // 
            this.ID_Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Book.DataPropertyName = "ID_Book";
            this.ID_Book.FillWeight = 73.05836F;
            this.ID_Book.HeaderText = "ID";
            this.ID_Book.Name = "ID_Book";
            this.ID_Book.ReadOnly = true;
            // 
            // NameBook
            // 
            this.NameBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameBook.DataPropertyName = "NameBook";
            this.NameBook.FillWeight = 151.5565F;
            this.NameBook.HeaderText = "Tên sách";
            this.NameBook.Name = "NameBook";
            this.NameBook.ReadOnly = true;
            // 
            // PublishDate
            // 
            this.PublishDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PublishDate.DataPropertyName = "PublishDate";
            this.PublishDate.FillWeight = 70.97385F;
            this.PublishDate.HeaderText = "Ngày xuất bản";
            this.PublishDate.Name = "PublishDate";
            this.PublishDate.ReadOnly = true;
            // 
            // NameAuthor
            // 
            this.NameAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameAuthor.DataPropertyName = "NameAuthor";
            this.NameAuthor.FillWeight = 118.0675F;
            this.NameAuthor.HeaderText = "Tác giả";
            this.NameAuthor.Name = "NameAuthor";
            this.NameAuthor.ReadOnly = true;
            // 
            // NameLanguage
            // 
            this.NameLanguage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameLanguage.DataPropertyName = "NameLanguage";
            this.NameLanguage.FillWeight = 118.0675F;
            this.NameLanguage.HeaderText = "Ngôn ngữ";
            this.NameLanguage.Name = "NameLanguage";
            this.NameLanguage.ReadOnly = true;
            // 
            // NamePublisher
            // 
            this.NamePublisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamePublisher.DataPropertyName = "NamePublisher";
            this.NamePublisher.FillWeight = 116.6275F;
            this.NamePublisher.HeaderText = "Nhà xuất bản";
            this.NamePublisher.Name = "NamePublisher";
            this.NamePublisher.ReadOnly = true;
            // 
            // NameGenre
            // 
            this.NameGenre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameGenre.DataPropertyName = "NameGenre";
            this.NameGenre.FillWeight = 92.63647F;
            this.NameGenre.HeaderText = "Thể loại";
            this.NameGenre.Name = "NameGenre";
            this.NameGenre.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 76.77856F;
            this.Price.HeaderText = "Giá tiền";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 82.2335F;
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // FormQLBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.cbbCritiaDetail);
            this.Controls.Add(this.cbbCriteria);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgvQLBS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTKS);
            this.Controls.Add(this.rjtbTKS);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLBS";
            this.Text = "Quản lý bán sách";
            this.Load += new System.EventHandler(this.FormQLBS_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBS)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.rjDropDownMenuSXS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSXS;
        private RJTextBox rjtbTKS;
        private RJDropDownMenu rjDropDownMenuSXS;
        private System.Windows.Forms.ToolStripMenuItem chữCáiGiảmDầnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chữCáiTăngDầnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáMuaSáchTăngDầnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáMuaSáchGiảmDầnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sốLượngSáchHiệnCóTăngDầnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sốLượngSáchHiệnCóGiảmDầnToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnTKS;
        private System.Windows.Forms.Label englishBook;
        private System.Windows.Forms.Label lblEnglishBook;
        private System.Windows.Forms.Label vietnameseBook;
        private System.Windows.Forms.Label lblVietnameseBook;
        private System.Windows.Forms.Label totalBook;
        private System.Windows.Forms.Label lblTotalBook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLBS;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblSort;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCritiaDetail;
        private FontAwesome.Sharp.IconButton btnFind;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCriteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}