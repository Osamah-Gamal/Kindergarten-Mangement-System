using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarten_Mangement_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Stores_Form stor = new Stores_Form();
            stor.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Buses_Form bus = new Buses_Form();
            bus.ShowDialog();
        }
    }
}
