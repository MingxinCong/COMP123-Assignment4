using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace COMP123_Assignment4
{
    public partial class BMICalculator : Form
    {
        private List<BMIResultLine> bmiResultLines;
        public BMICalculator()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            bmiResultLines = new List<BMIResultLine>();
            bmiResultLines.Add(new BMIResultLine("Underweight", "less than 18.5"));
            bmiResultLines.Add(new BMIResultLine("Normal", "between 18.5 and 24.9"));
            bmiResultLines.Add(new BMIResultLine("Overweight", "between 25 and 29.9"));
            bmiResultLines.Add(new BMIResultLine("Obese", "30 or greater"));
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                || (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'));
        }

        private void calculateButton_Click(object sender, System.EventArgs e)
        {
            double height = double.Parse(heightTextBox.Text);
            double weight = double.Parse(weightTextBox.Text);
            bool isImperial = ImperialRadioButton.Checked;
            double bmi = 0;
            if (isImperial)
            {
                bmi = (weight * 703) / (height * height);
            }
            else
            {
                bmi = weight / (height * height);
            }
            bmi = Math.Round(bmi, 1);
            bMITextBox.Text = bmi.ToString();
            bMIScaleTextBox.Text = "According to National Institutes of Health\r\n";

            foreach(var line in bmiResultLines)
            {
                bMIScaleTextBox.Text += $"{line}\r\n";
            }
            int indexOfResult = 0;
            if(bmi < 18.5)
            {
                indexOfResult = 0;
            }else if(bmi >= 18.5 && bmi <= 24.9)
            {
                indexOfResult = 1;
            }else if(bmi >= 25 && bmi <= 29.9)
            {
                indexOfResult = 2;
            }else
            {
                indexOfResult = 3;
            }
            bMIScaleTextBox.Text += $"\nSo you are {bmiResultLines[indexOfResult].Scale}.";
            bMIScaleTextBox.Font = new Font(bMIScaleTextBox.Font.FontFamily, 10);
        }
    }
}
