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
    /// <summary>
    /// 
    /// Name - SHUBHAM
    /// Student ID-301044110
    ///  Last Date Modified: 26/07/19
    /// 
    /// This is a BMI Calculator Application that is continuously itterated till it's final version.
    /// The commits are inorder to major changes and necessary results that were important to be saved.
    /// In this we have an imperical as well as a metric button for the user's convenience of units.
    /// The user can't input either weight ="0" or  height = "0" because that is practically imposible
    /// The user also can't input anything other than number because of our calculator that restricts
    /// user's input.
    /// 
    /// Hope You Enjoy This App!! 
    /// 
    /// </summary>

    public partial class BMI_Calculator_Form : Form
    {
       


        /// <summary>
        /// These are class properties that will contain the respective value
        /// </summary>

        public string outputstringresult { get; set; }
        public float result_value { get; set; }
        public bool decimalresult { get; set; }
        public double bmiresult { get; set; }




        public Label Active_Label { get; set; }
        public Locomotion animated_field;


        /// <summary>
        /// This is the form of my BMI Calculator
        /// </summary>
        public BMI_Calculator_Form()
        {
            InitializeComponent();
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
            Active_Label = null;
            BMICalculatorTableLayoutPanel.Visible = false;
            Size = new Size(320, 480);

            animated_field = Locomotion.IDLE;
        }

        private void BMI_Calculator_Form_Click(object sender, EventArgs e)
        {
            Clear_Numeric_Keyboard();
            if(Active_Label != null)
            {
                Active_Label.BackColor = Color.White;
            }
            Active_Label = null;
            animated_field = Locomotion.DOWN;
            Timer_for_Animation.Enabled = true;
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
                        Backspace_each_character();

                        break;


                    case "Clear":

                        Clear_Numeric_Keyboard();

                        break;

                    case "Done":
                        Submit_your_value();

                        break;
                    case "Decimal":
                        decimal_Exists();
                        break;
                }      
            }
        }

        private void decimal_Exists()
        {
            if (!decimalresult)
            {
                outputstringresult += ".";
                decimalresult = true;
            }
        }

        private void Submit_your_value()
        {
            if (outputstringresult == string.Empty)
            {
                outputstringresult = "0";
            }

            result_value = float.Parse(outputstringresult);
            //result_value = (float)(Math.Round(result_value, 1));

            //if(result_value < 0.1f)
            //{
            //    result_value = 0.1f;
            //}


            Active_Label.Text = result_value.ToString();

            if (Height_Label.Text == "0")
            {
                Height_Label.Text = "0.1";
                Clear_Numeric_Keyboard();


                BMICalculatorTableLayoutPanel.Visible = false;

                Active_Label.BackColor = Color.White;
                Active_Label = null;

                animated_field = Locomotion.DOWN;
                Timer_for_Animation.Enabled = true;

            }


            else if(Weight_Label.Text == "0")
            {
                Weight_Label.Text = "0.1";
                Clear_Numeric_Keyboard();


                BMICalculatorTableLayoutPanel.Visible = false;

                Active_Label.BackColor = Color.White;
                Active_Label = null;

                animated_field = Locomotion.DOWN;
                Timer_for_Animation.Enabled = true;

            }



        }

        private void Backspace_each_character()
        {
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


     
        private void Active_Label_Click_Event(object sender, EventArgs e)
        {
            if(Active_Label != null)
            {
                Active_Label.BackColor = Color.White;
                Active_Label = null;
            }

            Active_Label = sender as Label;
            Active_Label.BackColor = Color.LightBlue;
            BMICalculatorTableLayoutPanel.Visible = true;

            if(Active_Label.Text != "0")
            {
                Resut_Label.Text = Active_Label.Text;
                outputstringresult = Resut_Label.Text;
            }

            //BMICalculatorTableLayoutPanel.Location = new Point(12, Active_Label.Location.Y + 55);
            BMICalculatorTableLayoutPanel.BringToFront();
            Timer_for_Animation.Enabled = true;
            animated_field = Locomotion.UP;

        }

        private void BMI_Calculator_Up(object sender, EventArgs e)
        {
            switch (animated_field)
            {
                case Locomotion.IDLE:
                    break;
                case Locomotion.UP:
                    BMI_Calculator_UP();

                    break;
                case Locomotion.DOWN:
                    BMI_Calculator_Down();
                    break;
            }

        }

        private void BMI_Calculator_UP()
        {
            var present_location = BMICalculatorTableLayoutPanel.Location;
            present_location = new Point(present_location.X, present_location.Y - 20);
            BMICalculatorTableLayoutPanel.Location = present_location;

            if (present_location.Y <= Active_Label.Location.Y + 35)
            {
                BMICalculatorTableLayoutPanel.Location = new Point(present_location.X, Active_Label.Location.Y + 35);
                Timer_for_Animation.Enabled = false;
                animated_field = Locomotion.IDLE;
            }

        }

        private void BMI_Calculator_Down()
        {
            var present_location = BMICalculatorTableLayoutPanel.Location;
            present_location = new Point(present_location.X, present_location.Y + 20);
            BMICalculatorTableLayoutPanel.Location = present_location;

            if (present_location.Y >= 466)
            {
                BMICalculatorTableLayoutPanel.Location = new Point(present_location.X, 466);
                Timer_for_Animation.Enabled = false;
                animated_field = Locomotion.IDLE;
            }

        }

        private void Height_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {

            double Height = Convert.ToDouble(Height_Label.Text);
            double Weight = Convert.ToDouble(Weight_Label.Text);

            if (Imperial_radioButton.Checked)
            {
                bmiresult = Weight * 703 / Math.Pow(Height, 2);
                BMI_Result_label.Text = bmiresult.ToString();

            }
            else if (Metric_Radio_Button.Checked)
            {
                bmiresult = Weight / Math.Pow(Height, 2);
                BMI_Result_label.Text = bmiresult.ToString();
            }

            if(BMI_Result_label.Text == "20")
            {
                progressBar1.
            }

        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Clear_Numeric_Keyboard();
            BMI_Result_label.Text = "";
            Height_Label.Text = "";
            Weight_Label.Text = "";
        }
    }
}
