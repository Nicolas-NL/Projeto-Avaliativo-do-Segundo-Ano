
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSobNom = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblRedSen = new System.Windows.Forms.Label();
            this.gpbRedSen = new System.Windows.Forms.GroupBox();
            this.btnRedSen = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gpbRedSen.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(228, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(167, 85);
            this.lblNome.Name = "lblNome";
            this.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 135);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sobrenome:";
            // 
            // txtSobNom
            // 
            this.txtSobNom.Location = new System.Drawing.Point(228, 132);
            this.txtSobNom.Name = "txtSobNom";
            this.txtSobNom.Size = new System.Drawing.Size(100, 20);
            this.txtSobNom.TabIndex = 2;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(168, 184);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(228, 181);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 4;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(168, 229);
            this.lblSex.Name = "lblSex";
            this.lblSex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSex.Size = new System.Drawing.Size(34, 13);
            this.lblSex.TabIndex = 7;
            this.lblSex.Text = "Sexo:";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(228, 226);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(100, 20);
            this.txtSex.TabIndex = 6;
            // 
            // lblRedSen
            // 
            this.lblRedSen.AutoSize = true;
            this.lblRedSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblRedSen.Location = new System.Drawing.Point(27, 35);
            this.lblRedSen.Name = "lblRedSen";
            this.lblRedSen.Size = new System.Drawing.Size(469, 22);
            this.lblRedSen.TabIndex = 8;
            this.lblRedSen.Text = "Forneça essas informações e poderá redefinir sua senha:";
            // 
            // gpbRedSen
            // 
            this.gpbRedSen.Controls.Add(this.btnRedSen);
            this.gpbRedSen.Controls.Add(this.lblRedSen);
            this.gpbRedSen.Controls.Add(this.txtNome);
            this.gpbRedSen.Controls.Add(this.lblSex);
            this.gpbRedSen.Controls.Add(this.lblNome);
            this.gpbRedSen.Controls.Add(this.txtSex);
            this.gpbRedSen.Controls.Add(this.txtSobNom);
            this.gpbRedSen.Controls.Add(this.lblIdade);
            this.gpbRedSen.Controls.Add(this.label1);
            this.gpbRedSen.Controls.Add(this.txtIdade);
            this.gpbRedSen.Location = new System.Drawing.Point(154, 28);
            this.gpbRedSen.Name = "gpbRedSen";
            this.gpbRedSen.Size = new System.Drawing.Size(511, 353);
            this.gpbRedSen.TabIndex = 9;
            this.gpbRedSen.TabStop = false;
            this.gpbRedSen.Text = "Redefinir a Senha:";
            // 
            // btnRedSen
            // 
            this.btnRedSen.Location = new System.Drawing.Point(126, 282);
            this.btnRedSen.Name = "btnRedSen";
            this.btnRedSen.Size = new System.Drawing.Size(298, 44);
            this.btnRedSen.TabIndex = 9;
            this.btnRedSen.Text = "Redefinir a senha";
            this.btnRedSen.UseVisualStyleBackColor = true;
            this.btnRedSen.Click += new System.EventHandler(this.btnRedSen_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(24, 13);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.gpbRedSen);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gpbRedSen.ResumeLayout(false);
            this.gpbRedSen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSobNom;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label lblRedSen;
        private System.Windows.Forms.GroupBox gpbRedSen;
        private System.Windows.Forms.Button btnRedSen;
        private System.Windows.Forms.TextBox txtEmail;
    }
}