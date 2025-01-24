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
    public partial class Classes_Form : Form
    {
        //-------------- Connection by SqlConection
        SqlConnection sqlcon = new SqlConnection("Data Source=OSAMAJAMAL\\OSAMAH;Initial Catalog=Kindergarten Mangement System;Integrated Security=True");
        SqlCommand cmd;
        //-------------- Connection by ADO.Net
        Kindergarten_Mangement_SystemEntities con = new Kindergarten_Mangement_SystemEntities();
        Classes_schedule emp = null;
        public Classes_Form()
        {
            InitializeComponent();
        }


        // labels error 
        private void lbl_errors()
        {
            lbl_error_id.Text = "";
            lbl_error_name.Text = "";
            lbl_error_number.Text = "";

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

        // for show data in datagride
        private void Show_datagrid()
        {
            // Show all the data from table Subjects 
            show_datagride.DataSource = con.Classes_schedule.ToList();

        }


        // ---------
        // get top number from table Classes
        private void get_id_number()
        {
            cmd = new SqlCommand("select Max(c_id) from Classes_schedule", sqlcon);
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

        private void Classes_Form_Load(object sender, EventArgs e)
        {
            // get top number from table Classes
            get_id_number();

            // to show data in datagrid
            Show_datagrid();
        }


        // for show the row when selecte 
        private void Show_in_form(int value)
        {
            // value == e_id 

            Classes_schedule sel = con.Classes_schedule.First(d => d.c_id == value);
            // class id
            text_id.Text = "    " + sel.c_id;

            //class name 
            text_name.Text = sel.c_name;

            //class number 
            text_number.Text ="    "+ sel.c_number;


        }



        // for add or update --  add=1 |  update=2
        private void add_update(int operation)
        {
            // text name
            if (text_name.Text.Trim() != "")
            {

                if (text_name.Text.Length <= 30)
                {
                    // text level name
                    if (text_number.Text.Trim() != "")
                    {


                        // text employee name
                        if (text_number.Value > 0 )
                        {
                            // to add data  when operation==1
                            if (operation == 1)
                            {
                                lbl_errors();

                                try
                                {


                                    // Here to add data to table class..
                                    int id = Convert.ToInt32(text_id.Text);
                                    int num = Convert.ToInt32(text_number.Value);
                                    con.Classes_schedule.Add(
                                    new Classes_schedule()
                                    {
                                        //class id = text_id.Text;

                                        c_id = id,
                                        c_name = text_name.Text,
                                        c_number = num,

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
                                    int num = Convert.ToInt32(text_number.Value);
                                    int id = int.Parse(text_id.Text); //int.Parse(text_id.Text);
                                    Classes_schedule sel = con.Classes_schedule.First(d => d.c_id == id);
                                    sel.c_id = id;
                                    sel.c_name = text_name.Text;
                                    sel.c_number = num;
                                   
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
                            lbl_error_number.Text = "يجب ان يكون اكبر من 0";
                            text_number.Focus();
                        }

                    }
                    else
                    {
                        lbl_error_number.Text = "لايزال الحقل فارغ";
                        text_number.Focus();
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


        // for add data
        private void btn_add_gender_Click(object sender, EventArgs e)
        {
            add_update(1);
        }


        // for update data
        private void btn_update_gender_Click(object sender, EventArgs e)
        {
            add_update(2);
        }


        // for delete row of data from table
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
                    Classes_schedule del = con.Classes_schedule.First(d => d.c_id == id);
                    con.Classes_schedule.Remove(del);

                    // save after remove items 
                    con.SaveChanges();

                    // show data gride items 
                    Show_datagrid();

                    // get top id from table class_..
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


        // for rest all fields form to dafault 
        private void btn_reset_Click(object sender, EventArgs e)
        {
            // fun rest to set form to default 
            rest();

            
            text_name.Text = "";
            text_search.Text = "";
            text_number.Value = 0;
            text_delete.Text = "";
            text_search.Text = "";
        }


        //button for search
        private void btn_search_Click(object sender, EventArgs e)
        {

            List<Classes_schedule> nem = con.Classes_schedule.ToList();

            if (text_search.Text.Trim() != "")
            {
                lbl_errors();

                int number;
                bool isnum = int.TryParse(text_search.Text, out number);
                if (isnum)
                {
                    // int sreach id
                    nem = nem.Where(d => d.c_id.ToString().Contains(text_search.Text)).ToList();

                    show_datagride.DataSource = nem.ToList();
                }
                else
                {
                    // string sreach name
                    nem = nem.Where(r => r.c_name.Contains(text_search.Text)).ToList();

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

        // for show data in fields form when selected on datagrid
        private void show_datagride_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowindex = e.RowIndex;
            DataGridViewRow select = show_datagride.Rows[rowindex];

            string value = select.Cells[0].Value.ToString();

            int index = int.Parse(value);
            // method to show in data form
            Show_in_form(index);
        }
    }
}
