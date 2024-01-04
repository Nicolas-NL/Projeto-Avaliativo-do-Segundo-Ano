
namespace WindowsFormsApp1
{
    partial class Form8
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
            this.gpbApagCont = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnConf = new System.Windows.Forms.Button();
            this.lblRedSen = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtSobNom = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gpbApagCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbApagCont
            // 
            this.gpbApagCont.Controls.Add(this.label2);
            this.gpbApagCont.Controls.Add(this.txtSenha);
            this.gpbApagCont.Controls.Add(this.btnConf);
            this.gpbApagCont.Controls.Add(this.lblRedSen);
            this.gpbApagCont.Controls.Add(this.txtNome);
            this.gpbApagCont.Controls.Add(this.lblSex);
            this.gpbApagCont.Controls.Add(this.lblNome);
            this.gpbApagCont.Controls.Add(this.txtSex);
            this.gpbApagCont.Controls.Add(this.txtSobNom);
            this.gpbApagCont.Controls.Add(this.lblIdade);
            this.gpbApagCont.Controls.Add(this.label1);
            this.gpbApagCont.Controls.Add(this.txtIdade);
            this.gpbApagCont.Location = new System.Drawing.Point(145, 49);
            this.gpbApagCont.Name = "gpbApagCont";
            this.gpbApagCont.Size = new System.Drawing.Size(511, 353);
            this.gpbApagCont.TabIndex = 10;
            this.gpbApagCont.TabStop = false;
            this.gpbApagCont.Text = "Apagar a Conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 226);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(228, 223);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 10;
            // 
            // btnConf
            // 
            this.btnConf.Location = new System.Drawing.Point(126, 296);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(298, 44);
            this.btnConf.TabIndex = 9;
            this.btnConf.Text = "Confirmar";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // lblRedSen
            // 
            this.lblRedSen.AutoSize = true;
            this.lblRedSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblRedSen.Location = new System.Drawing.Point(27, 35);
            this.lblRedSen.Name = "lblRedSen";
            this.lblRedSen.Size = new System.Drawing.Size(420, 22);
            this.lblRedSen.TabIndex = 8;
            this.lblRedSen.Text = "Forneça essas informações para apagar sua conta:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(228, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(168, 190);
            this.lblSex.Name = "lblSex";
            this.lblSex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSex.Size = new System.Drawing.Size(34, 13);
            this.lblSex.TabIndex = 7;
            this.lblSex.Text = "Sexo:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(167, 78);
            this.lblNome.Name = "lblNome";
            this.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(228, 187);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 20);
            this.txtSex.TabIndex = 6;
            // 
            // txtSobNom
            // 
            this.txtSobNom.Location = new System.Drawing.Point(228, 112);
            this.txtSobNom.Name = "txtSobNom";
            this.txtSobNom.Size = new System.Drawing.Size(100, 20);
            this.txtSobNom.TabIndex = 2;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(168, 155);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 115);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sobrenome:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(228, 152);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(12, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Visible = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.gpbApagCont);
            this.Name = "Form8";
            this.Text = "Form8";
            this.gpbApagCont.ResumeLayout(false);
            this.gpbApagCont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbApagCont;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Label lblRedSen;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtSobNom;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
    }
}