
namespace DoAnPBL3
{
    partial class FormNhapMua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapMua));
            this.btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNameBook = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbIDBook = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblIDBook = new System.Windows.Forms.Label();
            this.tbAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.Index = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1049, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.Size = new System.Drawing.Size(39, 40);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.LightGray;
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.Enabled = false;
            this.tbPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPrice.ForeColor = System.Drawing.Color.White;
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.Location = new System.Drawing.Point(676, 11);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderForeColor = System.Drawing.SystemColors.Window;
            this.tbPrice.PlaceholderText = "";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.SelectedText = "";
            this.tbPrice.Size = new System.Drawing.Size(114, 27);
            this.tbPrice.TabIndex = 25;
            // 
            // tbQuantity
            // 
            this.tbQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQuantity.DefaultText = "";
            this.tbQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbQuantity.ForeColor = System.Drawing.Color.LightGray;
            this.tbQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbQuantity.Location = new System.Drawing.Point(567, 11);
            this.tbQuantity.MaxLength = 10;
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.PasswordChar = '\0';
            this.tbQuantity.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbQuantity.PlaceholderText = "Nhập";
            this.tbQuantity.SelectedText = "";
            this.tbQuantity.Size = new System.Drawing.Size(59, 27);
            this.tbQuantity.TabIndex = 24;
            this.tbQuantity.TextChanged += new System.EventHandler(this.TbQuantity_TextChanged);
            // 
            // tbNameBook
            // 
            this.tbNameBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNameBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbNameBook.DefaultText = "";
            this.tbNameBook.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNameBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNameBook.DisabledState.ForeColor = System.Drawing.Color.Silver;
            this.tbNameBook.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNameBook.Enabled = false;
            this.tbNameBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbNameBook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNameBook.ForeColor = System.Drawing.Color.White;
            this.tbNameBook.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameBook.Location = new System.Drawing.Point(245, 11);
            this.tbNameBook.Name = "tbNameBook";
            this.tbNameBook.PasswordChar = '\0';
            this.tbNameBook.PlaceholderForeColor = System.Drawing.SystemColors.Window;
            this.tbNameBook.PlaceholderText = "";
            this.tbNameBook.ReadOnly = true;
            this.tbNameBook.SelectedText = "";
            this.tbNameBook.Size = new System.Drawing.Size(257, 27);
            this.tbNameBook.TabIndex = 23;
            // 
            // tbIDBook
            // 
            this.tbIDBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbIDBook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDBook.DefaultText = "";
            this.tbIDBook.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIDBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIDBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDBook.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbIDBook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbIDBook.ForeColor = System.Drawing.Color.LightGray;
            this.tbIDBook.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDBook.Location = new System.Drawing.Point(81, 11);
            this.tbIDBook.MaxLength = 32;
            this.tbIDBook.Name = "tbIDBook";
            this.tbIDBook.PasswordChar = '\0';
            this.tbIDBook.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbIDBook.PlaceholderText = "Nhập";
            this.tbIDBook.SelectedText = "";
            this.tbIDBook.Size = new System.Drawing.Size(99, 27);
            this.tbIDBook.TabIndex = 17;
            this.tbIDBook.TextChanged += new System.EventHandler(this.TbIDBook_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(635, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "x";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(818, 18);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(41, 13);
            this.lblAmount.TabIndex = 21;
            this.lblAmount.Text = "Chi phí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(799, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "=";
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.BackColor = System.Drawing.Color.Transparent;
            this.lblNameBook.ForeColor = System.Drawing.Color.White;
            this.lblNameBook.Location = new System.Drawing.Point(187, 18);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(52, 13);
            this.lblNameBook.TabIndex = 19;
            this.lblNameBook.Text = "Tên sách";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(647, 18);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(23, 13);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Giá";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(508, 18);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(53, 13);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Số Lượng";
            // 
            // lblIDBook
            // 
            this.lblIDBook.AutoSize = true;
            this.lblIDBook.BackColor = System.Drawing.Color.Transparent;
            this.lblIDBook.ForeColor = System.Drawing.Color.White;
            this.lblIDBook.Location = new System.Drawing.Point(34, 18);
            this.lblIDBook.Name = "lblIDBook";
            this.lblIDBook.Size = new System.Drawing.Size(46, 13);
            this.lblIDBook.TabIndex = 15;
            this.lblIDBook.Text = "ID Sách";
            // 
            // tbAmount
            // 
            this.tbAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbAmount.DefaultText = "";
            this.tbAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbAmount.DisabledState.ForeColor = System.Drawing.Color.LightGray;
            this.tbAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAmount.Enabled = false;
            this.tbAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(59)))));
            this.tbAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbAmount.ForeColor = System.Drawing.Color.White;
            this.tbAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAmount.Location = new System.Drawing.Point(860, 11);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.PasswordChar = '\0';
            this.tbAmount.PlaceholderForeColor = System.Drawing.SystemColors.Window;
            this.tbAmount.PlaceholderText = "";
            this.tbAmount.ReadOnly = true;
            this.tbAmount.SelectedText = "";
            this.tbAmount.Size = new System.Drawing.Size(176, 27);
            this.tbAmount.TabIndex = 28;
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Index.ForeColor = System.Drawing.Color.White;
            this.Index.Location = new System.Drawing.Point(6, 16);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(27, 15);
            this.Index.TabIndex = 29;
            this.Index.Text = "Ind";
            this.Index.Paint += new System.Windows.Forms.PaintEventHandler(this.Index_Paint);
            // 
            // FormNhapMua
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1094, 52);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbNameBook);
            this.Controls.Add(this.tbIDBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNameBook);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblIDBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNhapMua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbQuantity;
        private Guna.UI2.WinForms.Guna2TextBox tbNameBook;
        private Guna.UI2.WinForms.Guna2TextBox tbIDBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblIDBook;
        private Guna.UI2.WinForms.Guna2TextBox tbAmount;
        private System.Windows.Forms.Label Index;
    }
}