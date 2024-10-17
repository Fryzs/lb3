using Microsoft.VisualBasic.Logging;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ExampleText.ForeColor = Example.ForeColor;
            form.ExampleText.Font = new System.Drawing.Font(Example.Font.FontFamily, Example.Size.Height, Example.Font.Style);
            form.ShowDialog();
           
            if (form.DialogResult == DialogResult.OK)
            {
                Example.Font = new System.Drawing.Font(Example.Font.FontFamily, form.ExampleText.Size.Height, form.ExampleText.Font.Style);
                Example.ForeColor = form.ExampleText.ForeColor;
            }
            if (Convert.ToInt32(form.button4.Tag) != 1)
            {
                Example.Visible = false;
            }
            else
            {
                Example.Visible = true;
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            if (form3.DialogResult == DialogResult.OK)
            {
                if (Convert.ToInt32(form3.button1.Tag) == 1)
                {
                    loginToolStripMenuItem.Visible = false;
                    logoutToolStripMenuItem.Visible = true;
                    EditText.Visible = true;
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditText.Visible = false;
            loginToolStripMenuItem.Visible = true;
            logoutToolStripMenuItem.Visible = false;
        }
    }
}
