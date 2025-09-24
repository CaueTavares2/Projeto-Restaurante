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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(); // Certifique-se que Login.cs é o nome do Form
            loginForm.Show();


            // Opcional: esconder o Form atual
            this.Hide();
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
