
namespace RestauranteProjeto
{
    partial class Cadastro
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
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbleEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestauranteProjeto.Properties.Resources.FundoOfertas;
            this.pictureBox1.Location = new System.Drawing.Point(240, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txbNumero
            // 
            this.txbNumero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbNumero.Location = new System.Drawing.Point(373, 259);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(159, 23);
            this.txbNumero.TabIndex = 26;
            this.txbNumero.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(285, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Telefone";
            // 
            // txbSenha
            // 
            this.txbSenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbSenha.Location = new System.Drawing.Point(373, 203);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(158, 23);
            this.txbSenha.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Senha";
            // 
            // lbleEmail
            // 
            this.lbleEmail.AutoSize = true;
            this.lbleEmail.BackColor = System.Drawing.Color.White;
            this.lbleEmail.Location = new System.Drawing.Point(293, 141);
            this.lbleEmail.Name = "lbleEmail";
            this.lbleEmail.Size = new System.Drawing.Size(36, 15);
            this.lbleEmail.TabIndex = 22;
            this.lbleEmail.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(373, 137);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(159, 23);
            this.txbEmail.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(373, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "CADASTRO";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Gold;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(350, 334);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 25);
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbleEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbleEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
    }
}