namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ValidarDivisor(double divisor)
        {

            if (divisor == 0)
            {
                errorProvider1.SetError(tb_n2, "Divisor não pode ser zero.");
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
        }

        private void ler_valores(out double a, out double b)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(tb_n1.Text))
            {
                errorProvider1.SetError(tb_n1, "Campo obrigatório.");
                throw new Exception("O campo número 1 é obrigatório.");
            }

            if (string.IsNullOrWhiteSpace(tb_n2.Text))
            {
                errorProvider1.SetError(tb_n2, "Campo obrigatório.");
                throw new Exception("O campo número 2 é obrigatório.");
            }

            if (!double.TryParse(tb_n1.Text, out a))
            {
                errorProvider1.SetError(tb_n1, "Valor numérico inválido.");
                throw new Exception("O valor do número 1 é inválido.");
            }

            if (!double.TryParse(tb_n2.Text, out b))
            {
                errorProvider1.SetError(tb_n2, "Valor numérico inválido.");
                throw new Exception("O valor do número 2 é inválido.");
            }
        }
        private void btn_dividir_Click(object sender, EventArgs e)
        {
            try
            {
                ler_valores(out double a, out double b);
                ValidarDivisor(b);

                lb_resultado.Text = "Resultado: " + (a / b);
            }
            catch (FormatException ex)
            {
                lb_resultado.Text = "Erro: " + ex.Message;
            }
            catch (DivideByZeroException ex)
            {
                lb_resultado.Text = "Erro: " + ex.Message;
            }
            catch (Exception ex)
            {
                lb_resultado.Text = "Erro: " + ex.Message;
            }
        }
        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                ler_valores(out double a, out double b);

                lb_resultado.Text = "Resultado: " + (a + b);
            }
            catch (FormatException ex)
            {
                lb_resultado.Text = "Erro: " + ex.Message;
            }

            catch (Exception ex)
            {
                lb_resultado.Text = "Erro: " + ex.Message;
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                ler_valores(out double a, out double b);

                lb_resultado.Text = "Resultado: " + (a - b);
            }
            catch (FormatException ex)
            {
                lb_resultado.Text = "Erro: " + ex.Message;
            }

            catch (Exception ex)
            {
                lb_resultado.Text = "Erro: " + ex.Message;
            }
        }
    }
}
