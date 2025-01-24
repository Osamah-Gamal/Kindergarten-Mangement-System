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
    public partial class Levels_Form : Form
    { 
        //-------------- Connection by SqlConection
        SqlConnection sqlcon = new SqlConnection("Data Source=OSAMAJAMAL\\OSAMAH;Initial Catalog=Kindergarten Mangement System;Integrated Security=True");
        SqlCommand cmd;

        //-------------- Connection by ADO.Net
        Kindergarten_Mangement_SystemEntities con = new Kindergarten_Mangement_SystemEntities();
        Level emp = null;
        public Levels_Form()
        {
            InitializeComponent();
        }


        private void add_update(int operation)
        {
            if (operation==1)
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

                con.Levels.Add(
                        new Level()
                        {

                            l_name = text_name.Text,
                            l_number = 1,


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
                    Level sel = con.Levels.First(d => d.l_id == id);
                    sel.l_id = id;
                    sel.l_name = text_name.Text;
                    con.SaveChanges();
                    MessageBox.Show("Done Update");
                    Show_datagrid();
                }
                catch
                {

                }
            }

        }
        private void btn_add_level_Click(object sender, EventArgs e)
        {
            add_update(1);
        }


        //   --
        private void Show_datagrid()
        {
            // Show all the data from table Employees 
            show_datagride.DataSource = con.Levels.ToList();

        }


        // ---------
        // get top number from table empolyees
        private void get_id_number()
        {
            cmd = new SqlCommand("select Max(l_id) from Levels", sqlcon);
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



        private void Levels_Form_Load(object sender, EventArgs e)
        {
            // show data from database on datagride
            Show_datagrid();

            

            // get top id from table empolyees
            get_id_number();
        }

        private void btn_update_level_Click(object sender, EventArgs e)
        {
            add_update(2);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            List<Level> nem = con.Levels.ToList();

            if (text_search.Text.Trim() != "")
            {

                int number;
                bool isnum = int.TryParse(text_search.Text, out number);
                if (isnum)
                {
                    // int sreach id
                    nem = nem.Where(d => d.l_id.ToString().Contains(text_search.Text)).ToList();

                    show_datagride.DataSource = nem.ToList();
                }
                else
                {
                    // string sreach name
                    nem = nem.Where(r => r.l_name.Contains(text_search.Text)).ToList();

                    show_datagride.DataSource = nem.ToList();
                }

            }
            else
            {
                lbl_error_delete.Text = "    ! الحقل لايزال فارغ";
                text_search.Focus();
            }
        }

        private void btn_delete_level_Click(object sender, EventArgs e)
        {


            if (text_search.Text.Trim() != "")
            {

                lbl_error_delete.Text = "";


                try
                {
                    lbl_error_delete.Text = "";


                    int id = Convert.ToInt32(text_search.Text);
                    Level del = con.Levels.First(d => d.l_id == id);
                    con.Levels.Remove(del);
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


        // to show all data from click row in datagrid on the fields form
        private void Show_in_form(int value)
        {

            // value == l_id 

            Level sel = con.Levels.First(d => d.l_id == value);
            // employee id
            text_id.Text ="   "+ sel.l_id ;
            text_name.Text = sel.l_name + "";           
  
            
        }




        //-------
        private void show_datagride_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int rowindex = e.RowIndex;
            DataGridViewRow select = show_datagride.Rows[rowindex];

            string value = select.Cells[0].Value.ToString();

            int index = int.Parse(value);

            // method to show in data form
            Show_in_form(index);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            get_id_number();
            
            text_name.Text = "";
            lbl_error_delete.Text = "";
            text_search.Text = "";
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
