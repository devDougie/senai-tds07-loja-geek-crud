using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Geek_Crud_Tds07
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            List<Produto> produtos = produto.listaProdutos();
            dgvProduto.DataSource = produtos;

            //Habilitar/desabilitar botões:
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        //Evento clique para selecionar o cadastro direto do DataGridView Produto (FrmProduto):
        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = this.dgvProduto.Rows[e.RowIndex];
                linha.Selected = true;
                txbId.Text = linha.Cells[0].Value.ToString();
                txbNome.Text = linha.Cells[1].Value.ToString();
                txbDescricao.Text = linha.Cells[2].Value.ToString();
                txbFabricante.Text = linha.Cells[3].Value.ToString();
                txbEstoque.Text = linha.Cells[4].Value.ToString();
                txbValor.Text = linha.Cells[5].Value.ToString();

                //Habilitar/desabilitar botões:
                btnAtualizar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCadastrar.Enabled = false;
            }
        }

        //Botão Cadastrar (FrmProduto):
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text == "" && txbEstoque.Text == "" && txbValor.Text == "")
            {
                MessageBox.Show("Os campos Nome, Qtd. em Estoque e Valor são obrigatórios!!");
                this.txbNome.Focus();
            }
            else
            {
                Produto produto = new Produto();
                if (produto.RegistroRepetido(txbNome.Text, txbFabricante.Text) != false)
                {
                    MessageBox.Show("Este produto já existe em nossa base de dados!");
                    this.txbNome.Focus();
                    txbNome.Text = "";
                    txbDescricao.Text = "";
                    txbFabricante.Text = "";
                    txbEstoque.Text = "";
                    txbValor.Text = "";
                }
                else
                {
                    int estoque = Convert.ToInt32(txbEstoque.Text.Trim());
                    produto.Inserir(txbNome.Text, txbDescricao.Text, txbFabricante.Text, estoque, txbValor.Text);
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    List<Produto> produtos = produto.listaProdutos();
                    dgvProduto.DataSource = produtos;
                    txbNome.Text = "";
                    txbDescricao.Text = "";
                    txbFabricante.Text = "";
                    txbEstoque.Text = "";
                    txbValor.Text = "";
                }
            }
        }

        //Botão Localizar (FrmProduto):
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txbId.Text == "")
            {
                MessageBox.Show("Por favor digite um ID!");
                this.txbId.Focus();
            }
            else
            {
                int id = Convert.ToInt32(txbId.Text.Trim());
                Produto produto = new Produto();
                produto.Localizar(id);
                txbNome.Text = produto.nome;
                txbDescricao.Text = produto.descricao;
                txbFabricante.Text = produto.fabricante;
                txbEstoque.Text = produto.estoque.ToString();
                txbValor.Text = produto.valor.ToString();

                //Habilitar/desabilitar botões:
                btnAtualizar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCadastrar.Enabled = false;
            }
        }

        //Botão Atualizar (FrmProduto):
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text == "" && txbEstoque.Text == "" && txbValor.Text == "") //"IF" não funcionando!!!!!!!!!!
            {
                MessageBox.Show("Os campos Nome, Qtd. em Estoque e Valor não podem estar em branco!");
            }
            else
            {
                int id = Convert.ToInt32(txbId.Text.Trim());
                int quantidade = Convert.ToInt32(txbEstoque.Text.Trim());
                Produto produto = new Produto();
                produto.Atualizar(id, txbNome.Text, txbDescricao.Text, txbFabricante.Text, quantidade, txbValor.Text);
                MessageBox.Show("Produto atualizado com sucesso!");
                List<Produto> produtos = produto.listaProdutos();
                dgvProduto.DataSource = produtos;
                txbId.Text = "";
                txbNome.Text = "";
                txbDescricao.Text = "";
                txbFabricante.Text = "";
                txbEstoque.Text = "";
                txbValor.Text = "";

                //Habilitar/desabilitar botões:
                btnAtualizar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        //Botão Excluir (FrmProduto):
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbId.Text.Trim());
            Produto produto = new Produto();
            produto.Excluir(id);
            MessageBox.Show("Produto excluído com sucesso!");
            List<Produto> produtos = produto.listaProdutos();
            dgvProduto.DataSource = produtos;
            txbId.Text = "";
            txbNome.Text = "";
            txbDescricao.Text = "";
            txbFabricante.Text = "";
            txbEstoque.Text = "";
            txbValor.Text = "";

            //Habilitar/desabilitar botões:
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        //Botão Limpar (FrmProduto):
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbId.Text = "";
            txbNome.Text = "";
            txbDescricao.Text = "";
            txbFabricante.Text = "";
            txbEstoque.Text = "";
            txbValor.Text = "";

            //Habilitar/desabilitar botões:
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = true;
        }

        //Botão Sair (FrmProduto):
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
