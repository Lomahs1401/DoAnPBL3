
namespace DoAnPBL3
{
    partial class FormChiTietHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.msgValidateID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIDNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIDNV = new System.Windows.Forms.Label();
            this.rjbtnOK = new DoAnPBL3.RJButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tbQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbNumDiverse = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalNumberBook = new System.Windows.Forms.Label();
            this.tbTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvQLBSNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelTitleBar.Size = new System.Drawing.Size(848, 41);
            this.panelTitleBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.dgvQLBSNV);
            this.panelContainer.Controls.Add(this.tbQuantity);
            this.panelContainer.Controls.Add(this.lblQuantity);
            this.panelContainer.Controls.Add(this.tbNumDiverse);
            this.panelContainer.Controls.Add(this.lblTotalNumberBook);
            this.panelContainer.Controls.Add(this.tbTotal);
            this.panelContainer.Controls.Add(this.lblTotal);
            this.panelContainer.Controls.Add(this.msgValidateID);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.tbIDNV);
            this.panelContainer.Controls.Add(this.lblIDNV);
            this.panelContainer.Controls.Add(this.rjbtnOK);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.Location = new System.Drawing.Point(0, 41);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(848, 738);
            this.panelContainer.TabIndex = 5;
            // 
            // msgValidateID
            // 
            this.msgValidateID.AutoSize = true;
            this.msgValidateID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateID.Location = new System.Drawing.Point(118, 73);
            this.msgValidateID.Name = "msgValidateID";
            this.msgValidateID.Size = new System.Drawing.Size(0, 16);
            this.msgValidateID.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 55;
            // 
            // tbIDNV
            // 
            this.tbIDNV.Animated = true;
            this.tbIDNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbIDNV.BorderRadius = 6;
            this.tbIDNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDNV.DefaultText = "";
            this.tbIDNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbIDNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbIDNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbIDNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbIDNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbIDNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDNV.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbIDNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbIDNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDNV.Location = new System.Drawing.Point(117, 23);
            this.tbIDNV.Name = "tbIDNV";
            this.tbIDNV.PasswordChar = '\0';
            this.tbIDNV.PlaceholderText = "Mã hóa đơn";
            this.tbIDNV.SelectedText = "";
            this.tbIDNV.Size = new System.Drawing.Size(306, 30);
            this.tbIDNV.TabIndex = 0;
            // 
            // lblIDNV
            // 
            this.lblIDNV.AutoSize = true;
            this.lblIDNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIDNV.Location = new System.Drawing.Point(9, 29);
            this.lblIDNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDNV.Name = "lblIDNV";
            this.lblIDNV.Size = new System.Drawing.Size(92, 18);
            this.lblIDNV.TabIndex = 52;
            this.lblIDNV.Text = "Mã hóa đơn";
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
            this.rjbtnOK.Location = new System.Drawing.Point(354, 679);
            this.rjbtnOK.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnOK.Name = "rjbtnOK";
            this.rjbtnOK.Size = new System.Drawing.Size(145, 36);
            this.rjbtnOK.TabIndex = 11;
            this.rjbtnOK.Text = "OK";
            this.rjbtnOK.TextColor = System.Drawing.Color.White;
            this.rjbtnOK.UseVisualStyleBackColor = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 10;
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.White;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // tbQuantity
            // 
            this.tbQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.BorderRadius = 2;
            this.tbQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQuantity.DefaultText = "";
            this.tbQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.DisabledState.ForeColor = System.Drawing.Color.LightGray;
            this.tbQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuantity.Enabled = false;
            this.tbQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.ForeColor = System.Drawing.Color.LightGray;
            this.tbQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQuantity.Location = new System.Drawing.Point(403, 591);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.PasswordChar = '\0';
            this.tbQuantity.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.PlaceholderText = "";
            this.tbQuantity.ReadOnly = true;
            this.tbQuantity.SelectedText = "";
            this.tbQuantity.Size = new System.Drawing.Size(130, 30);
            this.tbQuantity.TabIndex = 62;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(285, 599);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(112, 18);
            this.lblQuantity.TabIndex = 61;
            this.lblQuantity.Text = "Số lượng sách";
            // 
            // tbNumDiverse
            // 
            this.tbNumDiverse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNumDiverse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNumDiverse.DefaultText = "";
            this.tbNumDiverse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNumDiverse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNumDiverse.DisabledState.ForeColor = System.Drawing.Color.LightGray;
            this.tbNumDiverse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNumDiverse.Enabled = false;
            this.tbNumDiverse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNumDiverse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumDiverse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumDiverse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumDiverse.Location = new System.Drawing.Point(108, 592);
            this.tbNumDiverse.Name = "tbNumDiverse";
            this.tbNumDiverse.PasswordChar = '\0';
            this.tbNumDiverse.PlaceholderText = "";
            this.tbNumDiverse.ReadOnly = true;
            this.tbNumDiverse.SelectedText = "";
            this.tbNumDiverse.Size = new System.Drawing.Size(130, 30);
            this.tbNumDiverse.TabIndex = 60;
            // 
            // lblTotalNumberBook
            // 
            this.lblTotalNumberBook.AutoSize = true;
            this.lblTotalNumberBook.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalNumberBook.ForeColor = System.Drawing.Color.White;
            this.lblTotalNumberBook.Location = new System.Drawing.Point(9, 600);
            this.lblTotalNumberBook.Name = "lblTotalNumberBook";
            this.lblTotalNumberBook.Size = new System.Drawing.Size(93, 18);
            this.lblTotalNumberBook.TabIndex = 59;
            this.lblTotalNumberBook.Text = "Số loại sách";
            // 
            // tbTotal
            // 
            this.tbTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotal.DefaultText = "";
            this.tbTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbTotal.DisabledState.ForeColor = System.Drawing.Color.LightGray;
            this.tbTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTotal.Enabled = false;
            this.tbTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.ForeColor = System.Drawing.Color.LightGray;
            this.tbTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotal.Location = new System.Drawing.Point(626, 590);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.PasswordChar = '\0';
            this.tbTotal.PlaceholderText = "";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.SelectedText = "";
            this.tbTotal.Size = new System.Drawing.Size(211, 30);
            this.tbTotal.TabIndex = 58;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(571, 598);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 18);
            this.lblTotal.TabIndex = 57;
            this.lblTotal.Text = "Tổng:";
            // 
            // dgvQLBSNV
            // 
            this.dgvQLBSNV.AllowUserToAddRows = false;
            this.dgvQLBSNV.AllowUserToDeleteRows = false;
            this.dgvQLBSNV.AllowUserToResizeColumns = false;
            this.dgvQLBSNV.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dgvQLBSNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvQLBSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLBSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLBSNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLBSNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLBSNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLBSNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBSNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvQLBSNV.ColumnHeadersHeight = 30;
            this.dgvQLBSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLBSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Book,
            this.Name_Book,
            this.Name_Language,
            this.Price_Book,
            this.Quantity_Book});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLBSNV.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvQLBSNV.EnableHeadersVisualStyles = false;
            this.dgvQLBSNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.dgvQLBSNV.Location = new System.Drawing.Point(11, 155);
            this.dgvQLBSNV.Name = "dgvQLBSNV";
            this.dgvQLBSNV.ReadOnly = true;
            this.dgvQLBSNV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLBSNV.RowHeadersVisible = false;
            this.dgvQLBSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLBSNV.Size = new System.Drawing.Size(826, 413);
            this.dgvQLBSNV.TabIndex = 68;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLBSNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLBSNV.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvQLBSNV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLBSNV.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQLBSNV.ThemeStyle.ReadOnly = true;
            this.dgvQLBSNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLBSNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLBSNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLBSNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLBSNV.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLBSNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLBSNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(301, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 22);
            this.label2.TabIndex = 69;
            this.label2.Text = "Liệt kê sách trong hóa đơn";
            // 
            // ID_Book
            // 
            this.ID_Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Book.DataPropertyName = "ID_Book";
            this.ID_Book.FillWeight = 82.33902F;
            this.ID_Book.HeaderText = "ID_Sach";
            this.ID_Book.Name = "ID_Book";
            this.ID_Book.ReadOnly = true;
            // 
            // Name_Book
            // 
            this.Name_Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_Book.DataPropertyName = "NameBook";
            this.Name_Book.FillWeight = 144.9335F;
            this.Name_Book.HeaderText = "Tên sách";
            this.Name_Book.Name = "Name_Book";
            this.Name_Book.ReadOnly = true;
            // 
            // Name_Language
            // 
            this.Name_Language.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_Language.DataPropertyName = "NameLanguage";
            this.Name_Language.FillWeight = 81.99689F;
            this.Name_Language.HeaderText = "Đơn Giá";
            this.Name_Language.Name = "Name_Language";
            this.Name_Language.ReadOnly = true;
            // 
            // Price_Book
            // 
            this.Price_Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price_Book.DataPropertyName = "Price";
            this.Price_Book.FillWeight = 76.14212F;
            this.Price_Book.HeaderText = "Số lượng";
            this.Price_Book.Name = "Price_Book";
            this.Price_Book.ReadOnly = true;
            // 
            // Quantity_Book
            // 
            this.Quantity_Book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity_Book.DataPropertyName = "Quantity";
            this.Quantity_Book.FillWeight = 114.5885F;
            this.Quantity_Book.HeaderText = "Thành tiền";
            this.Quantity_Book.Name = "Quantity_Book";
            this.Quantity_Book.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.file;
            this.pictureBox1.Location = new System.Drawing.Point(141, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(545, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "Ngày xuất hóa đơn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(710, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "dd/mm/yyyy";
            // 
            // FormChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 779);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChiTietHoaDon";
            this.Text = "FormChiTietHoaDon";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLBSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label msgValidateID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbIDNV;
        private System.Windows.Forms.Label lblIDNV;
        private RJButton rjbtnOK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox tbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private Guna.UI2.WinForms.Guna2TextBox tbNumDiverse;
        private System.Windows.Forms.Label lblTotalNumberBook;
        private Guna.UI2.WinForms.Guna2TextBox tbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLBSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Book;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}