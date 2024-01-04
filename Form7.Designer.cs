
namespace WindowsFormsApp1
{
    partial class Form7
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
            this.gpbInfPesso = new System.Windows.Forms.GroupBox();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLoja = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtSobNom = new System.Windows.Forms.TextBox();
            this.lblSobNom = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gpbInfPesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInfPesso
            // 
            this.gpbInfPesso.Controls.Add(this.btnLiberar);
            this.gpbInfPesso.Controls.Add(this.btnSair);
            this.gpbInfPesso.Controls.Add(this.btnLoja);
            this.gpbInfPesso.Controls.Add(this.btnApagar);
            this.gpbInfPesso.Controls.Add(this.txtSexo);
            this.gpbInfPesso.Controls.Add(this.lblSexo);
            this.gpbInfPesso.Controls.Add(this.txtIdade);
            this.gpbInfPesso.Controls.Add(this.lblIdade);
            this.gpbInfPesso.Controls.Add(this.txtSobNom);
            this.gpbInfPesso.Controls.Add(this.lblSobNom);
            this.gpbInfPesso.Controls.Add(this.txtNome);
            this.gpbInfPesso.Controls.Add(this.lblNome);
            this.gpbInfPesso.Location = new System.Drawing.Point(157, 60);
            this.gpbInfPesso.Name = "gpbInfPesso";
            this.gpbInfPesso.Size = new System.Drawing.Size(505, 327);
            this.gpbInfPesso.TabIndex = 0;
            this.gpbInfPesso.TabStop = false;
            this.gpbInfPesso.Text = "Informações Pessoais";
            this.gpbInfPesso.Enter += new System.EventHandler(this.gpbInfPesso_Enter);
            // 
            // btnLiberar
            // 
            this.btnLiberar.Location = new System.Drawing.Point(206, 137);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(104, 34);
            this.btnLiberar.TabIndex = 11;
            this.btnLiberar.Text = "Liberar";
            this.btnLiberar.UseVisualStyleBackColor = true;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Enabled = false;
            this.btnSair.Location = new System.Drawing.Point(337, 231);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 34);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLoja
            // 
            this.btnLoja.Enabled = false;
            this.btnLoja.Location = new System.Drawing.Point(206, 231);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(104, 34);
            this.btnLoja.TabIndex = 9;
            this.btnLoja.Text = "Loja";
            this.btnLoja.UseVisualStyleBackColor = true;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Enabled = false;
            this.btnApagar.Location = new System.Drawing.Point(68, 231);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(104, 34);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar Conta";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // txtSexo
            // 
            this.txtSexo.Enabled = false;
            this.txtSexo.Location = new System.Drawing.Point(109, 172);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(241, 20);
            this.txtSexo.TabIndex = 7;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(65, 175);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtIdade
            // 
            this.txtIdade.Enabled = false;
            this.txtIdade.Location = new System.Drawing.Point(109, 137);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(241, 20);
            this.txtIdade.TabIndex = 5;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(65, 140);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "Idade:";
            // 
            // txtSobNom
            // 
            this.txtSobNom.Enabled = false;
            this.txtSobNom.Location = new System.Drawing.Point(109, 102);
            this.txtSobNom.Name = "txtSobNom";
            this.txtSobNom.Size = new System.Drawing.Size(241, 20);
            this.txtSobNom.TabIndex = 3;
            // 
            // lblSobNom
            // 
            this.lblSobNom.AutoSize = true;
            this.lblSobNom.Location = new System.Drawing.Point(42, 105);
            this.lblSobNom.Name = "lblSobNom";
            this.lblSobNom.Size = new System.Drawing.Size(64, 13);
            this.lblSobNom.TabIndex = 2;
            this.lblSobNom.Text = "Sobrenome:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(109, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(241, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(65, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(12, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Visible = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.gpbInfPesso);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.gpbInfPesso.ResumeLayout(false);
            this.gpbInfPesso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInfPesso;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtSobNom;
        private System.Windows.Forms.Label lblSobNom;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.TextBox txtEmail;
    }
}