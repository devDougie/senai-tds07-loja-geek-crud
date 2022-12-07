namespace Loja_Geek_Crud_Tds07
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pbxCliente = new System.Windows.Forms.PictureBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.pbxProduto = new System.Windows.Forms.PictureBox();
            this.lblVenda = new System.Windows.Forms.Label();
            this.pbxVenda = new System.Windows.Forms.PictureBox();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.lblSair = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(752, 546);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(31, 17);
            this.lblVersao.TabIndex = 0;
            this.lblVersao.Text = "v1.0";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.Location = new System.Drawing.Point(198, 249);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 17);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Clientes";
            // 
            // pbxCliente
            // 
            this.pbxCliente.BackColor = System.Drawing.Color.Silver;
            this.pbxCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCliente.Image = global::Loja_Geek_Crud_Tds07.Properties.Resources.cliente;
            this.pbxCliente.Location = new System.Drawing.Point(128, 46);
            this.pbxCliente.Name = "pbxCliente";
            this.pbxCliente.Size = new System.Drawing.Size(200, 200);
            this.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCliente.TabIndex = 2;
            this.pbxCliente.TabStop = false;
            this.pbxCliente.Click += new System.EventHandler(this.pbxCliente_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduto.Location = new System.Drawing.Point(535, 249);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(64, 17);
            this.lblProduto.TabIndex = 3;
            this.lblProduto.Text = "Produtos";
            // 
            // pbxProduto
            // 
            this.pbxProduto.BackColor = System.Drawing.Color.Silver;
            this.pbxProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxProduto.Image = global::Loja_Geek_Crud_Tds07.Properties.Resources.produto;
            this.pbxProduto.Location = new System.Drawing.Point(467, 46);
            this.pbxProduto.Name = "pbxProduto";
            this.pbxProduto.Size = new System.Drawing.Size(200, 200);
            this.pbxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProduto.TabIndex = 5;
            this.pbxProduto.TabStop = false;
            this.pbxProduto.Click += new System.EventHandler(this.pbxProduto_Click);
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVenda.Location = new System.Drawing.Point(203, 509);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(52, 17);
            this.lblVenda.TabIndex = 6;
            this.lblVenda.Text = "Vendas";
            // 
            // pbxVenda
            // 
            this.pbxVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxVenda.Image = global::Loja_Geek_Crud_Tds07.Properties.Resources.venda;
            this.pbxVenda.Location = new System.Drawing.Point(128, 306);
            this.pbxVenda.Name = "pbxVenda";
            this.pbxVenda.Size = new System.Drawing.Size(200, 200);
            this.pbxVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVenda.TabIndex = 7;
            this.pbxVenda.TabStop = false;
            this.pbxVenda.Click += new System.EventHandler(this.pbxVenda_Click);
            // 
            // pbxSair
            // 
            this.pbxSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSair.Image = global::Loja_Geek_Crud_Tds07.Properties.Resources.sair;
            this.pbxSair.Location = new System.Drawing.Point(467, 306);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(200, 200);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 8;
            this.pbxSair.TabStop = false;
            this.pbxSair.WaitOnLoad = true;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSair.Location = new System.Drawing.Point(551, 509);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(31, 17);
            this.lblSair.TabIndex = 9;
            this.lblSair.Text = "Sair";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(795, 572);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.pbxVenda);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.pbxProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.pbxCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblVersao);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geek Store - MENU";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblVersao;
        private Label lblCliente;
        private PictureBox pbxCliente;
        private Label lblProduto;
        private PictureBox pbxProduto;
        private Label lblVenda;
        private PictureBox pbxVenda;
        private PictureBox pbxSair;
        private Label lblSair;
    }
}