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



namespace Kindergarten_Mangement_System
{
    public partial class Buses_Form : Form
    {
        //-------------- Connection by SqlConection
        SqlConnection sqlcon = new SqlConnection("Data Source=OSAMAJAMAL\\OSAMAH;Initial Catalog=Kindergarten Mangement System;Integrated Security=True");
        SqlCommand cmd;

        //-------------- Connection by ADO.Net
        Kindergarten_Mangement_SystemEntities con = new Kindergarten_Mangement_SystemEntities();
        Bus bus = null;
        public Buses_Form()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            lbl_errors();



            List<Bus> nem = con.Buses.ToList();

            if (text_search.Text.Trim() != "")
            {
                lbl_errors();

                int number;
                bool isnum = int.TryParse(text_search.Text, out number);
                if (isnum)
                {
                    // int sreach id
                    nem = nem.Where(d => d.b_id.ToString().Contains(text_search.Text)).ToList();

                    show_datagride.DataSource = nem.ToList();
                }
                else
                {
                    // string sreach name
                    nem = nem.Where(r => r.employee_id.ToString().Contains(text_search.Text)).ToList();

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

        // this function to set all labels error to null
        private void lbl_errors()
        {
            lbl_error_id.Text = "";
            lbl_error_employee.Text = "";
            lbl_error_pate_number.Text = "";
            lbl_error_pic.Text = "";
            lbl_error_search.Text = "";
            lbl_error_typ_bus.Text = "";
        }



        // this function to add or update data add=1 update=2
        private void add_update(int operation)
        {

            //  text type bus
            if (text_typ_bus.Text.Trim()!="")
            {
                lbl_errors();

                if (text_typ_bus.Text.Length<=20)
                {
                    lbl_errors();


                    //  text plat number
                    string str = text_plat_numberus + "";

                    if (str.Trim()!="")
                    {
                        lbl_errors();
                        
                        if (str.Trim().Length>=4 && str.Trim().Length <=6)
                        {

                            // button image paper ownership
                            if (pic_paper_ownership.Image != null)
                            {




                            }
                            else
                            {
                                btn_enter_image.Text = " يجب اختيار الصورة";
                                btn_enter_image.BorderColor = Color.Red;
                                pic_paper_ownership.Focus();
                            }



                        }
                        else
                        {
                            lbl_error_pate_number.Text = "يجب ادخال رقم اللوحه من 4 الى 6 ارقام";
                            text_plat_numberus.Focus();
                        }
                    }
                    else
                    {
                        lbl_error_pate_number.Text = "الحقل لايزال فارغ";
                        text_plat_numberus.Focus();
                    }


                }
                else
                {
                    lbl_error_typ_bus.Text = "حجم النص اكبر من 20 حرف";
                    text_typ_bus.Focus();
                }

            }
            else
            {
                lbl_error_typ_bus.Text = "الحقل لايزال فارغ";
                text_typ_bus.Focus();
            }


        }


        // this button to add bus
        private void btn_add_bus_Click(object sender, EventArgs e)
        {
            add_update(1);
        }


        //this button to update bus
        private void btn_update_bus_Click(object sender, EventArgs e)
        {
            add_update(2);
        }

        private void btn_enter_image_Click(object sender, EventArgs e)
        {
            lbl_errors();

            OpenFileDialog per_image = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg";
            openFileDialog1.Title = "الصورة الشخصية";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_error_pic.Text = "       تم الاختيار";
                lbl_error_pic.ForeColor = Color.LimeGreen;
                btn_enter_image.BorderColor = Color.PaleGreen;


                pic_paper_ownership.Image = new Bitmap(openFileDialog1.FileName);



            }
            else
            {
                lbl_error_pic.Text = "  يجب اختيار الصورة";
                btn_enter_image.BorderColor = Color.Red;
                btn_enter_image.Focus();
            }
        }


        // this function to set items to combbox text_employees
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
                text_employees.Items.Clear();

                while (read.Read())
                {
                    text_employees.Items.Add(read["e_name"].ToString());
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

        // when select on item from combbox
        private void text_employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexs = text_employees.SelectedIndex;
            comb_items(indexs);
        }


        // this function to show all information on fields form
        private void Show_in_form(int value)
        {
            // value == e_id 

            Bus sel = con.Buses.First(d => d.b_id == value);
            // bus id
            text_id.Text = sel.b_id + "";

            //text bus type
            text_typ_bus.Text = sel.b_type;

            //
            text_employees.Items.Clear();
            int id = int.Parse(sel.employee_id + "");
            Employee sel1 = con.Employees.First(d => d.e_id == id);

            text_employees.Items.Add(sel1.e_name + "");
            text_employees.Text = text_employees.Items[0].ToString();



        }

        // when select row from datagride 
        private void show_datagride_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int rowindex = e.RowIndex;
            DataGridViewRow select = show_datagride.Rows[rowindex];

            string value = select.Cells[10].Value.ToString();

            int index = int.Parse(value);

            // method to show in data form
            Show_in_form(index);
        }


        // function to set all fields null
        private void rest()
        {
            lbl_errors();
            text_typ_bus.Text = "";
            text_plat_numberus.Value = 0000;
            pic_paper_ownership.Image = null;

            // to show all data in datagride
            Show_datagrid();
            // toget the top number id from table
            get_id_number();
            // to set items in combbox text employee
            comb_items();
        }

        // to set all fields null
        private void btn_reset_Click(object sender, EventArgs e)
        {
            
            rest();

        }


        // get top id from table buses
        private void get_id_number()
        {
            cmd = new SqlCommand("select Max(b_id) from Buses", sqlcon);
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
                text_id.Text = "      " + 1;
            }
            sqlcon.Close();
        }



        // show data from show_data_grid
        private void Show_datagrid()
        {
            // Show all the data from table Employees 
            show_datagride.DataSource = con.Buses.ToList();

        }


        // form load
        private void Buses_Form_Load(object sender, EventArgs e)
        {
            // get top id from table empolyees
            get_id_number();

            // show all data in datagride 
            Show_datagrid();

            // to set items from table to combbox text employee
            comb_items();
        }


        // button to remove row of data from table buses 
        private void btn_delete_bus_Click(object sender, EventArgs e)
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
                     Bus del = con.Buses.First(d => d.b_id == id);
                    con.Buses.Remove(del);

                    // to save after delete 
                    con.SaveChanges();

                    // to show all data in datagride 
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
    }
}
