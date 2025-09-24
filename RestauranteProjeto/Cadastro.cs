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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            string senha = txbSenha.Text;
            string telefone = string.IsNullOrWhiteSpace(txbNumero.Text) ? null : txbNumero.Text;


            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Email e senha são obrigatórios!");
                return;
            }


            Database db = new Database();


            using (MySqlConnection conn = db.GetConexao())
            {
                try
                {
                    conn.Open();


                    // Verificar se o email já existe
                    string checkSql = "SELECT COUNT(*) FROM Usuarios WHERE Email=@Email";
                    MySqlCommand checkCmd = new MySqlCommand(checkSql, conn);
                    checkCmd.Parameters.AddWithValue("@Email", email);
                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());


                    if (exists > 0)
                    {
                        MessageBox.Show("Este email já está cadastrado!");
                        return;
                    }


                    // Inserir novo usuário
                    string insertSql = "INSERT INTO Usuarios (Email, Senha, Telefone) VALUES (@Email, @Senha, @Telefone)";
                    MySqlCommand insertCmd = new MySqlCommand(insertSql, conn);
                    insertCmd.Parameters.AddWithValue("@Email", email);
                    insertCmd.Parameters.AddWithValue("@Senha", senha);
                    insertCmd.Parameters.AddWithValue("@Telefone", (object)telefone ?? DBNull.Value);


                    int rows = insertCmd.ExecuteNonQuery();


                    if (rows > 0)
                    {
                        MessageBox.Show($"EMAIL {email} cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Fecha o formulário de cadastro e retorna ao Login
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar usuário.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na conexão: " + ex.Message);
                }
            }
        }
    }
 }
