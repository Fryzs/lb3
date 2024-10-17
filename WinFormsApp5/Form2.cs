using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExampleText.ForeColor = ((Button)sender).ForeColor;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ExampleText.Font = new Font(ExampleText.Font.FontFamily, trackBar1.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(button4.Tag) == 1)
            {
                button4.Tag = 0;
                button4.Text = "Off";
                ExampleText.Visible = false;
            }
            else
            {
                button4.Tag = 1;
                button4.Text = "On";
                ExampleText.Visible = true;
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            {
                ExampleText.Font = new Font(((Label)sender).Font.FontFamily, ExampleText.Font.Size, ((Label)sender).Font.Style);
            }

        }
    }
}
