namespace Media_Nota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validarcampos(double a, double b)
        {
            if (string.IsNullOrEmpty(txt_valor1.Text))
            {
                errorProvider1.SetError(txt_valor1, "Campo obrigatorio");
                throw new Exception("O campo número 1 é obrigatório.");
            }
            if (string.IsNullOrEmpty(txt_valor2.Text))
            {
                errorProvider1.SetError(txt_valor1, "Campo obrigatorio");
                throw new Exception("O campo número 2 é obrigatório.");
            }
        }

        private void ler_campos(out double a, out double b)
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txt_valor1.Text))
            {
                errorProvider1.SetError(txt_valor1, "Campo obrigatório.");
                throw new Exception("O campo número 1 é obrigatório.");
            }

            if (string.IsNullOrWhiteSpace(txt_valor2.Text))
            {
                errorProvider1.SetError(txt_valor2, "Campo obrigatório.");
                throw new Exception("O campo número 2 é obrigatório.");
            }

            if (!double.TryParse(txt_valor1.Text, out a))
            {
                errorProvider1.SetError(txt_valor1, "Valor numérico inválido.");
                throw new Exception("O valor do número 1 é inválido.");
            }

            if (!double.TryParse(txt_valor2.Text, out b))
            {
                errorProvider1.SetError(txt_valor2, "Valor numérico inválido.");
                throw new Exception("O valor do número 2 é inválido.");
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                ler_campos(out double a, out double b);
                validarcampos(a,b);

                lbl_resultado.Text = "Resultado:"+(a +b)/2;
            }
            catch (FormatException ex)
            {
                lbl_resultado.Text = "Erro: " + ex.Message;
            }
            catch (DivideByZeroException ex)
            {
                lbl_resultado.Text = "Erro: " + ex.Message;
            }
            catch (Exception ex)
            {
                lbl_resultado.Text = "Erro: " + ex.Message;
            }
        }
    }
}
