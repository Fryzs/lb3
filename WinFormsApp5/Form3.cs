using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Tag = -1;
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                button1.Tag = 1;
            }
            else

                MessageBox.Show("Wrong info");
        }
    }
}
