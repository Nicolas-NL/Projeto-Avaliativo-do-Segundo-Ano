
namespace WindowsFormsApp1
{
    partial class Form5
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbCadastro = new System.Windows.Forms.GroupBox();
            this.btnTemCad = new System.Windows.Forms.Button();
            this.txtRepSen = new System.Windows.Forms.TextBox();
            this.lblRepSen = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSobNom = new System.Windows.Forms.TextBox();
            this.lblSobNom = new System.Windows.Forms.Label();
            this.gpbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(71, 95);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(153, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 11;
            // 
            // gpbCadastro
            // 
            this.gpbCadastro.Controls.Add(this.btnTemCad);
            this.gpbCadastro.Controls.Add(this.txtRepSen);
            this.gpbCadastro.Controls.Add(this.lblRepSen);
            this.gpbCadastro.Controls.Add(this.txtEmail);
            this.gpbCadastro.Controls.Add(this.lblEmail);
            this.gpbCadastro.Controls.Add(this.txtSex);
            this.gpbCadastro.Controls.Add(this.lblSex);
            this.gpbCadastro.Controls.Add(this.txtIdade);
            this.gpbCadastro.Controls.Add(this.lblIdade);
            this.gpbCadastro.Controls.Add(this.txtSenha);
            this.gpbCadastro.Controls.Add(this.lblSenha);
            this.gpbCadastro.Controls.Add(this.txtSobNom);
            this.gpbCadastro.Controls.Add(this.lblSobNom);
            this.gpbCadastro.Controls.Add(this.txtNome);
            this.gpbCadastro.Controls.Add(this.lblNome);
            this.gpbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.gpbCadastro.Location = new System.Drawing.Point(191, 12);
            this.gpbCadastro.Name = "gpbCadastro";
            this.gpbCadastro.Size = new System.Drawing.Size(391, 411);
            this.gpbCadastro.TabIndex = 2;
            this.gpbCadastro.TabStop = false;
            this.gpbCadastro.Text = "Cadastro";
            this.gpbCadastro.Enter += new System.EventHandler(this.gpbCadastro_Enter);
            // 
            // btnTemCad
            // 
            this.btnTemCad.Location = new System.Drawing.Point(105, 347);
            this.btnTemCad.Name = "btnTemCad";
            this.btnTemCad.Size = new System.Drawing.Size(179, 41);
            this.btnTemCad.TabIndex = 14;
            this.btnTemCad.Text = "Terminar Cadastro";
            this.btnTemCad.UseVisualStyleBackColor = true;
            this.btnTemCad.Click += new System.EventHandler(this.btnTemCad_Click);
            // 
            // txtRepSen
            // 
            this.txtRepSen.Location = new System.Drawing.Point(153, 217);
            this.txtRepSen.Name = "txtRepSen";
            this.txtRepSen.Size = new System.Drawing.Size(100, 20);
            this.txtRepSen.TabIndex = 13;
            // 
            // lblRepSen
            // 
            this.lblRepSen.AutoSize = true;
            this.lblRepSen.Location = new System.Drawing.Point(60, 217);
            this.lblRepSen.Name = "lblRepSen";
            this.lblRepSen.Size = new System.Drawing.Size(95, 15);
            this.lblRepSen.TabIndex = 12;
            this.lblRepSen.Text = "Repita a Senha:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(153, 58);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(71, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(153, 293);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 20);
            this.txtSex.TabIndex = 9;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(71, 293);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(38, 15);
            this.lblSex.TabIndex = 8;
            this.lblSex.Text = "Sexo:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(153, 251);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 7;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(71, 251);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(41, 15);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "Idade:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(153, 179);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(71, 179);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 15);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSobNom
            // 
            this.txtSobNom.Location = new System.Drawing.Point(153, 135);
            this.txtSobNom.Name = "txtSobNom";
            this.txtSobNom.Size = new System.Drawing.Size(100, 20);
            this.txtSobNom.TabIndex = 3;
            // 
            // lblSobNom
            // 
            this.lblSobNom.AutoSize = true;
            this.lblSobNom.Location = new System.Drawing.Point(71, 135);
            this.lblSobNom.Name = "lblSobNom";
            this.lblSobNom.Size = new System.Drawing.Size(75, 15);
            this.lblSobNom.TabIndex = 2;
            this.lblSobNom.Text = "Sobrenome:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbCadastro);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.gpbCadastro.ResumeLayout(false);
            this.gpbCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gpbCadastro;
        private System.Windows.Forms.TextBox txtRepSen;
        private System.Windows.Forms.Label lblRepSen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSobNom;
        private System.Windows.Forms.Label lblSobNom;
        private System.Windows.Forms.Button btnTemCad;
    }
}