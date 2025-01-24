namespace Kindergarten_Mangement_System
{
    partial class Signup_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup_Form));
            this.text_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.text_pass1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_pass2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_error_id = new System.Windows.Forms.Label();
            this.lbl_error_pass1 = new System.Windows.Forms.Label();
            this.lbl_error_pass2 = new System.Windows.Forms.Label();
            this.lbl_error_type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_q_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_error_rpeat_pass = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // text_type
            // 
            this.text_type.BackColor = System.Drawing.Color.Transparent;
            this.text_type.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_type.BorderRadius = 5;
            this.text_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.text_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.text_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.text_type.ItemHeight = 30;
            this.text_type.Items.AddRange(new object[] {
            "Manager",
            "Agent",
            "Secrtary"});
            this.text_type.Location = new System.Drawing.Point(92, 402);
            this.text_type.Name = "text_type";
            this.text_type.Size = new System.Drawing.Size(225, 36);
            this.text_type.TabIndex = 97;
            // 
            // text_pass1
            // 
            this.text_pass1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_pass1.BorderRadius = 5;
            this.text_pass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_pass1.DefaultText = "";
            this.text_pass1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_pass1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_pass1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_pass1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_pass1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_pass1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.text_pass1.ForeColor = System.Drawing.Color.Black;
            this.text_pass1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_pass1.Location = new System.Drawing.Point(92, 270);
            this.text_pass1.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.text_pass1.Name = "text_pass1";
            this.text_pass1.PasswordChar = '*';
            this.text_pass1.PlaceholderText = "كلمة المرور";
            this.text_pass1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_pass1.SelectedText = "";
            this.text_pass1.Size = new System.Drawing.Size(232, 27);
            this.text_pass1.TabIndex = 98;
            // 
            // text_pass2
            // 
            this.text_pass2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_pass2.BorderRadius = 5;
            this.text_pass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_pass2.DefaultText = "";
            this.text_pass2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_pass2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_pass2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_pass2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_pass2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_pass2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.text_pass2.ForeColor = System.Drawing.Color.Black;
            this.text_pass2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_pass2.Location = new System.Drawing.Point(92, 335);
            this.text_pass2.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.text_pass2.Name = "text_pass2";
            this.text_pass2.PasswordChar = '*';
            this.text_pass2.PlaceholderText = "تاكيد كلمة المرور";
            this.text_pass2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_pass2.SelectedText = "";
            this.text_pass2.Size = new System.Drawing.Size(232, 26);
            this.text_pass2.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(162, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 100;
            this.label6.Text = "إنشاء حساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(257, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 102;
            this.label2.Text = ": كلمة المرور";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(225, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 103;
            this.label3.Text = ": تاكيد كلمة المرور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(254, 377);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 104;
            this.label4.Text = ": نوع الحساب";
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
            this.text_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.text_id.ForeColor = System.Drawing.Color.Black;
            this.text_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_id.Location = new System.Drawing.Point(92, 185);
            this.text_id.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.text_id.Name = "text_id";
            this.text_id.PasswordChar = '\0';
            this.text_id.PlaceholderText = " الرقم الوظيفي";
            this.text_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_id.SelectedText = "";
            this.text_id.Size = new System.Drawing.Size(232, 26);
            this.text_id.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(169, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 106;
            this.label5.Text = ": الرقم الوظيفي";
            // 
            // lbl_error_id
            // 
            this.lbl_error_id.AutoSize = true;
            this.lbl_error_id.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_id.Location = new System.Drawing.Point(191, 213);
            this.lbl_error_id.Name = "lbl_error_id";
            this.lbl_error_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_id.TabIndex = 107;
            // 
            // lbl_error_pass1
            // 
            this.lbl_error_pass1.AutoSize = true;
            this.lbl_error_pass1.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_pass1.Location = new System.Drawing.Point(191, 300);
            this.lbl_error_pass1.Name = "lbl_error_pass1";
            this.lbl_error_pass1.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_pass1.TabIndex = 109;
            // 
            // lbl_error_pass2
            // 
            this.lbl_error_pass2.AutoSize = true;
            this.lbl_error_pass2.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_pass2.Location = new System.Drawing.Point(191, 364);
            this.lbl_error_pass2.Name = "lbl_error_pass2";
            this.lbl_error_pass2.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_pass2.TabIndex = 110;
            // 
            // lbl_error_type
            // 
            this.lbl_error_type.AutoSize = true;
            this.lbl_error_type.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_type.Location = new System.Drawing.Point(191, 441);
            this.lbl_error_type.Name = "lbl_error_type";
            this.lbl_error_type.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_type.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(209, 456);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 113;
            this.label1.Text = ": كلمة مرور احتياطية";
            // 
            // text_q_pass
            // 
            this.text_q_pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text_q_pass.BorderRadius = 5;
            this.text_q_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_q_pass.DefaultText = "";
            this.text_q_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_q_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_q_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_q_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_q_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_q_pass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.text_q_pass.ForeColor = System.Drawing.Color.Black;
            this.text_q_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_q_pass.Location = new System.Drawing.Point(92, 481);
            this.text_q_pass.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.text_q_pass.Name = "text_q_pass";
            this.text_q_pass.PasswordChar = '*';
            this.text_q_pass.PlaceholderText = "اسم الموظف";
            this.text_q_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_q_pass.SelectedText = "";
            this.text_q_pass.Size = new System.Drawing.Size(225, 26);
            this.text_q_pass.TabIndex = 112;
            // 
            // lbl_error_rpeat_pass
            // 
            this.lbl_error_rpeat_pass.AutoSize = true;
            this.lbl_error_rpeat_pass.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_rpeat_pass.Location = new System.Drawing.Point(191, 510);
            this.lbl_error_rpeat_pass.Name = "lbl_error_rpeat_pass";
            this.lbl_error_rpeat_pass.Size = new System.Drawing.Size(0, 13);
            this.lbl_error_rpeat_pass.TabIndex = 114;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(324, 331);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ok.Image = ((System.Drawing.Image)(resources.GetObject("btn_ok.Image")));
            this.btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ok.Location = new System.Drawing.Point(92, 529);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(225, 33);
            this.btn_ok.TabIndex = 18;
            this.btn_ok.Text = "موافــــق";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(154, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(324, 269);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(324, 182);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 573);
            this.panel1.TabIndex = 115;
            // 
            // Signup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 573);
            this.Controls.Add(this.lbl_error_rpeat_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_q_pass);
            this.Controls.Add(this.lbl_error_type);
            this.Controls.Add(this.lbl_error_pass2);
            this.Controls.Add(this.lbl_error_pass1);
            this.Controls.Add(this.lbl_error_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_pass2);
            this.Controls.Add(this.text_pass1);
            this.Controls.Add(this.text_type);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Signup_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2ComboBox text_type;
        private Guna.UI2.WinForms.Guna2TextBox text_pass1;
        private Guna.UI2.WinForms.Guna2TextBox text_pass2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox text_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_error_id;
        private System.Windows.Forms.Label lbl_error_pass1;
        private System.Windows.Forms.Label lbl_error_pass2;
        private System.Windows.Forms.Label lbl_error_type;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox text_q_pass;
        private System.Windows.Forms.Label lbl_error_rpeat_pass;
        private System.Windows.Forms.Panel panel1;
    }
}