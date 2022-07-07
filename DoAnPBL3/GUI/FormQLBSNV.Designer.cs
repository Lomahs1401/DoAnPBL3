
namespace DoAnPBL3
{
    partial class FormQLBSNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLBSNV));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.totalEnglishBooks = new System.Windows.Forms.Label();
            this.lblTotalEnglishBook = new System.Windows.Forms.Label();
            this.totalVietnameseBooks = new System.Windows.Forms.Label();
            this.lblTotalVietnameseBook = new System.Windows.Forms.Label();
            this.totalBooks = new System.Windows.Forms.Label();
            this.lblTotalBook = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjbtnAddCart = new DoAnPBL3.RJButton();
            this.NotificationCircle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblNotificationCounter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CartIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTKS = new Guna.UI2.WinForms.Guna2Button();
            this.rjtbTKS = new DoAnPBL3.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFind = new FontAwesome.Sharp.IconButton();
            this.lblSort = new System.Windows.Forms.Label();
            this.cbbCritiaDetail = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbCriteria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvQLBSNV = new Guna.UI2.WinForms.Guna2DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.CartIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // totalEnglishBooks
            // 
            this.totalEnglishBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalEnglishBooks.AutoSize = true;
            this.totalEnglishBooks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEnglishBooks.ForeColor = System.Drawing.Color.White;
            this.totalEnglishBooks.Location = new System.Drawing.Point(816, 56);
            this.totalEnglishBooks.Name = "totalEnglishBooks";
            this.totalEnglishBooks.Size = new System.Drawing.Size(29, 16);
            this.totalEnglishBooks.TabIndex = 61;
            this.totalEnglishBooks.Text = "100";
            // 
            // lblTotalEnglishBook
            // 
            this.lblTotalEnglishBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalEnglishBook.AutoSize = true;
            this.lblTotalEnglishBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEnglishBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalEnglishBook.Location = new System.Drawing.Point(772, 25);
            this.lblTotalEnglishBook.Name = "lblTotalEnglishBook";
            this.lblTotalEnglishBook.Size = new System.Drawing.Size(123, 16);
            this.lblTotalEnglishBook.TabIndex = 60;
            this.lblTotalEnglishBook.Text = "Số sách tiếng Anh";
            // 
            // totalVietnameseBooks
            // 
            this.totalVietnameseBooks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalVietnameseBooks.AutoSize = true;
            this.totalVietnameseBooks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVietnameseBooks.ForeColor = System.Drawing.Color.White;
            this.totalVietnameseBooks.Location = new System.Drawing.Point(451, 56);
            this.totalVietnameseBooks.Name = "totalVietnameseBooks";
            this.totalVietnameseBooks.Size = new System.Drawing.Size(29, 16);
            this.totalVietnameseBooks.TabIndex = 59;
            this.totalVietnameseBooks.Text = "100";
            // 
            // lblTotalVietnameseBook
            // 
            this.lblTotalVietnameseBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalVietnameseBook.AutoSize = true;
            this.lblTotalVietnameseBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVietnameseBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalVietnameseBook.Location = new System.Drawing.Point(408, 25);
            this.lblTotalVietnameseBook.Name = "lblTotalVietnameseBook";
            this.lblTotalVietnameseBook.Size = new System.Drawing.Size(123, 16);
            this.lblTotalVietnameseBook.TabIndex = 58;
            this.lblTotalVietnameseBook.Text = "Số sách tiếng Việt";
            // 
            // totalBooks
            // 
            this.totalBooks.AutoSize = true;
            this.totalBooks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBooks.ForeColor = System.Drawing.Color.White;
            this.totalBooks.Location = new System.Drawing.Point(86, 56);
            this.totalBooks.Name = "totalBooks";
            this.totalBooks.Size = new System.Drawing.Size(29, 16);
            this.totalBooks.TabIndex = 57;
            this.totalBooks.Text = "100";
            // 
            // lblTotalBook
            // 
            this.lblTotalBook.AutoSize = true;
            this.lblTotalBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalBook.Location = new System.Drawing.Point(30, 25);
            this.lblTotalBook.Name = "lblTotalBook";
            this.lblTotalBook.Size = new System.Drawing.Size(155, 16);
            this.lblTotalBook.TabIndex = 56;
            this.lblTotalBook.Text = "Tổng số sách đang bán";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rjbtnAddCart);
            this.panel1.Location = new System.Drawing.Point(828, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 51);
            this.panel1.TabIndex = 66;
            // 
            // rjbtnAddCart
            // 
            this.rjbtnAddCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjbtnAddCart.BackColor = System.Drawing.Color.DodgerBlue;
            this.rjbtnAddCart.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.rjbtnAddCart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjbtnAddCart.BorderRadius = 20;
            this.rjbtnAddCart.BorderSize = 0;
            this.rjbtnAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjbtnAddCart.FlatAppearance.BorderSize = 0;
            this.rjbtnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjbtnAddCart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjbtnAddCart.ForeColor = System.Drawing.Color.White;
            this.rjbtnAddCart.Image = global::DoAnPBL3.Properties.Resources.icons8_add_shopping_cart_30px;
            this.rjbtnAddCart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjbtnAddCart.Location = new System.Drawing.Point(0, 3);
            this.rjbtnAddCart.Name = "rjbtnAddCart";
            this.rjbtnAddCart.Padding = new System.Windows.Forms.Padding(18, 0, 16, 0);
            this.rjbtnAddCart.Size = new System.Drawing.Size(150, 40);
            this.rjbtnAddCart.TabIndex = 65;
            this.rjbtnAddCart.Text = "Thêm vào giỏ hàng";
            this.rjbtnAddCart.TextColor = System.Drawing.Color.White;
            this.rjbtnAddCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjbtnAddCart.UseVisualStyleBackColor = false;
            this.rjbtnAddCart.Click += new System.EventHandler(this.RjbtnAddCart_Click);
            // 
            // NotificationCircle
            // 
            this.NotificationCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationCircle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NotificationCircle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NotificationCircle.DisabledState.FillColor = System.Drawing.Color.Firebrick;
            this.NotificationCircle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NotificationCircle.Enabled = false;
            this.NotificationCircle.FillColor = System.Drawing.Color.Firebrick;
            this.NotificationCircle.Font = new System.Drawing.Font("Arial", 5.25F);
            this.NotificationCircle.ForeColor = System.Drawing.Color.White;
            this.NotificationCircle.Location = new System.Drawing.Point(914, 122);
            this.NotificationCircle.Name = "NotificationCircle";
            this.NotificationCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.NotificationCircle.Size = new System.Drawing.Size(28, 28);
            this.NotificationCircle.TabIndex = 69;
            // 
            // lblNotificationCounter
            // 
            this.lblNotificationCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotificationCounter.AutoSize = true;
            this.lblNotificationCounter.BackColor = System.Drawing.Color.Firebrick;
            this.lblNotificationCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNotificationCounter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificationCounter.ForeColor = System.Drawing.Color.White;
            this.lblNotificationCounter.Location = new System.Drawing.Point(922, 129);
            this.lblNotificationCounter.Name = "lblNotificationCounter";
            this.lblNotificationCounter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNotificationCounter.Size = new System.Drawing.Size(13, 14);
            this.lblNotificationCounter.TabIndex = 70;
            this.lblNotificationCounter.Text = "0";
            this.lblNotificationCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // CartIcon
            // 
            this.CartIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CartIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CartIcon.Image = global::DoAnPBL3.Properties.Resources.icons8_shopping_cart_52;
            this.CartIcon.Location = new System.Drawing.Point(854, 131);
            this.CartIcon.Name = "CartIcon";
            this.CartIcon.Size = new System.Drawing.Size(99, 44);
            this.CartIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CartIcon.TabIndex = 68;
            this.CartIcon.TabStop = false;
            this.CartIcon.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(191, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.united_kingdom_flag;
            this.pictureBox1.Location = new System.Drawing.Point(893, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::DoAnPBL3.Properties.Resources.vietnam_flag;
            this.pictureBox2.Location = new System.Drawing.Point(529, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // btnTKS
            // 
            this.btnTKS.BorderRadius = 15;
            this.btnTKS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKS.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnTKS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTKS.ForeColor = System.Drawing.Color.White;
            this.btnTKS.Image = global::DoAnPBL3.Properties.Resources.icons8_search_20px;
            this.btnTKS.Location = new System.Drawing.Point(293, 132);
            this.btnTKS.Name = "btnTKS";
            this.btnTKS.Size = new System.Drawing.Size(141, 32);
            this.btnTKS.TabIndex = 55;
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
            this.rjtbTKS.Location = new System.Drawing.Point(6, 133);
            this.rjtbTKS.Margin = new System.Windows.Forms.Padding(4);
            this.rjtbTKS.Multiline = false;
            this.rjtbTKS.Name = "rjtbTKS";
            this.rjtbTKS.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjtbTKS.PasswordChar = false;
            this.rjtbTKS.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(83)))), ((int)(((byte)(103)))));
            this.rjtbTKS.PlaceholderText = "Tìm kiếm theo ID, tên sách hoặc tên tác giả";
            this.rjtbTKS.Size = new System.Drawing.Size(280, 31);
            this.rjtbTKS.TabIndex = 37;
            this.rjtbTKS.Texts = "";
            this.rjtbTKS.UnderlinedStyle = false;
            this.rjtbTKS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RjtbTKS_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalVietnameseBook);
            this.panel2.Controls.Add(this.lblTotalBook);
            this.panel2.Controls.Add(this.totalBooks);
            this.panel2.Controls.Add(this.totalVietnameseBooks);
            this.panel2.Controls.Add(this.lblTotalEnglishBook);
            this.panel2.Controls.Add(this.totalEnglishBooks);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 95);
            this.panel2.TabIndex = 71;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.btnFind.Location = new System.Drawing.Point(746, 127);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(77, 36);
            this.btnFind.TabIndex = 72;
            this.btnFind.Text = "OK";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // lblSort
            // 
            this.lblSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSort.AutoSize = true;
            this.lblSort.BackColor = System.Drawing.Color.Transparent;
            this.lblSort.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblSort.Location = new System.Drawing.Point(451, 137);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(31, 16);
            this.lblSort.TabIndex = 71;
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
            this.cbbCritiaDetail.Location = new System.Drawing.Point(644, 127);
            this.cbbCritiaDetail.Name = "cbbCritiaDetail";
            this.cbbCritiaDetail.Size = new System.Drawing.Size(96, 36);
            this.cbbCritiaDetail.TabIndex = 69;
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
            this.cbbCriteria.Location = new System.Drawing.Point(488, 127);
            this.cbbCriteria.Name = "cbbCriteria";
            this.cbbCriteria.Size = new System.Drawing.Size(150, 36);
            this.cbbCriteria.TabIndex = 70;
            this.cbbCriteria.SelectedIndexChanged += new System.EventHandler(this.CbbCriteria_SelectedIndexChanged);
            // 
            // dgvQLBSNV
            // 
            this.dgvQLBSNV.AllowUserToAddRows = false;
            this.dgvQLBSNV.AllowUserToDeleteRows = false;
            this.dgvQLBSNV.AllowUserToResizeColumns = false;
            this.dgvQLBSNV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQLBSNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLBSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLBSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLBSNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLBSNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLBSNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLBSNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBSNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLBSNV.ColumnHeadersHeight = 30;
            this.dgvQLBSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLBSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvQLBSNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLBSNV.EnableHeadersVisualStyles = false;
            this.dgvQLBSNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.dgvQLBSNV.Location = new System.Drawing.Point(12, 173);
            this.dgvQLBSNV.Name = "dgvQLBSNV";
            this.dgvQLBSNV.ReadOnly = true;
            this.dgvQLBSNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLBSNV.RowHeadersVisible = false;
            this.dgvQLBSNV.RowHeadersWidth = 60;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQLBSNV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLBSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLBSNV.Size = new System.Drawing.Size(816, 413);
            this.dgvQLBSNV.TabIndex = 73;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLBSNV.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLBSNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQLBSNV.ThemeStyle.ReadOnly = true;
            this.dgvQLBSNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLBSNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLBSNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQLBSNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dgvQLBSNV.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLBSNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLBSNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLBSNV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvQLBSNV_RowHeaderMouseClick);
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
            // FormQLBSNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.dgvQLBSNV);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblNotificationCounter);
            this.Controls.Add(this.cbbCritiaDetail);
            this.Controls.Add(this.NotificationCircle);
            this.Controls.Add(this.cbbCriteria);
            this.Controls.Add(this.CartIcon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTKS);
            this.Controls.Add(this.rjtbTKS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLBSNV";
            this.Text = "Bán sách";
            this.Load += new System.EventHandler(this.FormQLBSNV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CartIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RJTextBox rjtbTKS;
        private Guna.UI2.WinForms.Guna2Button btnTKS;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label totalEnglishBooks;
        private System.Windows.Forms.Label lblTotalEnglishBook;
        private System.Windows.Forms.Label totalVietnameseBooks;
        private System.Windows.Forms.Label lblTotalVietnameseBook;
        private System.Windows.Forms.Label totalBooks;
        private System.Windows.Forms.Label lblTotalBook;
        private RJButton rjbtnAddCart;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CartIcon;
        private Guna.UI2.WinForms.Guna2CircleButton NotificationCircle;
        private System.Windows.Forms.Label lblNotificationCounter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnFind;
        private System.Windows.Forms.Label lblSort;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCritiaDetail;
        private Guna.UI2.WinForms.Guna2ComboBox cbbCriteria;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLBSNV;
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