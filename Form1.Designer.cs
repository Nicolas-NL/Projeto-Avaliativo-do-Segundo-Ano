
namespace WindowsFormsApp1
{
    partial class frmLoja
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoja));
            this.rdbPao = new System.Windows.Forms.RadioButton();
            this.chkConf = new System.Windows.Forms.CheckBox();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.lstItem = new System.Windows.Forms.ListBox();
            this.rdbBata = new System.Windows.Forms.RadioButton();
            this.rdbCacho = new System.Windows.Forms.RadioButton();
            this.rdbCama = new System.Windows.Forms.RadioButton();
            this.rdbLasa = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblLista = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbLasa = new System.Windows.Forms.PictureBox();
            this.pcbCama = new System.Windows.Forms.PictureBox();
            this.pcbCacho = new System.Windows.Forms.PictureBox();
            this.pcbBata = new System.Windows.Forms.PictureBox();
            this.pcbPao = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPao)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbPao
            // 
            this.rdbPao.AutoSize = true;
            this.rdbPao.CausesValidation = false;
            this.rdbPao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbPao.Location = new System.Drawing.Point(184, 312);
            this.rdbPao.Name = "rdbPao";
            this.rdbPao.Size = new System.Drawing.Size(83, 17);
            this.rdbPao.TabIndex = 0;
            this.rdbPao.Text = "Hambúrguer";
            this.rdbPao.UseVisualStyleBackColor = true;
            this.rdbPao.CheckedChanged += new System.EventHandler(this.rdbPao_CheckedChanged);
            // 
            // chkConf
            // 
            this.chkConf.AutoSize = true;
            this.chkConf.Enabled = false;
            this.chkConf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkConf.Location = new System.Drawing.Point(662, 384);
            this.chkConf.Name = "chkConf";
            this.chkConf.Size = new System.Drawing.Size(109, 17);
            this.chkConf.TabIndex = 1;
            this.chkConf.Text = "Confirmar Compra";
            this.chkConf.UseVisualStyleBackColor = true;
            this.chkConf.CheckedChanged += new System.EventHandler(this.chkConf_CheckedChanged);
            // 
            // cboItem
            // 
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.ItemHeight = 13;
            this.cboItem.Location = new System.Drawing.Point(12, 95);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(117, 21);
            this.cboItem.TabIndex = 2;
            this.cboItem.SelectedIndexChanged += new System.EventHandler(this.cboItem_SelectedIndexChanged);
            // 
            // lstItem
            // 
            this.lstItem.BackColor = System.Drawing.Color.MistyRose;
            this.lstItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstItem.FormattingEnabled = true;
            this.lstItem.Location = new System.Drawing.Point(232, 95);
            this.lstItem.Name = "lstItem";
            this.lstItem.Size = new System.Drawing.Size(347, 197);
            this.lstItem.TabIndex = 3;
            this.lstItem.SelectedIndexChanged += new System.EventHandler(this.lb_Sons_SelectedIndexChanged);
            // 
            // rdbBata
            // 
            this.rdbBata.AutoSize = true;
            this.rdbBata.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbBata.Location = new System.Drawing.Point(278, 312);
            this.rdbBata.Name = "rdbBata";
            this.rdbBata.Size = new System.Drawing.Size(79, 17);
            this.rdbBata.TabIndex = 4;
            this.rdbBata.TabStop = true;
            this.rdbBata.Text = "Batata Frita";
            this.rdbBata.UseVisualStyleBackColor = true;
            this.rdbBata.CheckedChanged += new System.EventHandler(this.rdbBata_CheckedChanged);
            // 
            // rdbCacho
            // 
            this.rdbCacho.AutoSize = true;
            this.rdbCacho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbCacho.Location = new System.Drawing.Point(361, 312);
            this.rdbCacho.Name = "rdbCacho";
            this.rdbCacho.Size = new System.Drawing.Size(106, 17);
            this.rdbCacho.TabIndex = 5;
            this.rdbCacho.TabStop = true;
            this.rdbCacho.Text = "Cachorro Quente";
            this.rdbCacho.UseVisualStyleBackColor = true;
            this.rdbCacho.CheckedChanged += new System.EventHandler(this.rdbCacho_CheckedChanged);
            // 
            // rdbCama
            // 
            this.rdbCama.AutoSize = true;
            this.rdbCama.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbCama.Location = new System.Drawing.Point(472, 312);
            this.rdbCama.Name = "rdbCama";
            this.rdbCama.Size = new System.Drawing.Size(67, 17);
            this.rdbCama.TabIndex = 6;
            this.rdbCama.TabStop = true;
            this.rdbCama.Text = "Camarão";
            this.rdbCama.UseVisualStyleBackColor = true;
            this.rdbCama.CheckedChanged += new System.EventHandler(this.rdbCama_CheckedChanged);
            // 
            // rdbLasa
            // 
            this.rdbLasa.AutoSize = true;
            this.rdbLasa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbLasa.Location = new System.Drawing.Point(546, 312);
            this.rdbLasa.Name = "rdbLasa";
            this.rdbLasa.Size = new System.Drawing.Size(66, 17);
            this.rdbLasa.TabIndex = 7;
            this.rdbLasa.TabStop = true;
            this.rdbLasa.Text = "Lasanha";
            this.rdbLasa.UseVisualStyleBackColor = true;
            this.rdbLasa.CheckedChanged += new System.EventHandler(this.rdbLasa_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "teste.jpeg");
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLista.Location = new System.Drawing.Point(12, 69);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(91, 13);
            this.lblLista.TabIndex = 16;
            this.lblLista.Text = "Lista de Compras:";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Enabled = false;
            this.btnCalculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculo.Location = new System.Drawing.Point(623, 95);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(165, 31);
            this.btnCalculo.TabIndex = 17;
            this.btnCalculo.Text = "Calcular Valor da Compra";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click_1);
            // 
            // txtFinal
            // 
            this.txtFinal.Enabled = false;
            this.txtFinal.Location = new System.Drawing.Point(223, 49);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(356, 20);
            this.txtFinal.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Valor da Compra";
            // 
            // pcbLasa
            // 
            this.pcbLasa.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2022_05_17_at_23_57_54;
            this.pcbLasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLasa.Location = new System.Drawing.Point(289, 113);
            this.pcbLasa.Name = "pcbLasa";
            this.pcbLasa.Size = new System.Drawing.Size(232, 142);
            this.pcbLasa.TabIndex = 15;
            this.pcbLasa.TabStop = false;
            this.pcbLasa.Visible = false;
            // 
            // pcbCama
            // 
            this.pcbCama.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2022_05_17_at_23_59_11;
            this.pcbCama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCama.Location = new System.Drawing.Point(289, 113);
            this.pcbCama.Name = "pcbCama";
            this.pcbCama.Size = new System.Drawing.Size(232, 142);
            this.pcbCama.TabIndex = 14;
            this.pcbCama.TabStop = false;
            this.pcbCama.Visible = false;
            // 
            // pcbCacho
            // 
            this.pcbCacho.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2022_05_17_at_23_58_19;
            this.pcbCacho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCacho.Location = new System.Drawing.Point(295, 113);
            this.pcbCacho.Name = "pcbCacho";
            this.pcbCacho.Size = new System.Drawing.Size(226, 142);
            this.pcbCacho.TabIndex = 13;
            this.pcbCacho.TabStop = false;
            this.pcbCacho.Visible = false;
            // 
            // pcbBata
            // 
            this.pcbBata.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2022_05_17_at_23_58_50;
            this.pcbBata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbBata.Location = new System.Drawing.Point(295, 113);
            this.pcbBata.Name = "pcbBata";
            this.pcbBata.Size = new System.Drawing.Size(226, 142);
            this.pcbBata.TabIndex = 12;
            this.pcbBata.TabStop = false;
            this.pcbBata.Visible = false;
            // 
            // pcbPao
            // 
            this.pcbPao.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WhatsApp_Image_2022_05_17_at_23_59_35;
            this.pcbPao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbPao.Location = new System.Drawing.Point(295, 113);
            this.pcbPao.Name = "pcbPao";
            this.pcbPao.Size = new System.Drawing.Size(226, 142);
            this.pcbPao.TabIndex = 11;
            this.pcbPao.TabStop = false;
            this.pcbPao.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(28, 384);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 26);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(15, 26);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(116, 20);
            this.txtCod.TabIndex = 22;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // frmLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.pcbLasa);
            this.Controls.Add(this.pcbCama);
            this.Controls.Add(this.pcbCacho);
            this.Controls.Add(this.pcbBata);
            this.Controls.Add(this.pcbPao);
            this.Controls.Add(this.rdbLasa);
            this.Controls.Add(this.rdbCama);
            this.Controls.Add(this.rdbCacho);
            this.Controls.Add(this.rdbBata);
            this.Controls.Add(this.lstItem);
            this.Controls.Add(this.cboItem);
            this.Controls.Add(this.chkConf);
            this.Controls.Add(this.rdbPao);
            this.Name = "frmLoja";
            this.Text = "LOJA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbPao;
        private System.Windows.Forms.CheckBox chkConf;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.ListBox lstItem;
        private System.Windows.Forms.RadioButton rdbBata;
        private System.Windows.Forms.RadioButton rdbCacho;
        private System.Windows.Forms.RadioButton rdbCama;
        private System.Windows.Forms.RadioButton rdbLasa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pcbPao;
        private System.Windows.Forms.PictureBox pcbBata;
        private System.Windows.Forms.PictureBox pcbCacho;
        private System.Windows.Forms.PictureBox pcbCama;
        private System.Windows.Forms.PictureBox pcbLasa;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtCod;
    }
}

