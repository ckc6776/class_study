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
    public partial class Form_panel : Form
    {
        public Form_panel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mainFood = "";//主食2
            string mainMeal = "";//主餐1
            string sideDish = "";//配菜3
            string dessert = "";//點心4

            foreach (Control c in panel2.Controls)
            { 
                if(c is CheckBox)
                {
                    if(((CheckBox)c).Checked == true)
                    {
                        mainFood += c.Text + " ";
                    }
                }
            }

            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        mainMeal += c.Text + " ";
                    }
                }
            }

            foreach (Control c in panel3.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        sideDish += c.Text + " ";
                    }
                }
            }

            foreach (Control c in panel4.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        dessert += c.Text + " ";
                    }
                }
            }
            //Environment.NewLine可以替代\n
            MessageBox.Show("主餐:"+ mainFood + "\n主食:" + mainMeal + "\n配菜:"+ sideDish + "\n點心:"+ dessert);













        }
    }
}
