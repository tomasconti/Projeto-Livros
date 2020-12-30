using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace Projeto_Livros
{
    public partial class FrmIntro : Form
    {
        public FrmIntro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
         
            FrmLivro livro = new FrmLivro();
            this.Hide();
            livro.ShowDialog();
            this.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmCadastro cadastro = new FrmCadastro();
            this.Hide();
            cadastro.ShowDialog();
            this.Show();
        }
    }
    } 
    

