namespace Loja_Geek_Crud_Tds07
{
    partial class FrmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenda));
            this.txbIdPedidoVenda = new System.Windows.Forms.TextBox();
            this.lblIdPedidoVenda = new System.Windows.Forms.Label();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLocalizarPedidoVenda = new System.Windows.Forms.Button();
            this.txbIdProduto = new System.Windows.Forms.TextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txbEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnAtualizarPedido = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblInvisivel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // txbIdPedidoVenda
            // 
            this.txbIdPedidoVenda.Location = new System.Drawing.Point(219, 170);
            this.txbIdPedidoVenda.Name = "txbIdPedidoVenda";
            this.txbIdPedidoVenda.Size = new System.Drawing.Size(150, 25);
            this.txbIdPedidoVenda.TabIndex = 30;
            // 
            // lblIdPedidoVenda
            // 
            this.lblIdPedidoVenda.AutoSize = true;
            this.lblIdPedidoVenda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdPedidoVenda.Location = new System.Drawing.Point(219, 150);
            this.lblIdPedidoVenda.Name = "lblIdPedidoVenda";
            this.lblIdPedidoVenda.Size = new System.Drawing.Size(117, 17);
            this.lblIdPedidoVenda.TabIndex = 29;
            this.lblIdPedidoVenda.Text = "ID Pedido/Venda:";
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(73, 91);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(503, 25);
            this.cbxProduto.TabIndex = 37;
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.cbxProduto_SelectedIndexChanged);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduto.Location = new System.Drawing.Point(12, 94);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(62, 17);
            this.lblProduto.TabIndex = 36;
            this.lblProduto.Text = "Produto:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(73, 29);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(503, 25);
            this.cbxCliente.TabIndex = 35;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.Location = new System.Drawing.Point(12, 32);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 17);
            this.lblCliente.TabIndex = 34;
            this.lblCliente.Text = "Cliente:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(633, 695);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 50);
            this.btnSair.TabIndex = 47;
            this.btnSair.Text = "Voltar para Menu";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarVenda.Location = new System.Drawing.Point(219, 695);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(150, 50);
            this.btnFinalizarVenda.TabIndex = 45;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarPedido.Location = new System.Drawing.Point(12, 695);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(150, 50);
            this.btnFinalizarPedido.TabIndex = 44;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(426, 715);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(150, 25);
            this.txbTotal.TabIndex = 49;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(426, 695);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(108, 17);
            this.lblTotal.TabIndex = 48;
            this.lblTotal.Text = "Valor Total (R$):";
            // 
            // dgvVenda
            // 
            this.dgvVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenda.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(12, 387);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.RowTemplate.Height = 25;
            this.dgvVenda.Size = new System.Drawing.Size(771, 305);
            this.dgvVenda.TabIndex = 50;
            this.dgvVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(633, 331);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 50);
            this.btnLimpar.TabIndex = 51;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLocalizarPedidoVenda
            // 
            this.btnLocalizarPedidoVenda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLocalizarPedidoVenda.Location = new System.Drawing.Point(426, 156);
            this.btnLocalizarPedidoVenda.Name = "btnLocalizarPedidoVenda";
            this.btnLocalizarPedidoVenda.Size = new System.Drawing.Size(150, 50);
            this.btnLocalizarPedidoVenda.TabIndex = 52;
            this.btnLocalizarPedidoVenda.Text = "Buscar ID Pedido/Venda";
            this.btnLocalizarPedidoVenda.UseVisualStyleBackColor = true;
            this.btnLocalizarPedidoVenda.Click += new System.EventHandler(this.btnLocalizarPedidoVenda_Click);
            // 
            // txbIdProduto
            // 
            this.txbIdProduto.Location = new System.Drawing.Point(12, 283);
            this.txbIdProduto.Name = "txbIdProduto";
            this.txbIdProduto.Size = new System.Drawing.Size(150, 25);
            this.txbIdProduto.TabIndex = 55;
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdProduto.Location = new System.Drawing.Point(12, 263);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(80, 17);
            this.lblIdProduto.TabIndex = 54;
            this.lblIdProduto.Text = "ID Produto:";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(219, 283);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(150, 25);
            this.txbQuantidade.TabIndex = 57;
            this.txbQuantidade.Leave += new System.EventHandler(this.txbQuantidade_Leave);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidade.Location = new System.Drawing.Point(219, 263);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(84, 17);
            this.lblQuantidade.TabIndex = 56;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(633, 283);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(150, 25);
            this.txbValor.TabIndex = 63;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(633, 263);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(126, 17);
            this.lblValor.TabIndex = 62;
            this.lblValor.Text = "Valor unitário (R$):";
            // 
            // txbEstoque
            // 
            this.txbEstoque.Location = new System.Drawing.Point(426, 283);
            this.txbEstoque.Name = "txbEstoque";
            this.txbEstoque.Size = new System.Drawing.Size(150, 25);
            this.txbEstoque.TabIndex = 65;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstoque.Location = new System.Drawing.Point(426, 263);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(115, 17);
            this.lblEstoque.TabIndex = 64;
            this.lblEstoque.Text = "Qtd. em estoque:";
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarItem.Location = new System.Drawing.Point(12, 331);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(150, 50);
            this.btnAdicionarItem.TabIndex = 66;
            this.btnAdicionarItem.Text = "Adicionar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarItem.Location = new System.Drawing.Point(219, 331);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(150, 50);
            this.btnEditarItem.TabIndex = 67;
            this.btnEditarItem.Text = "Editar Item";
            this.btnEditarItem.UseVisualStyleBackColor = true;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirItem.Location = new System.Drawing.Point(426, 331);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(150, 50);
            this.btnExcluirItem.TabIndex = 68;
            this.btnExcluirItem.Text = "Excluir Item";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnAtualizarPedido
            // 
            this.btnAtualizarPedido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizarPedido.Location = new System.Drawing.Point(633, 91);
            this.btnAtualizarPedido.Name = "btnAtualizarPedido";
            this.btnAtualizarPedido.Size = new System.Drawing.Size(150, 50);
            this.btnAtualizarPedido.TabIndex = 70;
            this.btnAtualizarPedido.Text = "Atualizar Pedido";
            this.btnAtualizarPedido.UseVisualStyleBackColor = true;
            this.btnAtualizarPedido.Click += new System.EventHandler(this.btnAtualizarPedido_Click);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoPedido.Location = new System.Drawing.Point(633, 29);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(150, 50);
            this.btnNovoPedido.TabIndex = 69;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = true;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // lblSeparador
            // 
            this.lblSeparador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeparador.Location = new System.Drawing.Point(12, 223);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(771, 2);
            this.lblSeparador.TabIndex = 73;
            this.lblSeparador.Text = "label1";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(12, 156);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(175, 39);
            this.lblAviso.TabIndex = 74;
            this.lblAviso.Text = "*A busca Pedido/Venda só irá \r\nlocalizar apenas os pedidos que \r\nNÃO foram fechad" +
    "os!";
            // 
            // lblInvisivel
            // 
            this.lblInvisivel.AutoSize = true;
            this.lblInvisivel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInvisivel.Location = new System.Drawing.Point(12, 748);
            this.lblInvisivel.Name = "lblInvisivel";
            this.lblInvisivel.Size = new System.Drawing.Size(0, 21);
            this.lblInvisivel.TabIndex = 75;
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(795, 572);
            this.Controls.Add(this.lblInvisivel);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.btnAtualizarPedido);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.btnExcluirItem);
            this.Controls.Add(this.btnEditarItem);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.txbEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txbIdProduto);
            this.Controls.Add(this.lblIdProduto);
            this.Controls.Add(this.btnLocalizarPedidoVenda);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txbIdPedidoVenda);
            this.Controls.Add(this.lblIdPedidoVenda);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geek Store - VENDAS";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbIdPedidoVenda;
        private Label lblIdPedidoVenda;
        private ComboBox cbxProduto;
        private Label lblProduto;
        private ComboBox cbxCliente;
        private Label lblCliente;
        private Button btnSair;
        private Button btnFinalizarVenda;
        private Button btnFinalizarPedido;
        private TextBox txbTotal;
        private Label lblTotal;
        private DataGridView dgvVenda;
        private Button btnLimpar;
        private Button btnLocalizarPedidoVenda;
        private TextBox txbIdProduto;
        private Label lblIdProduto;
        private TextBox txbQuantidade;
        private Label lblQuantidade;
        private TextBox txbValor;
        private Label lblValor;
        private TextBox txbEstoque;
        private Label lblEstoque;
        private Button btnAdicionarItem;
        private Button btnEditarItem;
        private Button btnExcluirItem;
        private Button btnAtualizarPedido;
        private Button btnNovoPedido;
        private Label lblSeparador;
        private Label lblAviso;
        private Label lblInvisivel;
    }
}