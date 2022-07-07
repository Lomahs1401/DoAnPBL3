
namespace DoAnPBL3
{
    partial class FormMenuNote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuNote));
            this.lblNote = new System.Windows.Forms.Label();
            this.dgvQLGC = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteNote = new FontAwesome.Sharp.IconButton();
            this.btnAddNote = new FontAwesome.Sharp.IconButton();
            this.btnEditNote = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLGC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(389, 118);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(183, 22);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Danh sách ghi chú";
            // 
            // dgvQLGC
            // 
            this.dgvQLGC.AllowUserToAddRows = false;
            this.dgvQLGC.AllowUserToDeleteRows = false;
            this.dgvQLGC.AllowUserToResizeColumns = false;
            this.dgvQLGC.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvQLGC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLGC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLGC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLGC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.dgvQLGC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLGC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLGC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(16)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLGC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLGC.ColumnHeadersHeight = 30;
            this.dgvQLGC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLGC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Date});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLGC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLGC.EnableHeadersVisualStyles = false;
            this.dgvQLGC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLGC.Location = new System.Drawing.Point(3, 160);
            this.dgvQLGC.Name = "dgvQLGC";
            this.dgvQLGC.ReadOnly = true;
            this.dgvQLGC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLGC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLGC.RowHeadersVisible = false;
            this.dgvQLGC.RowHeadersWidth = 60;
            this.dgvQLGC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLGC.Size = new System.Drawing.Size(816, 424);
            this.dgvQLGC.TabIndex = 48;
            this.dgvQLGC.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLGC.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQLGC.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQLGC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQLGC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQLGC.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.dgvQLGC.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLGC.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvQLGC.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLGC.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLGC.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQLGC.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLGC.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQLGC.ThemeStyle.ReadOnly = true;
            this.dgvQLGC.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQLGC.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLGC.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvQLGC.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLGC.ThemeStyle.RowsStyle.Height = 22;
            this.dgvQLGC.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQLGC.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQLGC.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvQLGC_RowHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 37.30277F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 251.3677F;
            this.Title.HeaderText = "Tiêu đề";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.FillWeight = 78.76186F;
            this.Date.HeaderText = "Ngày tạo";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnDeleteNote);
            this.panel1.Controls.Add(this.btnAddNote);
            this.panel1.Controls.Add(this.btnEditNote);
            this.panel1.Location = new System.Drawing.Point(825, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 149);
            this.panel1.TabIndex = 49;
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteNote.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnDeleteNote.FlatAppearance.BorderSize = 0;
            this.btnDeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNote.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNote.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDeleteNote.IconColor = System.Drawing.Color.White;
            this.btnDeleteNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteNote.IconSize = 30;
            this.btnDeleteNote.Location = new System.Drawing.Point(4, 102);
            this.btnDeleteNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(143, 44);
            this.btnDeleteNote.TabIndex = 1;
            this.btnDeleteNote.Text = "Xóa";
            this.btnDeleteNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteNote.UseVisualStyleBackColor = false;
            this.btnDeleteNote.Click += new System.EventHandler(this.BtnDeleteNote_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNote.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnAddNote.FlatAppearance.BorderSize = 0;
            this.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNote.ForeColor = System.Drawing.Color.White;
            this.btnAddNote.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddNote.IconColor = System.Drawing.Color.White;
            this.btnAddNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNote.IconSize = 30;
            this.btnAddNote.Location = new System.Drawing.Point(4, 2);
            this.btnAddNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(143, 44);
            this.btnAddNote.TabIndex = 0;
            this.btnAddNote.Text = "Thêm";
            this.btnAddNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNote.UseVisualStyleBackColor = false;
            this.btnAddNote.Click += new System.EventHandler(this.BtnAddNote_Click);
            // 
            // btnEditNote
            // 
            this.btnEditNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditNote.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnEditNote.FlatAppearance.BorderSize = 0;
            this.btnEditNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditNote.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditNote.ForeColor = System.Drawing.Color.White;
            this.btnEditNote.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditNote.IconColor = System.Drawing.Color.White;
            this.btnEditNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditNote.IconSize = 30;
            this.btnEditNote.Location = new System.Drawing.Point(4, 52);
            this.btnEditNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditNote.Name = "btnEditNote";
            this.btnEditNote.Size = new System.Drawing.Size(143, 44);
            this.btnEditNote.TabIndex = 2;
            this.btnEditNote.Text = "Sửa";
            this.btnEditNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditNote.UseVisualStyleBackColor = false;
            this.btnEditNote.Click += new System.EventHandler(this.BtnEditNote_Click);
            // 
            // FormMenuNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(980, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvQLGC);
            this.Controls.Add(this.lblNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuNote";
            this.Text = "Ghi chú";
            this.Load += new System.EventHandler(this.FormMenuNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLGC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNote;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLGC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnDeleteNote;
        private FontAwesome.Sharp.IconButton btnAddNote;
        private FontAwesome.Sharp.IconButton btnEditNote;
    }
}