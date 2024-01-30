using System.Linq.Expressions;



namespace RafaForms
{
    public partial class Form1 : Form
    {
        decimal calculo;
        bool adicao = false;
        bool resultado = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Painel(object sender, EventArgs e)
        {

        }



        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Apagar = textBox1.Text;
                Apagar = Apagar.Remove(Apagar.Length - 1);
                textBox1.Text = Apagar;


            }
            catch (Exception)
            {
                MessageBox.Show("Não possui valor para exclusão");
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (subtracao == true)
                {
                    double valor1 = Convert.ToDouble(calculo);
                    double porcentagem = Convert.ToDouble(textBox1.Text) / 100;
                    textBox1.Text = Convert.ToString(valor1 - (porcentagem * valor1));

                }
            }
            catch (Exception) { }

            if (adicao == true)
            {
                try
                {
                    double valor1 = Convert.ToDouble(calculo);
                    double porcentagem = Convert.ToDouble(textBox1.Text) / 100;
                    textBox1.Text = Convert.ToString(valor1 + (porcentagem * valor1));
                }
                catch (Exception)
                {

                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = decimal.Parse(textBox1.Text);
                textBox1.Text += "+";
                textBox1.Text = "";

                adicao = true;
                subtracao = false;
                multiplicacao = false;
                divisao = false;


            }
            catch (Exception) { }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {

                resultado = true;
                if (adicao == true)
                {
                    textBox1.Text = Convert.ToString(Convert.ToDecimal(textBox1.Text)
                        + calculo);
                    textBox1.Text = textBox1.Text;
                }
                if (subtracao == true)
                {
                    textBox1.Text = Convert.ToString(calculo - Convert.ToDecimal
                        (textBox1.Text));
                }
                if (divisao == true)
                {
                    try
                    {
                        textBox1.Text = Convert.ToString(calculo / decimal.Parse(textBox1.Text));

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não é possível dividir por zero");
                        textBox1.Text = "";
                    }
                }
                if (multiplicacao == true)
                {
                    textBox1.Text = Convert.ToString(decimal.Parse(textBox1.Text) * calculo);
                    
                }
            }

            catch (Exception) { }
        }



        private void button15_Click(object sender, EventArgs e)

        {
            try

            {
                subtracao = true;
                calculo = decimal.Parse(textBox1.Text);
                textBox1.Text = "";
                adicao = false;
                subtracao = true;
                multiplicacao = false;
                divisao = false;
            }
            catch (Exception) { }
        }

        private void num1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button19_Click(object sender, EventArgs e)

        {
            try
            {

                calculo = decimal.Parse(textBox1.Text);
                textBox1.Text = "";
                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = true;
            }
            catch (Exception) { }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = decimal.Parse(textBox1.Text);
                textBox1.Text = "";
                adicao = false;
                subtracao = false;
                multiplicacao = true;
                divisao = false;
            }
            catch (Exception)
            { }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double x = Convert.ToDouble(textBox1.Text);
                    if (x <= 0)
                    {
                        MessageBox.Show("Não é possível obter a raiz de zero");
                    }
                    else
                    {
                        x = Math.Sqrt(x);
                        textBox1.Text = x.ToString();
                    }
                }
                catch (Exception) { }
            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}



