using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculadora
{
    public partial class Form1 : Form
    {
        decimal num1;
        decimal num2;
        decimal resultado;
        string operador;


        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum_Leave(object sender, EventArgs e)
        {
            txtNum.Focus();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNum.Text) || txtNum.Text == "0" || txtNum.Text == resultado.ToString())
            {
                txtNum.Text = "1";
            }

            else
            {
                txtNum.Text = txtNum.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNum.Text) || txtNum.Text == "0" || txtNum.Text == resultado.ToString())
            {
                txtNum.Text = "2";
            }

            else
            {
                txtNum.Text = txtNum.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNum.Text) || txtNum.Text == "0" || txtNum.Text == resultado.ToString())
            {
                txtNum.Text = "3";
            }

            else
            {
                txtNum.Text = txtNum.Text + "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNum.Text) || txtNum.Text == "0" || txtNum.Text == resultado.ToString())
            {
                txtNum.Text = "4";
            }

            else
            {
                txtNum.Text = txtNum.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNum.Text) || txtNum.Text == "0" || txtNum.Text == resultado.ToString())
            {
                txtNum.Text = "5";
            }

            else
            {
                txtNum.Text = txtNum.Text + "5";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNum.Text) || txtNum.Text == "0" || txtNum.Text == resultado.ToString())
            {
                txtNum.Text = "6";
            }

            else
            {
                txtNum.Text = txtNum.Text + "6";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNum.Text) || txtNum.Text == "0" || txtNum.Text == resultado.ToString())
            {
                txtNum.Text = "7";
            }

            else
            {
                txtNum.Text = txtNum.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNum.Text) || txtNum.Text == "0" || txtNum.Text == resultado.ToString())
            {
                txtNum.Text = "8";
            }

            else
            {
                txtNum.Text = txtNum.Text + "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNum.Text) || txtNum.Text == "0" || txtNum.Text == resultado.ToString())
            {
                txtNum.Text = "9";
            }

            else
            {
                txtNum.Text = txtNum.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNum.Text) || txtNum.Text == "0" || txtNum.Text == resultado.ToString())
            {
                txtNum.Text = "0";
            }

            else
            {
                txtNum.Text = txtNum.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNum.Text) || txtNum.Text == "0" || txtNum.Text == resultado.ToString())
            {
                txtNum.Text = "0,";
            }

            else
            {
                txtNum.Text = txtNum.Text + ",";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = "";
            txtNum.Text = "0";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(txtNum.Text);
            operador = "+";

            txtNum.Text = "0";
        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(txtNum.Text);
            operador = "-";


            txtNum.Text = "0";
        }
        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(txtNum.Text);
            operador = "*";

            txtNum.Text = "0";
        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(txtNum.Text);
            operador = "/";

            txtNum.Text = "0";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDecimal(txtNum.Text);
            
            calculo(num1, num2, operador);

            txtNum.Text = resultado.ToString();
            
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            string numErrado = txtNum.Text;
            string numNovo = txtNum.Text.Remove(numErrado.Length - 1);

            txtNum.Text = numNovo;

            if (String.IsNullOrEmpty(txtNum.Text))
            {
                txtNum.Text = "0";
            }
        }

        public decimal calculo(decimal n1, decimal n2, string operador)
        {
            if (operador == "+")
            {
                resultado = n1 + n2;
                return resultado;
            }
            if (operador == "-")
            {
                resultado = n1 - n2;
                return resultado;
            }
            if (operador == "/")
            {
                if (n2 == 0)
                {
                    MessageBox.Show("Impossivel divisão por 0");
                    return 0;
                }
                resultado = n1 / n2;
                return resultado;
            }
            if (operador == "*")
            {
                resultado = n1 * n2;
                return resultado;
            }
            return 0;
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {

            // le os numeros pelo teclado
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                button1_Click(null, null);
            }

            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                button2_Click(null, null);
            }

            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                button3_Click(null, null);
            }

            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                button6_Click(null, null);
            }

            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                button5_Click(null, null);
            }

            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                button4_Click(null, null);
            }

            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                button9_Click(null, null);
            }

            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                button8_Click(null, null);
            }

            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                button7_Click(null, null);
            }

            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                button10_Click(null, null);
            }

            if (e.KeyCode == Keys.Oemcomma)
            {
                button11_Click(null, null);
            }


            // le as operações pelo teclado

            if (e.KeyCode == Keys.Divide)
            {
                btnDivisao_Click(null, null);
            }

            if (e.KeyCode == Keys.Multiply)
            {
                btnMultiplicacao_Click(null, null);
            }

            if (e.KeyCode == Keys.Subtract)
            {
                btnSubtracao_Click(null, null);
            }

            if (e.KeyCode == Keys.Add)
            {
                btnAdicao_Click(null, null);
            }

            if (e.KeyCode == Keys.Return)
            { 
                btnResultado_Click(null, null);
            }

            if (e.KeyCode == Keys.Back)
            {
                btnBackSpace_Click(null, null);
            }
            //
        }

    }


    
}
