namespace Kindergarten_Mangement_System
{
    partial class Jobs_Form
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
            this.label4 = new System.Windows.Forms.Label();
            this.show_job_datagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_reset = new Guna.UI2.WinForms.Guna2Button();
            this.text_delete = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_error_delete = new System.Windows.Forms.Label();
            this.lbl_error_name = new System.Windows.Forms.Label();
            this.lbl_job_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_error_total = new System.Windows.Forms.Label();
            this.lbl_error_Subject_name = new System.Windows.Forms.Label();
            this.lbl_error_level = new System.Windows.Forms.Label();
            this.lbl_error_Student_id = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_delete_job = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update_job = new Guna.UI2.WinForms.Guna2Button();
            this.btn_enter_job = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_error_id = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.text_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_error_search = new System.Windows.Forms.Label();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.jobidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.show_job_datagrid)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Marlett", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 32);
            this.label4.TabIndex = 66;
            this.label4.Text = "إدارة الوظائف";
            // 
            // show_job_datagrid
            // 
            this.show_job_datagrid.AllowUserToAddRows = false;
            this.show_job_datagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.show_job_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.show_job_datagrid.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.show_job_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.show_job_datagrid.ColumnHeadersHeight = 15;
            this.show_job_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.show_job_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobidDataGridViewTextBoxColumn,
            this.jobnameDataGridViewTextBoxColumn});
            this.show_job_datagrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_job_datagrid.DataSource = this.jobBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.show_job_datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.show_job_datagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.show_job_datagrid.Location = new System.Drawing.Point(246, 204);
            this.show_job_datagrid.Name = "show_job_datagrid";
            this.show_job_datagrid.ReadOnly = true;
            this.show_job_datagrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.show_job_datagrid.RowHeadersVisible = false;
            this.show_job_datagrid.Size = new System.Drawing.Size(430, 425);
            this.show_job_datagrid.TabIndex = 65;
            this.show_job_datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.show_job_datagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.show_job_datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.show_job_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.show_job_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.show_job_datagrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.show_job_datagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.show_job_datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.show_job_datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.show_job_datagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_job_datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.show_job_datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.show_job_datagrid.ThemeStyle.HeaderStyle.Height = 15;
            this.show_job_datagrid.ThemeStyle.ReadOnly = true;
            this.show_job_datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.show_job_datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.show_job_datagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_job_datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.show_job_datagrid.ThemeStyle.RowsStyle.Height = 22;
            this.show_job_datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.show_job_datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.show_job_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show_job_datagrid_CellClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.BorderColor = System.Drawing.Color.SteelBlue;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.btn_reset);
            this.guna2Panel1.Controls.Add(this.text_delete);
            this.guna2Panel1.Controls.Add(this.lbl_error_delete);
            this.guna2Panel1.Controls.Add(this.lbl_error_name);
            this.guna2Panel1.Controls.Add(this.lbl_job_id);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.text_name);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.text_id);
            this.guna2Panel1.Controls.Add(this.lbl_error_total);
            this.guna2Panel1.Controls.Add(this.lbl_error_Subject_name);
            this.guna2Panel1.Controls.Add(this.lbl_error_level);
            this.guna2Panel1.Controls.Add(this.lbl_error_Student_id);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.lbl_error_id);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(700, 204);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(367, 426);
            this.guna2Panel1.TabIndex = 64;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Location = new System.Drawing.Point(276, 362);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(88, 21);
            this.guna2Button1.TabIndex = 101;
            this.guna2Button1.Text = "إفراغ الحقول";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_reset.BorderRadius = 6;
            this.btn_reset.BorderThickness = 1;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_reset.Location = new System.Drawing.Point(409, -34);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(98, 31);
            this.btn_reset.TabIndex = 103;
            this.btn_reset.Text = "إفراغ الحقول";
            // 
            // text_delete
            // 
            this.text_delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.text_delete.BorderRadius = 12;
            this.text_delete.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_delete.DefaultText = "";
            this.text_delete.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_delete.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_delete.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_delete.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.text_delete.ForeColor = System.Drawing.Color.Red;
            this.text_delete.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.text_delete.Location = new System.Drawing.Point(4, 330);
            this.text_delete.Name = "text_delete";
            this.text_delete.PasswordChar = '\0';
            this.text_delete.PlaceholderText = "حذف عبر كود";
            this.text_delete.SelectedText = "";
            this.text_delete.Size = new System.Drawing.Size(118, 25);
            this.text_delete.TabIndex = 104;
            this.text_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_error_delete
            // 
            this.lbl_error_delete.AutoSize = true;
            this.lbl_error_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_delete.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_delete.Location = new System.Drawing.Point(29, 368);
            this.lbl_error_delete.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_error_delete.Name = "lbl_error_delete";
            this.lbl_error_delete.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_delete.TabIndex = 102;
            // 
            // lbl_error_name
            // 
            this.lbl_error_name.AutoSize = true;
            this.lbl_error_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_name.Location = new System.Drawing.Point(126, 211);
            this.lbl_error_name.Name = "lbl_error_name";
            this.lbl_error_name.Size = new System.Drawing.Size(0, 17);
            this.lbl_error_name.TabIndex = 86;
            // 
            // lbl_job_id
            // 
            this.lbl_job_id.AutoSize = true;
            this.lbl_job_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_job_id.ForeColor = System.Drawing.Color.Red;
            this.lbl_job_id.Location = new System.Drawing.Point(126, 114);
            this.lbl_job_id.Name = "lbl_job_id";
            this.lbl_job_id.Size = new System.Drawing.Size(0, 17);
            this.lbl_job_id.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = ": كود الوظيفة";
            // 
            // text_name
            // 
            this.text_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_name.BorderRadius = 12;
            this.text_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_name.DefaultText = "";
            this.text_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.text_name.ForeColor = System.Drawing.Color.Black;
            this.text_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_name.Location = new System.Drawing.Point(19, 175);
            this.text_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.text_name.Name = "text_name";
            this.text_name.PasswordChar = '\0';
            this.text_name.PlaceholderText = "اسم الوظيفة";
            this.text_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_name.SelectedText = "";
            this.text_name.Size = new System.Drawing.Size(333, 33);
            this.text_name.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = ": اسم الوظيفة";
            // 
            // text_id
            // 
            this.text_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_id.BorderRadius = 12;
            this.text_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_id.DefaultText = "";
            this.text_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_id.Enabled = false;
            this.text_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_id.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.text_id.ForeColor = System.Drawing.Color.Black;
            this.text_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_id.Location = new System.Drawing.Point(19, 79);
            this.text_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.text_id.Name = "text_id";
            this.text_id.PasswordChar = '\0';
            this.text_id.PlaceholderText = "رقم الوظيفة";
            this.text_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_id.SelectedText = "";
            this.text_id.Size = new System.Drawing.Size(333, 32);
            this.text_id.TabIndex = 53;
            // 
            // lbl_error_total
            // 
            this.lbl_error_total.AutoSize = true;
            this.lbl_error_total.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_total.Location = new System.Drawing.Point(6, 267);
            this.lbl_error_total.Name = "lbl_error_total";
            this.lbl_error_total.Size = new System.Drawing.Size(0, 7);
            this.lbl_error_total.TabIndex = 52;
            // 
            // lbl_error_Subject_name
            // 
            this.lbl_error_Subject_name.AutoSize = true;
            this.lbl_error_Subject_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_Subject_name.Location = new System.Drawing.Point(352, 175);
            this.lbl_error_Subject_name.Name = "lbl_error_Subject_name";
            this.lbl_error_Subject_name.Size = new System.Drawing.Size(0, 7);
            this.lbl_error_Subject_name.TabIndex = 48;
            // 
            // lbl_error_level
            // 
            this.lbl_error_level.AutoSize = true;
            this.lbl_error_level.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_level.Location = new System.Drawing.Point(352, 140);
            this.lbl_error_level.Name = "lbl_error_level";
            this.lbl_error_level.Size = new System.Drawing.Size(0, 7);
            this.lbl_error_level.TabIndex = 47;
            // 
            // lbl_error_Student_id
            // 
            this.lbl_error_Student_id.AutoSize = true;
            this.lbl_error_Student_id.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_Student_id.Location = new System.Drawing.Point(352, 104);
            this.lbl_error_Student_id.Name = "lbl_error_Student_id";
            this.lbl_error_Student_id.Size = new System.Drawing.Size(0, 7);
            this.lbl_error_Student_id.TabIndex = 46;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Panel2.Controls.Add(this.btn_delete_job);
            this.guna2Panel2.Controls.Add(this.btn_update_job);
            this.guna2Panel2.Controls.Add(this.btn_enter_job);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 384);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(367, 42);
            this.guna2Panel2.TabIndex = 5;
            // 
            // btn_delete_job
            // 
            this.btn_delete_job.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete_job.BorderRadius = 6;
            this.btn_delete_job.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_job.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_job.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_job.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete_job.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete_job.FillColor = System.Drawing.Color.Maroon;
            this.btn_delete_job.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_delete_job.ForeColor = System.Drawing.Color.White;
            this.btn_delete_job.Location = new System.Drawing.Point(4, 10);
            this.btn_delete_job.Name = "btn_delete_job";
            this.btn_delete_job.Size = new System.Drawing.Size(122, 25);
            this.btn_delete_job.TabIndex = 4;
            this.btn_delete_job.Text = "حذف وظيفة";
            this.btn_delete_job.Click += new System.EventHandler(this.btn_delete_job_Click);
            // 
            // btn_update_job
            // 
            this.btn_update_job.BackColor = System.Drawing.Color.Transparent;
            this.btn_update_job.BorderRadius = 6;
            this.btn_update_job.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_job.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_job.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_job.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update_job.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update_job.FillColor = System.Drawing.Color.Green;
            this.btn_update_job.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_update_job.ForeColor = System.Drawing.Color.White;
            this.btn_update_job.Location = new System.Drawing.Point(127, 10);
            this.btn_update_job.Name = "btn_update_job";
            this.btn_update_job.Size = new System.Drawing.Size(121, 25);
            this.btn_update_job.TabIndex = 3;
            this.btn_update_job.Text = "تعديل وظيفة";
            this.btn_update_job.Click += new System.EventHandler(this.btn_update_job_Click);
            // 
            // btn_enter_job
            // 
            this.btn_enter_job.BackColor = System.Drawing.Color.Transparent;
            this.btn_enter_job.BorderRadius = 6;
            this.btn_enter_job.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enter_job.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_enter_job.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_enter_job.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_enter_job.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_enter_job.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_enter_job.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_enter_job.ForeColor = System.Drawing.Color.White;
            this.btn_enter_job.Location = new System.Drawing.Point(250, 9);
            this.btn_enter_job.Name = "btn_enter_job";
            this.btn_enter_job.Size = new System.Drawing.Size(115, 25);
            this.btn_enter_job.TabIndex = 0;
            this.btn_enter_job.Text = "إضافة وظيفة";
            this.btn_enter_job.Click += new System.EventHandler(this.btn_enter_job_Click);
            // 
            // lbl_error_id
            // 
            this.lbl_error_id.AutoSize = true;
            this.lbl_error_id.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_id.Location = new System.Drawing.Point(352, 71);
            this.lbl_error_id.Name = "lbl_error_id";
            this.lbl_error_id.Size = new System.Drawing.Size(0, 7);
            this.lbl_error_id.TabIndex = 45;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderColor = System.Drawing.Color.Empty;
            this.guna2Button3.BorderRadius = 8;
            this.guna2Button3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button3.BorderThickness = 2;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(105)))), ((int)(((byte)(112)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(928, 193);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(127, 24);
            this.guna2Button3.TabIndex = 58;
            this.guna2Button3.Text = "بيانات الوظائف";
            // 
            // text_search
            // 
            this.text_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_search.BorderRadius = 12;
            this.text_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_search.DefaultText = "";
            this.text_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_search.ForeColor = System.Drawing.Color.Black;
            this.text_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_search.Location = new System.Drawing.Point(247, 139);
            this.text_search.Name = "text_search";
            this.text_search.PasswordChar = '\0';
            this.text_search.PlaceholderText = "بحث عن الوظيف بواسطة الكود او الاسم  ";
            this.text_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_search.SelectedText = "";
            this.text_search.Size = new System.Drawing.Size(706, 34);
            this.text_search.TabIndex = 62;
            // 
            // lbl_error_search
            // 
            this.lbl_error_search.AutoSize = true;
            this.lbl_error_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_search.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_search.Location = new System.Drawing.Point(615, 177);
            this.lbl_error_search.Name = "lbl_error_search";
            this.lbl_error_search.Size = new System.Drawing.Size(0, 17);
            this.lbl_error_search.TabIndex = 105;
            // 
            // btn_search
            // 
            this.btn_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_search.BorderRadius = 12;
            this.btn_search.BorderThickness = 1;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_search.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_search.HoverState.ForeColor = System.Drawing.Color.Lime;
            this.btn_search.Location = new System.Drawing.Point(953, 141);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 27);
            this.btn_search.TabIndex = 106;
            this.btn_search.Text = "بحــــث";
            // 
            // jobidDataGridViewTextBoxColumn
            // 
            this.jobidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jobidDataGridViewTextBoxColumn.DataPropertyName = "job_id";
            this.jobidDataGridViewTextBoxColumn.HeaderText = "كود الوظيفة";
            this.jobidDataGridViewTextBoxColumn.Name = "jobidDataGridViewTextBoxColumn";
            this.jobidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobnameDataGridViewTextBoxColumn
            // 
            this.jobnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jobnameDataGridViewTextBoxColumn.DataPropertyName = "job_name";
            this.jobnameDataGridViewTextBoxColumn.HeaderText = "اسم الوظيفة";
            this.jobnameDataGridViewTextBoxColumn.Name = "jobnameDataGridViewTextBoxColumn";
            this.jobnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(Kindergarten_Mangement_System.Job);
            // 
            // Jobs_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_error_search);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.show_job_datagrid);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.text_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Jobs_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Jobs_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.show_job_datagrid)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView show_job_datagrid;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox text_name;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox text_id;
        private System.Windows.Forms.Label lbl_error_total;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label lbl_error_Subject_name;
        private System.Windows.Forms.Label lbl_error_level;
        private System.Windows.Forms.Label lbl_error_Student_id;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btn_delete_job;
        private Guna.UI2.WinForms.Guna2Button btn_update_job;
        private Guna.UI2.WinForms.Guna2Button btn_enter_job;
        private System.Windows.Forms.Label lbl_error_id;
        private Guna.UI2.WinForms.Guna2TextBox text_search;
        private System.Windows.Forms.Label lbl_error_name;
        private System.Windows.Forms.Label lbl_job_id;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
        private Guna.UI2.WinForms.Guna2TextBox text_delete;
        private System.Windows.Forms.Label lbl_error_delete;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lbl_error_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private Guna.UI2.WinForms.Guna2Button btn_search;
    }
}