using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Geek_Crud_Tds07
{
    internal class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string nascimento { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }

        //Cadeia de conexão do Banco de Dados:
        SqlConnection conexao = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Loja-Geek-Crud-Tds07\\LojaGeekBD.mdf;Integrated Security=True");

        //Método Construtor:
        public List<Cliente> listaClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            string sql = "SELECT * FROM Cliente";
            conexao.Open();
            SqlCommand comandoSQL = new SqlCommand(sql, conexao);
            SqlDataReader leitorSQL = comandoSQL.ExecuteReader();
            while (leitorSQL.Read())
            {
                Cliente cliente = new Cliente();
                cliente.id = (int)leitorSQL["Id"];
                cliente.nome = leitorSQL["nome"].ToString();
                cliente.cpf = leitorSQL["cpf"].ToString();
                cliente.nascimento = leitorSQL["nascimento"].ToString();
                cliente.telefone = leitorSQL["telefone"].ToString();
                cliente.email = leitorSQL["email"].ToString();
                lista.Add(cliente);
            }
            leitorSQL.Close();
            conexao.Close();
            return lista;
        }

        //Método para cadastrar CLIENTE no banco de dados (CREATE):
        public void Inserir(string nome, string cpf, string nascimento, string telefone, string email)
        {
            string sql = "INSERT INTO Cliente (nome, cpf, nascimento, telefone, email) VALUES ('" + nome + "', '" + cpf + "', '" + nascimento + "', '" + telefone + "', '" + email + "')";
            conexao.Open();
            SqlCommand comandoSQL = new SqlCommand(sql, conexao);
            comandoSQL.ExecuteNonQuery();
            conexao.Close();
        }

        //Método para localizar o cadastro do CLIENTE no banco de dados (READ):
        public void Localizar(int id)
        {
            string sql = "SELECT * FROM Cliente WHERE id='" + id + "'";
            conexao.Open();
            SqlCommand comandoSQL = new SqlCommand(sql, conexao);
            SqlDataReader leitorSQL = comandoSQL.ExecuteReader();
            while (leitorSQL.Read())
            {
                nome = leitorSQL["nome"].ToString();
                cpf = leitorSQL["cpf"].ToString();
                nascimento = leitorSQL["nascimento"].ToString();
                telefone = leitorSQL["telefone"].ToString();
                email = leitorSQL["email"].ToString();
            }
            leitorSQL.Close();
            conexao.Close();
        }

        //Método para atualizar o cadastro do CLIENTE no banco de dados (UPDATE):
        public void Atualizar(int id, string nome, string cpf, string nascimento, string telefone, string email)
        {
            string sql = "UPDATE Cliente SET nome='" + nome + "', cpf='" + cpf + "', nascimento='" + nascimento + "', telefone='" + telefone + "', email='" + email + "' WHERE id='" + id + "'";
            conexao.Open();
            SqlCommand comandoSQL = new SqlCommand(sql, conexao);
            comandoSQL.ExecuteNonQuery();
            conexao.Close();
        }

        //Método para excluir o cadastro do CLIENTE no banco de dados (DELETE):
        public void Excluir(int id)
        {
            string sql = "DELETE FROM Cliente WHERE id='" + id + "'";
            conexao.Open();
            SqlCommand comandoSQL = new SqlCommand(sql, conexao);
            comandoSQL.ExecuteNonQuery();
            conexao.Close();
        }

        //Método para verificar se o CLIENTE já foi cadastrado (usando Nome e CPF):
        public bool RegistroRepetido(string nome, string cpf)
        {
            string sql = "SELECT * FROM Cliente WHERE nome='" + nome + "' AND cpf='" + cpf + "'";
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
