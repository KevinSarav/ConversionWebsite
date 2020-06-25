using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class Default : System.Web.UI.Page
    {
        static string resultMeasurement;

        public static string ResultMeasurement
        {
            get
            {
                return resultMeasurement;
            }
            set
            {
                resultMeasurement = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // When loading page:
        }

        protected void ddType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When selecting type:
            
            // Clear dropdown conversions list and all labels first in case a type was selected prior.
            ddConversions.Items.Clear();
            lbMeasurement.Text = "";
            lbResult.Text = "";
            lbResultMeasurement.Text = "";

            // If type selected was the default:
            if(ddType.SelectedValue.Equals("Please choose a type"))
            {
                // Add default dropdown conversions list value requesting type
                ddConversions.Items.Add("Please choose a type first");
            }
            else
            {
                // Add default dropdown conversions list value requesting conversion
                ddConversions.Items.Add("Please choose a conversion");

                // Fill dropdown conversions list depending on type
                if (ddType.SelectedValue.Equals("Length"))
                {
                    ddConversions.Items.Add("Kilometer to Miles");
                    ddConversions.Items.Add("Miles to Kilometers");
                    ddConversions.Items.Add("Yard to Feet");
                    ddConversions.Items.Add("Feet to Yard");
                    ddConversions.Items.Add("Inches to Centimeters");
                    ddConversions.Items.Add("Centimeters to Inches");
                }
                if (ddType.SelectedValue.Equals("Liquid"))
                {
                    ddConversions.Items.Add("Liters to Gallons");
                    ddConversions.Items.Add("Gallons to Liters");
                    ddConversions.Items.Add("Pints to Gallons");
                    ddConversions.Items.Add("Gallons to Pints");
                    ddConversions.Items.Add("Quarts to Gallons");
                    ddConversions.Items.Add("Gallons to Quarts");
                }
                if (ddType.SelectedValue.Equals("Temperature"))
                {
                    ddConversions.Items.Add("Fahrenheit to Celsius");
                    ddConversions.Items.Add("Celsius to Fahrenheit");
                }
                if (ddType.SelectedValue.Equals("Mass"))
                {
                    ddConversions.Items.Add("Kilograms to Pounds");
                    ddConversions.Items.Add("Pounds to Kilograms");
                    ddConversions.Items.Add("Ounce to Grams");
                    ddConversions.Items.Add("Grams to Ounce");
                }
            }
        }

        protected void btConvert_Click(object sender, EventArgs e)
        {
            // When clicking convert button:

            // If conversion selected are neither of the defaults and amount was not left blank:
            if(!ddConversions.SelectedValue.Equals("Please choose a conversion") && !ddConversions.SelectedValue.Equals("Please choose a type first") && !txAmount.Text.Equals(""))
            {
                // Store amount as double into input and clear result label in case filled prior
                double result = 0, input = Convert.ToDouble(txAmount.Text);
                lbResult.Text = "";

                // Calculate result depending on conversion
                if (ddConversions.SelectedValue.Equals("Kilometer to Miles"))
                {
                    result = input * 0.621371;
                }
                if (ddConversions.SelectedValue.Equals("Miles to Kilometers"))
                {
                    result = input * 1.60934;
                }
                if (ddConversions.SelectedValue.Equals("Yard to Feet"))
                {
                    result = input * 3;
                }
                if (ddConversions.SelectedValue.Equals("Feet to Yard"))
                {
                    result = input * 0.33333;
                }
                if (ddConversions.SelectedValue.Equals("Inches to Centimeters"))
                {
                    result = input * 2.54;
                }
                if (ddConversions.SelectedValue.Equals("Centimeters to Inches"))
                {
                    result = input * 0.3937;
                }
                if (ddConversions.SelectedValue.Equals("Liters to Gallons"))
                {
                    result = input * 0.264172;
                }
                if (ddConversions.SelectedValue.Equals("Gallons to Liters"))
                {
                    result = input * 3.78541;
                }
                if (ddConversions.SelectedValue.Equals("Pints to Gallons"))
                {
                    result = input * 0.125;
                }
                if (ddConversions.SelectedValue.Equals("Gallons to Pints"))
                {
                    result = input * 9.60762;
                }
                if (ddConversions.SelectedValue.Equals("Quarts to Gallons"))
                {
                    result = input * 0.20817;
                }
                if (ddConversions.SelectedValue.Equals("Gallons to Quarts"))
                {
                    result = input * 4.80381;
                }
                if (ddConversions.SelectedValue.Equals("Fahrenheit to Celsius"))
                {
                    result = (input - 32) * 0.5555;
                }
                if (ddConversions.SelectedValue.Equals("Celsius to Fahrenheit"))
                {
                    result = (input * 1.8) + 32;
                }
                if (ddConversions.SelectedValue.Equals("Kilograms to Pounds"))
                {
                    result = input * 2.20462;
                }
                if (ddConversions.SelectedValue.Equals("Pounds to Kilograms"))
                {
                    result = input * 0.453592;
                }
                if (ddConversions.SelectedValue.Equals("Ounce to Grams"))
                {
                    result = input * 28.3495;
                }
                if (ddConversions.SelectedValue.Equals("Grams to Ounce"))
                {
                    result = input * 0.035274;
                }

                // Store result as formatted string into result label and result measurement string into result measurement label
                string format = "#,#.000";
                lbResult.Text = result.ToString(format);
                lbResultMeasurement.Text = Default.ResultMeasurement;
            }
        }

        protected void btClear_Click(object sender, EventArgs e)
        {
            // When clicking clear button:

            // Restore page to how it first was
            ddType.SelectedValue = "Please choose a type";
            txAmount.Text = "";
            lbMeasurement.Text = "";
            ddConversions.Items.Clear();
            ddConversions.Items.Add("Please choose a type first");
            lbResult.Text = "";
            lbResultMeasurement.Text = "";
        }

        protected void ddConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When selecting conversion:

            // Clear all labels in case filled prior
            lbResult.Text = "";
            lbMeasurement.Text = "";
            lbResultMeasurement.Text = "";

            // If conversion selected is the default:
            if (!ddConversions.SelectedValue.Equals("Please choose a conversion"))
            {
                // Store measurement in measurement label and resulting measurement in result measurement string
                string[] words = ddConversions.SelectedValue.Split(' ');
                lbMeasurement.Text = words[0].ToLower();
                Default.ResultMeasurement = words[2].ToLower();
            }
        }
    }
}