namespace Projeto_Livros
{
    partial class FrmIntro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbltitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picLivro = new System.Windows.Forms.PictureBox();
            this.picSeta = new System.Windows.Forms.PictureBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeta)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbltitulo
            // 
            this.Lbltitulo.AutoSize = true;
            this.Lbltitulo.BackColor = System.Drawing.Color.LightBlue;
            this.Lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbltitulo.Location = new System.Drawing.Point(252, 50);
            this.Lbltitulo.Name = "Lbltitulo";
            this.Lbltitulo.Size = new System.Drawing.Size(230, 29);
            this.Lbltitulo.TabIndex = 0;
            this.Lbltitulo.Text = "Livraria Elementos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projeto_Livros.Properties.Resources.livro_certo;
            this.pictureBox2.Location = new System.Drawing.Point(44, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Livros.Properties.Resources.livro_certo;
            this.pictureBox1.Location = new System.Drawing.Point(519, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picLivro
            // 
            this.picLivro.Image = global::Projeto_Livros.Properties.Resources.Livroo;
            this.picLivro.Location = new System.Drawing.Point(539, 241);
            this.picLivro.Name = "picLivro";
            this.picLivro.Size = new System.Drawing.Size(58, 43);
            this.picLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLivro.TabIndex = 26;
            this.picLivro.TabStop = false;
            // 
            // picSeta
            // 
            this.picSeta.Image = global::Projeto_Livros.Properties.Resources.seta2;
            this.picSeta.Location = new System.Drawing.Point(603, 241);
            this.picSeta.Name = "picSeta";
            this.picSeta.Size = new System.Drawing.Size(58, 43);
            this.picSeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSeta.TabIndex = 25;
            this.picSeta.TabStop = false;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.LightBlue;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(381, 241);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(152, 43);
            this.btnCadastro.TabIndex = 24;
            this.btnCadastro.Text = "Cadastrar Livros";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.LightBlue;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(174, 241);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(152, 43);
            this.btnClientes.TabIndex = 27;
            this.btnClientes.Text = "Cadastrar Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // FrmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(770, 354);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.picLivro);
            this.Controls.Add(this.picSeta);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbltitulo);
            this.Name = "FrmIntro";
            this.Text = "Bem-Vindo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbltitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picLivro;
        private System.Windows.Forms.PictureBox picSeta;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnClientes;
    }
}

