using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//0605添加

namespace WindowsFormsApp1
{
    public partial class Form_panel : Form
    {
        public Form_panel()
        {
            InitializeComponent();
            File.WriteAllText("Temp.txt","歡迎暗黑雙靈餐館\n");
            File.AppendAllText("Temp.txt","我是第二行\n");
            String input = File.ReadAllText("Temp.txt");
            MessageBox.Show(input);
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,主食,主餐,配菜,點心\n",Encoding.UTF8);


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
            //MessageBox.Show("主餐:"+ mainFood + "\n主食:" + mainMeal + "\n配菜:"+ sideDish + "\n點心:"+ dessert);

            DateTime currentDateTime = DateTime.Now;
            string formateDateTime = currentDateTime.ToString("G");
            File.AppendAllText("OrderData.csv",formateDateTime+","+mainFood+","+mainMeal+","+sideDish+","+dessert+"\n");
            MessageBox.Show("點餐成功");








        }
    }
}
