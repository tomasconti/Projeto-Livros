using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livros.entidades
{
    public class Clientes
    {
        private Int64 id_cliente;
        private string nome;
        private string email;
        private string cpf;

        public long Id_Cliente { get => id_cliente; set => id_cliente = value; }
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ApplicationException("Voce deve colocar o nome de usuario, tente novamente");
                else
                    nome = value;
            }

        }
        public string Email { get => email; set => email = value; }
        public string CPF { get => cpf; set => cpf = value; }
    }

    public class Livro
    {
        private Int64 id_livro;
        private string nome;
        private string autor;
        private string editora;

        public long Id_Livros { get => id_livro; set => id_livro = value; }
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ApplicationException("Voce deve colocar o nome de usuario, tente novamente");
                else
                    nome = value;
            }

        }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }
    }
}
