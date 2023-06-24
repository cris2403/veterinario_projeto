



using MySql.Data.MySqlClient;

namespace veterinario_projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           string mysqlconn = "server=127.0.0.1;user=root;database=login;password=";
           MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            string username = textBoxUsername.Text.ToString();
            string password = textBoxPasword.Text.ToString();
                if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Não permitido campos em branco");
                }
                else
                {
                    mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand("select * from users", mySqlConnection);
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        if (username.Equals(reader.GetString("username")) && password.Equals(reader.GetString("password")))
                        {
                            MessageBox.Show("Login efetuado com sucesso");

                            PaginaInicial paginaInicial = new PaginaInicial();

                            paginaInicial.Show();

                            this.Hide();

                    }
                        else
                        {
                            MessageBox.Show("Login invalido");
                        }
                    }
                    mySqlConnection.Close();
                }

        }

        private void buttonRegisto_Click(object sender, EventArgs e)
        {
            Form2 registo = new Form2();

            registo.Show();

            this.Hide();

        }

        private void buttonLista_Click(object sender, EventArgs e)
        {
            ListarLogin ListarLogin = new ListarLogin();

            ListarLogin.Show();

            this.Hide();
        }
    }
}