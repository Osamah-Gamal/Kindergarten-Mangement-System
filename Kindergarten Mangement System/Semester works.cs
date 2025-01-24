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



/*      Osamah Gamal Mohammed Esmail        */

namespace Kindergarten_Mangement_System
{
    public partial class _ٍSemester_works : Form
    {

        //-------------- Connection by SqlConection
        SqlConnection sqlcon = new SqlConnection("Data Source=OSAMAJAMAL\\OSAMAH;Initial Catalog=Kindergarten Mangement System;Integrated Security=True");
        SqlCommand cmd;

        //-------------- Connection by ADO.Net
        Kindergarten_Mangement_SystemEntities con = new Kindergarten_Mangement_SystemEntities();
        Semester_works emp = null;
        public _ٍSemester_works()
        {
            InitializeComponent();
        }


        //----------- label error 
        private void lbl_errors()
        {
            lbl_error_id.Text = "";
            lbl_error_Student_id.Text = "";
            lbl_error_level.Text = "";
            lbl_error_Subject_name.Text = "";
            lbl_error_test1.Text = "";
            lbl_error_test2.Text = "";
            lbl_error_final.Text = "";
            lbl_error_total.Text = "";
        }

   


        // function to show all data from database to datagrid
        private void Show_datagrid()
        {
            // Show all the data from table Employees 
            show_datagridview.DataSource = con.Semester_works.ToList();
        }


        // get top number from table empolyees
        private void get_id_number()
        {
            cmd = new SqlCommand("select Max(sw_id) from Semester_works", sqlcon);
            sqlcon.Open();

            object result = cmd.ExecuteScalar();

            if (result != null)
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
                    text_id.Text = "     " + 1;
                }
            }
            else
            {
                text_id.Text = "     " + 1;
            }
            sqlcon.Close();
        }

       
        // this function to set items to combbox students id 
        private void comb_items_stuents(int num = -1)
        {
            int count = 0;
            if (num != -1)
            {
                cmd = new SqlCommand("select student_name from Students", sqlcon);
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
                cmd = new SqlCommand("select student_name from Students", sqlcon);
                sqlcon.Open();
                SqlDataReader read = cmd.ExecuteReader();
                text_student_id.Items.Clear();

                while (read.Read())
                {
                    text_student_id.Items.Add(read["student_name"].ToString());
                    count++;
                }
                sqlcon.Close();
                read.Close();
            }




            cmd = new SqlCommand("select student_id from Students", sqlcon);
            sqlcon.Open();
            SqlDataReader read_id = cmd.ExecuteReader();

            string[] numbers = new string[count];
            int x = 0;
            while (read_id.Read())
            {
                numbers[x] = read_id["student_id"].ToString();
                x++;
            }
            sqlcon.Close();
            read_id.Close();

            if (numbers.Length != 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (num == i)
                    {
                        lbl_subjects_id.Text = numbers[num];
                    }
                }
            }


        }


        // this function to set items to combbox levels id 
        private void comb_items_levels(int num = -1)
        {
            int count = 0;
            if (num != -1)
            {
                cmd = new SqlCommand("select l_name from Levels", sqlcon);
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
                cmd = new SqlCommand("select l_name from Levels", sqlcon);
                sqlcon.Open();
                SqlDataReader read = cmd.ExecuteReader();
                text_level_name.Items.Clear();

                while (read.Read())
                {
                    text_level_name.Items.Add(read["l_name"].ToString());
                    count++;
                }
                sqlcon.Close();
                read.Close();
            }




            cmd = new SqlCommand("select l_id from Levels", sqlcon);
            sqlcon.Open();
            SqlDataReader read_id = cmd.ExecuteReader();

            string[] numbers = new string[count];
            int x = 0;
            while (read_id.Read())
            {
                numbers[x] = read_id["l_id"].ToString();
                x++;
            }
            sqlcon.Close();
            read_id.Close();

            if (numbers.Length != 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (num == i)
                    {
                        lbl_level_id.Text = numbers[num];
                    }
                }
            }


        }


        // this function to set items to combbox levels id 
        private void comb_items_subjects(int num = -1)
        {
            int count = 0;
            if (num != -1)
            {
                cmd = new SqlCommand("select subject_name from Subjects", sqlcon);
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
                cmd = new SqlCommand("select subject_name from Subjects", sqlcon);
                sqlcon.Open();
                SqlDataReader read = cmd.ExecuteReader();
                text_subject_name.Items.Clear();

                while (read.Read())
                {
                    text_subject_name.Items.Add(read["subject_name"].ToString());
                    count++;
                }
                sqlcon.Close();
                read.Close();
            }




            cmd = new SqlCommand("select subject_id from Subjects", sqlcon);
            sqlcon.Open();
            SqlDataReader read_id = cmd.ExecuteReader();

            string[] numbers = new string[count];
            int x = 0;
            while (read_id.Read())
            {
                numbers[x] = read_id["subject_id"].ToString();
                x++;
            }
            sqlcon.Close();
            read_id.Close();

            if (numbers.Length != 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (num == i)
                    {
                        lbl_subjects_id.Text = numbers[num];
                    }
                }
            }


        }


        //when form load
        private void _ٍSemester_works_Load(object sender, EventArgs e)
        {
            // function to show data on data gride
            Show_datagrid();

            // get top id from table empolyees
            get_id_number();

            //get items from database table students in to set in combbox 
            comb_items_stuents();
            //get items from database table subjects in to set in combbox
            comb_items_subjects();
            //get items from table levles in database to set in combbox
            comb_items_levels();

        }

        private void text_student_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexs = text_subject_name.SelectedIndex;
            comb_items_stuents(indexs);
        }

        private void text_level_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexs = text_level_name.SelectedIndex;
            comb_items_levels(indexs);
        }

        private void text_subject_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexs = text_subject_name.SelectedIndex;
            comb_items_subjects(indexs);
        }


        // function to add--1 and update-->2
        private void add_update(int opreation)
        {
            //---text student id
            if (text_student_id.Text.Trim() != "")
            {
                lbl_errors();


                //-----text level name
                if (text_level_name.Text.Trim() != "")
                {
                    lbl_errors();

                    //-----text subject name
                    if (text_subject_name.Text.Trim() != "")
                    {
                        lbl_errors();


                        //-----text test1 
                        if (text_test_1.Text.Trim() != "")
                        {
                            try
                            {
                                double test1 = double.Parse(text_test_1.Text);
                                lbl_errors();


                                //----
                                if (test1 <= 50 && test1 > -1)
                                {
                                    //-----text test2 
                                    if (text_test_2.Text.Trim() != "")
                                    {
                                        try
                                        {
                                            double test2 = double.Parse(text_test_2.Text);
                                            lbl_errors();


                                            //----
                                            if (test2 <= 50 && test2 > -1)
                                            {

                                                //-----text test2 
                                                if (text_final.Text.Trim() != "")
                                                {
                                                    try
                                                    {
                                                        double final = double.Parse(text_final.Text);
                                                        lbl_errors();
                                                        if (final <= 100 && final > -1)
                                                        {
                                                            //----
                                                            text_total.Text = "    " + (test1 + test2 + final);

                                                            // Here to add data to table Employees

                                                            int student_id = int.Parse(lbl_student_id.Text);
                                                            int level_id = int.Parse(lbl_level_id.Text);
                                                            int subject_id = int.Parse(lbl_subjects_id.Text);

                                                            double total = test1 + test2 + final;

                                                            // to add
                                                            if (opreation == 1)
                                                            {
                                                                lbl_errors();

                                                                try
                                                                {
                                                                    con.Semester_works.Add(
                                                                  new Semester_works()
                                                                  {
                                                                      student_id = student_id,
                                                                      level_id = level_id,
                                                                      subject_id = subject_id,
                                                                      test1 = test1,
                                                                      test2 = test2,
                                                                      final = final,
                                                                      total = total,

                                                                  });
                                                                    con.SaveChanges();
                                                                    lbl_errors();
                                                                    MessageBox.Show("Added");
                                                                }
                                                                catch
                                                                {
                                                                    lbl_error_id.Text = "هذا الرقم موجود من قبل";

                                                                }

                                                                // to update
                                                                if (opreation == 2)
                                                                {
                                                                    lbl_errors();

                                                                    try
                                                                    {
                                                                        int id = int.Parse(text_id.Text);
                                                                        Semester_works sel = con.Semester_works.First(d => d.sw_id == id);
                                                                        sel.student_id = student_id;
                                                                        sel.level_id = level_id;
                                                                        sel.subject_id = subject_id;
                                                                        sel.test1 = test1;
                                                                        sel.test2 = test2;
                                                                        sel.final = final;
                                                                        sel.total = total;
                                                                        con.SaveChanges();
                                                                        MessageBox.Show("Done Update");
                                                                        lbl_errors();
                                                                        Show_datagrid();
                                                                    }
                                                                    catch
                                                                    {
                                                                        lbl_error_id.Text = "لا يوجد هذا الرقم";

                                                                    }
                                                                }

                                                                Show_datagrid();
                                                            }
                                                            else
                                                            {
                                                                lbl_error_final.Text = "    قيمة اكبر من المطلوب";
                                                                text_final.Focus();
                                                            }


                                                        }
                                                    }
                                                    catch
                                                    {
                                                        lbl_error_final.Text = "يجب ان يكون الادخال ارقام فقط";
                                                        text_final.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    lbl_error_final.Text = "يجب إدخال درجة الاختبار النهائي";
                                                    text_final.Focus();
                                                }
                                            }
                                            else
                                            {
                                                lbl_error_test2.Text = "    قيمة اكبر من المطلوب";
                                                text_test_2.Focus();
                                            }
                                        }
                                        catch
                                        {
                                            lbl_error_test2.Text = "يجب ان يكون الادخال ارقام فقط";
                                            text_test_2.Focus();
                                        }
                                    }
                                    else
                                    {
                                        lbl_error_test2.Text = "يجب إدخال درجة الاختبار الثاني";
                                        text_test_2.Focus();
                                    }
                                }
                                else
                                {
                                    lbl_error_test1.Text = "    قيمة اكبر من المطلوب";
                                    text_test_1.Focus();
                                }
                            }
                            catch
                            {
                                lbl_error_test1.Text = "يجب ان يكون الادخال ارقام فقط";
                                text_test_1.Focus();
                            }
                        }
                        else
                        {
                            lbl_error_test1.Text = "يجب إدخال درجة الاختبار الاول";
                            text_test_1.Focus();
                        }

                    }
                    else
                    {
                        lbl_error_Subject_name.Text = "يجب إخال اسم الماده";
                        text_subject_name.Focus();
                    }

                }
                else
                {
                    lbl_error_level.Text = "يجب إخال المستوى";
                    text_level_name.Focus();
                }

            }
            else
            {
                lbl_error_Student_id.Text = "يجب إخال رقم الطالب";
                text_student_id.Focus();
            }
        }

        //button to add data to database
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            add_update(1);
        }

        // button to update data from database
        private void btn_update_data_Click(object sender, EventArgs e)
        {
            add_update(2);
        }

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            lbl_errors();



            List<Semester_works> nem = con.Semester_works.ToList();

            if (text_search.Text.Trim() != "")
            {
                lbl_errors();

                int number;
                bool isnum = int.TryParse(text_search.Text, out number);
                if (isnum)
                {
                    // int sreach id
                    nem = nem.Where(d => d.sw_id.ToString().Contains(text_search.Text)).ToList();

                    show_datagridview.DataSource = nem.ToList();
                }
                else
                {
                    // string sreach name
                    nem = nem.Where(r => r.student_id.ToString().Contains(text_search.Text)).ToList();

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


        // to show all data from click row in datagrid on the fields form
        private void Show_in_form(int value)
        {

            // value == e_id 

             Semester_works sel = con.Semester_works.First(d => d.sw_id == value);
             text_id.Text = "    "+sel.sw_id;

            //---------
             text_student_id.Items.Clear();
            int id1 = int.Parse(sel.student_id + "");
            Student sel1 = con.Students.First(d => d.student_id == id1);

            text_student_id.Items.Add(sel1.student_name + "");
            text_student_id.Text = text_student_id.Items[0].ToString();

            //---------
            text_level_name.Items.Clear();
            int id2 = int.Parse(sel.level_id + "");
            Level sel2 = con.Levels.First(d => d.l_id == id2);

            text_level_name.Items.Add(sel2.l_name + "");
            text_level_name.Text = text_level_name.Items[0].ToString();


            //---------
            text_subject_name.Items.Clear();
            int id3 = int.Parse(sel.subject_id + "");
            Subject sel3 = con.Subjects.First(d => d.subject_id == id3);

            text_subject_name.Items.Add(sel3.subject_name + "");
            text_subject_name.Text = text_subject_name.Items[0].ToString();


            text_test_1.Value= Convert.ToDecimal(sel.test1);
            text_test_2.Value = Convert.ToDecimal(sel.test2);
            text_final.Value =Convert.ToDecimal(sel.final);
            text_total.Text ="    "+ sel.total;



            //---
            lbl_errors();
        }



        // when click row in  datagride
        private void show_datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            DataGridViewRow select = show_datagridview.Rows[rowindex];

            string value = select.Cells[10].Value.ToString();

            int index = int.Parse(value);

            // method to show in data form
            Show_in_form(index);
        }


        private void btn_reset_Click(object sender, EventArgs e)
        {
            // to set all labels null
            lbl_errors();
            // to get the top of number id table
            get_id_number();
            //to show all data in datagride 
            Show_datagrid();
            // to set items in combbox students name
            comb_items_stuents();
            // to set items in combbox levels name
            comb_items_levels();
            // to set items in combbox subjects name
            comb_items_subjects();

        }
    }
}
