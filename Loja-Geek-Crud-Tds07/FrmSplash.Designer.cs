namespace Loja_Geek_Crud_Tds07
{
    partial class FrmSplash
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
            this.lblLojaGeek = new System.Windows.Forms.Label();
            this.lblSenaiTds07 = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLojaGeek
            // 
            this.lblLojaGeek.AutoSize = true;
            this.lblLojaGeek.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLojaGeek.Location = new System.Drawing.Point(12, 374);
            this.lblLojaGeek.Name = "lblLojaGeek";
            this.lblLojaGeek.Size = new System.Drawing.Size(103, 17);
            this.lblLojaGeek.TabIndex = 0;
            this.lblLojaGeek.Text = "Geek Store v1.0";
            // 
            // lblSenaiTds07
            // 
            this.lblSenaiTds07.AutoSize = true;
            this.lblSenaiTds07.Location = new System.Drawing.Point(259, 374);
            this.lblSenaiTds07.Name = "lblSenaiTds07";
            this.lblSenaiTds07.Size = new System.Drawing.Size(129, 17);
            this.lblSenaiTds07.TabIndex = 1;
            this.lblSenaiTds07.Text = "SENAI TDS-07 (2022)";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::Loja_Geek_Crud_Tds07.Properties.Resources.logo;
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(376, 359);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblSenaiTds07);
            this.Controls.Add(this.lblLojaGeek);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLojaGeek;
        private Label lblSenaiTds07;
        private PictureBox pbxLogo;
    }
}