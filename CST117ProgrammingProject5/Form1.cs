using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117ProgrammingProject5
{
    public partial class LuckyNumber : Form
    {
        public LuckyNumber()
        {
            InitializeComponent();
            List<string> years = new List<string>();
            for (int i = 1975; i < 2019; i++)
            {
                years.Add(i.ToString());
            }
            comboBox1_birthYear.DataSource = years;

            string[] monthArr = {"January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"};
            comboBox2_birthMonth.DataSource = monthArr;

            string[] colorsArr = { "Pink", "Blue", "Light Blue", "Mint", "Purple", "Red", "Green", "Orange", "Yellow" };
            comboBox4_color.DataSource = colorsArr;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Results result = new Results();
            result.label1.Text = "Your" + "\nLucky Space Number" + "\nIs";
            string color = this.comboBox4_color.SelectedItem.ToString();
            switch (color) 
            {
                case "Pink":
                    result.ForeColor = System.Drawing.Color.Pink;
                    break;
                case "Blue":
                    result.ForeColor = System.Drawing.Color.Blue;
                    break;
                case "Light Blue":
                    result.ForeColor = System.Drawing.Color.LightBlue;
                    break;
                case "Mint":
                    result.ForeColor = System.Drawing.Color.MintCream;
                    break;
                case "Purple":
                    result.ForeColor = System.Drawing.Color.Purple;
                    break;
                case "Red":
                    result.ForeColor = System.Drawing.Color.Red;
                    break;
                case "Green":
                    result.ForeColor = System.Drawing.Color.Green;
                    break;
                case "Orange":
                    result.ForeColor = System.Drawing.Color.Orange;
                    break;
                case "Yellow":
                    result.ForeColor = System.Drawing.Color.Yellow;
                    break;
            }
            string combo1 = this.comboBox1_birthYear.SelectedItem.ToString();
            string combo3 = this.comboBox3_birthday.SelectedItem.ToString();
            int answer = int.Parse(combo1) / int.Parse(combo3);
            result.label2.Text = answer.ToString();
            if (answer.ToString().Length == 4)
            {
                result.label2.TextAlign = ContentAlignment.MiddleCenter;
            }

            else if (answer.ToString().Length == 3)
            {
                result.label2.TextAlign = ContentAlignment.MiddleLeft;
            }

            else if (answer.ToString().Length == 2)
            {
                result.label2.TextAlign = ContentAlignment.MiddleLeft;
            }

            result.ShowDialog();
        }
        private void comboBox2_birthMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month = this.comboBox2_birthMonth.SelectedItem.ToString();
            List<string> birthday = new List<string>();
            int days = 0;
            switch (month)
            {
                case "January":
                    days = 31;
                    break;
                case "February":
                    days = 29;
                    break;
                case "March":
                    days = 31;
                    break;
                case "April":
                    days = 30;
                    break;
                case "May":
                    days = 31;
                    break;
                case "June":
                    days = 30;
                    break;
                case "July":
                    days = 31;
                    break;
                case "August":
                    days = 31;
                    break;
                case "September":
                    days = 30;
                    break;
                case "October":
                    days = 31;
                    break;
                case "November":
                    days = 30;
                    break;
                case "December":
                    days = 31;
                    break;
            }
            for (int i = 1; i <= days; i++)
            {
                birthday.Add(i.ToString());
            }
            comboBox3_birthday.DataSource = birthday;
        }
    }
}
