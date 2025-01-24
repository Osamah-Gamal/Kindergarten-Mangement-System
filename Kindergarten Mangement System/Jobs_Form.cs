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
    public partial class Jobs_Form : Form
    {
        //-------------- Connection by SqlConection
        SqlConnection sqlcon = new SqlConnection("Data Source=OSAMAJAMAL\\OSAMAH;Initial Catalog=Kindergarten Mangement System;Integrated Security=True");
        SqlCommand cmd;

        //-------------- Connection by ADO.Net
        Kindergarten_Mangement_SystemEntities con = new Kindergarten_Mangement_SystemEntities();
        Store store1 = null;
        public Jobs_Form()
        {
            InitializeComponent();
        }


        // show data grit items
        private void Show_datagrid()
        {
            show_job_datagrid.DataSource = con.Jobs.ToList();
        }

        // get the top id in jobs
        private void get_id_jobs()
        {
            cmd = new SqlCommand("select Max(job_id) from Jobs", sqlcon);
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


        private void Jobs_Form_Load(object sender, EventArgs e)
        {
            // show items in datagrid
            Show_datagrid();

            // this function to get the last id in stores
            get_id_jobs();
        }


        // to set all lables null
        private void lbl_errors()
        {
            lbl_error_id.Text = "";
            lbl_error_name.Text = "";
            lbl_error_search.Text = "";
        }



        // to set all fields to null
        private void rest()
        {
            lbl_errors();
            get_id_jobs();
            text_name.Text = "";
            text_delete.Text = "";
        }



        // to add jobs 
        private void btn_enter_job_Click(object sender, EventArgs e)
        {
            // coding 
            lbl_errors();

            // text id 
            if (text_id.Text.Trim()!="")
            {
                lbl_errors();
                // text name

                if (text_name.Text.Trim()!="")
                {
                    lbl_errors();

                    if (text_name.Text.Length<=30)
                    {
                        //  

                        // Here to add data to table store

                        con.Jobs.Add(
                        new Job()
                        {
                                // primary key edintity 1,1
                                //store id = text_id.Text;



                                //employee name 
                                job_name = text_name.Text,

                        });
                        con.SaveChanges();
                        lbl_errors();
                        MessageBox.Show("Added");
                        Show_datagrid();
                        get_id_jobs();
                        rest();

                    }
                    else
                    {
                        lbl_error_name.Text = "طول النص اكبر من 30 حرف";
                        text_name.Focus();
                    }
                }
                else
                {
                    lbl_error_name.Text = "لا يزال الحقل فارغ";
                    text_name.Focus();
                }
            }
            else
            {
                lbl_error_id.Text="لا يزال الحقل فارغ";
            }


        }


        // to update jobs 
        private void btn_update_job_Click(object sender, EventArgs e)
        {
            // coding 
            lbl_errors();

            // text id 
            if (text_id.Text.Trim() != "")
            {
                lbl_errors();
                // text name

                if (text_name.Text.Trim() != "")
                {
                    lbl_errors();

                    if (text_name.Text.Length <= 30)
                    {
                        //  

                        // Here to add data to table jobs
                        int id = int.Parse(text_id.Text); 

                        //int.Parse(text_search.Text);
                        Job sel = con.Jobs.First(d => d.job_id == id);
                        sel.job_id = id;
                        sel.job_name = text_name.Text;

                        con.SaveChanges();
                        MessageBox.Show("Done Update");
                        lbl_errors();
                        Show_datagrid();
                        rest();

                    }
                    else
                    {
                        lbl_error_name.Text = "طول النص اكبر من 30 حرف";
                        text_name.Focus();
                    }
                }
                else
                {
                    lbl_error_name.Text = "لا يزال الحقل فارغ";
                    text_name.Focus();
                }
            }
            else
            {
                lbl_error_id.Text = "لا يزال الحقل فارغ";
            }
        }

        private void btn_delete_job_Click(object sender, EventArgs e)
        {
            if (text_delete.Text.Trim()!= "")
            {
                lbl_errors();

                lbl_error_delete.Text = "";


                try
                {
                    lbl_errors();
                    lbl_error_delete.Text = "";


                    int id = Convert.ToInt32(text_delete.Text);
                    Job del = con.Jobs.First(d => d.job_id == id);
                    con.Jobs.Remove(del);

                    // save after remove items 
                    con.SaveChanges();

                    // show data gride items 
                    Show_datagrid();

                    // get top id from table jobs
                    get_id_jobs();

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


        // this function us in data gride when click one row 
        private void Show_in_form(int value)
        {
            // value == e_id 

            Job sel = con.Jobs.First(d => d.job_id == value);
            // job id
            text_id.Text = "    "+sel.job_id;

            //job name 
            text_name.Text = sel.job_name;

            
        }

        // when click one row show its data in form
        private void show_job_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            DataGridViewRow select = show_job_datagrid.Rows[rowindex];

            string value = select.Cells[0].Value.ToString();

            int index = int.Parse(value);
            // method to show in data form
            Show_in_form(index);
        }


        // button rest to set all fields to null
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            rest();
        }


        // when search by  [ id or name ]
        private void btn_search_Click(object sender, EventArgs e)
        {

            List<Job> nem = con.Jobs.ToList();

            if (text_search.Text.Trim() != "")
            {
                lbl_errors();

                int number;
                bool isnum = int.TryParse(text_search.Text, out number);
                if (isnum)
                {
                    // int sreach id
                    nem = nem.Where(d => d.job_id.ToString().Contains(text_search.Text)).ToList();

                    show_job_datagrid.DataSource = nem.ToList();
                }
                else
                {
                    // string sreach name
                    nem = nem.Where(r => r.job_name.Contains(text_search.Text)).ToList();

                    show_job_datagrid.DataSource = nem.ToList();
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
