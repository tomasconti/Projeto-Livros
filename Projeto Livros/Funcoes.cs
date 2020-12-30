using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Livros.entidades;
using Projeto_Livros.conecta;
using Npgsql;

namespace Projeto_Livros.funcoes
{
    public class Funcoes
    {
        private static Clientes objCliente(ref NpgsqlDataReader dr)
        {
            Clientes cli = new Clientes();
            cli.Id_Cliente = Convert.ToInt64(dr["id_cliente"]);
            cli.Nome = dr["nome"].ToString();
            cli.Email = dr["email"].ToString();
            cli.CPF = dr["Cpf"].ToString();
            return cli;
        }
        public static Clientes PesquisarCliente(string id_cliente)
        {
            Clientes cli = new Clientes();
            string sql = "select * from cliente where id_cliente = @1";
            List<object> param = new List<object>();
            param.Add(Convert.ToInt64(id_cliente));
            NpgsqlDataReader dr = Conexao.selecionar(sql, param);
            if (dr.Read())
            {
                cli = objCliente(ref dr);
            }
            else
            {
                cli = null;
            }
            dr.Close();
            return cli;
        }
        public static void SalvarCliente(Clientes cli)
        {
            string sql;
            List<object> param = new List<object>();
            param.Add(cli.Nome);
            param.Add(cli.Email);
            param.Add(cli.CPF);

            if (cli.Id_Cliente == 0)
            {
                sql = "insert into cliente (nome, email, cpf) values (@1, @2, @3)";
            }
            else
            {
                sql = "update cliente set nome = @1, email = @2, cpf = @3 where id_cliente = @4";
                param.Add(Convert.ToInt64(cli.Id_Cliente));
            }

            Conexao.executar(sql, param);

        }
        public static void ExcluirCliente(int id_cli)
        {
            string sql;
            if (id_cli != 0)
            {
                sql = "delete from cliente where id_cliente = @id_cliente";
                List<object> param = new List<object>();
                param.Add(id_cli);
                Conexao.executar(sql, param);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////

        private static Livro objLivro(ref NpgsqlDataReader dr)
        {
            Livro livro = new Livro();
            livro.Id_Livros = Convert.ToInt64(dr["id_livro"]);
            livro.Nome = dr["nome"].ToString();
            livro.Autor = dr["autor"].ToString();
            livro.Editora = dr["editora"].ToString();
            return livro;
        }
        public static Livro PesquisarLivro(string id_livro)
        {
            Livro livro = new Livro();
            string sql = "select * from livro where id_livro = @1";
            List<object> param = new List<object>();
            param.Add(Convert.ToInt64(id_livro));
            NpgsqlDataReader dr = Conexao.selecionar(sql, param);
            if (dr.Read())
            {
                livro = objLivro(ref dr);
            }
            else
            {
                livro = null;
            }
            dr.Close();
            return livro;
        }
        public static void SalvarLivro(Livro livro)
        {
            string sql;
            List<object> param = new List<object>();
            param.Add(livro.Nome);
            param.Add(livro.Autor);
            param.Add(livro.Editora);

            if (livro.Id_Livros == 0)
            {
                sql = "insert into livro (nome, autor, editora) values (@1, @2, @3)";
            }
            else
            {
                sql = "update livro set nome = @1, autor = @2, editora = @3 where id_livro = @4";
                param.Add(Convert.ToInt64(livro.Id_Livros));
            }

            Conexao.executar(sql, param);

        }
        public static void ExcluirLivro(Livro livro)
        {
            string sql;
            if (livro.Id_Livros != 0)
            {
                sql = "delete from livro where id_livro = @id_livro";
                List<object> param = new List<object>();
                param.Add(Convert.ToInt64(livro.Id_Livros));
                Conexao.executar(sql, param);
            }
        }
    }
}
