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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyCalculate
{
    public partial class Mycalculator : Form
    {
        double enterfirstnumber, entersecondnumber;
        string op;
        double pi = 3.1415926535899;
        public Mycalculator()
        {
            InitializeComponent();
        }

        private void EnterNumberss(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
                string buttonText = button.Text;

                if (textbox.Text == "0")
                {
                    textbox.Text = "";
                }

                Regex regex = new Regex(@"^[0-9\.]$");

                if (regex.IsMatch(buttonText))
                {
                    if (!textbox.Text.Contains("."))
                    {
                        textbox.Text += buttonText;
                    }
                    else if (buttonText != ".")
                    {
                        textbox.Text += buttonText;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception here
            }
        }

        private void btneaq_Click(object sender, EventArgs e)
        {
            entersecondnumber = Convert.ToDouble(textbox.Text);

            switch (op)
            {
                case "+":
                    textbox.Text = (enterfirstnumber + entersecondnumber).ToString();
                    break;
                case "-":
                    textbox.Text = (enterfirstnumber - entersecondnumber).ToString();
                    break;
                case "*":
                    textbox.Text = (enterfirstnumber * entersecondnumber).ToString();
                    break;
                case "/":
                    textbox.Text = (enterfirstnumber / entersecondnumber).ToString();
                    break;
                case "%":
                    textbox.Text = (enterfirstnumber % entersecondnumber).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textbox.Text = "0";
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (textbox.Text.Length > 0)
            {
                textbox.Text = textbox.Text.Remove(textbox.Text.Length - 1, 1);
            }
            if (textbox.Text == "")
            {
                textbox.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textbox.Text);
            textbox.Text = Convert.ToString(-1 * a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textbox.Text = "0";

            String f, s;
            f = Convert.ToString(enterfirstnumber);
            s = Convert.ToString(entersecondnumber);

            f = "";
            s = "";
        }

        private void Sientifique_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void standarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 974;
            textbox.Width = 2138;
        }

        private void sientifiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 2193;
            textbox.Width = 2138;
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirme if you want to exit" , "Scientifaue Calculatoe" , 
                MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void darkModeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textbox.BackColor= SystemColors.Desktop;
            textbox.ForeColor= SystemColors.Control;
            this.BackColor= SystemColors.Desktop;
            menuStrip1.BackColor = SystemColors.Desktop;
            menuStrip1.ForeColor = SystemColors.Control;
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.BackColor = SystemColors.Control;
            textbox.ForeColor = SystemColors.Desktop;
            this.BackColor = SystemColors.Control;
            menuStrip1.ForeColor = SystemColors.Desktop;
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textbox.Text = "3.1415926535899";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(textbox.Text);
            logg = Math.Log(logg);
            textbox.Text = Convert.ToString(logg);
        }

        private void button25_Click(object sender, EventArgs e) { 
        
            double sqrtt = Convert.ToDouble(textbox.Text);
            sqrtt = Math.Sqrt(sqrtt);
            textbox.Text = Convert.ToString(sqrtt);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double coss = Convert.ToDouble(textbox.Text);
            coss = Math.Cos(coss);
            textbox.Text = Convert.ToString(coss);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double sinn = Convert.ToDouble(textbox.Text);
            sinn = Math.Sin(sinn);
            textbox.Text = Convert.ToString(sinn);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textbox.Text) * Convert.ToDouble(textbox.Text);
            textbox.Text = Convert.ToString(x);
       }

        private void button9_Click(object sender, EventArgs e)
        {
            double f, y, r, t;
            y = Convert.ToDouble(textbox.Text);
            r = Convert.ToDouble(textbox.Text);
            t = Convert.ToDouble(textbox.Text);
            f = y*r*t;
            textbox.Text = Convert.ToString(f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sinnh = Convert.ToDouble(textbox.Text);
            sinnh = Math.Sinh(sinnh);
            textbox.Text = Convert.ToString(sinnh);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double cossh = Convert.ToDouble(textbox.Text);
            cossh = Math.Cosh(cossh);
            textbox.Text = Convert.ToString(cossh);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(textbox.Text);
            tan = Math.Tan(tan);
            textbox.Text = Convert.ToString(tan);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(textbox.Text);
            tanh = Math.Tanh(tanh);
            textbox.Text = Convert.ToString(tanh);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double folat = Convert.ToDouble(textbox.Text);
            double i = 1 / folat;
            textbox.Text = Convert.ToString(i);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double exp = Convert.ToDouble(textbox.Text);
            exp = Math.Exp(exp);
            textbox.Text = Convert.ToString(exp);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double exp = Convert.ToDouble(textbox.Text);
            double i = Math.Exp(exp);
            textbox.Text = Convert.ToString(i);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double one = Convert.ToDouble(textbox.Text);
            double r =1;
            //2
            for (int i =2; i<=one; i++)
            {
                r *= i;
            }
            textbox.Text = Convert.ToString(r);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double rad = Convert.ToDouble(textbox.Text);
            double fix = (rad * pi) / 180;
            textbox.Text = Convert.ToString(fix);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double lnn = Convert.ToDouble(textbox.Text);
            double i = Math.Log10(lnn);
            textbox.Text = Convert.ToString(i);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double xii = Convert.ToDouble(textbox.Text);
            double one = Math.Pow(10,xii);
            textbox.Text = Convert.ToString(one);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textbox.Text) / Convert.ToDouble(100);
            textbox.Text = Convert.ToString(a);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(textbox.Text);
            int i1 =  Convert.ToInt32(dec);
            int i2 = (int)dec;
            textbox.Text = Convert.ToString(i2);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textbox.Text);
            //2 ---> Is the base of the out put string (binary)
            textbox.Text = Convert.ToString(i ,2);

        }

        private void button22_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textbox.Text);
            //16 ---> Is the base of the out put string (hexa deimal)
            textbox.Text = Convert.ToString(i, 16);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textbox.Text);
            //8 ---> Is the base of the out put string (octat)
            textbox.Text = Convert.ToString(i, 8);
        }

        private void NumberOpritorr(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            enterfirstnumber = Convert.ToDouble(textbox.Text);
            op = button.Text;
            textbox.Text = "";
        }
    }
}
