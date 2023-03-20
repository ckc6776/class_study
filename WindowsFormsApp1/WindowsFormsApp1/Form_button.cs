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
    public partial class Form_button : Form
    {
        public Form_button()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (button1.Text == "你按了按鈕")
               button1.Text = "你有按按鈕";
            else if   (button1.Text == "你有按按鈕")
               button1.Text = "你按了按鈕";
        }
    }
}
