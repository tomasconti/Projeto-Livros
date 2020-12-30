namespace Projeto_Livros
{
    partial class FrmCadastro
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
            this.LblClientes = new System.Windows.Forms.Label();
            this.lblIdC = new System.Windows.Forms.Label();
            this.lblNomeC = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.txtIdC = new System.Windows.Forms.TextBox();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.BtnNovoC = new System.Windows.Forms.Button();
            this.btnCancelarC = new System.Windows.Forms.Button();
            this.btnGravarC = new System.Windows.Forms.Button();
            this.BtnPesquisarC = new System.Windows.Forms.Button();
            this.btnExcluirC = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picseta4 = new System.Windows.Forms.PictureBox();
            this.picseta3 = new System.Windows.Forms.PictureBox();
            this.picseta2 = new System.Windows.Forms.PictureBox();
            this.picseta1 = new System.Windows.Forms.PictureBox();
            this.btnajuda1 = new System.Windows.Forms.Button();
            this.btnajuda3 = new System.Windows.Forms.Button();
            this.btnajuda2 = new System.Windows.Forms.Button();
            this.btnajuda4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblClientes
            // 
            this.LblClientes.AutoSize = true;
            this.LblClientes.BackColor = System.Drawing.Color.LightBlue;
            this.LblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblClientes.Location = new System.Drawing.Point(196, 9);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Size = new System.Drawing.Size(258, 29);
            this.LblClientes.TabIndex = 1;
            this.LblClientes.Text = "Cadastro de Clientes";
            // 
            // lblIdC
            // 
            this.lblIdC.AutoSize = true;
            this.lblIdC.BackColor = System.Drawing.Color.LightBlue;
            this.lblIdC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdC.Location = new System.Drawing.Point(12, 86);
            this.lblIdC.Name = "lblIdC";
            this.lblIdC.Size = new System.Drawing.Size(41, 25);
            this.lblIdC.TabIndex = 2;
            this.lblIdC.Text = "ID ";
            // 
            // lblNomeC
            // 
            this.lblNomeC.AutoSize = true;
            this.lblNomeC.BackColor = System.Drawing.Color.LightBlue;
            this.lblNomeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomeC.Location = new System.Drawing.Point(12, 134);
            this.lblNomeC.Name = "lblNomeC";
            this.lblNomeC.Size = new System.Drawing.Size(72, 25);
            this.lblNomeC.TabIndex = 3;
            this.lblNomeC.Text = "Nome";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.Color.LightBlue;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblEmail.Location = new System.Drawing.Point(12, 181);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(70, 25);
            this.LblEmail.TabIndex = 4;
            this.LblEmail.Text = "Email";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.BackColor = System.Drawing.Color.LightBlue;
            this.LblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCpf.Location = new System.Drawing.Point(12, 228);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(57, 25);
            this.LblCpf.TabIndex = 5;
            this.LblCpf.Text = "CPF";
            // 
            // txtIdC
            // 
            this.txtIdC.Location = new System.Drawing.Point(184, 86);
            this.txtIdC.Multiline = true;
            this.txtIdC.Name = "txtIdC";
            this.txtIdC.Size = new System.Drawing.Size(194, 25);
            this.txtIdC.TabIndex = 6;
            // 
            // txtNomeC
            // 
            this.txtNomeC.Location = new System.Drawing.Point(184, 134);
            this.txtNomeC.Multiline = true;
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(194, 25);
            this.txtNomeC.TabIndex = 7;
            // 
            // TxtCpf
            // 
            this.TxtCpf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtCpf.Location = new System.Drawing.Point(184, 228);
            this.TxtCpf.Multiline = true;
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(194, 25);
            this.TxtCpf.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(184, 181);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 25);
            this.txtEmail.TabIndex = 9;
            // 
            // BtnNovoC
            // 
            this.BtnNovoC.BackColor = System.Drawing.Color.LightBlue;
            this.BtnNovoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoC.Location = new System.Drawing.Point(237, 274);
            this.BtnNovoC.Name = "BtnNovoC";
            this.BtnNovoC.Size = new System.Drawing.Size(204, 43);
            this.BtnNovoC.TabIndex = 15;
            this.BtnNovoC.Text = "Clique para iniciar";
            this.BtnNovoC.UseVisualStyleBackColor = false;
            this.BtnNovoC.Click += new System.EventHandler(this.BtnNovoC_Click);
            // 
            // btnCancelarC
            // 
            this.btnCancelarC.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarC.Location = new System.Drawing.Point(179, 339);
            this.btnCancelarC.Name = "btnCancelarC";
            this.btnCancelarC.Size = new System.Drawing.Size(112, 30);
            this.btnCancelarC.TabIndex = 16;
            this.btnCancelarC.Text = "Cancelar";
            this.btnCancelarC.UseVisualStyleBackColor = false;
            this.btnCancelarC.Click += new System.EventHandler(this.btCancelarC_Click);
            // 
            // btnGravarC
            // 
            this.btnGravarC.BackColor = System.Drawing.Color.LightBlue;
            this.btnGravarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarC.Location = new System.Drawing.Point(17, 339);
            this.btnGravarC.Name = "btnGravarC";
            this.btnGravarC.Size = new System.Drawing.Size(112, 30);
            this.btnGravarC.TabIndex = 17;
            this.btnGravarC.Text = "Gravar/Alterar";
            this.btnGravarC.UseVisualStyleBackColor = false;
            this.btnGravarC.Click += new System.EventHandler(this.btnGravarC_Click);
            // 
            // BtnPesquisarC
            // 
            this.BtnPesquisarC.BackColor = System.Drawing.Color.LightBlue;
            this.BtnPesquisarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisarC.Location = new System.Drawing.Point(17, 412);
            this.BtnPesquisarC.Name = "BtnPesquisarC";
            this.BtnPesquisarC.Size = new System.Drawing.Size(112, 30);
            this.BtnPesquisarC.TabIndex = 18;
            this.BtnPesquisarC.Text = "Pesquisar";
            this.BtnPesquisarC.UseVisualStyleBackColor = false;
            this.BtnPesquisarC.Click += new System.EventHandler(this.BtnPesquisarC_Click);
            // 
            // btnExcluirC
            // 
            this.btnExcluirC.BackColor = System.Drawing.Color.LightBlue;
            this.btnExcluirC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirC.Location = new System.Drawing.Point(179, 412);
            this.btnExcluirC.Name = "btnExcluirC";
            this.btnExcluirC.Size = new System.Drawing.Size(112, 30);
            this.btnExcluirC.TabIndex = 19;
            this.btnExcluirC.Text = "Excluir";
            this.btnExcluirC.UseVisualStyleBackColor = false;
            this.btnExcluirC.Click += new System.EventHandler(this.btnExcluirC_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.LightBlue;
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(434, 349);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(152, 43);
            this.BtnVoltar.TabIndex = 20;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Projeto_Livros.Properties.Resources.livro_certo;
            this.picLogo.Location = new System.Drawing.Point(479, 39);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(175, 111);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 14;
            this.picLogo.TabStop = false;
            // 
            // picseta4
            // 
            this.picseta4.Image = global::Projeto_Livros.Properties.Resources.Seta1;
            this.picseta4.Location = new System.Drawing.Point(90, 221);
            this.picseta4.Name = "picseta4";
            this.picseta4.Size = new System.Drawing.Size(79, 34);
            this.picseta4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picseta4.TabIndex = 13;
            this.picseta4.TabStop = false;
            // 
            // picseta3
            // 
            this.picseta3.Image = global::Projeto_Livros.Properties.Resources.Seta1;
            this.picseta3.Location = new System.Drawing.Point(90, 181);
            this.picseta3.Name = "picseta3";
            this.picseta3.Size = new System.Drawing.Size(79, 34);
            this.picseta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picseta3.TabIndex = 12;
            this.picseta3.TabStop = false;
            // 
            // picseta2
            // 
            this.picseta2.Image = global::Projeto_Livros.Properties.Resources.Seta1;
            this.picseta2.Location = new System.Drawing.Point(90, 125);
            this.picseta2.Name = "picseta2";
            this.picseta2.Size = new System.Drawing.Size(79, 34);
            this.picseta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picseta2.TabIndex = 11;
            this.picseta2.TabStop = false;
            // 
            // picseta1
            // 
            this.picseta1.Image = global::Projeto_Livros.Properties.Resources.Seta1;
            this.picseta1.Location = new System.Drawing.Point(90, 77);
            this.picseta1.Name = "picseta1";
            this.picseta1.Size = new System.Drawing.Size(79, 34);
            this.picseta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picseta1.TabIndex = 10;
            this.picseta1.TabStop = false;
            // 
            // btnajuda1
            // 
            this.btnajuda1.Location = new System.Drawing.Point(135, 339);
            this.btnajuda1.Name = "btnajuda1";
            this.btnajuda1.Size = new System.Drawing.Size(25, 25);
            this.btnajuda1.TabIndex = 21;
            this.btnajuda1.Text = "?";
            this.btnajuda1.UseVisualStyleBackColor = true;
            this.btnajuda1.Click += new System.EventHandler(this.btnajuda1_Click);
            // 
            // btnajuda3
            // 
            this.btnajuda3.Location = new System.Drawing.Point(297, 416);
            this.btnajuda3.Name = "btnajuda3";
            this.btnajuda3.Size = new System.Drawing.Size(25, 25);
            this.btnajuda3.TabIndex = 22;
            this.btnajuda3.Text = "?";
            this.btnajuda3.UseVisualStyleBackColor = true;
            this.btnajuda3.Click += new System.EventHandler(this.btnajuda3_Click);
            // 
            // btnajuda2
            // 
            this.btnajuda2.Location = new System.Drawing.Point(135, 412);
            this.btnajuda2.Name = "btnajuda2";
            this.btnajuda2.Size = new System.Drawing.Size(25, 25);
            this.btnajuda2.TabIndex = 23;
            this.btnajuda2.Text = "?";
            this.btnajuda2.UseVisualStyleBackColor = true;
            this.btnajuda2.Click += new System.EventHandler(this.btnajuda2_Click);
            // 
            // btnajuda4
            // 
            this.btnajuda4.Location = new System.Drawing.Point(447, 284);
            this.btnajuda4.Name = "btnajuda4";
            this.btnajuda4.Size = new System.Drawing.Size(25, 25);
            this.btnajuda4.TabIndex = 24;
            this.btnajuda4.Text = "?";
            this.btnajuda4.UseVisualStyleBackColor = true;
            this.btnajuda4.Click += new System.EventHandler(this.btnajuda4_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(666, 476);
            this.Controls.Add(this.btnajuda4);
            this.Controls.Add(this.btnajuda2);
            this.Controls.Add(this.btnajuda3);
            this.Controls.Add(this.btnajuda1);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.btnExcluirC);
            this.Controls.Add(this.BtnPesquisarC);
            this.Controls.Add(this.btnGravarC);
            this.Controls.Add(this.btnCancelarC);
            this.Controls.Add(this.BtnNovoC);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picseta4);
            this.Controls.Add(this.picseta3);
            this.Controls.Add(this.picseta2);
            this.Controls.Add(this.picseta1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.txtNomeC);
            this.Controls.Add(this.txtIdC);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.lblNomeC);
            this.Controls.Add(this.lblIdC);
            this.Controls.Add(this.LblClientes);
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastro_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblClientes;
        private System.Windows.Forms.Label lblIdC;
        private System.Windows.Forms.Label lblNomeC;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.TextBox txtIdC;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox picseta1;
        private System.Windows.Forms.PictureBox picseta2;
        private System.Windows.Forms.PictureBox picseta3;
        private System.Windows.Forms.PictureBox picseta4;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button BtnNovoC;
        private System.Windows.Forms.Button btnCancelarC;
        private System.Windows.Forms.Button btnGravarC;
        private System.Windows.Forms.Button BtnPesquisarC;
        private System.Windows.Forms.Button btnExcluirC;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button btnajuda1;
        private System.Windows.Forms.Button btnajuda3;
        private System.Windows.Forms.Button btnajuda2;
        private System.Windows.Forms.Button btnajuda4;
    }
}