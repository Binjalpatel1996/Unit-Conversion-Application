using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{

    public partial class Default : System.Web.UI.Page
    {
        private decimal conversion = 0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ArrayList listitem = new ArrayList()
                {
                    "Select",
                    "Length",
                    "Liquid",
                    "Temperature",
                    "Mass"
                };
                foreach (object item in listitem)
                {
                    DropDownList1.Items.Add(new ListItem(item.ToString(), item.ToString()));
                }
                
                
            }


        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            string conversiontype = Convert.ToString(DropDownList1.SelectedValue);
            string unittype = Convert.ToString(DropDownList2.SelectedValue);
            double val = Convert.ToInt32(TextBox1.Text);
            conversion = this.CalculateConversion(conversiontype, unittype, val);

            ArrayList itemList = new ArrayList();
            {
                itemList.Add(Label1.Text);
            }
            foreach(object item in itemList)
            {
                TextBox2.Text += item + "\n";

            }
                    


           
        }

        

        public decimal CalculateConversion(string conversiontype, string unittype, double val)
        {
            double i = int.Parse(TextBox1.Text);
            if (DropDownList2.SelectedValue == "Kilometers to Miles")
            {
                double km = i / 1.609;
                Label1.Text = int.Parse(TextBox1.Text) + " Kilometers = " + km.ToString() + " Miles";
            }
            else if (DropDownList2.SelectedValue == "Miles to Kilometers")
            {
                double mile = i * 1.60934;
                Label1.Text = int.Parse(TextBox1.Text) + " Miles = " + mile.ToString() + " Kilometers";
            }
            else if (DropDownList2.SelectedValue == "Yard to Feet")
            {
                double yard = i * 3;
                Label1.Text = int.Parse(TextBox1.Text) + " Yards = " + yard.ToString() + " Feets";
            }
            else if (DropDownList2.SelectedValue == "Feet to Yard")
            {
                double feets = i / 3;
                Label1.Text = int.Parse(TextBox1.Text) + " Feets = " + feets.ToString() + " Yards";
            }
            else if (DropDownList2.SelectedValue == "Inches to Centimeters")
            {
                double inch = i * 2.54;
                Label1.Text = int.Parse(TextBox1.Text) + " Inches = " + inch.ToString() + " Centimeters";
            }
            else if (DropDownList2.SelectedValue == "Centimeters to Inches")
            {
                double cm = i / 2.54;
                Label1.Text = int.Parse(TextBox1.Text) + " Centimeters = " + cm.ToString() + " Inches";
            }
            else if (DropDownList2.SelectedValue == "Liters to Gallons")
            {
                double Ltr = i / 3.785;
                Label1.Text = int.Parse(TextBox1.Text) + " Liters = " + Ltr.ToString() + " Gallons";
            }
            else if (DropDownList2.SelectedValue == "Gallons to Liters")
            {
                double Gl = i * 3.785;
                Label1.Text = int.Parse(TextBox1.Text) + " Gallons = " + Gl.ToString() + " Liters";
            }
            else if (DropDownList2.SelectedValue == "Pints to Gallons")
            {
                double pn = i / 8;
                Label1.Text = int.Parse(TextBox1.Text) + " Pints = " + pn.ToString() + " Gallons";
            }
            else if (DropDownList2.SelectedValue == "Gallons to Pints")
            {
                double gal = i * 8;
                Label1.Text = int.Parse(TextBox1.Text) + " Gallons = " + gal.ToString() + " Pints";
            }
            else if (DropDownList2.SelectedValue == "Quarts to Gallons")
            {
                double qt = i / 4;
                Label1.Text = int.Parse(TextBox1.Text) + " Quarts = " + qt.ToString() + " Gallons";
            }
            else if (DropDownList2.SelectedValue == "Gallons to Quarts")
            {
                double Gns = i * 4;
                Label1.Text = int.Parse(TextBox1.Text) + " Gallons = " + Gns.ToString() + " Quarts";
            }
            else if (DropDownList2.SelectedValue == "Fahrenheit to Celsius")
            {
                double fh = (i - 32) * 5 / 9;
                Label1.Text = int.Parse(TextBox1.Text) + " Fahrenheit = " + fh.ToString() + " Cenlsius";
            }
            else if (DropDownList2.SelectedValue == "Celsius to Fahrenheit")
            {
                double cs = (i * 1.8) + 32;
                Label1.Text = int.Parse(TextBox1.Text) + " Celsius = " + cs.ToString() + " Fahrenheit";
            }
            else if (DropDownList2.SelectedValue == "Kilograms to Pounds")
            {
                double kg = i * 2.205;
                Label1.Text = int.Parse(TextBox1.Text) + " Kilograms = " + kg.ToString() + " Pounds";
            }
            else if (DropDownList2.SelectedValue == "Pounds to Kilograms")
            {
                double pou = i / 2.205;
                Label1.Text = int.Parse(TextBox1.Text) + " Pounds = " + pou.ToString() + " Kilograms";
            }
            else if (DropDownList2.SelectedValue == "Ounce to Grams")
            {
                double oun = i * 28.35;
                Label1.Text = int.Parse(TextBox1.Text) + " Ounce = " + oun.ToString() + " Grams";
            }
            else if (DropDownList2.SelectedValue == "Grams to Ounce")
            {
                double Gm = i / 28.35;
                Label1.Text = int.Parse(TextBox1.Text) + " Grams = " + Gm.ToString() + " Ounce";
            }
            else
            {
                Label1.Text = "Enter the Valid Input!";
            }
            return conversion;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedValue = DropDownList1.SelectedItem.Text;

            if (selectedValue == "Length")
            {
                ArrayList listitem1 = new ArrayList()
                {
                    "Select",
                   "Kilometers to Miles",
                   "Miles to Kilometers",
                   "Yard to Feet",
                   "Feet to Yard",
                   "Inches to Centimeters",
                   "Centimeters to Inches"

                };
                foreach (object item in listitem1)
                {
                    DropDownList2.Items.Add(new ListItem(item.ToString(), item.ToString()));
                }
            }
            if (selectedValue == "Liquid")
            {
                ArrayList listitem2 = new ArrayList() {
                    "Select",
                    "Liters to Gallons",
                    "Gallons to Liters",
                    "Pints to Gallons",
                    "Gallons to Pints",
                    "Quarts to Gallons",
                    "Gallons to Quarts"
                };
                foreach (object item in listitem2)
                {
                    DropDownList2.Items.Add(new ListItem(item.ToString(), item.ToString()));
                }
            }
            if (selectedValue == "Temperature")
            {

                ArrayList listitem3 = new ArrayList()
                {
                    "Select",
                    "Fahrenheit to Celsius",
                    "Celsius to Fahrenheit"
                };
                foreach (object item in listitem3)
                {
                    DropDownList2.Items.Add(new ListItem(item.ToString(), item.ToString()));
                }
            }

            if (selectedValue == "Mass")
            {
                ArrayList listitem4 = new ArrayList()
                {
                    "Select",
                    "Kilograms to Pounds",
                    "Pounds to Kilograms ",
                    "Ounce to Grams",
                    "Grams to Ounce"
                };

                foreach (object item in listitem4)
                {
                    DropDownList2.Items.Add(new ListItem(item.ToString(), item.ToString()));
                }

            }
        }

        protected void btnclear(object sender, EventArgs e)
        {
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
            TextBox1.Text = "";
            Label1.Text = "";
        }
    }
}
 
