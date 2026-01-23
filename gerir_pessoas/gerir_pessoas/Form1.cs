using System.Text.Json;

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
                MessageBox.Show("pessoa guardada com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao guardar pessoa: " + ex.Message);
            }
        }
        // Ler ficheiro TXT
        private void btn_lerT_Click(object sender, EventArgs e)
        {

            lst_pessoas.Items.Clear();

            try
            {
                using (StreamReader sr = new StreamReader("pessoas.txt"))
                {
                    string linha;

                    // Ler linha a linha
                    while ((linha = sr.ReadLine()) != null)
                    {
                        // Separar campos
                        string[] dados = linha.Split(',');

                        pessoa p = new pessoa(int.Parse(dados[0]), dados[1],
                            int.Parse(dados[2]), dados[3]);

                        lst_pessoas.Items.Add(p.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler ficheiros: " + ex.Message);
            }
        }

        //Guardar em ficheiros JSON
        private void btn_guardarJ_Click(object sender, EventArgs e)
        {
            try
            {
                pessoa p = new pessoa(int.Parse(txt_id.Text), txt_nome.Text,
                    int.Parse(txt_idade.Text), txt_email.Text);

                List<pessoa> pessoas = new List<pessoa>();

                //Se o ficheiro já existe, ler dados anteriores
                if (File.Exists("pessoas.json"))
                {
                    using (FileStream fs = new FileStream("pessoas.json", FileMode.Open))
                    {
                        pessoas = System.Text.Json.JsonSerializer.Deserialize<List<pessoa>>(fs);
                    }
                }

                pessoas.Add(p);

                // Guardar lista atualizada
                using (FileStream fs = new FileStream("pessoas.json", FileMode.Create))
                {
                    System.Text.Json.JsonSerializer.Serialize(fs, pessoas, new JsonSerializerOptions { WriteIndented = true });
                }

                MessageBox.Show("pessoa guardada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btn_lerJ_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("pessoas.json"))
                {
                    MessageBox.Show("Nenhum ficheiro encontrado.");
                    return;
                }
                using (FileStream fs = new FileStream("pessoas.json", FileMode.Open))
                {
                    List<pessoa> pessoas = JsonSerializer.Deserialize<List<pessoa>>(fs);

                    foreach (pessoa p in pessoas)
                    {
                        lst_pessoas.Items.Add(p.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void btn_maiores18_Click(object sender, EventArgs e)
        {
            lst_pessoas.Items.Clear();

            using (StreamReader sr = new StreamReader("pessoas.txt"))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] dados = linha.Split(";");
                    int idade = int.Parse(dados[2]);

                    if (idade == 18)
                    {
                        pessoa p = new pessoa(int.Parse(dados[0]), dados[1], idade, dados[3]);

                        lst_pessoas.Items.Add(p.ToString());

                    }
                }
            }
        }

        private void btn_converter_JT_Click(object sender, EventArgs e)
        {
            lst_pessoas.Items.Clear();

            List<pessoa> listapessoas = new List<pessoa>();

            using (StreamReader sr = new StreamReader("pessoas.json"))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] dados = linha.Split(";");

                    pessoa p = new pessoa(
                        int.Parse(dados[0]),
                        dados[1],
                        int.Parse(dados[2]),
                        dados[3]);
                    listapessoas.Add(p);
                    lst_pessoas.Items.Add(p.ToString());
                }
                using (FileStream fs = new FileStream("pessoas.txt", FileMode.Create))
                {
                    JsonSerializer.Serialize(fs, listapessoas, new JsonSerializerOptions { WriteIndented = true });
                }
            }
        }

        private void btn_converter_TJ_Click(object sender, EventArgs e)
        {
            lst_pessoas.Items.Clear();

            List<pessoa> listapessoas = new List<pessoa>();

            using (StreamReader sr = new StreamReader("pessoas.txt"))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] dados = linha.Split(";");

                    pessoa p = new pessoa(
                        int.Parse(dados[0]),
                        dados[1],
                        int.Parse(dados[2]),
                        dados[3]);
                    listapessoas.Add(p);
                    lst_pessoas.Items.Add(p.ToString());
                }
                using (FileStream fs = new FileStream("pessoas.json", FileMode.Create))
                {
                    JsonSerializer.Serialize(fs, listapessoas, new JsonSerializerOptions { WriteIndented = true });
                }
            }
        } 
        private void Form1_Load(object sender, EventArgs e)
        {
            lst_pessoas.Items.Clear();

            try
            {
                using(FileStream fs = new FileStream("pessoas.json", FileMode.Open))
                {
                    List<pessoa> pessoas = JsonSerializer.Deserialize<List<pessoa>>(fs);

                    foreach (pessoa p in pessoas)
                    {
                        lst_pessoas.Items.Add(p.ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não existem ficheiros criados" + ex.Message);
            }
        }
    }
}
