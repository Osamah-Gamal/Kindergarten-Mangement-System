namespace Kindergarten_Mangement_System
{
    partial class Levels_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.text_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.empoyee_gridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_error_E_name = new System.Windows.Forms.Label();
            this.lbl_error_Driving_card = new System.Windows.Forms.Label();
            this.lbl_error_address = new System.Windows.Forms.Label();
            this.lbl_error_Cer_card = new System.Windows.Forms.Label();
            this.lbl_error_personal_card = new System.Windows.Forms.Label();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.text_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete_level = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add_level = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update_level = new Guna.UI2.WinForms.Guna2Button();
            this.show_datagride = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_error_delete = new System.Windows.Forms.Label();
            this.btn_reset = new Guna.UI2.WinForms.Guna2Button();
            this.lidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empoyee_gridview)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_datagride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 98;
            this.label1.Text = "المستويات";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.text_name);
            this.guna2Panel1.Controls.Add(this.text_id);
            this.guna2Panel1.Controls.Add(this.empoyee_gridview);
            this.guna2Panel1.Controls.Add(this.lbl_error_E_name);
            this.guna2Panel1.Controls.Add(this.lbl_error_Driving_card);
            this.guna2Panel1.Controls.Add(this.lbl_error_address);
            this.guna2Panel1.Controls.Add(this.lbl_error_Cer_card);
            this.guna2Panel1.Controls.Add(this.lbl_error_personal_card);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Location = new System.Drawing.Point(34, 63);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1138, 257);
            this.guna2Panel1.TabIndex = 96;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
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
            this.text_name.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.text_name.ForeColor = System.Drawing.Color.Black;
            this.text_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_name.Location = new System.Drawing.Point(337, 43);
            this.text_name.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.text_name.Name = "text_name";
            this.text_name.PasswordChar = '\0';
            this.text_name.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.text_name.PlaceholderText = "أدخال أسم المستوى";
            this.text_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_name.SelectedText = "";
            this.text_name.Size = new System.Drawing.Size(210, 31);
            this.text_name.TabIndex = 95;
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
            this.text_id.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.text_id.ForeColor = System.Drawing.Color.Black;
            this.text_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_id.Location = new System.Drawing.Point(756, 43);
            this.text_id.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.text_id.Name = "text_id";
            this.text_id.PasswordChar = '\0';
            this.text_id.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.text_id.PlaceholderText = "أدخال رقم المستوى";
            this.text_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_id.SelectedText = "";
            this.text_id.Size = new System.Drawing.Size(210, 31);
            this.text_id.TabIndex = 93;
            // 
            // empoyee_gridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.empoyee_gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empoyee_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.empoyee_gridview.ColumnHeadersHeight = 4;
            this.empoyee_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empoyee_gridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.empoyee_gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empoyee_gridview.Location = new System.Drawing.Point(-586, 480);
            this.empoyee_gridview.Name = "empoyee_gridview";
            this.empoyee_gridview.RowHeadersVisible = false;
            this.empoyee_gridview.Size = new System.Drawing.Size(806, 209);
            this.empoyee_gridview.TabIndex = 25;
            this.empoyee_gridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.empoyee_gridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.empoyee_gridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.empoyee_gridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.empoyee_gridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.empoyee_gridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.empoyee_gridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empoyee_gridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.empoyee_gridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empoyee_gridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empoyee_gridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.empoyee_gridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.empoyee_gridview.ThemeStyle.HeaderStyle.Height = 4;
            this.empoyee_gridview.ThemeStyle.ReadOnly = false;
            this.empoyee_gridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.empoyee_gridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empoyee_gridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empoyee_gridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.empoyee_gridview.ThemeStyle.RowsStyle.Height = 22;
            this.empoyee_gridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empoyee_gridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lbl_error_E_name
            // 
            this.lbl_error_E_name.AutoSize = true;
            this.lbl_error_E_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_E_name.Location = new System.Drawing.Point(27, 61);
            this.lbl_error_E_name.Name = "lbl_error_E_name";
            this.lbl_error_E_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_E_name.TabIndex = 82;
            // 
            // lbl_error_Driving_card
            // 
            this.lbl_error_Driving_card.AutoSize = true;
            this.lbl_error_Driving_card.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_Driving_card.Location = new System.Drawing.Point(241, 246);
            this.lbl_error_Driving_card.Name = "lbl_error_Driving_card";
            this.lbl_error_Driving_card.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_Driving_card.TabIndex = 90;
            // 
            // lbl_error_address
            // 
            this.lbl_error_address.AutoSize = true;
            this.lbl_error_address.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_address.Location = new System.Drawing.Point(127, 122);
            this.lbl_error_address.Name = "lbl_error_address";
            this.lbl_error_address.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_address.TabIndex = 88;
            // 
            // lbl_error_Cer_card
            // 
            this.lbl_error_Cer_card.AutoSize = true;
            this.lbl_error_Cer_card.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_Cer_card.Location = new System.Drawing.Point(653, 246);
            this.lbl_error_Cer_card.Name = "lbl_error_Cer_card";
            this.lbl_error_Cer_card.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_Cer_card.TabIndex = 87;
            // 
            // lbl_error_personal_card
            // 
            this.lbl_error_personal_card.AutoSize = true;
            this.lbl_error_personal_card.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_personal_card.Location = new System.Drawing.Point(1020, 246);
            this.lbl_error_personal_card.Name = "lbl_error_personal_card";
            this.lbl_error_personal_card.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_personal_card.TabIndex = 84;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(985, 48);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(74, 22);
            this.guna2HtmlLabel2.TabIndex = 96;
            this.guna2HtmlLabel2.Text = "     : المستوى رقم          ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(556, 46);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(75, 22);
            this.guna2HtmlLabel1.TabIndex = 94;
            this.guna2HtmlLabel1.Text = "   : المستوى اسم        ";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel2.BorderColor = System.Drawing.SystemColors.Control;
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.btn_reset);
            this.guna2Panel2.Controls.Add(this.text_search);
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.Controls.Add(this.btn_delete_level);
            this.guna2Panel2.Controls.Add(this.btn_add_level);
            this.guna2Panel2.Controls.Add(this.btn_update_level);
            this.guna2Panel2.Location = new System.Drawing.Point(395, 330);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(775, 38);
            this.guna2Panel2.TabIndex = 97;
            // 
            // text_search
            // 
            this.text_search.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.text_search.BorderRadius = 12;
            this.text_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_search.DefaultText = "";
            this.text_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_search.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.text_search.ForeColor = System.Drawing.Color.Black;
            this.text_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_search.Location = new System.Drawing.Point(9, 4);
            this.text_search.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.text_search.Name = "text_search";
            this.text_search.PasswordChar = '\0';
            this.text_search.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.text_search.PlaceholderText = "البحث بستخدام معرف";
            this.text_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_search.SelectedText = "";
            this.text_search.Size = new System.Drawing.Size(187, 31);
            this.text_search.TabIndex = 97;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(202, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(112, 31);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "بحث";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_delete_level
            // 
            this.btn_delete_level.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete_level.BorderRadius = 6;
            this.btn_delete_level.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_level.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_level.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_level.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete_level.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete_level.FillColor = System.Drawing.Color.Maroon;
            this.btn_delete_level.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete_level.ForeColor = System.Drawing.Color.White;
            this.btn_delete_level.Location = new System.Drawing.Point(318, 3);
            this.btn_delete_level.Name = "btn_delete_level";
            this.btn_delete_level.Size = new System.Drawing.Size(109, 31);
            this.btn_delete_level.TabIndex = 8;
            this.btn_delete_level.Text = "حذف مستوى";
            this.btn_delete_level.Click += new System.EventHandler(this.btn_delete_level_Click);
            // 
            // btn_add_level
            // 
            this.btn_add_level.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_level.BorderRadius = 6;
            this.btn_add_level.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_level.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_level.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_level.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_level.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_level.FillColor = System.Drawing.Color.Navy;
            this.btn_add_level.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add_level.ForeColor = System.Drawing.Color.White;
            this.btn_add_level.Location = new System.Drawing.Point(566, 3);
            this.btn_add_level.Name = "btn_add_level";
            this.btn_add_level.Size = new System.Drawing.Size(115, 31);
            this.btn_add_level.TabIndex = 6;
            this.btn_add_level.Text = "أدراج المستوى";
            this.btn_add_level.Click += new System.EventHandler(this.btn_add_level_Click);
            // 
            // btn_update_level
            // 
            this.btn_update_level.BackColor = System.Drawing.Color.Transparent;
            this.btn_update_level.BorderColor = System.Drawing.Color.Empty;
            this.btn_update_level.BorderRadius = 6;
            this.btn_update_level.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_level.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_level.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_level.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update_level.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update_level.FillColor = System.Drawing.Color.Green;
            this.btn_update_level.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_update_level.ForeColor = System.Drawing.Color.White;
            this.btn_update_level.Location = new System.Drawing.Point(430, 4);
            this.btn_update_level.Name = "btn_update_level";
            this.btn_update_level.Size = new System.Drawing.Size(133, 30);
            this.btn_update_level.TabIndex = 7;
            this.btn_update_level.Text = "تعديل على المستوى";
            this.btn_update_level.Click += new System.EventHandler(this.btn_update_level_Click);
            // 
            // show_datagride
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.show_datagride.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.show_datagride.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.show_datagride.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.show_datagride.ColumnHeadersHeight = 15;
            this.show_datagride.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.show_datagride.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lidDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn});
            this.show_datagride.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_datagride.DataSource = this.levelBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.show_datagride.DefaultCellStyle = dataGridViewCellStyle6;
            this.show_datagride.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.show_datagride.Location = new System.Drawing.Point(34, 353);
            this.show_datagride.Name = "show_datagride";
            this.show_datagride.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.show_datagride.RowHeadersVisible = false;
            this.show_datagride.Size = new System.Drawing.Size(355, 263);
            this.show_datagride.TabIndex = 99;
            this.show_datagride.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.show_datagride.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.show_datagride.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.show_datagride.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.show_datagride.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.show_datagride.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.show_datagride.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.show_datagride.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.show_datagride.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.show_datagride.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_datagride.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.show_datagride.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.show_datagride.ThemeStyle.HeaderStyle.Height = 15;
            this.show_datagride.ThemeStyle.ReadOnly = false;
            this.show_datagride.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.show_datagride.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.show_datagride.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_datagride.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.show_datagride.ThemeStyle.RowsStyle.Height = 22;
            this.show_datagride.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.show_datagride.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.show_datagride.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show_datagride_CellClick);
            // 
            // lbl_error_delete
            // 
            this.lbl_error_delete.AutoSize = true;
            this.lbl_error_delete.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_delete.Location = new System.Drawing.Point(495, 371);
            this.lbl_error_delete.Name = "lbl_error_delete";
            this.lbl_error_delete.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_delete.TabIndex = 98;
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
            this.btn_reset.Location = new System.Drawing.Point(684, 3);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(88, 31);
            this.btn_reset.TabIndex = 100;
            this.btn_reset.Text = "إفراغ الحقول";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lidDataGridViewTextBoxColumn
            // 
            this.lidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lidDataGridViewTextBoxColumn.DataPropertyName = "l_id";
            this.lidDataGridViewTextBoxColumn.HeaderText = "رقم المستوى";
            this.lidDataGridViewTextBoxColumn.Name = "lidDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "l_name";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "اسم المستوى";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // levelBindingSource
            // 
            this.levelBindingSource.DataSource = typeof(Kindergarten_Mangement_System.Level);
            // 
            // Levels_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.lbl_error_delete);
            this.Controls.Add(this.show_datagride);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Levels_Form";
            this.Load += new System.EventHandler(this.Levels_Form_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empoyee_gridview)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.show_datagride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox text_name;
        private Guna.UI2.WinForms.Guna2TextBox text_id;
        private Guna.UI2.WinForms.Guna2DataGridView empoyee_gridview;
        private System.Windows.Forms.Label lbl_error_E_name;
        private System.Windows.Forms.Label lbl_error_Driving_card;
        private System.Windows.Forms.Label lbl_error_address;
        private System.Windows.Forms.Label lbl_error_Cer_card;
        private System.Windows.Forms.Label lbl_error_personal_card;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox text_search;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btn_delete_level;
        private Guna.UI2.WinForms.Guna2Button btn_add_level;
        private Guna.UI2.WinForms.Guna2Button btn_update_level;
        private Guna.UI2.WinForms.Guna2DataGridView show_datagride;
        private System.Windows.Forms.DataGridViewTextBoxColumn lidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource levelBindingSource;
        private System.Windows.Forms.Label lbl_error_delete;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
    }
}