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
    public partial class FrmCadastro : Form
    {
        string stringConexao =
       "Server = localhost;" + "Database = Projeto-Livro; Port = 5432;" +
       "User ID = postgres; password = toti123;";
        private bool novoRegistro = false;
        NpgsqlConnection cn = new NpgsqlConnection();
        private Clientes clientes = new Clientes();

        public FrmCadastro()
        {
            InitializeComponent();
        }
        private void ResetaForm()
        {
            txtIdC.Clear();
            txtNomeC.Clear();
            txtEmail.Clear();
            TxtCpf.Clear();
            txtNomeC.Focus();
        }
        private void MostraBotoes(bool novoRegistro)
        {
            txtIdC.Enabled = !novoRegistro;
            BtnNovoC.Enabled = !novoRegistro;
            btnGravarC.Enabled = novoRegistro;
            btnCancelarC.Enabled = novoRegistro;
            btnExcluirC.Enabled = !novoRegistro;
            BtnVoltar.Enabled = novoRegistro;
            BtnPesquisarC.Enabled = !novoRegistro;

        }
        private void MostraTodos()
        {
            BtnNovoC.Enabled = true;
            btnGravarC.Enabled = true;
            btnCancelarC.Enabled = true;
            btnExcluirC.Enabled = true;
            BtnVoltar.Enabled = true;
            BtnPesquisarC.Enabled = true;
            txtIdC.Enabled = true;
            txtIdC.Focus();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancelarC_Click(object sender, EventArgs e)
        {
            ResetaForm();
            MostraTodos();
        }

        private void BtnNovoC_Click(object sender, EventArgs e)
        {
            txtNomeC.Enabled = true;
            txtEmail.Enabled = true;
            TxtCpf.Enabled = true;
            ResetaForm();
            novoRegistro = true;
            MostraBotoes(true);
            clientes = new Clientes();
            txtNomeC.Focus();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = stringConexao;
                cn.OpenAsync();
                MostraTodos();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados! \n\n" + "\n\n Erro: " + ex.Message, "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravarC_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNomeC.Text))
                {
                    MessageBox.Show("Informe o nome do Cliente!", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomeC.Focus();
                    return;

                }
                else if (String.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Informe o Email!", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomeC.Focus();
                    return;

                }
                else if (String.IsNullOrEmpty(TxtCpf.Text))
                {
                    MessageBox.Show("Deve ser informado o CPF!", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomeC.Focus();
                    return;

                }
                else
                {
                    clientes.Nome = txtNomeC.Text;
                    clientes.Email = txtEmail.Text;
                    clientes.CPF = TxtCpf.Text;
                    Funcoes.SalvarCliente(clientes);
                    MessageBox.Show("Cliente salvo com sucesso!", "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetaForm();
                    novoRegistro = false;
                    MostraTodos();
                    txtIdC.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os dados do cliente" + "\n\nErro: " + ex.Message, "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnPesquisarC_Click(object sender, EventArgs e)
        {
            if (txtIdC.Text != " ")
            {
                try
                {
                    clientes = Funcoes.PesquisarCliente(txtIdC.Text);
                    if (clientes != null)
                    {
                        txtNomeC.Text = clientes.Nome;
                        txtEmail.Text = clientes.Email;
                        TxtCpf.Text = clientes.CPF;
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado!", "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ResetaForm();
                        txtIdC.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro na pesquisa do clientes!" + "\n\nErro: " + ex.Message, "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExcluirC_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeC.Text != " ")
                {
                    DialogResult resposta;
                    resposta = MessageBox.Show("Deseja realmente excluir o cliente " + txtNomeC.Text + "?", "Cadastro de clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resposta == DialogResult.Yes)
                    {
                        Funcoes.ExcluirCliente(Convert.ToInt32(clientes.Id_Cliente));
                        MessageBox.Show("O usuário " + txtNomeC.Text + " foi excluído com sucesso", "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetaForm();
                        MostraTodos();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o cliente" + "\n\nErro: " + ex.Message, "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetaForm();
                MostraTodos();
            }
        }

        private void FrmCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Quer mesmo sair do casdastro de clientes?", "Cadastro de clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void btnajuda1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botao Gravar/Alterar: \n\n1) Para gravar um novo cliente " +
                "basta inserir seus dados (o id é opicional por se definir automaticamente), e apertar o botao" +
                "\n\n2) Ja para alterar, voce precisa pesquisar primeiro o id do usuario" +
                "\n\n3) Depois da pesquisa, voce pode alterar as informacoes motradas na tela (menos o id), e apertar o botao");
        }

        private void btnajuda2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botao Pesquisar: \n\n1) Para pesquisar um cliente " +
             "basta inserir seu ID e apertar o botao, assim as informacoes do cliente vao aparecer nos campos");
        }

        private void btnajuda3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botao Excluir: \n\n1) Para excluir um cliente " +
            "basta pesquisar o cliente com o botao pesquisar, e depois das informacoes aparecerem apenas apertar o botao excluir");
        }

        private void btnajuda4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botao Clique para Iniciar: \n\n1) Esse botao facilita o cadastro " +
            "removendo o campo ID, que pode ser preenchido automaticamente");
        }
    }
}
