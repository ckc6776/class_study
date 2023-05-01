using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_First : Form
    {
        public Form_First()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form Form_button = new Form_button();
            Form_button.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form_TextBox = new Form_TextBox();
            Form_TextBox.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form MidTest_Form = new MidTest_Form();
            MidTest_Form.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Form Form_0501 = new Form_0501();
            Form_0501.Show();
        }
    }
}
