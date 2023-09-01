using System.Text.RegularExpressions;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse((textBox1.Text).Trim());
            double num2 = double.Parse((textBox2.Text).Trim());

            double result = num1 + num2;
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse((textBox1.Text).Trim());
            double num2 = double.Parse((textBox2.Text).Trim());

            double result = num1 - num2;
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse((textBox1.Text).Trim());
            double num2 = double.Parse((textBox2.Text).Trim());

            double result = num1 * num2;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse((textBox1.Text).Trim());
            double num2 = double.Parse((textBox2.Text).Trim());

            if (num2 != 0)
            {
                double result = num1 / num2;
                textBox3.Text = result.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private bool IsValidNumber(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                string pattern = @"^[-+]?\d+(\.\d*)?$";

                // Use Regex.IsMatch to check if the input matches the pattern
                return Regex.IsMatch(input, pattern);
            }
            return false;
        }


        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Create an array or list of all your TextBox controls
            TextBox[] textBoxes = { textBox1, textBox2 }; // Add more TextBox controls

            // Assume you have a List<Button> containing your operation buttons
            List<Button> operationButtons = new List<Button> { button1, button2, button3, button4 }; // Add your buttons

            bool allInputsValid = true;

            foreach (TextBox textBox in textBoxes)
            {
                if (!IsValidNumber(textBox.Text))
                {
                    // The input is not a valid number
                    textBox.BackColor = Color.Red;
                    allInputsValid = false;
                }
                else
                {
                    // The input is a valid number
                    textBox.BackColor = SystemColors.Window;
                }
            }

            // Enable or disable operation buttons based on input validity
            foreach (Button button in operationButtons)
            {
                button.Enabled = allInputsValid;
            }
        }

    }
}