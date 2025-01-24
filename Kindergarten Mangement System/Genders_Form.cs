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
    public partial class Genders_Form : Form
    {

        SqlConnection sqlcon = new SqlConnection("Data Source=OSAMAJAMAL\\OSAMAH;Initial Catalog=Kindergarten Mangement System;Integrated Security=True");
        SqlCommand cmd;

        //-------------- Connection by ADO.Net
        Kindergarten_Mangement_SystemEntities con = new Kindergarten_Mangement_SystemEntities();
        Gender emp = null;
        public Genders_Form()
        {
            InitializeComponent();
        }
        //----------

        private void Show_datagrid()
        {
            // Show all the data from table Employees 
            show_datagride.DataSource = con.Genders.ToList();

        }



        //----------
        private void add_update(int operation)
        {
            if (operation == 1)
            {
                

                con.Genders.Add(
                        new Gender()
                        {

                            g_name = text_name.Text,
                         
                        });
                con.SaveChanges();
                MessageBox.Show("Added");
                Show_datagrid();
            }


            if (operation == 2)
            {
                int number;
                bool check = int.TryParse(text_id.Text, out number);
                if (check)
                {
                    number = int.Parse(text_id.Text);

                }
                else
                {

                    text_id.Focus();

                }

                try
                {

                    int id = int.Parse(text_id.Text); //int.Parse(text_search.Text);
                    Gender sel = con.Genders.First(d => d.g_id == id);
                    sel.g_id = id;
                    sel.g_name = text_name.Text;
                    con.SaveChanges();
                    MessageBox.Show("Done Update");
                    Show_datagrid();
                }
                catch
                {

                }
            }
        }


        private void Genders_Form_Load(object sender, EventArgs e)
        {
            get_id_number();
            Show_datagrid();
        }

        private void btn_add_gender_Click(object sender, EventArgs e)
        {
            add_update(1);
        }
        private void get_id_number()
        {
            cmd = new SqlCommand("select Max(g_id) from Genders", sqlcon);
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
        private void btn_reset_Click(object sender, EventArgs e)
        {
            get_id_number();

            text_name.Text = "";
        
        }

        private void btn_update_gender_Click(object sender, EventArgs e)
        {
            add_update(2);

        }
        private void Show_in_form(int value)
        {

            // value == l_id 

            Gender sel = con.Genders.First(d => d.g_id == value);
            // employee id
            text_id.Text = "   " + sel.g_id;
            text_name.Text = sel.g_name + "";


        }
        private void show_datagride_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            DataGridViewRow select = show_datagride.Rows[rowindex];

            string value = select.Cells[0].Value.ToString();

            int index = int.Parse(value);

            // method to show in data form
            Show_in_form(index);
        }

        private void btn_delete_delete_Click(object sender, EventArgs e)
        {
            if (text_search.Text.Trim() != "")
            {

                lbl_error_delete.Text = "";


                try
                {
                    lbl_error_delete.Text = "";


                    int id = Convert.ToInt32(text_search.Text);
                    Gender del = con.Genders.First(d => d.g_id == id);
                    con.Genders.Remove(del);
                    con.SaveChanges();
                    Show_datagrid();

                    // get top id from table empolyees
                    get_id_number();

                    //------------------------------
                    MessageBox.Show("Done Delete");

                }
                catch
                {
                    lbl_error_delete.Text = "غير متوفر هذا الكود";
                    text_search.Focus();
                }
            }
            else
            {
                lbl_error_delete.Text = "! لايزال الحقل فارغ";
                text_search.Focus();

            }
        }
    }
}
