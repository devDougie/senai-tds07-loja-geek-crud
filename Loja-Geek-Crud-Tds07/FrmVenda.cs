using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Geek_Crud_Tds07
{
    public partial class FrmVenda : Form
    {
        //Cadeia de conexão do Banco de Dados:
        SqlConnection conexao = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Loja-Geek-Crud-Tds07\\LojaGeekBD.mdf;Integrated Security=True");

        public FrmVenda()
        {
            InitializeComponent();
        }

        //Método que carrega os clientes na ComboBox Cliente (FrmVenda):
        public void CarregacbxCliente()
        {
            string cliente = "SELECT id, nome FROM Cliente";
            SqlCommand comandoSQL = new SqlCommand(cliente, conexao);
            conexao.Open();
            comandoSQL.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cliente, conexao);
            DataSet ds = new DataSet();
            da.Fill(ds, "cliente");
            cbxCliente.ValueMember = "id";
            cbxCliente.DisplayMember = "nome";
            cbxCliente.DataSource = ds.Tables["cliente"];
            conexao.Close();
        }

        //Método que carrega os produtos na ComboBox Produto (FrmVenda):
        public void CarregacbxProduto()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
            string produto = "SELECT id, nome FROM Produto ORDER BY nome";
            SqlCommand comandoSQL = new SqlCommand(produto, conexao);
            conexao.Open();
            comandoSQL.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(produto, conexao);
            DataSet ds = new DataSet();
            da.Fill(ds, "produto");
            cbxProduto.ValueMember = "id";
            cbxProduto.DisplayMember = "nome";
            cbxProduto.DataSource = ds.Tables["produto"];
            conexao.Close();
        }

        //Método para evitar Estoque NEGATIVO;
        private void txbQuantidade_Leave(object sender, EventArgs e)
        {
            conexao.Open();
            SqlCommand comandoSQL = new SqlCommand("Quantidade_Produto", conexao);
            comandoSQL.Parameters.AddWithValue("@id", txbIdProduto.Text);
            comandoSQL.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = comandoSQL.ExecuteReader();
            int valor1 = 0;
            bool conversaoSucedida = int.TryParse(txbQuantidade.Text, out valor1);
            if (dr.Read())
            {
                int valor2 = Convert.ToInt32(dr["estoque"].ToString());
                if (valor1 > valor2)
                {
                    MessageBox.Show("Estoque insuficiente!");
                    txbQuantidade.Text = "";
                    txbQuantidade.Focus();
                }
            }
            dr.Close();
            conexao.Close();
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            CarregacbxCliente();
            cbxProduto.Enabled = false;
            txbIdProduto.Enabled = false;
            txbQuantidade.Enabled = false;
            txbValor.Enabled = false;
            txbTotal.Enabled = false;

            //Habilitar/Desabilitar botões:
            btnAtualizarPedido.Enabled = false;
            btnFinalizarPedido.Enabled = false;
            btnFinalizarVenda.Enabled = false;
            btnEditarItem.Enabled = false;
            btnAdicionarItem.Enabled = false;
            btnExcluirItem.Enabled = false;
        }

        //Evento clique para selecionar o cadastro direto do DataGridView Venda (FrmVenda):
        private void dgvVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvVenda.Rows[e.RowIndex];
            cbxProduto.Text = row.Cells[1].Value.ToString();
            txbIdProduto.Text = row.Cells[0].Value.ToString();
            txbQuantidade.Text = row.Cells[2].Value.ToString();
            txbValor.Text = row.Cells[3].Value.ToString();

            //Habilitar/desabilitar botões:
            btnEditarItem.Enabled = true;
            btnExcluirItem.Enabled = true;
        }

        //ComboBox Cliente (FrmVenda):
        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////
        }

        //ComboBox Produto (FrmVenda):
        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
            SqlCommand comandoSQL = new SqlCommand("SELECT * FROM Produto WHERE id=@id", conexao);
            comandoSQL.Parameters.AddWithValue("@id", cbxProduto.SelectedValue);
            comandoSQL.CommandType = CommandType.Text;
            conexao.Open();
            SqlDataReader leitorSQL = comandoSQL.ExecuteReader();
            if (leitorSQL.Read())
            {
                txbValor.Text = leitorSQL["valor"].ToString();
                txbIdProduto.Text = leitorSQL["id"].ToString();
                txbEstoque.Text = leitorSQL["estoque"].ToString();
                txbQuantidade.Focus();
            }
            leitorSQL.Close();
            conexao.Close();
        }

        //Botão Novo Pedido (FrmVenda):
        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            cbxProduto.Enabled = true;
            CarregacbxProduto();
            txbIdProduto.Enabled = true;
            txbQuantidade.Enabled = true;
            txbValor.Enabled = true;
            txbTotal.Enabled = true;

            //Habilitar/desabilitar botões:
            btnNovoPedido.Enabled = false;
            btnAtualizarPedido.Enabled = false;
            btnFinalizarPedido.Enabled = true;
            btnFinalizarVenda.Enabled = true;
            btnAdicionarItem.Enabled = true;
            btnEditarItem.Enabled = false;
            btnExcluirItem.Enabled = false;

            dgvVenda.Columns.Add("ID", "ID");
            dgvVenda.Columns.Add("Produto", "Produto");
            dgvVenda.Columns.Add("Quantidade", "Quantidade");
            dgvVenda.Columns.Add("Valor", "Valor");
            dgvVenda.Columns.Add("Total", "Total");
        }

        //Botão Atualizar Pedido (FrmVenda):
        private void btnAtualizarPedido_Click(object sender, EventArgs e)
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
            conexao.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Venda SET total=@total WHERE id=@id", conexao);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txbIdPedidoVenda.Text.Trim());
            cmd.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(txbTotal.Text.Trim());
            cmd.ExecuteNonQuery();

            SqlCommand deletarpedido = new SqlCommand("DELETE FROM ItensPedido WHERE id_venda=@id", conexao);
            deletarpedido.CommandType = CommandType.Text;
            deletarpedido.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txbIdPedidoVenda.Text.Trim());
            deletarpedido.ExecuteNonQuery();

            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                SqlCommand itens = new SqlCommand("InserirItensPedidos", conexao);
                itens.CommandType = CommandType.StoredProcedure;
                itens.Parameters.AddWithValue("@id_venda", SqlDbType.Int).Value = Convert.ToInt32(txbIdPedidoVenda.Text.Trim());
                itens.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                itens.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                itens.Parameters.AddWithValue("@valor_unitario", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[3].Value);
                itens.Parameters.AddWithValue("@valor_total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                itens.ExecuteNonQuery();
            }
            conexao.Close();
            MessageBox.Show("Pedido atualizado com sucesso!", "Atualizar pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvVenda.Columns.Clear();
            dgvVenda.Rows.Clear();
            txbIdPedidoVenda.Text = "";
            txbTotal.Text = "";
        }

        //Botão Localizar Pedido/Venda (FrmVenda):
        //*** Este botão só irá localizar apenas os pedidos que NÃO foram fechados!
        private void btnLocalizarPedidoVenda_Click(object sender, EventArgs e)
        {
            CarregacbxProduto();
            txbTotal.Text = "";
            dgvVenda.Columns.Clear();
            dgvVenda.Rows.Clear();
            conexao.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("VendaId", conexao);
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txbIdPedidoVenda.Text.Trim());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string venda = dt.Rows[0]["situacao"].ToString();
                int linhas = dt.Rows.Count;
                if (dt.Rows.Count > 0 && venda == "Aberta")
                {
                    conexao.Close();
                    conexao.Open();
                    SqlCommand pedido = new SqlCommand("LocalizarPedido", conexao);
                    pedido.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txbIdPedidoVenda.Text.Trim());
                    pedido.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ped = new SqlDataAdapter(pedido);
                    DataTable dtped = new DataTable();
                    ped.Fill(dtped);
                    int linhasped = dtped.Rows.Count;
                    if (dtped.Rows.Count > 0)
                    {
                        cbxCliente.Enabled = true;
                        cbxCliente.Text = "";
                        cbxCliente.Text = dtped.Rows[0]["nomecliente"].ToString();
                        txbTotal.Text = dtped.Rows[0]["total"].ToString();
                        cbxProduto.Enabled = true;
                        txbQuantidade.Enabled = true;
                        txbValor.Enabled = true;

                        //Habilitar/desabilitar botões:
                        btnAdicionarItem.Enabled = true;
                        btnEditarItem.Enabled = true;
                        btnExcluirItem.Enabled = true;
                        btnFinalizarVenda.Enabled = true;
                        btnNovoPedido.Enabled = false;
                        btnAtualizarPedido.Enabled = true;

                        dgvVenda.Columns.Add("ID", "ID");
                        dgvVenda.Columns.Add("Produto", "Produto");
                        dgvVenda.Columns.Add("Quantidade", "Quantidade");
                        dgvVenda.Columns.Add("Valor", "Valor");
                        dgvVenda.Columns.Add("Total", "Total");
                        for (int i = 0; i < linhasped; i++)
                        {
                            DataGridViewRow itemped = new DataGridViewRow();
                            itemped.CreateCells(dgvVenda);
                            itemped.Cells[0].Value = dtped.Rows[i]["id_produto"].ToString();
                            itemped.Cells[1].Value = dtped.Rows[i]["nomeproduto"].ToString();
                            itemped.Cells[2].Value = dtped.Rows[i]["quantidade"].ToString();
                            itemped.Cells[3].Value = dtped.Rows[i]["valor_unitario"].ToString();
                            itemped.Cells[4].Value = dtped.Rows[i]["valor_total"].ToString();
                            dgvVenda.Rows.Add(itemped);
                        }
                    }
                }
                else
                {
                    conexao.Close();
                    conexao.Open();
                    SqlCommand lvenda = new SqlCommand("LocalizarVendido", conexao);
                    lvenda.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txbIdPedidoVenda.Text.Trim());
                    lvenda.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ven = new SqlDataAdapter(lvenda);
                    DataTable dtven = new DataTable();
                    ven.Fill(dtven);
                    int linhasven = dtven.Rows.Count;
                    if (dtven.Rows.Count > 0)
                    {
                        cbxCliente.Enabled = true;
                        cbxCliente.Text = "";
                        cbxCliente.Text = dtven.Rows[0]["nomecliente"].ToString();
                        txbTotal.Text = dtven.Rows[0]["total"].ToString();
                        cbxProduto.Enabled = true;
                        txbQuantidade.Enabled = true;
                        txbValor.Enabled = true;

                        //Habilitar/desabilitar botões:
                        btnAdicionarItem.Enabled = true;
                        btnEditarItem.Enabled = true;
                        btnExcluirItem.Enabled = true;
                        btnFinalizarVenda.Enabled = true;
                        btnNovoPedido.Enabled = false;
                        btnAtualizarPedido.Enabled = true;

                        dgvVenda.Columns.Add("ID", "ID");
                        dgvVenda.Columns.Add("Produto", "Produto");
                        dgvVenda.Columns.Add("Quantidade", "Quantidade");
                        dgvVenda.Columns.Add("Valor", "Valor");
                        dgvVenda.Columns.Add("Total", "Total");
                        for (int i = 0; i < linhasven; i++)
                        {
                            DataGridViewRow itemven = new DataGridViewRow();
                            itemven.CreateCells(dgvVenda);
                            itemven.Cells[0].Value = dtven.Rows[i]["id_produto"].ToString();
                            itemven.Cells[1].Value = dtven.Rows[i]["nomeproduto"].ToString();
                            itemven.Cells[2].Value = dtven.Rows[i]["quantidade"].ToString();
                            itemven.Cells[3].Value = dtven.Rows[i]["valor_unitario"].ToString();
                            itemven.Cells[4].Value = dtven.Rows[i]["valor_total"].ToString();
                            dgvVenda.Rows.Add(itemven);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum pedido ou venda localizado com esta ID!", "Não localizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexao.Close();
        }

        //Botão Adicionar Item (FrmVenda):
        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            //Método para verificar se, o Item que será adicionado, já estava no Pedido;
            var repetido = false;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                if (txbIdProduto.Text == Convert.ToString(dr.Cells[0].Value))
                {
                    repetido = true;
                }
            }
            if (repetido == false)
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvVenda);
                item.Cells[0].Value = txbIdProduto.Text;
                item.Cells[1].Value = cbxProduto.Text;
                item.Cells[2].Value = txbQuantidade.Text;
                item.Cells[3].Value = txbValor.Text;
                item.Cells[4].Value = Convert.ToDecimal(txbValor.Text) * Convert.ToDecimal(txbQuantidade.Text);
                dgvVenda.Rows.Add(item);
                txbIdProduto.Text = "";
                txbValor.Text = "";
                txbQuantidade.Text = "";
                cbxProduto.Text = "";
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvVenda.Rows)
                    soma += Convert.ToDecimal(dr.Cells[4].Value);
                txbTotal.Text = Convert.ToString(soma);
            }
            else
            {
                MessageBox.Show("Produto já cadastrado!");
            }
        }

        //Botão Editar Item (FrmVenda):
        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            int linha = dgvVenda.CurrentRow.Index;
            dgvVenda.Rows[linha].Cells[0].Value = txbIdProduto.Text;
            dgvVenda.Rows[linha].Cells[1].Value = cbxProduto.Text;
            dgvVenda.Rows[linha].Cells[2].Value = txbQuantidade.Text;
            dgvVenda.Rows[linha].Cells[3].Value = txbValor.Text;
            dgvVenda.Rows[linha].Cells[4].Value = Convert.ToDecimal(txbValor.Text) * Convert.ToDecimal(txbQuantidade.Text);
            txbIdProduto.Text = "";
            txbValor.Text = "";
            txbQuantidade.Text = "";
            cbxProduto.Text = "";
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
                soma += Convert.ToDecimal(dr.Cells[4].Value);
            txbTotal.Text = Convert.ToString(soma);

            //Habilitar/desabilitar botões:
            btnEditarItem.Enabled = false;
            btnExcluirItem.Enabled = false;
        }

        //Botão Excluir Item (FrmVenda):
        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            int linha = dgvVenda.CurrentRow.Index;
            dgvVenda.Rows.RemoveAt(linha);
            dgvVenda.Refresh();
            txbIdProduto.Text = "";
            txbValor.Text = "";
            txbQuantidade.Text = "";
            cbxProduto.Text = "";
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
                soma += Convert.ToDecimal(dr.Cells[4].Value);
            txbTotal.Text = Convert.ToString(soma);

            //Habilitar/desabilitar botões:
            btnEditarItem.Enabled = false;
            btnExcluirItem.Enabled = false;
        }

        //Botão Finalizar Pedido (FrmVenda):
        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
            conexao.Open();
            SqlCommand cmd = new SqlCommand("InserirVenda", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_pessoa", SqlDbType.NChar).Value = cbxCliente.SelectedValue;
            cmd.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(txbTotal.Text);
            cmd.Parameters.AddWithValue("@data_venda", SqlDbType.Date).Value = DateTime.Now;
            cmd.Parameters.AddWithValue("@situacao", SqlDbType.NChar).Value = "Aberta";
            cmd.ExecuteNonQuery();
            string idvenda = "SELECT IDENT_CURRENT('Venda') AS id_venda";
            SqlCommand cmd2 = new SqlCommand(idvenda, conexao);
            Int32 idvenda2 = Convert.ToInt32(cmd2.ExecuteScalar());
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                SqlCommand cmditens = new SqlCommand("InserirItensPedidos", conexao);
                cmditens.CommandType = CommandType.StoredProcedure;
                cmditens.Parameters.AddWithValue("@id_venda", SqlDbType.Int).Value = idvenda2;
                cmditens.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                cmditens.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                cmditens.Parameters.AddWithValue("@valor_unitario", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[3].Value);
                cmditens.Parameters.AddWithValue("@valor_total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                cmditens.ExecuteNonQuery();
            }
            conexao.Close();
            dgvVenda.Rows.Clear();
            dgvVenda.Refresh();
            txbTotal.Text = "";
            MessageBox.Show("Pedido realizado com sucesso!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Botão Finalizar Venda (FrmVenda):
        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
            conexao.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Venda SET situacao = @situacao WHERE id=@id", conexao);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txbIdPedidoVenda.Text.Trim());
            cmd.Parameters.AddWithValue("@situacao", SqlDbType.NChar).Value = "Fechada";
            cmd.ExecuteNonQuery();
            SqlCommand deletarpedido = new SqlCommand("DELETE FROM ItensPedido WHERE id_venda=@id", conexao);
            deletarpedido.CommandType = CommandType.Text;
            deletarpedido.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txbIdPedidoVenda.Text.Trim());
            deletarpedido.ExecuteNonQuery();
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                SqlCommand itens = new SqlCommand("InserirItensVendidos", conexao);
                itens.CommandType = CommandType.StoredProcedure;
                itens.Parameters.AddWithValue("@id_venda", SqlDbType.Int).Value = Convert.ToInt32(txbIdPedidoVenda.Text.Trim());
                itens.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                itens.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                itens.Parameters.AddWithValue("@valor_unitario", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[3].Value);
                itens.Parameters.AddWithValue("@valor_total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                itens.ExecuteNonQuery();
            }
            conexao.Close();
            MessageBox.Show("Venda realizada com sucesso!", "Atualizar pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvVenda.Columns.Clear();
            dgvVenda.Rows.Clear();
            txbIdPedidoVenda.Text = "";
            txbTotal.Text = "";

            //Habilitar/desabilitar botões:
            btnFinalizarVenda.Enabled = false;
        }

        //Botão Limpar (FrmVenda):
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbxCliente.Text = "";
            cbxProduto.Text = "";
            txbIdPedidoVenda.Text = "";
            txbIdProduto.Text = "";
            txbQuantidade.Text = "";
            txbEstoque.Text = "";
            txbValor.Text = "";
            txbTotal.Text = "";

            //Habilitar/desabilitar botões:
            btnNovoPedido.Enabled = true;
            btnAtualizarPedido.Enabled = false;
            btnFinalizarPedido.Enabled = false;
            btnFinalizarVenda.Enabled = false;
            btnEditarItem.Enabled = false;
            btnAdicionarItem.Enabled = false;
            btnExcluirItem.Enabled = false;
        }

        //Botão Sair (FrmVenda):
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
