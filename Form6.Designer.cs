
namespace WindowsFormsApp1
{
    partial class Form6
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
            this.lblBemVin = new System.Windows.Forms.Label();
            this.txtVTG = new System.Windows.Forms.TextBox();
            this.lblVTG = new System.Windows.Forms.Label();
            this.lblVTIC = new System.Windows.Forms.Label();
            this.txtVTI = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBemVin
            // 
            this.lblBemVin.AutoSize = true;
            this.lblBemVin.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblBemVin.ForeColor = System.Drawing.Color.Turquoise;
            this.lblBemVin.Location = new System.Drawing.Point(305, 53);
            this.lblBemVin.Name = "lblBemVin";
            this.lblBemVin.Size = new System.Drawing.Size(209, 39);
            this.lblBemVin.TabIndex = 0;
            this.lblBemVin.Text = "BEM VINDO";
            // 
            // txtVTG
            // 
            this.txtVTG.Enabled = false;
            this.txtVTG.Location = new System.Drawing.Point(640, 147);
            this.txtVTG.Name = "txtVTG";
            this.txtVTG.Size = new System.Drawing.Size(100, 20);
            this.txtVTG.TabIndex = 1;
            this.txtVTG.TextChanged += new System.EventHandler(this.txtVTG_TextChanged);
            // 
            // lblVTG
            // 
            this.lblVTG.AutoSize = true;
            this.lblVTG.BackColor = System.Drawing.Color.Transparent;
            this.lblVTG.ForeColor = System.Drawing.Color.Turquoise;
            this.lblVTG.Location = new System.Drawing.Point(540, 150);
            this.lblVTG.Name = "lblVTG";
            this.lblVTG.Size = new System.Drawing.Size(92, 13);
            this.lblVTG.TabIndex = 2;
            this.lblVTG.Text = "Valor Total Gasto:";
            // 
            // lblVTIC
            // 
            this.lblVTIC.AutoSize = true;
            this.lblVTIC.BackColor = System.Drawing.Color.Transparent;
            this.lblVTIC.ForeColor = System.Drawing.Color.Turquoise;
            this.lblVTIC.Location = new System.Drawing.Point(472, 218);
            this.lblVTIC.Name = "lblVTIC";
            this.lblVTIC.Size = new System.Drawing.Size(162, 13);
            this.lblVTIC.TabIndex = 4;
            this.lblVTIC.Text = "Valor Total de Itens Consumidos:";
            // 
            // txtVTI
            // 
            this.txtVTI.Enabled = false;
            this.txtVTI.Location = new System.Drawing.Point(640, 218);
            this.txtVTI.Name = "txtVTI";
            this.txtVTI.Size = new System.Drawing.Size(100, 20);
            this.txtVTI.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mostrar Informações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 53);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "NicolasNL";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblVTIC);
            this.Controls.Add(this.txtVTI);
            this.Controls.Add(this.lblVTG);
            this.Controls.Add(this.txtVTG);
            this.Controls.Add(this.lblBemVin);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBemVin;
        private System.Windows.Forms.TextBox txtVTG;
        private System.Windows.Forms.Label lblVTG;
        private System.Windows.Forms.Label lblVTIC;
        private System.Windows.Forms.TextBox txtVTI;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEmail;
    }
}