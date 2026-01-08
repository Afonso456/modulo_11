namespace Media_Nota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validarcampos()
        {
            if (string.IsNullOrEmpty(txt_valor1.Text))
            {
                errorProvider1.SetError(txt_valor1, "Campo obrigatorio");
                throw new Exception("O campo número 1 é obrigatório.");
            }
        }
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            public string media( get; set;);
            private void 

        }
    }
}
