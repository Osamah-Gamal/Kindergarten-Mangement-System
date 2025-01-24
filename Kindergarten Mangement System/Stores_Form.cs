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
    public partial class Stores_Form : Form
    { 
        //-------------- Connection by SqlConection
        SqlConnection sqlcon = new SqlConnection("Data Source=OSAMAJAMAL\\OSAMAH;Initial Catalog=Kindergarten Mangement System;Integrated Security=True");
        SqlCommand cmd;

        //-------------- Connection by ADO.Net
        Kindergarten_Mangement_SystemEntities con = new Kindergarten_Mangement_SystemEntities();
        Store store1 = null;
        
        public Stores_Form()
        {
            InitializeComponent();
        }


        //      datagrid لعرض البيانات في  
        private void Show_datagrid()
        {
            store_gridview.DataSource = con.Stores.ToList();
        }

        //this function to get the last id in stores
        private void get_id_store()
        {
            
                cmd = new SqlCommand("select Max(store_id) from Stores", sqlcon);
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
                    text_id.Text = " " + 10;
                }
                sqlcon.Close();
         
        }

        private void Stores_Form_Load(object sender, EventArgs e)
        {
            // function to show data in datagride
            Show_datagrid();

            // this function to get the last id in stores
            get_id_store();

            // to add employees to combbox id empolyees
                comb_items();
        }


    // this function to set null to all lable errors
        private void lbl_errors()
        {
            lbl_error_store_id.Text = "";
            lbl_error_name_store.Text = "";
            lbl_error_employee.Text = "";

            lbl_error_store_id.Text = "";
            lbl_error_search.Text = "";
        }


        //
        private void comb_items(int num = -1)
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
                text_employee_id.Items.Clear();

                while (read.Read())
                {
                    text_employee_id.Items.Add(read["e_name"].ToString());
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

        private void btn_enter_store_Click(object sender, EventArgs e)
        {
            lbl_errors();
            if (text_name.Text.Trim()!="")
            {
                lbl_errors();
                if (text_name.Text.Trim().Length> 3)
                {
                    lbl_errors();
                    if (text_name.Text.Length<=30)
                    {



                        if (text_employee_id.Text.Trim() != "")
                        {
                            int id = int.Parse(lbl_employee.Text);


                            // Here to add data to table store

                            con.Stores.Add(
                            new Store()
                            {
                                // primary key edintity 1,1
                                //store id = text_id.Text;



                                //employee name 
                                store_name = text_name.Text,
                                employee_id = id,

                            });
                            con.SaveChanges();
                            lbl_errors();
                            MessageBox.Show("Added");
                            Show_datagrid();
                            get_id_store();
                            rest();
                            lbl_employee.Text = "";

                        }
                        else
                        {
                            lbl_error_name_store.Text = "طول النص اكبر من 30 حرف";
                            text_name.Focus();
                        }

                    }
                    else
                    {
                        lbl_error_employee.Text = "الحقل لايزال فارغ";
                        text_employee_id.Focus();
                    }

                }
                else
                {
                    lbl_error_name_store.Text = "طول النص قصير";
                    text_name.Focus();
                }


            }
            else
            {
                lbl_error_name_store.Text = "الحقل لايزال فارغ";
                text_id.Focus();
            }
        }

        // to show the row when selecte 
        private void Show_in_form(int value)
        {
            // value == e_id 

            Store sel = con.Stores.First(d => d.store_id == value);
            // store id
            text_id.Text ="    "+ sel.store_id ;
            
            //store name 
            text_name.Text = sel.store_name;

            //employee id 
            int id = int.Parse(sel.employee_id + "");
            Employee sel1 = con.Employees.First(d => d.e_id == id);
            lbl_employee.Text = sel.employee_id.ToString();
            text_employee_id.Items.Clear();
            text_employee_id.Items.Add(sel1.e_name + "");
            text_employee_id.Text = text_employee_id.Items[0].ToString();
            
        }
        private void store_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            DataGridViewRow select = store_gridview.Rows[rowindex];

            string value = select.Cells[0].Value.ToString();

            int index = int.Parse(value);
            // method to show in data form
            Show_in_form(index);
        }

        private void text_employee_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexs = text_employee_id.SelectedIndex;
            comb_items(indexs);
        }


        // function to rest the all fields 
        private void rest()
        {
            lbl_errors();

            // text id 
            // function --> get top id from table empolyees
            get_id_store();
            //from text box job's number to employee
            text_employee_id.Items.Clear();
            comb_items();

            text_name.Text = "";
        }
        //button to rest all fields to null
        private void btn_reset_Click(object sender, EventArgs e)
        {

            rest();
        }

        private void btn_delete_store_Click(object sender, EventArgs e)
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
                    Store del = con.Stores.First(d => d.store_id == id);
                    con.Stores.Remove(del);

                    // save after remove items 
                    con.SaveChanges();

                    // show data gride items 
                    Show_datagrid();

                    // get top id from table store
                    get_id_store();

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


        // this button to update data store
        private void btn_update_store_Click(object sender, EventArgs e)
        {

            lbl_errors();



            if (text_id.Text.Trim() == "")
            {
                lbl_error_store_id.Text = "يجب جلب رقم الكود";
                return;
            }
            lbl_error_store_id.Text = "";
            try
            {

                int id = int.Parse(text_id.Text); //int.Parse(text_search.Text);
                Store sel = con.Stores.First(d => d.store_id == id);
                sel.store_id = id;
                sel.store_name = text_name.Text;
                sel.employee_id = int.Parse(lbl_employee.Text);
                con.SaveChanges();
                MessageBox.Show("Done Update");
                lbl_errors();
                Show_datagrid();

                lbl_employee.Text = "";

            }
            catch
            {
                lbl_error_store_id.Text = "لا يوجد هذا الكود يجب جلب البيانات من الجدول";

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Store> nem = con.Stores.ToList();

            if (text_search.Text.Trim() != "")
            {
                lbl_errors();

                int number;
                bool isnum = int.TryParse(text_search.Text, out number);
                if (isnum)
                {
                    // int sreach id
                    nem = nem.Where(d => d.store_id.ToString().Contains(text_search.Text)).ToList();

                    store_gridview.DataSource = nem.ToList();
                }
                else
                {
                    // string sreach name
                    nem = nem.Where(r => r.store_name.Contains(text_search.Text)).ToList();

                    store_gridview.DataSource = nem.ToList();
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
