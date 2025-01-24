namespace Kindergarten_Mangement_System
{
    partial class Buses_Form
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
            this.label8 = new System.Windows.Forms.Label();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete_bus = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update_bus = new Guna.UI2.WinForms.Guna2Button();
            this.text_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_add_bus = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.text_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_typ_bus = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_employees = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_plat_numberus = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btn_enter_image = new Guna.UI2.WinForms.Guna2Button();
            this.btn_reset = new Guna.UI2.WinForms.Guna2Button();
            this.show_datagride = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_error_id = new System.Windows.Forms.Label();
            this.lbl_error_typ_bus = new System.Windows.Forms.Label();
            this.lbl_error_pate_number = new System.Windows.Forms.Label();
            this.lbl_error_pic = new System.Windows.Forms.Label();
            this.lbl_error_employee = new System.Windows.Forms.Label();
            this.lbl_error_search = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_employee = new System.Windows.Forms.Label();
            this.lbl_error_delete = new System.Windows.Forms.Label();
            this.text_delete = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic_paper_ownership = new System.Windows.Forms.PictureBox();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bplatnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bownershippaperDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.busBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_plat_numberus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_datagride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_paper_ownership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1009, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = ": البحث عن باص";
            // 
            // btn_search
            // 
            this.btn_search.BorderRadius = 5;
            this.btn_search.BorderThickness = 1;
            this.btn_search.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(444, 385);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(99, 37);
            this.btn_search.TabIndex = 25;
            this.btn_search.Text = "بحث";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete_bus
            // 
            this.btn_delete_bus.BorderRadius = 5;
            this.btn_delete_bus.BorderThickness = 1;
            this.btn_delete_bus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_bus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_bus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete_bus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete_bus.FillColor = System.Drawing.Color.Maroon;
            this.btn_delete_bus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete_bus.ForeColor = System.Drawing.Color.White;
            this.btn_delete_bus.Location = new System.Drawing.Point(371, 309);
            this.btn_delete_bus.Name = "btn_delete_bus";
            this.btn_delete_bus.Size = new System.Drawing.Size(142, 36);
            this.btn_delete_bus.TabIndex = 23;
            this.btn_delete_bus.Text = "حذف باص";
            this.btn_delete_bus.Click += new System.EventHandler(this.btn_delete_bus_Click);
            // 
            // btn_update_bus
            // 
            this.btn_update_bus.BorderRadius = 5;
            this.btn_update_bus.BorderThickness = 1;
            this.btn_update_bus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_bus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_bus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update_bus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update_bus.FillColor = System.Drawing.Color.Green;
            this.btn_update_bus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_update_bus.ForeColor = System.Drawing.Color.White;
            this.btn_update_bus.Location = new System.Drawing.Point(519, 309);
            this.btn_update_bus.Name = "btn_update_bus";
            this.btn_update_bus.Size = new System.Drawing.Size(142, 36);
            this.btn_update_bus.TabIndex = 22;
            this.btn_update_bus.Text = "تعديل على بيانات باص";
            this.btn_update_bus.Click += new System.EventHandler(this.btn_update_bus_Click);
            // 
            // text_search
            // 
            this.text_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_search.BorderRadius = 5;
            this.text_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_search.DefaultText = "";
            this.text_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_search.Location = new System.Drawing.Point(550, 385);
            this.text_search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.text_search.Name = "text_search";
            this.text_search.PasswordChar = '\0';
            this.text_search.PlaceholderText = "البحث عن باص";
            this.text_search.SelectedText = "";
            this.text_search.Size = new System.Drawing.Size(452, 37);
            this.text_search.TabIndex = 20;
            this.text_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_add_bus
            // 
            this.btn_add_bus.BorderRadius = 5;
            this.btn_add_bus.BorderThickness = 1;
            this.btn_add_bus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_bus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_bus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_bus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_bus.FillColor = System.Drawing.Color.Navy;
            this.btn_add_bus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add_bus.ForeColor = System.Drawing.Color.White;
            this.btn_add_bus.Location = new System.Drawing.Point(667, 309);
            this.btn_add_bus.Name = "btn_add_bus";
            this.btn_add_bus.Size = new System.Drawing.Size(142, 36);
            this.btn_add_bus.TabIndex = 18;
            this.btn_add_bus.Text = "اضافة باص";
            this.btn_add_bus.Click += new System.EventHandler(this.btn_add_bus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ادره الباصات";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Panel1.BorderRadius = 6;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lbl_employee);
            this.guna2Panel1.Controls.Add(this.lbl_error_employee);
            this.guna2Panel1.Controls.Add(this.lbl_error_pic);
            this.guna2Panel1.Controls.Add(this.lbl_error_pate_number);
            this.guna2Panel1.Controls.Add(this.lbl_error_typ_bus);
            this.guna2Panel1.Controls.Add(this.lbl_error_id);
            this.guna2Panel1.Controls.Add(this.btn_enter_image);
            this.guna2Panel1.Controls.Add(this.pic_paper_ownership);
            this.guna2Panel1.Controls.Add(this.text_plat_numberus);
            this.guna2Panel1.Controls.Add(this.text_id);
            this.guna2Panel1.Controls.Add(this.text_typ_bus);
            this.guna2Panel1.Controls.Add(this.text_employees);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 64);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1179, 230);
            this.guna2Panel1.TabIndex = 16;
            // 
            // text_id
            // 
            this.text_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_id.BorderRadius = 5;
            this.text_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_id.DefaultText = "";
            this.text_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_id.Enabled = false;
            this.text_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_id.ForeColor = System.Drawing.Color.Black;
            this.text_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_id.Location = new System.Drawing.Point(834, 25);
            this.text_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_id.Name = "text_id";
            this.text_id.PasswordChar = '\0';
            this.text_id.PlaceholderText = "الكود";
            this.text_id.SelectedText = "";
            this.text_id.Size = new System.Drawing.Size(229, 36);
            this.text_id.TabIndex = 4;
            this.text_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // text_typ_bus
            // 
            this.text_typ_bus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_typ_bus.BorderRadius = 5;
            this.text_typ_bus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_typ_bus.DefaultText = "";
            this.text_typ_bus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_typ_bus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_typ_bus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_typ_bus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_typ_bus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_typ_bus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_typ_bus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_typ_bus.Location = new System.Drawing.Point(430, 25);
            this.text_typ_bus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_typ_bus.Name = "text_typ_bus";
            this.text_typ_bus.PasswordChar = '\0';
            this.text_typ_bus.PlaceholderText = "نوع الباص";
            this.text_typ_bus.SelectedText = "";
            this.text_typ_bus.Size = new System.Drawing.Size(229, 36);
            this.text_typ_bus.TabIndex = 5;
            this.text_typ_bus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.text_typ_bus.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // text_employees
            // 
            this.text_employees.BackColor = System.Drawing.Color.Transparent;
            this.text_employees.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_employees.BorderRadius = 1;
            this.text_employees.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.text_employees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_employees.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_employees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_employees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.text_employees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.text_employees.ItemHeight = 30;
            this.text_employees.Location = new System.Drawing.Point(429, 130);
            this.text_employees.Name = "text_employees";
            this.text_employees.Size = new System.Drawing.Size(229, 36);
            this.text_employees.TabIndex = 0;
            this.text_employees.SelectedIndexChanged += new System.EventHandler(this.text_employees_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1126, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = ":الكود";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = ":نوع الباص";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = ":رقم اللوحه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1010, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = ": صورة من ورقة الملكيه";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(660, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = ": اسم الموظف";
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.BorderRadius = 5;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FillColor = System.Drawing.Color.Black;
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Location = new System.Drawing.Point(357, 304);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderText = "";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(460, 46);
            this.guna2TextBox6.TabIndex = 19;
            // 
            // text_plat_numberus
            // 
            this.text_plat_numberus.BackColor = System.Drawing.Color.Transparent;
            this.text_plat_numberus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_plat_numberus.BorderRadius = 5;
            this.text_plat_numberus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_plat_numberus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_plat_numberus.Location = new System.Drawing.Point(26, 25);
            this.text_plat_numberus.Name = "text_plat_numberus";
            this.text_plat_numberus.Size = new System.Drawing.Size(229, 36);
            this.text_plat_numberus.TabIndex = 14;
            // 
            // btn_enter_image
            // 
            this.btn_enter_image.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_enter_image.BorderRadius = 12;
            this.btn_enter_image.BorderThickness = 1;
            this.btn_enter_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enter_image.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_enter_image.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_enter_image.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_enter_image.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_enter_image.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_enter_image.ForeColor = System.Drawing.Color.White;
            this.btn_enter_image.Location = new System.Drawing.Point(1026, 170);
            this.btn_enter_image.Name = "btn_enter_image";
            this.btn_enter_image.Size = new System.Drawing.Size(143, 27);
            this.btn_enter_image.TabIndex = 67;
            this.btn_enter_image.Text = "جلب الصورة";
            this.btn_enter_image.Click += new System.EventHandler(this.btn_enter_image_Click);
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
            this.btn_reset.Location = new System.Drawing.Point(821, 312);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(98, 31);
            this.btn_reset.TabIndex = 101;
            this.btn_reset.Text = "إفراغ الحقول";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // show_datagride
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.show_datagride.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.show_datagride.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.show_datagride.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.show_datagride.ColumnHeadersHeight = 15;
            this.show_datagride.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.show_datagride.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bidDataGridViewTextBoxColumn,
            this.btypeDataGridViewTextBoxColumn,
            this.bplatnumberDataGridViewTextBoxColumn,
            this.bownershippaperDataGridViewImageColumn,
            this.employeeidDataGridViewTextBoxColumn});
            this.show_datagride.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_datagride.DataSource = this.busBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.show_datagride.DefaultCellStyle = dataGridViewCellStyle3;
            this.show_datagride.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.show_datagride.Location = new System.Drawing.Point(29, 452);
            this.show_datagride.Name = "show_datagride";
            this.show_datagride.ReadOnly = true;
            this.show_datagride.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.show_datagride.RowHeadersVisible = false;
            this.show_datagride.Size = new System.Drawing.Size(1114, 177);
            this.show_datagride.TabIndex = 102;
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
            this.show_datagride.ThemeStyle.ReadOnly = true;
            this.show_datagride.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.show_datagride.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.show_datagride.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_datagride.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.show_datagride.ThemeStyle.RowsStyle.Height = 22;
            this.show_datagride.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.show_datagride.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.show_datagride.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show_datagride_CellClick);
            // 
            // lbl_error_id
            // 
            this.lbl_error_id.AutoSize = true;
            this.lbl_error_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_id.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_id.Location = new System.Drawing.Point(903, 65);
            this.lbl_error_id.Name = "lbl_error_id";
            this.lbl_error_id.Size = new System.Drawing.Size(0, 17);
            this.lbl_error_id.TabIndex = 85;
            // 
            // lbl_error_typ_bus
            // 
            this.lbl_error_typ_bus.AutoSize = true;
            this.lbl_error_typ_bus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_typ_bus.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_typ_bus.Location = new System.Drawing.Point(520, 65);
            this.lbl_error_typ_bus.Name = "lbl_error_typ_bus";
            this.lbl_error_typ_bus.Size = new System.Drawing.Size(0, 17);
            this.lbl_error_typ_bus.TabIndex = 86;
            // 
            // lbl_error_pate_number
            // 
            this.lbl_error_pate_number.AutoSize = true;
            this.lbl_error_pate_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_pate_number.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_pate_number.Location = new System.Drawing.Point(113, 64);
            this.lbl_error_pate_number.Name = "lbl_error_pate_number";
            this.lbl_error_pate_number.Size = new System.Drawing.Size(0, 17);
            this.lbl_error_pate_number.TabIndex = 87;
            // 
            // lbl_error_pic
            // 
            this.lbl_error_pic.AutoSize = true;
            this.lbl_error_pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_pic.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_pic.Location = new System.Drawing.Point(1063, 200);
            this.lbl_error_pic.Name = "lbl_error_pic";
            this.lbl_error_pic.Size = new System.Drawing.Size(0, 17);
            this.lbl_error_pic.TabIndex = 88;
            // 
            // lbl_error_employee
            // 
            this.lbl_error_employee.AutoSize = true;
            this.lbl_error_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_employee.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_employee.Location = new System.Drawing.Point(504, 158);
            this.lbl_error_employee.Name = "lbl_error_employee";
            this.lbl_error_employee.Size = new System.Drawing.Size(0, 17);
            this.lbl_error_employee.TabIndex = 89;
            // 
            // lbl_error_search
            // 
            this.lbl_error_search.AutoSize = true;
            this.lbl_error_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_search.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_search.Location = new System.Drawing.Point(724, 424);
            this.lbl_error_search.Name = "lbl_error_search";
            this.lbl_error_search.Size = new System.Drawing.Size(0, 17);
            this.lbl_error_search.TabIndex = 90;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_employee
            // 
            this.lbl_employee.AutoSize = true;
            this.lbl_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_employee.Location = new System.Drawing.Point(504, 110);
            this.lbl_employee.Name = "lbl_employee";
            this.lbl_employee.Size = new System.Drawing.Size(0, 17);
            this.lbl_employee.TabIndex = 90;
            // 
            // lbl_error_delete
            // 
            this.lbl_error_delete.AutoSize = true;
            this.lbl_error_delete.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_delete.Location = new System.Drawing.Point(205, 350);
            this.lbl_error_delete.Name = "lbl_error_delete";
            this.lbl_error_delete.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_delete.TabIndex = 104;
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
            this.text_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.text_delete.ForeColor = System.Drawing.Color.Red;
            this.text_delete.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.text_delete.Location = new System.Drawing.Point(156, 308);
            this.text_delete.Name = "text_delete";
            this.text_delete.PasswordChar = '\0';
            this.text_delete.PlaceholderText = "حذف عبر كود";
            this.text_delete.SelectedText = "";
            this.text_delete.Size = new System.Drawing.Size(200, 38);
            this.text_delete.TabIndex = 103;
            this.text_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_paper_ownership
            // 
            this.pic_paper_ownership.Location = new System.Drawing.Point(853, 130);
            this.pic_paper_ownership.Name = "pic_paper_ownership";
            this.pic_paper_ownership.Size = new System.Drawing.Size(141, 75);
            this.pic_paper_ownership.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_paper_ownership.TabIndex = 68;
            this.pic_paper_ownership.TabStop = false;
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "b_id";
            this.bidDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            this.bidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btypeDataGridViewTextBoxColumn
            // 
            this.btypeDataGridViewTextBoxColumn.DataPropertyName = "b_type";
            this.btypeDataGridViewTextBoxColumn.HeaderText = "نوع الباص";
            this.btypeDataGridViewTextBoxColumn.Name = "btypeDataGridViewTextBoxColumn";
            this.btypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bplatnumberDataGridViewTextBoxColumn
            // 
            this.bplatnumberDataGridViewTextBoxColumn.DataPropertyName = "b_plat_number";
            this.bplatnumberDataGridViewTextBoxColumn.HeaderText = "رقم لوحة الباص";
            this.bplatnumberDataGridViewTextBoxColumn.Name = "bplatnumberDataGridViewTextBoxColumn";
            this.bplatnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bownershippaperDataGridViewImageColumn
            // 
            this.bownershippaperDataGridViewImageColumn.DataPropertyName = "b_ownership_paper";
            this.bownershippaperDataGridViewImageColumn.HeaderText = "صوره من ملكية الباص";
            this.bownershippaperDataGridViewImageColumn.Name = "bownershippaperDataGridViewImageColumn";
            this.bownershippaperDataGridViewImageColumn.ReadOnly = true;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "الموظف";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // busBindingSource1
            // 
            this.busBindingSource1.DataSource = typeof(Kindergarten_Mangement_System.Bus);
            // 
            // busBindingSource
            // 
            this.busBindingSource.DataSource = typeof(Kindergarten_Mangement_System.Bus);
            // 
            // Buses_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.lbl_error_delete);
            this.Controls.Add(this.text_delete);
            this.Controls.Add(this.lbl_error_search);
            this.Controls.Add(this.show_datagride);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete_bus);
            this.Controls.Add(this.btn_update_bus);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.btn_add_bus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2TextBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Buses_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Buses_Form_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.text_plat_numberus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_datagride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_paper_ownership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2Button btn_delete_bus;
        private Guna.UI2.WinForms.Guna2Button btn_update_bus;
        private Guna.UI2.WinForms.Guna2TextBox text_search;
        private Guna.UI2.WinForms.Guna2Button btn_add_bus;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox text_id;
        private Guna.UI2.WinForms.Guna2TextBox text_typ_bus;
        private Guna.UI2.WinForms.Guna2ComboBox text_employees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Guna.UI2.WinForms.Guna2NumericUpDown text_plat_numberus;
        private Guna.UI2.WinForms.Guna2Button btn_enter_image;
        private System.Windows.Forms.PictureBox pic_paper_ownership;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
        private System.Windows.Forms.BindingSource busBindingSource;
        private Guna.UI2.WinForms.Guna2DataGridView show_datagride;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bplatnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn bownershippaperDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource busBindingSource1;
        private System.Windows.Forms.Label lbl_error_employee;
        private System.Windows.Forms.Label lbl_error_pic;
        private System.Windows.Forms.Label lbl_error_pate_number;
        private System.Windows.Forms.Label lbl_error_typ_bus;
        private System.Windows.Forms.Label lbl_error_id;
        private System.Windows.Forms.Label lbl_error_search;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_employee;
        private System.Windows.Forms.Label lbl_error_delete;
        private Guna.UI2.WinForms.Guna2TextBox text_delete;
    }
}