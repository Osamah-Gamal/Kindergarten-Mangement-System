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


namespace Kindergarten_Mangement_System
{
    public partial class Subjects_Form : Form
    {
        //-------------- Connection by SqlConection
        SqlConnection sqlcon = new SqlConnection("Data Source=OSAMAJAMAL\\OSAMAH;Initial Catalog=Kindergarten Mangement System;Integrated Security=True");
        SqlCommand cmd;

        //-------------- Connection by ADO.Net
        Kindergarten_Mangement_SystemEntities con = new Kindergarten_Mangement_SystemEntities();
        Subject emp = null;
        public Subjects_Form()
        {
            InitializeComponent();
        }


        // labels error 
        private void lbl_errors()
        {
            lbl_error_id.Text = "";
            lbl_error_name.Text = "";
            lbl_error_level.Text = "";
            lbl_error_employee.Text = "";

            lbl_error_delete.Text = "";

            lbl_error_search.Text = "";

           

        }


        // fun rest to set form to default
        private void rest()
        {
            // fun lbl errors to set all labels null
            lbl_errors();

            // to get the last id 
            get_id_number();

            // to show table subject in datagride
            Show_datagrid();

            
        }

        // to show data in datagride
        private void Show_datagrid()
        {
            // Show all the data from table Subjects 
            show_datagride.DataSource = con.Subjects.ToList();

        }


        // ---------
        // get top number from table Subjects
        private void get_id_number()
        {
            cmd = new SqlCommand("select Max(subject_id) from Subjects", sqlcon);
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
                    text_id.Text = "    " + 1;
                }
            }
            else
            {
                text_id.Text = "     " + 1;
            }
            sqlcon.Close();
        }


        // fun to set items to comb box levels name
        private void comb_items_level(int num = -1)
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
                text_levels_name.Items.Clear();

                while (read.Read())
                {
                    text_levels_name.Items.Add(read["l_name"].ToString());
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
                        lbl_level.Text = numbers[num];
                    }
                }
            }
        }




        // fun to set items to comb box levels name
        private void comb_items_employees(int num = -1)
        {
            int count = 0;
            if (num != -1)
            {
                cmd = new SqlCommand("select e_name from Employees", sqlcon);
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
                cmd = new SqlCommand("select e_name from Employees", sqlcon);
                sqlcon.Open();
                SqlDataReader read = cmd.ExecuteReader();
                text_employees_name.Items.Clear();

                while (read.Read())
                {
                    text_employees_name.Items.Add(read["e_name"].ToString());
                    count++;
                }
                sqlcon.Close();
                read.Close();
            }




            cmd = new SqlCommand("select e_id from Employees", sqlcon);
            sqlcon.Open();
            SqlDataReader read_id = cmd.ExecuteReader();

            string[] numbers = new string[count];
            int x = 0;
            while (read_id.Read())
            {
                numbers[x] = read_id["e_id"].ToString();
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
                        lbl_employee.Text = numbers[num];
                    }
                }
            }
        }


        // form load
        private void Subjects_Form_Load(object sender, EventArgs e)
        {
            // get top number from table empolyees
            get_id_number();

            // to show data in datagrid
            Show_datagrid();

            //fun to set items from table level
            comb_items_level();

            //fun to set items from table employees
            comb_items_employees();

        }


        // to show the row when selecte 
        private void Show_in_form(int value)
        {
            // value == e_id 

            Subject sel = con.Subjects.First(d => d.subject_id == value);
            // subject id
            text_id.Text = "    " + sel.subject_id;

            //subject name 
            text_name.Text = sel.subject_name;

            //Level id 
            int id = int.Parse(sel.l_id + "");
            Level sel1 = con.Levels.First(d => d.l_id == id);
            lbl_level.Text = sel.l_id.ToString();
            text_levels_name.Items.Clear();
            text_levels_name.Items.Add(sel1.l_name + "");
            text_levels_name.Text = text_levels_name.Items[0].ToString();

            //employee id 
            int id1 = int.Parse(sel.employee_id + "");
            Employee sel2 = con.Employees.First(d => d.e_id == id1);
            lbl_employee.Text = sel.employee_id.ToString();
            text_employees_name.Items.Clear();
            text_employees_name.Items.Add(sel2.e_name + "");
            text_employees_name.Text = text_employees_name.Items[0].ToString();

        }

        //   when select row in datagrid this is show in fields form
        private void show_datagride_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            DataGridViewRow select = show_datagride.Rows[rowindex];

            string value = select.Cells[0].Value.ToString();

            int index = int.Parse(value);
            // method to show in data form
            Show_in_form(index);
        }


        // to add or update --  add=1 |  update=2
        private void add_update(int operation)
        {
            // text name
            if (text_name.Text.Trim() != "")
            {

                if (text_name.Text.Length <= 30)
                {
                    // text level name
                    if (text_levels_name.Text.Trim() != "")
                    {


                        // text employee name
                        if (text_employees_name.Text.Trim() != "")
                        {
                            // to add data  when operation==1
                            if (operation == 1)
                            {
                                lbl_errors();

                                try {
                                 
                                    int id1 = int.Parse(lbl_level.Text);
                                    int id2 = int.Parse(lbl_employee.Text);
                                    // Here to add data to table store

                                    con.Subjects.Add(
                                    new Subject()
                                    {
                                        // primary key edintity 1,1
                                        //store id = text_id.Text;



                                        //employee name 
                                        subject_id = int.Parse(text_id.Text),
                                        subject_name = text_name.Text,
                                        l_id = id1,
                                        employee_id = id2,

                                    });
                                    con.SaveChanges();
                                    lbl_errors();
                                    MessageBox.Show("Added");
                                    Show_datagrid();
                                    rest();
                                }
                                catch
                                {
                                    lbl_error_id.Text = "موجود من قبل";
                                }
                                
                            }


                            // to update data when operation==2
                            if (operation == 2)
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

                                    int id = int.Parse(text_id.Text); //int.Parse(text_search.Text);
                                    Subject sel = con.Subjects.First(d => d.subject_id == id);
                                    sel.subject_id = id;
                                    sel.subject_name = text_name.Text;
                                    sel.l_id = int.Parse(lbl_level.Text); 
                                    sel.employee_id = int.Parse(lbl_employee.Text);
                                    con.SaveChanges();
                                    MessageBox.Show("Done Update");
                                    lbl_errors();
                                    Show_datagrid();
                                    rest();
                                   

                                }
                                catch
                                {
                                    lbl_error_id.Text = "لا يوجد هذا الكود يجب جلب البيانات من الجدول";

                                }
                            }

                        }
                        else
                        {
                            lbl_error_employee.Text = "لايزال الحقل فارغ";
                            text_employees_name.Focus();
                        }

                    }
                    else
                    {
                        lbl_error_level.Text = "لايزال الحقل فارغ";
                        text_levels_name.Focus();
                    }


                }
                else
                {
                    lbl_error_name.Text = "حجم النص يزيد عن 30 حرف";
                    text_name.Focus();
                }

            }
            else
            {
                lbl_error_name.Text = "لايزال الحقل فارغ";
                text_name.Focus();
            }
        }



        // button add
        private void btn_add_gender_Click(object sender, EventArgs e)
        {
            lbl_errors();

            add_update(1);
        }

        private void btn_delete_delete_Click(object sender, EventArgs e)
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
                    Subject del = con.Subjects.First(d => d.subject_id == id);
                    con.Subjects.Remove(del);

                    // save after remove items 
                    con.SaveChanges();

                    // show data gride items 
                    Show_datagrid();

                    // get top id from table store
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            // fun rest to set form to default 
            rest();

            text_name.Text = "";
            text_search.Text = "";
            text_delete.Text = "";
            comb_items_level();
            comb_items_employees();
        }

        private void btn_update_gender_Click(object sender, EventArgs e)
        {
            lbl_errors();

            add_update(2);
        }



        // comb box levels name
        private void text_levels_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexs = text_levels_name.SelectedIndex;
            comb_items_level(indexs);
        }

        // comb box employees name
        private void text_employees_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexs = text_employees_name.SelectedIndex;
            comb_items_employees(indexs);
        }


        // buton search by -->[ id || name ]
        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Subject> nem = con.Subjects.ToList();

            if (text_search.Text.Trim() != "")
            {
                lbl_errors();

                int number;
                bool isnum = int.TryParse(text_search.Text, out number);
                if (isnum)
                {
                    // int sreach id
                    nem = nem.Where(d => d.subject_id.ToString().Contains(text_search.Text)).ToList();

                    show_datagride.DataSource = nem.ToList();
                }
                else
                {
                    // string sreach name
                    nem = nem.Where(r => r.subject_name.Contains(text_search.Text)).ToList();

                    show_datagride.DataSource = nem.ToList();
                }

            }
            else
            {
                lbl_errors();
                lbl_error_search.Text = "    ! الحقل لايزال فارغ";
                text_search.Focus();
            }
        }
    }
}
