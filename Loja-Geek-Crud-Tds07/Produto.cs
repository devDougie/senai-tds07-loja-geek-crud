using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Geek_Crud_Tds07
{
    internal class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string fabricante { get; set; }
        public int estoque { get; set; }
        public decimal valor { get; set; }

        //Cadeia de conexão do Banco de Dados:
        SqlConnection conexao = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Loja-Geek-Crud-Tds07\\LojaGeekBD.mdf;Integrated Security=True");

        //Método Construtor:
        public List<Produto> listaProdutos()
        {
            List<Produto> lista = new List<Produto>();
            string sql = "SELECT * FROM Produto";
            conexao.Open();
            SqlCommand comandoSQL = new SqlCommand(sql, conexao);
            SqlDataReader leitorSQL = comandoSQL.ExecuteReader();
            while (leitorSQL.Read())
            {
                Produto produto = new Produto();
                produto.id = (int)leitorSQL["id"];
                produto.nome = leitorSQL["nome"].ToString();
                produto.descricao = leitorSQL["descricao"].ToString();
                produto.fabricante = leitorSQL["fabricante"].ToString();
                produto.estoque = (int)leitorSQL["estoque"];
                produto.valor = (decimal)leitorSQL["valor"];
                lista.Add(produto);
            }
            leitorSQL.Close();
            conexao.Close();
            return lista;
        }

        //Método para cadastrar PRODUTO no banco de dados (CREATE):
        public void Inserir(string nome, string descricao, string fabricante, int estoque, string valor)
        {
            decimal final = Convert.ToDecimal(valor) / 100;
            string sql = "INSERT INTO Produto (nome, descricao, fabricante, estoque, valor) VALUES (@nome, @descricao, @fabricante, @estoque, @valor)";
            conexao.Open();
            SqlCommand comandoSQL = new SqlCommand(sql, conexao);
            comandoSQL.Parameters.Add("@nome", SqlDbType.NChar).Value = nome;
            comandoSQL.Parameters.Add("@descricao", SqlDbType.NChar).Value = descricao;
            comandoSQL.Parameters.Add("@fabricante", SqlDbType.NChar).Value = fabricante;
            comandoSQL.Parameters.Add("@estoque", SqlDbType.Int).Value = estoque;
            comandoSQL.Parameters.Add("@valor", SqlDbType.Decimal).Value = final;
            comandoSQL.ExecuteNonQuery();
            conexao.Close();
        }

        //Método para localizar o PRODUTO do cliente no banco de dados (READ):
        public void Localizar(int id)
        {
            string sql = "SELECT * FROM Produto WHERE id='" + id + "'";
            conexao.Open();
            SqlCommand comandoSQL = new SqlCommand(sql, conexao);
            SqlDataReader leitorSQL = comandoSQL.ExecuteReader();
            while (leitorSQL.Read())
            {
                nome = leitorSQL["nome"].ToString();
                descricao = leitorSQL["descricao"].ToString();
                fabricante = leitorSQL["fabricante"].ToString();
                estoque = (int)leitorSQL["estoque"];
                valor = (decimal)leitorSQL["valor"];
            }
            leitorSQL.Close();
            conexao.Close();
        }

        //Método para atualizar o cadastro do PRODUTO no banco de dados (UPDATE):
        public void Atualizar(int id, string nome, string descricao, string fabricante, int estoque, string valor)
        {
            decimal final = Convert.ToDecimal(valor) / 100;
            string sql = "UPDATE Produto SET nome=@nome, descricao=@descricao, fabricante=@fabricante, estoque=@estoque, valor=@valor WHERE id='" + id + "'";
            conexao.Open();
            SqlCommand comandoSQL = new SqlCommand(sql, conexao);
            comandoSQL.Parameters.Add("@nome", SqlDbType.NChar).Value = nome;
            comandoSQL.Parameters.Add("@descricao", SqlDbType.NChar).Value = descricao;
            comandoSQL.Parameters.Add("@fabricante", SqlDbType.NChar).Value = fabricante;
            comandoSQL.Parameters.Add("@estoque", SqlDbType.Int).Value = estoque;
            comandoSQL.Parameters.Add("@valor", SqlDbType.Decimal).Value = final;
            comandoSQL.ExecuteNonQuery();
            conexao.Close();
        }

        //Método para excluir o cadastro do PRODUTO no banco de dados (DELETE):
        public void Excluir(int id)
        {
            string sql = "DELETE FROM Produto WHERE id='" + id + "'";
            conexao.Open();
            SqlCommand comandoSQL = new SqlCommand(sql, conexao);
            comandoSQL.ExecuteNonQuery();
            conexao.Close();
        }

        //Método para verificar se o PRODUTO já foi cadastrado (usando o NOME):
        public bool RegistroRepetido(string nome, string fabricante)
        {
            string sql = "SELECT * FROM Produto WHERE nome='" + nome + "' AND fabricante='" + fabricante + "'";
            conexao.Open();
            SqlCommand comandoSQL = new SqlCommand(sql, conexao);
            comandoSQL.ExecuteNonQuery();
            var result = comandoSQL.ExecuteScalar();
            if (result != null)
            {
                return (int)result > 0;
            }
            conexao.Close();
            return false;
        }
    }
}
