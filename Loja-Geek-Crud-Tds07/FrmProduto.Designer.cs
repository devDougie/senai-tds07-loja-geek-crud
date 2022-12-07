namespace Loja_Geek_Crud_Tds07
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.lblSeparador = new System.Windows.Forms.Label();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.txbFabricante = new System.Windows.Forms.TextBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txbEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeparador
            // 
            this.lblSeparador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeparador.Location = new System.Drawing.Point(12, 171);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(771, 2);
            this.lblSeparador.TabIndex = 45;
            this.lblSeparador.Text = "label1";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(12, 255);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.RowTemplate.Height = 25;
            this.dgvProduto.Size = new System.Drawing.Size(771, 305);
            this.dgvProduto.TabIndex = 44;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(633, 199);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 50);
            this.btnSair.TabIndex = 43;
            this.btnSair.Text = "Voltar para Menu";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txbFabricante
            // 
            this.txbFabricante.Location = new System.Drawing.Point(633, 61);
            this.txbFabricante.Name = "txbFabricante";
            this.txbFabricante.Size = new System.Drawing.Size(150, 25);
            this.txbFabricante.TabIndex = 42;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFabricante.Location = new System.Drawing.Point(633, 41);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(76, 17);
            this.lblFabricante.TabIndex = 41;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(633, 134);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(150, 25);
            this.txbValor.TabIndex = 40;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(633, 114);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(136, 17);
            this.lblValor.TabIndex = 39;
            this.lblValor.Text = "Valor unitário R$ (*):";
            // 
            // txbEstoque
            // 
            this.txbEstoque.Location = new System.Drawing.Point(426, 134);
            this.txbEstoque.Name = "txbEstoque";
            this.txbEstoque.Size = new System.Drawing.Size(150, 25);
            this.txbEstoque.TabIndex = 38;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstoque.Location = new System.Drawing.Point(426, 114);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(135, 17);
            this.lblEstoque.TabIndex = 37;
            this.lblEstoque.Text = "Qtd. em estoque (*):";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Location = new System.Drawing.Point(426, 199);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 50);
            this.btnExcluir.TabIndex = 36;
            this.btnExcluir.Text = "Excluir Cadastro";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizar.Location = new System.Drawing.Point(219, 199);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(150, 50);
            this.btnAtualizar.TabIndex = 35;
            this.btnAtualizar.Text = "Atualizar Cadastro";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(12, 199);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(150, 50);
            this.btnCadastrar.TabIndex = 34;
            this.btnCadastrar.Text = "Cadastrar Produto";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(219, 109);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 50);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(426, 61);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(150, 25);
            this.txbDescricao.TabIndex = 32;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.Location = new System.Drawing.Point(426, 41);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(76, 17);
            this.lblDescricao.TabIndex = 31;
            this.lblDescricao.Text = "Drescrição:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(219, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(69, 17);
            this.lblNome.TabIndex = 30;
            this.lblNome.Text = "Nome (*):";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(219, 61);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(150, 25);
            this.txbNome.TabIndex = 29;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(12, 61);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(150, 25);
            this.txbId.TabIndex = 28;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(12, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 17);
            this.lblId.TabIndex = 27;
            this.lblId.Text = "ID:";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLocalizar.Location = new System.Drawing.Point(12, 109);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(150, 50);
            this.btnLocalizar.TabIndex = 26;
            this.btnLocalizar.Text = "Buscar ID";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(12, 9);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(132, 13);
            this.lblAviso.TabIndex = 47;
            this.lblAviso.Text = "(*) Campos obrigatórios!";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(795, 572);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txbFabricante);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txbEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnLocalizar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geek Store - PRODUTOS";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSeparador;
        private DataGridView dgvProduto;
        private Button btnSair;
        private TextBox txbFabricante;
        private Label lblFabricante;
        private TextBox txbValor;
        private Label lblValor;
        private TextBox txbEstoque;
        private Label lblEstoque;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnCadastrar;
        private Button btnLimpar;
        private TextBox txbDescricao;
        private Label lblDescricao;
        private Label lblNome;
        private TextBox txbNome;
        private TextBox txbId;
        private Label lblId;
        private Button btnLocalizar;
        private Label lblAviso;
    }
}