
namespace WindowsFormsApp1
{
    partial class Form4
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
            this.txtNovSen = new System.Windows.Forms.TextBox();
            this.txtRepSen = new System.Windows.Forms.TextBox();
            this.gpbNovSen = new System.Windows.Forms.GroupBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.lblRepSen = new System.Windows.Forms.Label();
            this.lblNovSen = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gpbNovSen.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNovSen
            // 
            this.txtNovSen.Location = new System.Drawing.Point(111, 40);
            this.txtNovSen.Name = "txtNovSen";
            this.txtNovSen.Size = new System.Drawing.Size(100, 20);
            this.txtNovSen.TabIndex = 1;
            // 
            // txtRepSen
            // 
            this.txtRepSen.Location = new System.Drawing.Point(113, 103);
            this.txtRepSen.Name = "txtRepSen";
            this.txtRepSen.Size = new System.Drawing.Size(100, 20);
            this.txtRepSen.TabIndex = 2;
            // 
            // gpbNovSen
            // 
            this.gpbNovSen.Controls.Add(this.btnCon);
            this.gpbNovSen.Controls.Add(this.lblRepSen);
            this.gpbNovSen.Controls.Add(this.lblNovSen);
            this.gpbNovSen.Controls.Add(this.txtNovSen);
            this.gpbNovSen.Controls.Add(this.txtRepSen);
            this.gpbNovSen.Location = new System.Drawing.Point(256, 71);
            this.gpbNovSen.Name = "gpbNovSen";
            this.gpbNovSen.Size = new System.Drawing.Size(291, 228);
            this.gpbNovSen.TabIndex = 3;
            this.gpbNovSen.TabStop = false;
            this.gpbNovSen.Text = "Nova Senha";
            this.gpbNovSen.Enter += new System.EventHandler(this.gpbNovSen_Enter);
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(67, 177);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(175, 24);
            this.btnCon.TabIndex = 5;
            this.btnCon.Text = "Concluir";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // lblRepSen
            // 
            this.lblRepSen.AutoSize = true;
            this.lblRepSen.Location = new System.Drawing.Point(9, 106);
            this.lblRepSen.Name = "lblRepSen";
            this.lblRepSen.Size = new System.Drawing.Size(102, 13);
            this.lblRepSen.TabIndex = 4;
            this.lblRepSen.Text = "Repita a sua senha:";
            // 
            // lblNovSen
            // 
            this.lblNovSen.AutoSize = true;
            this.lblNovSen.Location = new System.Drawing.Point(25, 43);
            this.lblNovSen.Name = "lblNovSen";
            this.lblNovSen.Size = new System.Drawing.Size(70, 13);
            this.lblNovSen.TabIndex = 3;
            this.lblNovSen.Text = "Nova Senha:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(27, 21);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.gpbNovSen);
            this.Name = "Form4";
            this.Text = "Form4";
            this.gpbNovSen.ResumeLayout(false);
            this.gpbNovSen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNovSen;
        private System.Windows.Forms.TextBox txtRepSen;
        private System.Windows.Forms.GroupBox gpbNovSen;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Label lblRepSen;
        private System.Windows.Forms.Label lblNovSen;
        private System.Windows.Forms.TextBox txtEmail;
    }
}