using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;


/*      Osamah Gamal Mohammed Esmail        */

namespace Kindergarten_Mangement_System
{
    
    public partial class Form1 : Form
    {
        //-------------- Connection by SqlConection
        SqlConnection sqlcon = new SqlConnection("Data Source=OSAMAJAMAL\\OSAMAH;Initial Catalog=Kindergarten Mangement System;Integrated Security=True");
        SqlCommand cmd;

        //-------------- Connection by ADO.Net
        Kindergarten_Mangement_SystemEntities con = new Kindergarten_Mangement_SystemEntities();
        Employee emp = null;
        
        
        public Form1()
        {
            
            InitializeComponent();
        }


// show data from show_data_grid
        private void Show_datagrid()
        {
           // Show all the data from table Employees 
            show_datagridview.DataSource = con.Employees.ToList();

        }


        // this function to set items to combbox 
        private void comb_items(int num=-1)
        {
            int count = 0;
            if (num!=-1)
            {
                cmd = new SqlCommand("select job_name from Jobs", sqlcon);
                sqlcon.Open();
                SqlDataReader read = cmd.ExecuteReader();
                
                while (read.Read())
                {
                    count++;
                }
                sqlcon.Close();
                read.Close();
            }
            else
            {
                cmd = new SqlCommand("select job_name from Jobs", sqlcon);
                sqlcon.Open();
                SqlDataReader read = cmd.ExecuteReader();
                text_job_name.Items.Clear();

                while (read.Read())
                {
                    text_job_name.Items.Add(read["job_name"].ToString());
                    count++;
                }
                sqlcon.Close();
                read.Close();
            }
            



            cmd = new SqlCommand("select job_id from Jobs", sqlcon);
            sqlcon.Open();
            SqlDataReader read_id = cmd.ExecuteReader();

            string[] numbers = new string[count];
            int x = 0;
            while (read_id.Read())
            {
                numbers[x]= read_id["job_id"].ToString();
                x++;
            }
            sqlcon.Close();
            read_id.Close();

            if (numbers.Length!=0)
            {
                for (int i=0;i<numbers.Length;i++)
                {
                    if (num==i)
                    {
                        lbl_name_job.Text = numbers[num];
                    }
                }
            }
            

        }



        // get top number from table empolyees
        private void get_id_number()
        {
            cmd = new SqlCommand("select Max(e_id) from Employees", sqlcon);
            sqlcon.Open();

            object result = cmd.ExecuteScalar();

            if (result!=null)
            {
                string new_id = result.ToString();
                if (new_id.ToString().Trim() != "")
                {
                    int id = int.Parse(result.ToString());
                    id += 1;
                    text_id.Text = "     " + id;
                }
                else
                {
                    text_id.Text = " " + 100000000;
                }
            }
            else
            {
                text_id.Text = " " +100000000;
            }
            sqlcon.Close();
        }


        // form1 start load
        private void Form1_Load(object sender, EventArgs e)
        {
            // show data from database on datagride
            Show_datagrid();

            //get items from database to set in combbox 
            comb_items();

            // get top id from table empolyees
            get_id_number();
        }


        //--------to return lable errors null
        private void lbl_errors()
        {
            lbl_error_id.Text = "";
            lbl_error_Job_name.Text = "";
            lbl_error_E_name.Text = "";
            lbl_error_gender.Text = "";
            lbl_error_age.Text = "";
            lbl_error_address.Text = "";
            //lbl_error_personal_card.Text = "";
            //lbl_error_Driving_card.Text = "";
            //lbl_error_Cer_card.Text = "";
            lbl_error_phone.Text = "";
            //lbl_error_salary.Text = "";
            lbl_error_salary1.Text = "";

            lbl_error_delete.Text = "";
            lbl_error_search.Text = "";


            lbl_error_personal_card.Text = "";
            btn_chose_personal_card_photo.BorderColor = Color.Wheat;

            lbl_error_Cer_card.Text = "";
            btn_chose_certificate_photo.BorderColor = Color.Wheat;

            lbl_error_Driving_card.Text = "";
            btn_driving_license_photo.BorderColor = Color.Wheat;
            
        }




        // button add data to database
        private void btn_add_data_Click(object sender, EventArgs e)
        {

            lbl_errors();






            //-------text job name
            int check1 = 0;
            if (text_job_name.Text.Trim() != "")
            {
                lbl_errors();

                //-------text employee name
                int check2 = 0;
                if (text_name.Text.Trim() != "" && text_name.Text.Length <= 50)
                {
                    lbl_errors();
                    for (int i = 0; i < text_name.Text.Length; i++)
                    {
                        if (text_name.Text[i] >= 'A' && text_name.Text[i] >= 'Z' || text_name.Text[i] >= 'a' && text_name.Text[i] >= 'z' || text_name.Text[i] == ' ')
                        {

                            //----check the textbox has full name componennt from 4 parts
                            string[] f_name = text_name.Text.Split(' ');
                            string str = "";
                            int count = 0;
                            for (int j = 0; j < f_name.Length; j++)
                            {
                                str = f_name[j];
                                if (str != " ")
                                {
                                    if (str.Length >= 3)
                                    {
                                        count += 1;
                                    }
                                    else
                                    {

                                        lbl_error_E_name.Text = "يجب ان يكون الاسم الواحد اكثر من 2 احرف ";
                                        text_name.Focus();
                                        break;
                                    }
                                }
                                else
                                {
                                    continue;
                                }

                            }

                            //----after check string not has any number

                            if (count == 4)
                            {
                                check2 = 1;
                            }
                            else
                            {
                                lbl_error_E_name.Text = "          يجب إدخال اسم الموظف الكامل ";
                                text_name.Focus();
                            }
                        }
                        else
                        {
                            check2 = 0;
                            lbl_error_E_name.Text = "يجب ادخال اسم الموظف بدون ارقام او اشارات";
                            text_name.Focus();
                            break;
                        }
                    }


                    //----after check string not has any number 
                    if (check2 == 1)
                    {
                        lbl_errors();


                        //-------text age
                        if (text_age.Text.Trim()!="")
                        {
                            int age = int.Parse(text_age.Text);
                            if (age >= 22)
                            {


                                //-------radio gender
                                if (!radio_gender_m.Checked && !radio_gender_f.Checked)
                                {
                                    lbl_error_gender.Text = "يجب إختيار الجنس";
                                }
                                else
                                {
                                    lbl_errors();
                                    int gender = 0;
                                    if (radio_gender_m.Checked)
                                    {
                                        gender = 1;
                                    }
                                    else
                                    {
                                        gender = 2;
                                    }

                                    //  gender 1,2 send to database go to complete ---->

                                    if (radio_gender_m.Checked || radio_gender_f.Checked)
                                    {
                                        lbl_errors();
                                        int x = 0;
                                        if (radio_gender_m.Checked)
                                        {
                                            // checked male =1   ذكر
                                            x = 1;
                                        }
                                        else
                                        {
                                            // checked female =2  انثى
                                            x = 2;
                                        }

                                        // after check gender go to complete ---->


                                        // text box address cod
                                        if (text_address.Text.Trim()!="")
                                        {
                                            lbl_errors();
                                            if (text_address.Text.Length<=50)
                                            {
                                                lbl_errors();


                                                // text box number phone ---->

                                                if(text_phone.Text.Trim()!="")
                                                {
                                                    //example + 967 735 260 642 
                                                    string pattern = @"^(\+?967)?[1-9]\d{8}$";
                                                    if (Regex.IsMatch(text_phone.Text, pattern))
                                                    {
                                                        // to check the number of phone is unique 
                                                        cmd = new SqlCommand("select count(*) from Employees where e_phone='" + text_phone.Text+"'", sqlcon);
                                                        sqlcon.Open();
                                                        int count = (int)cmd.ExecuteScalar();
                                                        sqlcon.Close();
                                                        
                                                       

                                                        if (count>0)
                                                        {
                                                            lbl_error_phone.Text = "! هذا الرقم لشخص اخر";
                                                            text_phone.Focus();
                                                            return;
                                                        }
                                                       
                                                        // text box Salary of Employee
                                                        if (text_salary.Text.Trim()!="")
                                                        {
                                                            lbl_errors();
                                                             pattern = @"^d{4}\([1-9])$";
                                                            if (Regex.IsMatch(text_salary.Text, pattern))
                                                            {
                                                                lbl_errors();

                                                              

                                                                // 1- pictur box personal_card_photo -->
                                                                if (pic_personal_card_photo.Image!=null)
                                                                {
                                                                    MemoryStream ms1 = new MemoryStream();
                                                                    pic_personal_card_photo.Image.Save(ms1,System.Drawing.Imaging.ImageFormat.Jpeg);
                                                                    var pic_personal_card= ms1.ToArray();



                                                                    // 2- pictur box pic_certificate_photo -->
                                                                    if (pic_certificate_photo.Image != null)
                                                                    {
                                                                        MemoryStream ms2 = new MemoryStream();
                                                                        pic_certificate_photo.Image.Save(ms2,System.Drawing.Imaging.ImageFormat.Jpeg);
                                                                        var pic_certificate = ms2.ToArray();

                                                                        //سيتم ادراج صورة رخصة القياده فقط ان كان لاموظف سائق فقط
                                                                        //
                                                                        // pictur box pic_driving_license_photo -->
                                                                        
                                                                        if (btn_driving_license_photo.Visible == true)
                                                                        {
                                                                            if (pic_driving_license_photo.Image != null)
                                                                            {
                                                                                MemoryStream ms3 = new MemoryStream();
                                                                                pic_driving_license_photo.Image.Save(ms3, System.Drawing.Imaging.ImageFormat.Jpeg);
                                                                                var pic_driving_license = ms3.ToArray();

                                                                                //
                                                                                try
                                                                                {
                                                                                    // Here to add data to table Employees
                                                                                    int jobs_id = int.Parse(lbl_name_job.Text);
                                                                                    con.Employees.Add(
                                                                                        new Employee()
                                                                                        {
                                                                                    // primary key edintity 1,1
                                                                                    //e_id = text_id.Text;
                                                                                    //from text box job's number to employee


                                                                                    job_id = jobs_id,
                                                                                    //employee name 

                                                                                    e_name = text_name.Text,
                                                                                    //employee age 
                                                                                    e_age = int.Parse(text_age.Text),
                                                                                    //employee gender (1=Male 2=Famele)
                                                                                    gender_id = x,
                                                                                    //employee address
                                                                                    e_address = text_address.Text,
                                                                                    //employee phone number
                                                                                    e_phone = text_phone.Text,
                                                                                    //employee salary 
                                                                                    e_salary = decimal.Parse(text_salary.Text),
                                                                                    // image the personal_card 
                                                                                    e_personal_card = pic_personal_card,
                                                                                    // image the personal_card 
                                                                                    e_ceirtificate = pic_certificate,
                                                                                    // image the driving_license 
                                                                                    driving_license = pic_driving_license,


                                                                                        });
                                                                                    con.SaveChanges();
                                                                                    lbl_errors();
                                                                                    MessageBox.Show("Added");
                                                                                    Show_datagrid();


                                                                                }
                                                                                catch 
                                                                                {
                                                                                    lbl_error_id.Text= "هذا الرقم موجود من قبل";
                                                                                }

                                                                            }
                                                                            else
                                                                            {
                                                                                lbl_error_Driving_card.Text = "  يجب اختيار الصورة";
                                                                                btn_driving_license_photo.BorderColor = Color.Red;
                                                                                btn_driving_license_photo.Focus();
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            //
                                                                            try
                                                                            {
                                                                                // Here to add data to table Employees
                                                                                int jobs_id = int.Parse(lbl_name_job.Text);
                                                                                con.Employees.Add(
                                                                                    new Employee()
                                                                                    {
                                                                                    // primary key edintity 1,1
                                                                                    //e_id = text_id.Text;
                                                                                    //from text box job's number to employee


                                                                                    job_id = jobs_id,
                                                                                    //employee name 

                                                                                    e_name = text_name.Text,
                                                                                    //employee age 
                                                                                    e_age = int.Parse(text_age.Text),
                                                                                    //employee gender (1=Male 2=Famele)
                                                                                    gender_id = x,
                                                                                    //employee address
                                                                                    e_address = text_address.Text,
                                                                                    //employee phone number
                                                                                    e_phone = text_phone.Text,
                                                                                    //employee salary 
                                                                                    e_salary = decimal.Parse(text_salary.Text),
                                                                                    // image the personal_card 
                                                                                    e_personal_card = pic_personal_card,
                                                                                    // image the personal_card 
                                                                                    e_ceirtificate = pic_certificate,
                                                                                    // image the driving_license 


                                                                                    });
                                                                                con.SaveChanges();
                                                                                lbl_errors();
                                                                                MessageBox.Show("Added");
                                                                                Show_datagrid();


                                                                            }
                                                                            catch (Exception ex)
                                                                            {
                                                                                MessageBox.Show(ex + "");
                                                                            }
                                                                        }
                                                                        
                                                                       
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////







                                                                    }
                                                                    else
                                                                    {
                                                                        lbl_error_Cer_card.Text = " يجب اختيار الصورة";
                                                                        btn_chose_certificate_photo.BorderColor = Color.Red;
                                                                        btn_chose_certificate_photo.Focus();
                                                                    }


                                                                }
                                                                else
                                                                {
                                                                    lbl_error_personal_card.Text = "  يجب اختيار الصورة";
                                                                    btn_chose_personal_card_photo.BorderColor = Color.Red;
                                                                    btn_chose_personal_card_photo.Focus();
                                                                }
                                                                

                                                            }
                                                            else
                                                            {
                                                                lbl_error_salary1.Text = "يجب ادخال رقم فقط ";
                                                                text_salary.Focus();
                                                                
                                                            }

                                                        }
                                                        else
                                                        {
                                                            lbl_error_salary1.Text = "لا يزال الحقل فارغ";
                                                            text_salary.Focus();
                                                        }


                                                    }
                                                    else
                                                    {
                                                        lbl_error_phone.Text = "يجب ادخال رقم الهاتف بشكل صحيح"+"\n"+"     +967 000 000 000";
                                                        text_phone.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    lbl_error_phone.Text = "الحقل فارغ لا يوجد رقم";
                                                    text_phone.Focus();
                                                }
                                               



                                            }
                                            else
                                            {
                                                lbl_error_address.Text = "تجاوزت الحد الاقصى للعنوان";
                                                text_address.Focus();
                                            }

                                        }
                                        else
                                        {
                                            lbl_error_address.Text = "يجب ادخال العنوان";
                                            text_address.Focus();
                                        }

                                    }
                                    else
                                    {
                                        lbl_error_gender.Text = "يجب ان تختار الجنس";
                                        radio_gender_m.Focus();
                                    }
                                    


                                }
                            }
                            else
                            {
                                lbl_error_age.Text = "ادخل العمر اكبر من 21 سنه الى 70 سنه";
                                text_age.Focus();
                            }
                        }
                        else
                        {
                            lbl_error_age.Text = "             !لا يوجد رقم";
                            text_age.Focus();
                        }
                        

                    }

                }
                else
                {
                    if (text_name.Text.Length > 50)
                    {
                        lbl_error_E_name.Text = "        يجب الا يزيد اسم لموظف عن 50 حرف";
                        text_name.Focus();
                    }
                    else
                    {
                        lbl_error_E_name.Text = "                    يجب ادخال اسم الموظف";
                        text_name.Focus();
                    }

                }

            }
            else
            {
                lbl_error_Job_name.Text = "                    يجب ادخال اسم الوظيفه";
                text_job_name.Focus();
            }
        }

  
//  update data that in table emploeeys
        private void btn_update_data_Click(object sender, EventArgs e)
        {

            lbl_errors();



            if (text_id.Text.Trim() == "")
            {
                lbl_error_id.Text = "يجب جلب رقم الكود";
                return;
            }
            lbl_error_id.Text = "";
            try
            {
               
                int id =int.Parse(text_id.Text); //int.Parse(text_search.Text);
                Employee sel = con.Employees.First(d => d.e_id == id);
                sel.e_id =id;
                sel.e_name = text_name.Text;
                sel.job_id = int.Parse(lbl_name_job.Text);
                sel.e_age = int.Parse(text_age.Text);
                int x;
                if (radio_gender_m.Checked)
                {
                    x = 1;
                }
                else
                {
                    x = 2;
                }

                sel.gender_id = x;
                sel.e_address = text_address.Text;
                sel.e_phone = text_phone.Text;

                decimal num = decimal.Parse(text_salary.Text);
                sel.e_salary = num;


                MemoryStream ms1 = new MemoryStream();
                pic_personal_card_photo.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                var pic_personal_card = ms1.ToArray();

                sel.e_personal_card = pic_personal_card;


                MemoryStream ms2 = new MemoryStream();
                pic_certificate_photo.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg);
                var pic_certificate = ms2.ToArray();

                sel.e_ceirtificate = pic_certificate;


                string txt = text_job_name.Text;
                if (txt == "سائق" || txt == "سايق" || txt =="Driver" || txt == "driver" )
                {
                    MemoryStream ms3 = new MemoryStream();
                    pic_driving_license_photo.Image.Save(ms3, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var pic_driving_license = ms3.ToArray();

                    sel.driving_license = pic_driving_license;
                }
               


                con.SaveChanges();
                MessageBox.Show("Done Update");
                lbl_errors();
                Show_datagrid();

            }
            catch 
            {
                lbl_error_id.Text= "لا يوجد هذا الكود يجب جلب البيانات من الجدول";
            }
        }


 // button to delete 1 row from table Employees 
        private void btn_delete_data_Click(object sender, EventArgs e)
        {


            if (text_delete.Text.Trim() != "")
            {
                lbl_errors();

                lbl_error_delete.Text = "";


                try
                {
                    lbl_errors();
                    lbl_error_delete.Text = "";


                    int id = Convert.ToInt32(text_delete.Text);
                    Employee del = con.Employees.First(d => d.e_id == id);
                    con.Employees.Remove(del);
                    con.SaveChanges();
                    Show_datagrid();

                    // get top id from table empolyees
                        get_id_number();

                    //------------------------------
                    MessageBox.Show("Done Delete");
                    lbl_errors();

                }
                catch
                {
                    lbl_errors();
                    lbl_error_delete.Text = "غير متوفر هذا الكود";
                    text_delete.Focus();
                }
            }
            else
            {
                lbl_errors();
                lbl_error_delete.Text = "! لايزال الحقل فارغ";
                text_delete.Focus();

            }

        }


        // to show all data from click row in datagrid on the fields form
        private void Show_in_form(int value)
        {

                // value == e_id 
                
                Employee sel = con.Employees.First(d => d.e_id == value);
                // employee id
                text_id.Text = sel.e_id + "";
                //from text box job's number to employee
                text_job_name.Items.Clear();
                int id=int.Parse(sel.job_id+"");
                Job sel1 = con.Jobs.First(d => d.job_id == id);
                
                text_job_name.Items.Add(sel1.job_name + "");
                text_job_name.Text = text_job_name.Items[0].ToString();
                
                //employee name 
                text_name.Text = sel.e_name;
                //employee age 
                text_age.Text = sel.e_age + "";
                //employee gender (1=Male 2=Famele)
                if (sel.gender_id == 1)
                {
                    radio_gender_m.Checked = true;
                }
                else
                {
                    radio_gender_f.Checked = true;
                }
                //employee address
                text_address.Text = sel.e_address;
                //employee phone number
                text_phone.Text = sel.e_phone + "";
                //employee salary 
                text_salary.Text = sel.e_salary + "";

                // image the personal_card 
                byte[] pic1 = (byte[])sel.e_personal_card;
                MemoryStream ms1 = new MemoryStream(pic1);
                pic_personal_card_photo.Image = Image.FromStream(ms1);

                // image the personal_card 
                byte[] pic2 = (byte[])sel.e_ceirtificate;
                MemoryStream ms2 = new MemoryStream(pic2);
                pic_certificate_photo.Image = Image.FromStream(ms2);

                // when the employee is drivers this field is show
                string txt=text_job_name.Text.Trim();
                if (txt == "سائق" || txt == "سايق" || txt == "driver" || txt == "Driver")
                {
                    // image the driving_license
                    driving_license(true); 
                    byte[] pic3 = (byte[])sel.driving_license;
                    MemoryStream ms3 = new MemoryStream(pic3);
                    pic_driving_license_photo.Image = Image.FromStream(ms3);
                }
                

            //---
            lbl_errors();
        }

        // give the data from the table to set in form
        private void btn_enter_data_Click_1(object sender, EventArgs e)
        {

            lbl_errors();



            int number ;
            bool check = int.TryParse(text_search.Text,out number);
            if (check)
            {
                number = int.Parse(text_search.Text);
                Show_in_form(number);
            }
            else
            {
                lbl_error_search.Text = "! لايوجد بيانات لهذا الحساب";
                text_search.Focus();
            }
            
            
       }



        //   to open file for choses image 
        //  personal_card_photo
        private void btn_chose_personal_card_photo_Click_1(object sender, EventArgs e)
        {
            lbl_errors();

            OpenFileDialog per_image = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg";
            openFileDialog1.Title = "الصورة الشخصية";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_error_personal_card.Text = "       تم الاختيار";
                lbl_error_personal_card.ForeColor = Color.LimeGreen;
                btn_chose_personal_card_photo.BorderColor = Color.PaleGreen;


                pic_personal_card_photo.Image = new Bitmap(openFileDialog1.FileName);



            }
            else
            {
                lbl_error_personal_card.Text = "  يجب اختيار الصورة";
                btn_chose_personal_card_photo.BorderColor = Color.Red;
                btn_chose_personal_card_photo.Focus();
            }

        }

        //  ertificate_photo
        private void btn_chose_certificate_photo_Click_1(object sender, EventArgs e)
        {
            lbl_errors();

            OpenFileDialog per_image = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg";
            openFileDialog1.Title = "صورة شهادة خبره";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_error_Cer_card.Text = "       تم الاختيار";
                lbl_error_Cer_card.ForeColor = Color.LimeGreen;
                btn_chose_certificate_photo.BorderColor = Color.PaleGreen;


                string select = openFileDialog1.FileName;
                using (FileStream fs = new FileStream(select, FileMode.Open, FileAccess.Read))
                {
                    byte[] image = new byte[fs.Length];
                    fs.Read(image, 0, Convert.ToInt32(fs.Length));

                }


                pic_certificate_photo.Image = new Bitmap(openFileDialog1.FileName);

            }
            else
            {
                lbl_error_Cer_card.Text = " يجب اختيار الصورة";
                btn_chose_certificate_photo.BorderColor = Color.Red;
                btn_chose_certificate_photo.Focus();
            }
        }

        //  driving_license_photo
        private void btn_driving_license_photo_Click_1(object sender, EventArgs e)
        {
            lbl_errors();


            OpenFileDialog per_image = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg";
            openFileDialog1.Title = "صورة رخصة القيادة";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_error_Driving_card.Text = "       تم الاختيار";
                lbl_error_Driving_card.ForeColor = Color.LimeGreen;
                btn_driving_license_photo.BorderColor = Color.PaleGreen;

                string select = openFileDialog1.FileName;
                using (FileStream fs = new FileStream(select, FileMode.Open, FileAccess.Read))
                {
                    byte[] image = new byte[fs.Length];
                    fs.Read(image, 0, Convert.ToInt32(fs.Length));

                }


                pic_driving_license_photo.Image = new Bitmap(openFileDialog1.FileName);

            }
            else
            {
                lbl_error_Driving_card.Text = "  يجب اختيار الصورة";
                btn_driving_license_photo.BorderColor = Color.Red;
                btn_driving_license_photo.Focus();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            lbl_errors();



            List<Employee> nem = con.Employees.ToList();

            if (text_search.Text.Trim()!="")
            {
                lbl_errors();

                int number;
                bool isnum = int.TryParse( text_search.Text,out number);
                if (isnum)
                {
                    // int sreach id
                    nem = nem.Where(d => d.e_id.ToString().Contains(text_search.Text)).ToList();

                    show_datagridview.DataSource = nem.ToList();
                }
                else
                {
                    // string sreach name
                    nem = nem.Where(r => r.e_name.Contains(text_search.Text)).ToList();

                    show_datagridview.DataSource = nem.ToList();
                }
              
                }
            else
            {
                lbl_errors();
                lbl_error_search.Text = "    ! الحقل لايزال فارغ";
                text_search.Focus();
            }
        }

        private void show_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                int rowindex =e.RowIndex;
                DataGridViewRow select = show_datagridview.Rows[rowindex];

                string value = select.Cells[10].Value.ToString();

                int index=int.Parse(value);

                // method to show in data form
                Show_in_form(index);
           
        }

  
   //--------------Reset all fields-------------//
        private void btn_reset_Click(object sender, EventArgs e)
        {

            // text id 
                 // function --> get top id from table empolyees
                 get_id_number();
            //from text box job's number to employee
                text_job_name.Items.Clear();
                comb_items();

            //employee name 
            text_name.Text ="";
            //employee age 
                text_age.Text ="";
            //employee gender (1=Male 2=Famele)
                radio_gender_m.Checked = false;
                radio_gender_m.Checked = false;
            //employee address
                text_address.Text ="";
            //employee phone number
                text_phone.Text = "";
            //employee salary 
                text_salary.Text ="";

            // image the personal_card 
                pic_personal_card_photo.Image =null;
            // image the certificate  
                pic_certificate_photo.Image = null;
            // image the driving_license 
                pic_driving_license_photo.Image = null;

            // rest text box delete to null
            text_delete.Text = "";

            //--------- reset the text_name_job and dadagridview to the defoult items from database
            Show_datagrid();
            //---------method to labels to set null
                lbl_errors();

        }

     // to set tools's driving_license_photo lbl,but,pic visible-->true or false
        private void driving_license(bool set)
        {
            lbl_driving_license_photo.Visible = set;
            btn_driving_license_photo.Visible = set;
            pic_driving_license_photo.Visible = set;
        }
    
  //---------- the text_job_name code selected items 
        private void text_job_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexs = text_job_name.SelectedIndex;
            comb_items(indexs);


            // to return pute tools driving_license_photo true when he is inserte data
            // عندما يكون الموظف سائق سيتوجب عليه ادخال صورة رخصة القياده
            string txt = text_job_name.Text.Trim();
            if (txt == "سائق" || txt == "سايق" || txt =="driver" ||txt== "Driver")
            {
                driving_license(true);
            }
            else
            {
                driving_license(false);
            }
        }
    }
}