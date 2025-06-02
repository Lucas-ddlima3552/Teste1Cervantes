using Npgsql;

namespace CadastroLayout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text.Trim();
            string cpf = textBoxCPF.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Por favor, preencha o nome.");
                textBoxNome.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Por favor, preencha o CPF.");
                textBoxCPF.Focus();
                return;
            }

            if (!long.TryParse(cpf, out long cpfNum) || cpfNum <= 0)
            {
                MessageBox.Show("CPF deve conter apenas números e ser maior que zero.");
                textBoxCPF.Focus();
                return;
            }
            try
            {
                using (var conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=12345;Database=cadastrodb"))
                {
                    conn.Open();
                    string sql = "INSERT INTO cadastro (nome, cpf) VALUES (@nome, @cpf)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", nome);
                        cmd.Parameters.AddWithValue("cpf", cpfNum);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    textBoxNome.Clear();
                    textBoxCPF.Clear();
                    textBoxNome.Focus();
                }
            }
            catch (PostgresException pgEx) when (pgEx.SqlState == "23505") 
            {
                MessageBox.Show("CPF já cadastrado.");
                textBoxCPF.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }
    


    }
    }
