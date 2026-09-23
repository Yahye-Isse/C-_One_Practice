using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Assignment_CA242
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowDate_Click(object sender, EventArgs e)
        {
            string day_of_Wee, name_of_month;
            int numeric_day, Year;
            string fullName;

            day_of_Wee = txtDayoftheweek.Text;
            name_of_month = txtMonth.Text;
            numeric_day =int.Parse(txtdayofthemonth.Text);
            Year = int.Parse(txtYear.Text);

            fullName = day_of_Wee + name_of_month + numeric_day + Year;

            lbloutput.Text = fullName;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clearing texbox and Label 
           //clearning textbox 
            txtDayoftheweek.Clear();
            txtdayofthemonth.Text = "";
            txtMonth.Text = string.Empty;
            txtYear.Clear();

            //clearning label - not used clear function
            lbloutput.Text = "";
           // lbloutput.Text = string.Empty;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //form close - using this keyword and close function
            this.Close();
        }
    }
}
