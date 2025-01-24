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
    public partial class Signup_Form : Form
    {
        //-------------- Connection by SqlConection
        SqlConnection sqlcon = new SqlConnection("Data Source=OSAMAJAMAL\\OSAMAH;Initial Catalog=Kindergarten Mangement System;Integrated Security=True");
        SqlCommand cmd;


        //-------------- Connection by ADO.Net
        Kindergarten_Mangement_SystemEntities con = new Kindergarten_Mangement_SystemEntities();
        Level emp = null;
        public Signup_Form()
        {
            InitializeComponent();
        }

        // to set all labls error null
        private void lbl_errors()
        {
            lbl_error_id.Text = "";
            lbl_error_pass1.Text = "";
            lbl_error_pass2.Text = "";
            lbl_error_rpeat_pass.Text = "";
            lbl_error_type.Text = "";
        }


        //  button ok
        private void btn_ok_Click(object sender, EventArgs e)
        {
            //--------------
            if (text_id.Text.Trim()!="")
            {
                lbl_errors();

                int num;
                bool check = int.TryParse(text_id.Text,out num);
                if (check)
                {
                    lbl_errors();


                    // for check this use is employee or no
                     cmd = new SqlCommand("select count(*) from Employees where e_id='" + num+ "'", sqlcon);
                     sqlcon.Open();
                     int count = (int)cmd.ExecuteScalar();
                     sqlcon.Close();
                        
                   

                    

                    //-------false count==0
                    if (count!=1)
                    {
                        lbl_error_id.Text = "لايوجد موظف بهذا الرقم";
                        text_id.Focus();
                        return;
                    }

                    // for check this use is employee or no
                    cmd = new SqlCommand("select count(*) from Passwords where e_id='" + num + "'", sqlcon);
                    sqlcon.Open();
                    int count1 = (int)cmd.ExecuteScalar();
                    sqlcon.Close();


                    if (count1!=1)
                    {
                        lbl_error_id.Text = "لديك حساب من قبل";
                        text_id.Focus();
                        return;
                    }


                    lbl_errors();

                    //------true the count==1




                    //--------------
                    if (text_pass1.Text.Trim()!="")
                    {
                        lbl_errors();
                        if (text_pass1.Text.Length <=20)
                        {
                            lbl_errors();

                            //------------
                            if (text_pass2.Text.Trim() != "")
                            {
                                lbl_errors();
                                if (text_pass2.Text.Length <= 20)
                                {
                                    lbl_errors();
                                    //-------
                                    if (text_pass1.Text==text_pass2.Text)
                                    {
                                        lbl_errors();

                                        //---------------
                                        if (text_type.Text.Trim()!="")
                                        {
                                            lbl_errors();
                                            //-------
                                            if (text_q_pass.Text.Trim() != "")
                                            {
                                                lbl_errors();
                                                if (text_q_pass.Text.Length<=30)
                                                {
                                                    lbl_errors();

                                                    con.Passwords.Add(
                                                       new Password()
                                                       {

                                                           e_id = num,
                                                           pass = text_pass1.Text,
                                                           forget = text_q_pass.Text,


                                                       });
                                                    con.SaveChanges();
                                                    MessageBox.Show("Done create new account");

                                                    this.Hide();
                                                    Login_Form log = new Login_Form();
                                                    log.ShowDialog();


                                                }
                                                else
                                                {
                                                    lbl_error_rpeat_pass.Text = "حجم كلمة المرور اكبر من 30 حرف";
                                                    text_q_pass.Focus();
                                                }


                                            }
                                            else
                                            {
                                                lbl_error_rpeat_pass.Text = "لايزال الحقل فارغ";
                                                text_q_pass.Focus();
                                            }

                                        }
                                        else
                                        {
                                            lbl_error_type.Text = "لايزال الحقل فارغ";
                                            text_type.Focus();
                                        }

                                    }
                                    else
                                    {
                                        lbl_error_pass2.Text = "كلمة المرور لا تتطابق";
                                        text_pass2.Focus();
                                    }

                                }
                                else
                                {
                                    lbl_error_pass2.Text = "حجم كلمة المرور اكبر من 20 حرف";
                                    text_pass2.Focus();
                                }

                            }
                            else
                            {
                                lbl_error_pass2.Text = "لايزال الحقل فارغ";
                                text_pass2.Focus();
                            }

                        }
                        else
                        {
                            lbl_error_pass1.Text = "حجم كلمة المرور اكبر من 20 حرف";
                            text_pass1.Focus();
                        }

                    }
                    else
                    {
                        lbl_error_pass1.Text = "لايزال الحقل فارغ";
                        text_pass1.Focus();
                    }


                }
                else
                {
                    lbl_error_id.Text = "ادخل ارقام فقط";
                    text_id.Focus();
                }
            }
            else
            {
                lbl_error_id.Text = "لايزال الحقل فارغ";
                text_id.Focus();
            }
        }
    }
}
