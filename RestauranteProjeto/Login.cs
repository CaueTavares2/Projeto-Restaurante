using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace RestauranteProjeto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmarLogin_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            string senha = txbSenha.Text;

            Database db = new Database();

            using (MySqlConnection conn = db.GetConexao())
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT COUNT(*) FROM Usuarios WHERE Email=@Email AND Senha=@Senha";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                    if (resultado > 0)
                    {
                        // Login válido → abrir Form1
                        Form1 formPrincipal = new Form1();
                        formPrincipal.Show();

                        this.Hide(); // só esconde o login, não fecha
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha incorretos! Se não tiver cadastro, clique em Cadastrar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na conexão: " + ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Criar uma instância do Form1
            Form1 formPrincipal = new Form1();

            // Mostrar o Form1
            formPrincipal.Show();

            // Esconder o formulário atual
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Abrir cadastro sem fechar o Login
            Cadastro cadastroForm = new Cadastro();
            cadastroForm.ShowDialog(); // modal para o usuário terminar o cadastro antes de voltar ao Login

        }
    }
}
