using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_35
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // Display "Hi" in Red ...
            // Escape character \ is needed before " when a double quote is used within a string 
            //resultLabel.Text = "<p style=\"color:#ee3b32;\">Hi</p>";

           
            string value = valueTextBox.Text;
            // Access the 3rd character in the value textbox. Char is returned so it has to be cast to a string.
            //resultLabel.Text = value[2].ToString();

            // StartWith(), EndWith(), Contains()
            if (value.StartsWith("A"))
                resultLabel.Text = "Value starts with 'A' <br/>";

            if (value.EndsWith("."))
                resultLabel.Text += "Value ends with '.' <br/>";

            if (value.Contains("good"))
                resultLabel.Text += "Value contains 'good' ";

            // IndexOf()  ... to find the index of the first character of a given word or just a single character in a string
            int index = value.IndexOf("good");
            //resultLabel.Text = " The word 'good' begins at index " + index.ToString();

            // Insert, Remove
            //resultLabel.Text = value.Insert(index, "jolly ");
            //resultLabel.Text = value.Remove(index, value.Length - index);

            // Substring ... starts at a specified position and has a specified length
            // For example "A*good*day." index = 2 so the first character will be "g" value.Length = 11 and value.Length - index - 1 = 8 so resultLabel.Text = "good*day"
            //resultLabel.Text = value.Substring(index, value.Length - index - 1);

            // Trim ... leading and trailing spaces, TrimStart .... leading spaces, TrimEnd ... trailing spaces
            resultLabel.Text = string.Format("Length before: {0}<br/>Length after: {1}", value.Length, value.Trim().Length);

            // PadLeft ... specify the total length of the string after padding added to the left plus the character used as the padding in single quotes , PadRight ... same but to the right
            //resultLabel.Text = value.PadLeft(10,'*');
            //resultLabel.Text = value.PadRight(10, '&');

            //ToUpper, ToLower ... this doesn't actually work as need to make the string upper or lower case and trim leading and trailing spaces, see following example
            //if ("bob" == "Bob") resultLabel.Text = "The same";
            //else resultLabel.Text = "Different";

            //if (valueTextBox.Text.Trim().ToUpper() == "BOB") resultLabel.Text = "The same";
            //else resultLabel.Text = "Different";

            // Replace() ... useful when data is coming in from xml files, etc. Replacing the word "NAME" with the text in valueTextBox. 
            string template = "NAME said it would be ok. Talk to NAME.";
            resultLabel.Text = template.Replace("NAME", valueTextBox.Text);

            // Split ... this is a way to take a string, separate it by a specific character, in this instance a comma, place the values in an array, loop through the array, place a space
            // and an html <br/> tag between each value and return the values into a label. 
            //string result = "";
            //string[] values = valueTextBox.Text.Split(',');
            //for (int i = 0; i <values.Length; i++)
            //{
            //    result += values[i] + " " + values[i].Length + "<br/>";
            // }
            //resultLabel.Text = result;

            // HOWEVER As the string object is immutable in C#, it is a more memory efficient way of handling string concatenation if having performence issues to create a class and an object so I have 
            //replaced some of the lined below ...
           // string result = "";
            StringBuilder sb = new StringBuilder();        // using System.Text is added at the top of Default.aspx.cs when hover over the lightbulb to create a new class. StringBuilder is an object. 

            string[] values = valueTextBox.Text.Split(',');
            for (int i = 0; i < values.Length; i++)
            {

                //result += values[i] + " " + values[i].Length + "<br/>";
                sb.Append(values[i]);
                sb.Append(" ");
                sb.Append(values[i].Length);
                sb.Append("<br/>");

            }
            //resultLabel.Text = result;
            resultLabel.Text = sb.ToString();




























        }
    }
}