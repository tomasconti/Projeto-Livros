namespace Projeto_Livros
{
    partial class FrmLivro
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
            this.LblLivros = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblEditora = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.picseta1 = new System.Windows.Forms.PictureBox();
            this.picseta4 = new System.Windows.Forms.PictureBox();
            this.picseta3 = new System.Windows.Forms.PictureBox();
            this.picseta2 = new System.Windows.Forms.PictureBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtEditora = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.BtnNovoL = new System.Windows.Forms.Button();
            this.BtnPesquisarL = new System.Windows.Forms.Button();
            this.btnExcluirL = new System.Windows.Forms.Button();
            this.btnGravarl = new System.Windows.Forms.Button();
            this.BtnCancelarL = new System.Windows.Forms.Button();
            this.BtnVoltarL = new System.Windows.Forms.Button();
            this.btnHelp4 = new System.Windows.Forms.Button();
            this.btnHelp3 = new System.Windows.Forms.Button();
            this.btnHelp2 = new System.Windows.Forms.Button();
            this.btnHelp1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picseta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLivros
            // 
            this.LblLivros.AutoSize = true;
            this.LblLivros.BackColor = System.Drawing.Color.LightBlue;
            this.LblLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLivros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblLivros.Location = new System.Drawing.Point(197, 9);
            this.LblLivros.Name = "LblLivros";
            this.LblLivros.Size = new System.Drawing.Size(232, 29);
            this.LblLivros.TabIndex = 2;
            this.LblLivros.Text = "Cadastro de Livros";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.BackColor = System.Drawing.Color.LightBlue;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblId.Location = new System.Drawing.Point(26, 68);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(41, 25);
            this.LblId.TabIndex = 3;
            this.LblId.Text = "ID ";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.BackColor = System.Drawing.Color.LightBlue;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblNome.Location = new System.Drawing.Point(26, 114);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(72, 25);
            this.LblNome.TabIndex = 4;
            this.LblNome.Text = "Nome";
            // 
            // LblEditora
            // 
            this.LblEditora.AutoSize = true;
            this.LblEditora.BackColor = System.Drawing.Color.LightBlue;
            this.LblEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblEditora.Location = new System.Drawing.Point(26, 199);
            this.LblEditora.Name = "LblEditora";
            this.LblEditora.Size = new System.Drawing.Size(87, 25);
            this.LblEditora.TabIndex = 5;
            this.LblEditora.Text = "Editora";
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.BackColor = System.Drawing.Color.LightBlue;
            this.LblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblAutor.Location = new System.Drawing.Point(26, 156);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(68, 25);
            this.LblAutor.TabIndex = 6;
            this.LblAutor.Text = "Autor";
            // 
            // picseta1
            // 
            this.picseta1.Image = global::Projeto_Livros.Properties.Resources.Seta1;
            this.picseta1.Location = new System.Drawing.Point(123, 59);
            this.picseta1.Name = "picseta1";
            this.picseta1.Size = new System.Drawing.Size(79, 34);
            this.picseta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picseta1.TabIndex = 11;
            this.picseta1.TabStop = false;
            // 
            // picseta4
            // 
            this.picseta4.Image = global::Projeto_Livros.Properties.Resources.Seta1;
            this.picseta4.Location = new System.Drawing.Point(123, 190);
            this.picseta4.Name = "picseta4";
            this.picseta4.Size = new System.Drawing.Size(79, 34);
            this.picseta4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picseta4.TabIndex = 12;
            this.picseta4.TabStop = false;
            // 
            // picseta3
            // 
            this.picseta3.Image = global::Projeto_Livros.Properties.Resources.Seta1;
            this.picseta3.Location = new System.Drawing.Point(123, 147);
            this.picseta3.Name = "picseta3";
            this.picseta3.Size = new System.Drawing.Size(79, 34);
            this.picseta3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picseta3.TabIndex = 13;
            this.picseta3.TabStop = false;
            // 
            // picseta2
            // 
            this.picseta2.Image = global::Projeto_Livros.Properties.Resources.Seta1;
            this.picseta2.Location = new System.Drawing.Point(123, 105);
            this.picseta2.Name = "picseta2";
            this.picseta2.Size = new System.Drawing.Size(79, 34);
            this.picseta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picseta2.TabIndex = 14;
            this.picseta2.TabStop = false;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(235, 68);
            this.TxtId.Multiline = true;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(194, 25);
            this.TxtId.TabIndex = 15;
            // 
            // TxtEditora
            // 
            this.TxtEditora.Location = new System.Drawing.Point(235, 199);
            this.TxtEditora.Multiline = true;
            this.TxtEditora.Name = "TxtEditora";
            this.TxtEditora.Size = new System.Drawing.Size(194, 25);
            this.TxtEditora.TabIndex = 16;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(235, 156);
            this.TxtAutor.Multiline = true;
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(194, 25);
            this.TxtAutor.TabIndex = 17;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(235, 114);
            this.TxtNome.Multiline = true;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(194, 25);
            this.TxtNome.TabIndex = 18;
            // 
            // piclogo
            // 
            this.piclogo.Image = global::Projeto_Livros.Properties.Resources.livro_certo;
            this.piclogo.Location = new System.Drawing.Point(469, 59);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(175, 111);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 19;
            this.piclogo.TabStop = false;
            // 
            // BtnNovoL
            // 
            this.BtnNovoL.BackColor = System.Drawing.Color.LightBlue;
            this.BtnNovoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoL.Location = new System.Drawing.Point(235, 247);
            this.BtnNovoL.Name = "BtnNovoL";
            this.BtnNovoL.Size = new System.Drawing.Size(204, 43);
            this.BtnNovoL.TabIndex = 20;
            this.BtnNovoL.Text = "Clique para iniciar";
            this.BtnNovoL.UseVisualStyleBackColor = false;
            this.BtnNovoL.Click += new System.EventHandler(this.BtnNovoL_Click);
            // 
            // BtnPesquisarL
            // 
            this.BtnPesquisarL.BackColor = System.Drawing.Color.LightBlue;
            this.BtnPesquisarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisarL.Location = new System.Drawing.Point(1, 380);
            this.BtnPesquisarL.Name = "BtnPesquisarL";
            this.BtnPesquisarL.Size = new System.Drawing.Size(112, 30);
            this.BtnPesquisarL.TabIndex = 21;
            this.BtnPesquisarL.Text = "Pesquisar";
            this.BtnPesquisarL.UseVisualStyleBackColor = false;
            this.BtnPesquisarL.Click += new System.EventHandler(this.BtnPesquisarL_Click);
            // 
            // btnExcluirL
            // 
            this.btnExcluirL.BackColor = System.Drawing.Color.LightBlue;
            this.btnExcluirL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirL.Location = new System.Drawing.Point(167, 380);
            this.btnExcluirL.Name = "btnExcluirL";
            this.btnExcluirL.Size = new System.Drawing.Size(112, 30);
            this.btnExcluirL.TabIndex = 22;
            this.btnExcluirL.Text = "Excluir";
            this.btnExcluirL.UseVisualStyleBackColor = false;
            this.btnExcluirL.Click += new System.EventHandler(this.btnExcluirL_Click);
            // 
            // btnGravarl
            // 
            this.btnGravarl.BackColor = System.Drawing.Color.LightBlue;
            this.btnGravarl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarl.Location = new System.Drawing.Point(1, 322);
            this.btnGravarl.Name = "btnGravarl";
            this.btnGravarl.Size = new System.Drawing.Size(112, 30);
            this.btnGravarl.TabIndex = 23;
            this.btnGravarl.Text = "Gravar/Alterar";
            this.btnGravarl.UseVisualStyleBackColor = false;
            this.btnGravarl.Click += new System.EventHandler(this.btnGravarl_Click);
            // 
            // BtnCancelarL
            // 
            this.BtnCancelarL.BackColor = System.Drawing.Color.LightBlue;
            this.BtnCancelarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarL.Location = new System.Drawing.Point(167, 322);
            this.BtnCancelarL.Name = "BtnCancelarL";
            this.BtnCancelarL.Size = new System.Drawing.Size(112, 30);
            this.BtnCancelarL.TabIndex = 24;
            this.BtnCancelarL.Text = "Cancelar";
            this.BtnCancelarL.UseVisualStyleBackColor = false;
            this.BtnCancelarL.Click += new System.EventHandler(this.BtnCancelarL_Click);
            // 
            // BtnVoltarL
            // 
            this.BtnVoltarL.BackColor = System.Drawing.Color.LightBlue;
            this.BtnVoltarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarL.Location = new System.Drawing.Point(405, 322);
            this.BtnVoltarL.Name = "BtnVoltarL";
            this.BtnVoltarL.Size = new System.Drawing.Size(152, 43);
            this.BtnVoltarL.TabIndex = 26;
            this.BtnVoltarL.Text = "Voltar";
            this.BtnVoltarL.UseVisualStyleBackColor = false;
            this.BtnVoltarL.Click += new System.EventHandler(this.BtnVoltarL_Click);
            // 
            // btnHelp4
            // 
            this.btnHelp4.Location = new System.Drawing.Point(445, 257);
            this.btnHelp4.Name = "btnHelp4";
            this.btnHelp4.Size = new System.Drawing.Size(25, 25);
            this.btnHelp4.TabIndex = 27;
            this.btnHelp4.Text = "?";
            this.btnHelp4.UseVisualStyleBackColor = true;
            this.btnHelp4.Click += new System.EventHandler(this.btnHelp4_Click);
            // 
            // btnHelp3
            // 
            this.btnHelp3.Location = new System.Drawing.Point(285, 380);
            this.btnHelp3.Name = "btnHelp3";
            this.btnHelp3.Size = new System.Drawing.Size(25, 25);
            this.btnHelp3.TabIndex = 28;
            this.btnHelp3.Text = "?";
            this.btnHelp3.UseVisualStyleBackColor = true;
            this.btnHelp3.Click += new System.EventHandler(this.btnHelp3_Click);
            // 
            // btnHelp2
            // 
            this.btnHelp2.Location = new System.Drawing.Point(119, 380);
            this.btnHelp2.Name = "btnHelp2";
            this.btnHelp2.Size = new System.Drawing.Size(25, 25);
            this.btnHelp2.TabIndex = 29;
            this.btnHelp2.Text = "?";
            this.btnHelp2.UseVisualStyleBackColor = true;
            this.btnHelp2.Click += new System.EventHandler(this.btnHelp2_Click);
            // 
            // btnHelp1
            // 
            this.btnHelp1.Location = new System.Drawing.Point(119, 322);
            this.btnHelp1.Name = "btnHelp1";
            this.btnHelp1.Size = new System.Drawing.Size(25, 25);
            this.btnHelp1.TabIndex = 30;
            this.btnHelp1.Text = "?";
            this.btnHelp1.UseVisualStyleBackColor = true;
            this.btnHelp1.Click += new System.EventHandler(this.btnHelp1_Click);
            // 
            // FrmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 476);
            this.Controls.Add(this.btnHelp1);
            this.Controls.Add(this.btnHelp2);
            this.Controls.Add(this.btnHelp3);
            this.Controls.Add(this.btnHelp4);
            this.Controls.Add(this.BtnVoltarL);
            this.Controls.Add(this.BtnCancelarL);
            this.Controls.Add(this.btnGravarl);
            this.Controls.Add(this.btnExcluirL);
            this.Controls.Add(this.BtnPesquisarL);
            this.Controls.Add(this.BtnNovoL);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.TxtEditora);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.picseta2);
            this.Controls.Add(this.picseta3);
            this.Controls.Add(this.picseta4);
            this.Controls.Add(this.picseta1);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.LblEditora);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.LblLivros);
            this.Name = "FrmLivro";
            this.Text = "FrmLivro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLivro_FormClosing);
            this.Load += new System.EventHandler(this.FrmLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picseta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picseta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLivros;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblEditora;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.PictureBox picseta1;
        private System.Windows.Forms.PictureBox picseta4;
        private System.Windows.Forms.PictureBox picseta3;
        private System.Windows.Forms.PictureBox picseta2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtEditora;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Button BtnNovoL;
        private System.Windows.Forms.Button BtnPesquisarL;
        private System.Windows.Forms.Button btnExcluirL;
        private System.Windows.Forms.Button btnGravarl;
        private System.Windows.Forms.Button BtnCancelarL;
        private System.Windows.Forms.Button BtnVoltarL;
        private System.Windows.Forms.Button btnHelp4;
        private System.Windows.Forms.Button btnHelp3;
        private System.Windows.Forms.Button btnHelp2;
        private System.Windows.Forms.Button btnHelp1;
    }
}