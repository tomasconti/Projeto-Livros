using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Projeto_Livros.entidades;
using Projeto_Livros.funcoes;

namespace Projeto_Livros
{
    public partial class FrmLivro : Form
    {
        string stringConexao =
          "Server = localhost;" + "Database = Projeto-Livro; Port = 5432;" +
          "User ID = postgres; password = toti123;";
        private bool novoRegistro = false;
        NpgsqlConnection cn = new NpgsqlConnection();
        private Livro livro = new Livro();

        public FrmLivro()
        {
            InitializeComponent();
        }

        private void ResetaForm()
        {
            TxtId.Clear();
            TxtNome.Clear();
            TxtAutor.Clear();
            TxtEditora.Clear();
            TxtNome.Focus();
        }

        private void BtnVoltarL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostraTodos()
        {
            BtnNovoL.Enabled = true;
            btnGravarl.Enabled = true;
            BtnCancelarL.Enabled = true;
            btnExcluirL.Enabled = true;
            BtnVoltarL.Enabled = true;
            BtnPesquisarL.Enabled = true;
            TxtId.Enabled = true;
            TxtId.Focus();
        }

        private void MostraBotoes(bool novoRegistro)
        {
            TxtId.Enabled = !novoRegistro;
            BtnNovoL.Enabled = !novoRegistro;
            btnGravarl.Enabled = novoRegistro;
            BtnCancelarL.Enabled = novoRegistro;
            btnExcluirL.Enabled = !novoRegistro;
            BtnVoltarL.Enabled = novoRegistro;
            BtnPesquisarL.Enabled = !novoRegistro;

        }
        private void FrmLivro_Load(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = stringConexao;
                cn.OpenAsync();
                MostraTodos();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados! \n\n" + "\n\n Problema: " + ex.Message, "Cadastro de livros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnNovoL_Click(object sender, EventArgs e)
        {
            TxtNome.Enabled = true;
            TxtAutor.Enabled = true;
            TxtEditora.Enabled = true;
            ResetaForm();
            novoRegistro = true;
            MostraBotoes(true);
            livro = new Livro();
            TxtNome.Focus();
        }

        private void btnGravarl_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(TxtNome.Text))
                {
                    MessageBox.Show("Informe o nome do Livro!", "Cadastro de livro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNome.Focus();
                    return;

                }
                else if (String.IsNullOrEmpty(TxtAutor.Text))
                {
                    MessageBox.Show("Informe o nome do Autor!", "Cadastro de livro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNome.Focus();
                    return;

                }
                else if (String.IsNullOrEmpty(TxtEditora.Text))
                {
                    MessageBox.Show("Informe o nome da editora!", "Cadastro de livro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNome.Focus();
                    return;

                }
                else
                {
                    livro.Nome = TxtNome.Text;
                    livro.Autor = TxtAutor.Text;
                    livro.Editora = TxtEditora.Text;
                    Funcoes.SalvarLivro(livro);
                    MessageBox.Show("Livro salvo com sucesso!", "Cadastro de livros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetaForm();
                    novoRegistro = false;
                    MostraTodos();
                    TxtId.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os dados do livro" + "\n\nErro: " + ex.Message, "Cadastro de livros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCancelarL_Click(object sender, EventArgs e)
        {
            ResetaForm();
            MostraTodos();
        }

        private void BtnPesquisarL_Click(object sender, EventArgs e)
        {
            if (TxtId.Text != " ")
            {
                try
                {
                    livro = Funcoes.PesquisarLivro(TxtId.Text);
                    if (livro != null)
                    {
                        TxtNome.Text = livro.Nome;
                        TxtAutor.Text = livro.Autor;
                        TxtEditora.Text = livro.Editora;
                    }
                    else
                    {
                        MessageBox.Show("Livro não encontrado!", "Cadastro de livros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ResetaForm();
                        TxtId.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro na pesquisa do livro!" + "\n\nErro: " + ex.Message, "Cadastro de Livro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExcluirL_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNome.Text != " ")
                {
                    DialogResult resposta;
                    resposta = MessageBox.Show("Voce quer realmente excluir o livro " + TxtNome.Text + "?", "Cadastro de livros", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resposta == DialogResult.Yes)
                    {
                        Funcoes.ExcluirLivro(livro);
                        MessageBox.Show("O livro " + TxtNome.Text + " foi excluído com sucesso", "Cadastro de livros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetaForm();
                        MostraTodos();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o livro" + "\n\nErro: " + ex.Message, "Cadastro de livros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetaForm();
                MostraTodos();
            }
        }

        private void FrmLivro_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Quer mesmo sair do casdastro de livros?", "Cadastro de livros", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void btnHelp1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botao Gravar/Alterar: \n\n1) Para gravar um novo livro " +
             "basta inserir os dados (o id é opicional por se definir automaticamente), e apertar o botao" +
             "\n\n2) Ja para alterar, voce precisa pesquisar primeiro o id do livro" +
             "\n\n3) Depois da pesquisa, voce pode alterar as informacoes motradas na tela (menos o id), e apertar o botao");
        }

        private void btnHelp2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botao Pesquisar: \n\n1) Para pesquisar um livro " +
            "basta inserir seu ID e apertar o botao, assim as informacoes do livro vao aparecer nos campos");
        }

        private void btnHelp3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botao Excluir: \n\n1) Para excluir um livro " +
           "basta pesquisar o livro com o botao pesquisar, e depois das informacoes aparecerem apenas apertar o botao excluir");
        }

        private void btnHelp4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botao Clique para Iniciar: \n\n1) Esse botao facilita o cadastro " +
            "removendo o campo ID, que pode ser preenchido automaticamente");
        }
    }
    }

