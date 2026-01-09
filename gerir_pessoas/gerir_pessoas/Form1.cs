namespace gerir_pessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         //Guardar pessoas em ficheiro txt
        private void btn_guardat_Click(object sender, EventArgs e)
        {
            try
            {
                pessoa p = new pessoa(int.Parse(txt_id.Text), txt_nome.Text,
                    int.Parse(txt_idade.Text), txt_email.Text);
                using (StreamWriter sw = new StreamWriter("pessoas.txt", true))
                {
                    sw.WriteLine(p.ToString());
                }
                MessageBox.Show("Pessoa guardada com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar pessoa: " + ex.Message);
            }

        }
    }
}
