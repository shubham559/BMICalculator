using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{


    public partial class BMI_Calculator_Form : Form
    {
        /// <summary>
        /// These are class properties that will contain the respective value
        /// </summary>

        public string outputstringresult { get; set; }
        public float result_value { get; set; }
        public bool decimalresult { get; set; }
       
        /// <summary>
        /// This is the form of my BMI Calculator
        /// </summary>
        public BMI_Calculator_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is an event handler that shows the same text on result label or output as
        /// corresponding to the button that is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Calculator_Button_Click(object sender, EventArgs e)
        {
            Button Button = sender as Button;

            var tag = Button.Tag.ToString();

            int numeric_Value = 0; 

            bool numeric_result = int.TryParse(tag, out numeric_Value);
            if (numeric_result)
            {

                int maxSize = (decimalresult) ? 5 : 3;

                if (outputstringresult == "0")
                {
                    outputstringresult = tag;
                }
                else
                {
                    if(outputstringresult.Length < maxSize)
                    {
                        outputstringresult += tag;

                    }
                    Resut_Label.Text = outputstringresult;

                }
            }

            else
            {
                switch (tag)
                {
                    case "Back":

                        var last_char = outputstringresult.Substring(outputstringresult.Length - 1);
                        if (last_char == ".")
                        {
                            decimalresult = false;
                        }

                        outputstringresult = outputstringresult.Remove(outputstringresult.Length - 1);

                        if (outputstringresult.Length == 0)
                        {
                            outputstringresult = "0";
                        }

                        Resut_Label.Text = outputstringresult;

                        break;

                    
                    case "Clear":

                        Clear_Numeric_Keyboard();

                        break;

                    case "Done":
                        if (!decimalresult)
                        {
                            outputstringresult = outputstringresult.Remove(outputstringresult.IndexOf('.') + 1);
                        }
                            result_value = float.Parse(outputstringresult);

                        if(result_value < 0.1f)
                        {
                            result_value = 0.1f;
                        }

                        Output_Label.Text = result_value.ToString();
                        Clear_Numeric_Keyboard();
                        BMICalculatorTableLayoutPanel.Visible = false;

                        break;
                    case "Decimal":
                        if (!decimalresult)
                        {
                            outputstringresult += ".";
                            decimalresult = true;
                        }
                        break;

                }
            
            }



        }


        /// <summary>
        ///     This method clears the numeric keyboard of BMI
        /// </summary>

        private void Clear_Numeric_Keyboard()
        {
            Resut_Label.Text = "0";
            outputstringresult = "0";
            result_value = 0.0f;
            decimalresult = false;

        }

        /// <summary>
        /// this is the event handler of loading the form and we have intialised it by clearing the
        /// form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BMI_Calculator_Form_Load(object sender, EventArgs e)
        {
            Clear_Numeric_Keyboard();
            BMICalculatorTableLayoutPanel.Visible = false;
        }

        private void Output_Result_Event(object sender, EventArgs e)
        {
            BMICalculatorTableLayoutPanel.Visible = true;
        }
    }
}
