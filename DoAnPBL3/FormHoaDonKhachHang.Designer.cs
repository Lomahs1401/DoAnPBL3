
namespace DoAnPBL3
{
    partial class FormHoaDonKhachHang
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.msgValidateID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIDNV = new System.Windows.Forms.Label();
            this.msgValidateEmail = new System.Windows.Forms.Label();
            this.msgValidateName = new System.Windows.Forms.Label();
            this.tbNameKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.rjbtnOK = new DoAnPBL3.RJButton();
            this.lblNameNV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumberOfBills = new System.Windows.Forms.Label();
            this.dgvQLNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
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
            this.panelTitleBar.Size = new System.Drawing.Size(828, 41);
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
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa đơn khách hàng";
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.panelContainer.Controls.Add(this.dgvQLNV);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.msgValidateID);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.tbMaKH);
            this.panelContainer.Controls.Add(this.lblIDNV);
            this.panelContainer.Controls.Add(this.msgValidateEmail);
            this.panelContainer.Controls.Add(this.msgValidateName);
            this.panelContainer.Controls.Add(this.tbNameKH);
            this.panelContainer.Controls.Add(this.rjbtnOK);
            this.panelContainer.Controls.Add(this.lblNameNV);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.Location = new System.Drawing.Point(0, 41);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(828, 707);
            this.panelContainer.TabIndex = 5;
            // 
            // msgValidateID
            // 
            this.msgValidateID.AutoSize = true;
            this.msgValidateID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateID.Location = new System.Drawing.Point(181, 35);
            this.msgValidateID.Name = "msgValidateID";
            this.msgValidateID.Size = new System.Drawing.Size(0, 16);
            this.msgValidateID.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, -19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 55;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Animated = true;
            this.tbMaKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbMaKH.BorderRadius = 6;
            this.tbMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaKH.DefaultText = "";
            this.tbMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbMaKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaKH.Location = new System.Drawing.Point(180, 16);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.PasswordChar = '\0';
            this.tbMaKH.PlaceholderText = "Mã khách hàng";
            this.tbMaKH.SelectedText = "";
            this.tbMaKH.Size = new System.Drawing.Size(409, 30);
            this.tbMaKH.TabIndex = 0;
            // 
            // lblIDNV
            // 
            this.lblIDNV.AutoSize = true;
            this.lblIDNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIDNV.Location = new System.Drawing.Point(18, 21);
            this.lblIDNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDNV.Name = "lblIDNV";
            this.lblIDNV.Size = new System.Drawing.Size(114, 18);
            this.lblIDNV.TabIndex = 52;
            this.lblIDNV.Text = "Mã khách hàng";
            // 
            // msgValidateEmail
            // 
            this.msgValidateEmail.AutoSize = true;
            this.msgValidateEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateEmail.Location = new System.Drawing.Point(396, 212);
            this.msgValidateEmail.Name = "msgValidateEmail";
            this.msgValidateEmail.Size = new System.Drawing.Size(0, 16);
            this.msgValidateEmail.TabIndex = 50;
            // 
            // msgValidateName
            // 
            this.msgValidateName.AutoSize = true;
            this.msgValidateName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgValidateName.Location = new System.Drawing.Point(181, 100);
            this.msgValidateName.Name = "msgValidateName";
            this.msgValidateName.Size = new System.Drawing.Size(0, 16);
            this.msgValidateName.TabIndex = 50;
            // 
            // tbNameKH
            // 
            this.tbNameKH.Animated = true;
            this.tbNameKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.BorderRadius = 6;
            this.tbNameKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNameKH.DefaultText = "";
            this.tbNameKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(27)))), ((int)(((byte)(57)))));
            this.tbNameKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameKH.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbNameKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tbNameKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNameKH.Location = new System.Drawing.Point(180, 71);
            this.tbNameKH.Name = "tbNameKH";
            this.tbNameKH.PasswordChar = '\0';
            this.tbNameKH.PlaceholderText = "Họ và tên khách hàng";
            this.tbNameKH.SelectedText = "";
            this.tbNameKH.Size = new System.Drawing.Size(409, 30);
            this.tbNameKH.TabIndex = 1;
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
            this.rjbtnOK.Location = new System.Drawing.Point(342, 634);
            this.rjbtnOK.Margin = new System.Windows.Forms.Padding(2);
            this.rjbtnOK.Name = "rjbtnOK";
            this.rjbtnOK.Size = new System.Drawing.Size(145, 36);
            this.rjbtnOK.TabIndex = 11;
            this.rjbtnOK.Text = "OK";
            this.rjbtnOK.TextColor = System.Drawing.Color.White;
            this.rjbtnOK.UseVisualStyleBackColor = false;
            // 
            // lblNameNV
            // 
            this.lblNameNV.AutoSize = true;
            this.lblNameNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameNV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNameNV.Location = new System.Drawing.Point(14, 74);
            this.lblNameNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameNV.Name = "lblNameNV";
            this.lblNameNV.Size = new System.Drawing.Size(161, 18);
            this.lblNameNV.TabIndex = 1;
            this.lblNameNV.Text = "Họ và tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(37, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tổng số hóa đơn";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNumberOfBills);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(615, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 89);
            this.panel1.TabIndex = 57;
            // 
            // lblNumberOfBills
            // 
            this.lblNumberOfBills.AutoSize = true;
            this.lblNumberOfBills.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfBills.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumberOfBills.Location = new System.Drawing.Point(93, 46);
            this.lblNumberOfBills.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfBills.Name = "lblNumberOfBills";
            this.lblNumberOfBills.Size = new System.Drawing.Size(16, 18);
            this.lblNumberOfBills.TabIndex = 57;
            this.lblNumberOfBills.Text = "0";
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.AllowUserToAddRows = false;
            this.dgvQLNV.AllowUserToDeleteRows = false;
            this.dgvQLNV.AllowUserToResizeColumns = false;
            this.dgvQLNV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
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
            this.Gender,
            this.Phone});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLNV.EnableHeadersVisualStyles = false;
            this.dgvQLNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvQLNV.Location = new System.Drawing.Point(6, 158);
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
            this.dgvQLNV.Size = new System.Drawing.Size(816, 422);
            this.dgvQLNV.TabIndex = 58;
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
            // 
            // ID_Employee
            // 
            this.ID_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Employee.DataPropertyName = "ID_Employee";
            this.ID_Employee.HeaderText = "ID";
            this.ID_Employee.Name = "ID_Employee";
            this.ID_Employee.ReadOnly = true;
            // 
            // FullNameEmployee
            // 
            this.FullNameEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullNameEmployee.DataPropertyName = "FullNameEmployee";
            this.FullNameEmployee.HeaderText = "Họ và tên";
            this.FullNameEmployee.Name = "FullNameEmployee";
            this.FullNameEmployee.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới tính";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
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
            this.guna2DragControl1.TargetControl = this.panelTitleBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DoAnPBL3.Properties.Resources.bill;
            this.pictureBox1.Location = new System.Drawing.Point(180, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormHoaDonKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 748);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDonKhachHang";
            this.Text = "FormHoaDonKhachHang";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox tbMaKH;
        private System.Windows.Forms.Label lblIDNV;
        private System.Windows.Forms.Label msgValidateEmail;
        private System.Windows.Forms.Label msgValidateName;
        private Guna.UI2.WinForms.Guna2TextBox tbNameKH;
        private RJButton rjbtnOK;
        private System.Windows.Forms.Label lblNameNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumberOfBills;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQLNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}