using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyCalculate
{
    public partial class main : Form
    {
        double enterfirstnumber , entersecondnumber ;
        string op;

        public main()
        {
            InitializeComponent();
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterNumberss(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                string buttonText = button.Text;

                if (textBox.Text == "0")
                {
                    textBox.Text = "";
                }

                Regex regex = new Regex(@"^[0-9\.]$");

                if (regex.IsMatch(buttonText))
                {
                    if (!textBox.Text.Contains("."))
                    {
                        textBox.Text += buttonText;
                    }
                    else if (buttonText != ".")
                    {
                        textBox.Text += buttonText;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception here
            }
        }

        private void NumberOpritor(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            enterfirstnumber = Convert.ToDouble(textBox.Text);
            op = button.Text;
            textBox.Text = "";
        }

        private void btneaq_Click(object sender, EventArgs e)
        {
            entersecondnumber = Convert.ToDouble(textBox.Text);

            switch (op)
            {
                case "+":
                    textBox.Text = (enterfirstnumber + entersecondnumber).ToString();
                break;
                case "-":
                    textBox.Text = (enterfirstnumber - entersecondnumber).ToString();
                    break;
                case "*":
                    textBox.Text = (enterfirstnumber * entersecondnumber).ToString();
                    break;
                case "/":
                    textBox.Text = (enterfirstnumber / entersecondnumber).ToString();
                    break;
                case "%":
                    textBox.Text = (enterfirstnumber % entersecondnumber).ToString();
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0) 
            {
                Mycalculator since = new Mycalculator();
                this.Hide();
                since.Show();
            }
            else
            {
                MessageBox.Show("You are in hte main calculater");
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void main_Load_1(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
            }
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}