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
    public partial class Viwe_students : Form
    {
        //-------------- Connection by SqlConection
        SqlConnection sqlcon = new SqlConnection("Data Source=OSAMAJAMAL\\OSAMAH;Initial Catalog=Kindergarten Mangement System;Integrated Security=True");
        SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataSet dataset;
        public Viwe_students()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
