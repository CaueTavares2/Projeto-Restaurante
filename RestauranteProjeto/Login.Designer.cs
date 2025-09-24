
namespace RestauranteProjeto
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbleEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnConfirmarLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestauranteProjeto.Properties.Resources.FundoOfertas;
            this.pictureBox1.Location = new System.Drawing.Point(263, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "Início";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(347, 141);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(167, 23);
            this.txbEmail.TabIndex = 14;
            // 
            // lbleEmail
            // 
            this.lbleEmail.AutoSize = true;
            this.lbleEmail.BackColor = System.Drawing.Color.White;
            this.lbleEmail.Location = new System.Drawing.Point(275, 145);
            this.lbleEmail.Name = "lbleEmail";
            this.lbleEmail.Size = new System.Drawing.Size(36, 15);
            this.lbleEmail.TabIndex = 15;
            this.lbleEmail.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(272, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Senha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbSenha.Location = new System.Drawing.Point(347, 207);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(166, 23);
            this.txbSenha.TabIndex = 17;
            this.txbSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // btnConfirmarLogin
            // 
            this.btnConfirmarLogin.BackColor = System.Drawing.Color.Gold;
            this.btnConfirmarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirmarLogin.Location = new System.Drawing.Point(347, 327);
            this.btnConfirmarLogin.Name = "btnConfirmarLogin";
            this.btnConfirmarLogin.Size = new System.Drawing.Size(111, 38);
            this.btnConfirmarLogin.TabIndex = 18;
            this.btnConfirmarLogin.Text = "Confirmar";
            this.btnConfirmarLogin.UseVisualStyleBackColor = false;
            this.btnConfirmarLogin.Click += new System.EventHandler(this.btnConfirmarLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(267, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Telefone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbNumero
            // 
            this.txbNumero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbNumero.Location = new System.Drawing.Point(347, 263);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(167, 23);
            this.txbNumero.TabIndex = 20;
            this.txbNumero.UseSystemPasswordChar = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Gold;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(670, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 25);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmarLogin);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbleEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbleEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnConfirmarLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Button btnCadastrar;
    }
}