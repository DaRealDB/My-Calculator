using System.Data;

namespace Calculator_H2Bacusmo
{
    public partial class Form1 : Form
    {
        private bool minuspl = false;
        private bool decpointint = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BNum(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (tb_display.Text == "0" || tb_display.Text == "SYNTAX ERROR" || tb_display.Text == "ERROR")
            {
                if (button.Text == ".")
                {
                    tb_display.Text = "0" + button.Text;
                }
                else
                {
                    tb_display.Text = button.Text;
                }
  
            }
            else
            {
                if (tb_display.Text.EndsWith(".") && button.Text == ".")
                {
                    return;
                }
                tb_display.Text += button.Text;
            }


        }

        private void button16_Click(object sender, EventArgs e) // this is the addition button
        {
            if (tb_display.Text == "0")
            {
                tb_display.Text = "+";
            }
            else
            {
                tb_display.Text += "+";
            }
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            if (tb_display.Text == "0")
            {
                tb_display.Text = "-";
            }
            else
            {
                tb_display.Text += "-";
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (tb_display.Text == "0")
            {
                tb_display.Text = "×";
            }
            else
            {
                tb_display.Text += "×";
            }
        }

        private void button18_Click(object sender, EventArgs e) // this is the divide button
        {
            if (tb_display.Text == "0")
            {
                tb_display.Text = "/";
            }
            else
            {
                tb_display.Text += "/";
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            string Equal = tb_display.Text;
            if (Equal.Contains("++") || Equal.Contains("--") || Equal.Contains("+-") || Equal.Contains("-+"))
            {
                tb_display.Text = "ERROR";
            }
            else
            {
                try
                {
                    string expression = tb_display.Text.Replace("×", "*").Replace("%", "*0.01");
                    var result = new DataTable().Compute(expression, "");
                    tb_display.Text = Convert.ToDouble(result).ToString("G");
                }
                catch (Exception ex)
                {
                    tb_display.Text = "SYNTAX ERROR";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e) 
        {
    
            if (tb_display.Text.Contains("-"))
                {
                tb_display.Text = tb_display.Text.Trim('-');

            }else
            {
                tb_display.Text = "-" + tb_display.Text;
            }
        }

        private void AllClear_Click(object sender, EventArgs e)
        {
            tb_display.Text = "0";
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (tb_display.Text == "SYNTAX ERROR")
            {
                tb_display.Text = "0";
            }
            else if (tb_display.Text.Length > 0)
            {
                tb_display.Text = tb_display.Text.Substring(0, tb_display.Text.Length - 1);

                if (tb_display.Text.Length == 0)
                {
                    tb_display.Text = "0";
                }
            }
        }

        private void button12_click(object sender, EventArgs e)
        {

            if (!decpointint)
            {
                tb_display.Text += ".";
                decpointint = true;
            }
        }
    }
}