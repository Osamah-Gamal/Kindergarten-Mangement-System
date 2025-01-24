using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten_Mangement_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // إنشاء مربع حوار اختيار الملفات
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // تحديد الامتدادات المسموح بها للصور
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // الحصول على المسار المحدد للصورة
                string imagePath = openFileDialog.FileName;

                // تعيين مسار الصورة لـ PictureBox
                pictureBox1.ImageLocation = imagePath;
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
    
        }

        private void btn__physical_examination_photo_Click(object sender, EventArgs e)
        {
            // إنشاء مربع حوار اختيار الملفات
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // تحديد الامتدادات المسموح بها للصور
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // الحصول على المسار المحدد للصورة
                string imagePath = openFileDialog.FileName;

                // تعيين مسار الصورة لـ PictureBox
                pictureBox2.ImageLocation = imagePath;
            }
        }

        private void btn_get_student_photo_Click(object sender, EventArgs e)
        {
            // إنشاء مربع حوار اختيار الملفات
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // تحديد الامتدادات المسموح بها للصور
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // الحصول على المسار المحدد للصورة
                string imagePath = openFileDialog.FileName;

                // تعيين مسار الصورة لـ PictureBox
                pictureBox1.ImageLocation = imagePath;
            }
        }

        //---------------------------------------------Functions for Regex -------------------------------------------------------//
        static bool IsValidNumberPhon(string date)
        {
            string pattern = @"^(\+?967)?[1-9]\d{9}$";
            return Regex.IsMatch(date, pattern);
        }
       
        static bool IsValidDate(string date)
        {
            string pattern = @"^\d{4}-\d{2}-\d{2}$";
            return Regex.IsMatch(date, pattern);
        }
        static bool IsValidName(string fullName)
        {
            // النمط الذي يتحقق من صحة الاسم الرباعي بالعربية
            string pattern = @"^[\u0621-\u064A]+\s[\u0621-\u064A]+\s[\u0621-\u064A]+\s[\u0621-\u064A]+$";
            return Regex.IsMatch(fullName, pattern);
        }


        //-------------------------------------------------------------------------------------------------------------------------------//

        private void lab_eroor_student_name_Click(object sender, EventArgs e)
        {
           
           
         

        }

        private void txt_Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<17; i++)
            {
                if (i == 0)
                {
                    string fullName = txt_student.Text; // اسم رباعي بالعربية

                    if (IsValidName(fullName))
                    {
                        // insert in database column student name
                       
                        i++;
                    }
                    else
                    {

                        //Messag  eror in Date try agin
                        lab_eroor_student_name.Text = "الرجاء ادخال اسمك الرباعي";
                        lab_eroor_student_name.ForeColor = Color.Red;
                        txt_student.SelectAll();
                        txt_student.Focus();
                    }

                    if (i == 1)
                    {
                        string date = txt_Date.Text;

                        if (IsValidDate(date))
                        {
                            // insert in database column brithDate
                            MessageBox.Show("تنسيق التاريخ صحيح.");
                            i++;
                        }
                        else
                        {
                            //Messag  eror in Date try agin

                            lab_erorr_date.Text = "تنسيق التاريخ خطاء";
                            lab_erorr_date.ForeColor = Color.Red;
                            txt_Date.Clear();
                            txt_Date.Focus();

           
                        }
                    }
                        if (i == 3)
                        {
                            string NumberPhon = txt_phon.Text;
                            if (IsValidNumberPhon(NumberPhon))
                            {
                                i++;
                                
                            }
                        }


                        else
                        {

                            lab_error_number_phon.Text = "الرجاء كتابة الرقم بشكب صحيح";
                            lab_error_number_phon.ForeColor = Color.Red;
                            txt_Date.Clear();
                            txt_Date.Focus();
                 
                    }

                }
            }   

        }

        private void btn_viwe_students_Click(object sender, EventArgs e)
        {
            Viwe_students v_student = new Viwe_students();
            v_student.Show();   
        }

        private void rbtn_Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {

            for (int i = 0; i < 17; i++)
            {
                if (i == 0)
                {
                    string fullName = txt_student.Text; // اسم رباعي بالعربية

                    if (IsValidName(fullName))
                    {
                        // insert in database column student name

                        i++;
                    }
                    else
                    {

                        //Messag  eror in Date try agin
                        lab_eroor_student_name.Text = "الرجاء ادخال اسمك الرباعي";
                        lab_eroor_student_name.ForeColor = Color.Red;
                        txt_student.SelectAll();
                        txt_student.Focus();
                    }

                    if (i == 1)
                    {
                        string date = txt_Date.Text;

                        if (IsValidDate(date))
                        {
                            // insert in database column brithDate
                            MessageBox.Show("تنسيق التاريخ صحيح.");
                            i++;
                        }
                        else
                        {
                            //Messag  eror in Date try agin

                            lab_erorr_date.Text = "تنسيق التاريخ خطاء";
                            lab_erorr_date.ForeColor = Color.Red;
                            txt_Date.Clear();
                            txt_Date.Focus();


                        }
                    }
                    if (i == 3)
                    {
                        string NumberPhon = txt_phon.Text;
                        if (IsValidNumberPhon(NumberPhon))
                        {
                            i++;

                        }
                    }


                    else
                    {

                        lab_error_number_phon.Text = "الرجاء كتابة الرقم بشكب صحيح";
                        lab_error_number_phon.ForeColor = Color.Red;
                        txt_Date.Clear();
                        txt_Date.Focus();

                    }

                }
            }


        }

        private void btn_add_data_Click(object sender, EventArgs e)
        {

        }

        private void btn_viwe_students_Click_1(object sender, EventArgs e)
        {
            Viwe_students v1 = new Viwe_students();
            v1.ShowDialog();
        }
    }
}
