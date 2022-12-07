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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            List<Cliente> clientes = cliente.listaClientes();
            dgvCliente.DataSource = clientes;

            //Habilitar/desabilitar botões:
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        //Evento clique para selecionar o cadastro direto do DataGridView Cliente (FrmCliente):
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = this.dgvCliente.Rows[e.RowIndex];
                linha.Selected = true;
                txbId.Text = linha.Cells[0].Value.ToString();
                txbNome.Text = linha.Cells[1].Value.ToString();
                txbCpf.Text = linha.Cells[2].Value.ToString();
                txbNascimento.Text = linha.Cells[3].Value.ToString();
                txbTelefone.Text = linha.Cells[4].Value.ToString();
                txbEmail.Text = linha.Cells[5].Value.ToString();

                //Habilitar/desabilitar botões:
                btnAtualizar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCadastrar.Enabled = false;
            }
        }

        //Botão Cadastrar (FrmCliente):
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text == "" && txbCpf.Text == "" && txbTelefone.Text == "")
            {
                MessageBox.Show("Os campos Nome, CPF e Telefone são obrigatórios!");
                this.txbNome.Focus();
            }
            else
            {
                Cliente cliente = new Cliente();
                if (cliente.RegistroRepetido(txbNome.Text, txbCpf.Text) != false)
                {
                    MessageBox.Show("Este cliente já existe em nossa base de dados!");
                    this.txbNome.Focus();
                    txbNome.Text = "";
                    txbCpf.Text = "";
                    txbNascimento.Text = "";
                    txbTelefone.Text = "";
                    txbEmail.Text = "";
                }
                else
                {
                    cliente.Inserir(txbNome.Text, txbCpf.Text, txbNascimento.Text, txbTelefone.Text, txbEmail.Text);
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                    List<Cliente> clientes = cliente.listaClientes();
                    dgvCliente.DataSource = clientes;
                    txbNome.Text = "";
                    txbCpf.Text = "";
                    txbNascimento.Text = "";
                    txbTelefone.Text = "";
                    txbEmail.Text = "";
                }
            }
        }

        //Botão Localizar (FrmCliente):
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
                Cliente cliente = new Cliente();
                cliente.Localizar(id);
                txbNome.Text = cliente.nome;
                txbNascimento.Text = cliente.nascimento;
                txbCpf.Text = cliente.cpf;
                txbTelefone.Text = cliente.telefone;
                txbEmail.Text = cliente.email;

                //Habilitar/desabilitar botões:
                btnAtualizar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCadastrar.Enabled = false;
            }
        }

        //Botão Atualizar (FrmCliente):
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text == "" && txbCpf.Text == "" && txbTelefone.Text == "") //"IF" não funcionando!!!!!!!!!!
            {
                MessageBox.Show("Os campos Nome, CPF e Telefone não podem estar em branco!");
            }
            else
            {
                int id = Convert.ToInt32(txbId.Text.Trim());
                Cliente cliente = new Cliente();
                cliente.Atualizar(id, txbNome.Text, txbCpf.Text, txbNascimento.Text, txbTelefone.Text, txbEmail.Text);
                MessageBox.Show("Cliente atualizado com sucesso!");
                List<Cliente> clientes = cliente.listaClientes();
                dgvCliente.DataSource = clientes;
                txbId.Text = "";
                txbNome.Text = "";
                txbCpf.Text = "";
                txbNascimento.Text = "";
                txbTelefone.Text = "";
                txbEmail.Text = "";

                //Habilitar/desabilitar botões:
                btnAtualizar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        //Botão Excluir (FrmCliente):
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbId.Text.Trim());
            Cliente cliente = new Cliente();
            cliente.Excluir(id);
            MessageBox.Show("Cadastro excluído com sucesso!");
            List<Cliente> clientes = cliente.listaClientes();
            dgvCliente.DataSource = clientes;
            txbId.Text = "";
            txbNome.Text = "";
            txbCpf.Text = "";
            txbNascimento.Text = "";
            txbTelefone.Text = "";
            txbEmail.Text = "";

            //Habilitar/desabilitar botões:
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        //Botão Limpar (FrmCliente):
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbId.Text = "";
            txbNome.Text = "";
            txbCpf.Text = "";
            txbNascimento.Text = "";
            txbTelefone.Text = "";
            txbEmail.Text = "";

            //Habilitar/desabilitar botões:
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = true;
        }

        //Botão Sair (FrmCliente):
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
