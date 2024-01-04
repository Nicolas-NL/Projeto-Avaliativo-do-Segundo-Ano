using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class frmLoja : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "Integrated Security=SSPI;Initial Catalog=ProjetoBD_DDS;Data Source=DESKTOP-HKMM7TL";
        //private string strCon = "Data Source =LI08-02; Initial Catalog = ProjetoBD_DDS; User ID = sa; password = 123456";
        private string strSql = "";
        SqlConnection ObjConect = null;//
        SqlConnection ObjCommand = null;//

        public frmLoja()
        {

            InitializeComponent();
            {
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lb_Sons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void rdbPao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPao.Checked == true)
            {
                if (MessageBox.Show("Realmente deseja confirmar a sua escolha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    rdbPao.Checked = false;
                }
                else
                {
                    do { 
                    lstItem.Items.Clear();
                    lstItem.Items.Add("Hambúrguer: R$20,00");
                    rdbPao.Enabled = false;
                    pcbPao.Visible = true;
                    cboItem.Items.Add("Hambúrguer");
                    chkConf.Enabled = true;
                    items.valHam = items.valHam + 20.00;
                    items.qnt1 = items.qnt1 + 1;
                    btnCalculo.Enabled = true;

                    pcbBata.Visible = false;
                    pcbCacho.Visible = false;
                    pcbCama.Visible = false;
                    pcbLasa.Visible = false;

                } while (MessageBox.Show("Deseja mais deste item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) ;
              }
            }

          }

        private void rdbBata_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbBata.Checked == true)
            {
                if (MessageBox.Show("Realmente deseja confirmar a sua escolha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    rdbBata.Checked = false;
                }
                else
                {
                    do { 
                    lstItem.Items.Clear();
                    lstItem.Items.Add("Batata Frita: R$2,50");
                    rdbBata.Enabled = false;
                    pcbBata.Visible = true;
                    cboItem.Items.Add("Batata Frita");
                    chkConf.Enabled = true;
                    items.valBata = items.valBata + 2.50;
                    items.qnt2 = items.qnt2 + 1;
                    btnCalculo.Enabled = true;

                    pcbPao.Visible = false;
                    pcbCacho.Visible = false;
                    pcbCama.Visible = false;
                    pcbLasa.Visible = false;
                } while (MessageBox.Show("Deseja mais deste item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) ;
              }
            }
        }

        private void rdbCacho_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbCacho.Checked == true)
            {
                if (MessageBox.Show("Realmente deseja confirmar a sua escolha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    rdbCacho.Checked = false;
                }
                else
                {
                    do { 
                    lstItem.Items.Clear();
                    lstItem.Items.Add("Cachorro Quente: R$15,00");
                    rdbCacho.Enabled = false;
                    pcbCacho.Visible = true;
                    cboItem.Items.Add("Cachorro Quente");
                    chkConf.Enabled = true;
                    items.valCacho = items.valCacho + 15.00;
                    items.qnt3 = items.qnt3 + 1;
                    btnCalculo.Enabled = true;

                    pcbPao.Visible = false;
                    pcbBata.Visible = false;
                    pcbCama.Visible = false;
                    pcbLasa.Visible = false;
                } while (MessageBox.Show("Deseja mais deste item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) ;
            }
            }
        }

        private void rdbCama_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCama.Checked == true)
            {
                if (MessageBox.Show("Realmente deseja confirmar a sua escolha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    rdbCama.Checked = false;
                }
                else
                {
                    do { 
                    lstItem.Items.Clear();
                    lstItem.Items.Add("Camarão: R$10,00");
                    rdbCama.Enabled = false;
                    pcbCama.Visible = true;
                    cboItem.Items.Add("Camarão");
                    chkConf.Enabled = true;
                    items.valCama = items.valCama + 10.00;
                    items.qnt4 = items.qnt4 + 1;
                    btnCalculo.Enabled = true;

                    pcbPao.Visible = false;
                    pcbBata.Visible = false;
                    pcbCacho.Visible = false;
                    pcbLasa.Visible = false;
                    } while (MessageBox.Show("Deseja mais deste item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
                }
            }
        }

        private void rdbLasa_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbLasa.Checked == true)
            {
                if (MessageBox.Show("Realmente deseja confirmar a sua escolha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    rdbLasa.Checked = false;
                }
                else
                {
                    do
                    {

                        lstItem.Items.Clear();
                        lstItem.Items.Add("Lasanha: R$30,00");
                        rdbLasa.Enabled = false;
                        pcbLasa.Visible = true;
                        cboItem.Items.Add("Lasanha");
                        chkConf.Enabled = true;
                        items.valLasa = items.valLasa + 30.00;
                        items.qnt5 = items.qnt5 + 1;
                        btnCalculo.Enabled = true;

                        pcbPao.Visible = false;
                        pcbBata.Visible = false;
                        pcbCacho.Visible = false;
                        pcbCama.Visible = false;

                    } while (MessageBox.Show("Deseja mais deste item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
                }
            }

        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboItem.SelectedIndex == cboItem.FindStringExact("Hambúrguer"))
            {
                cboItem.Items.Remove("Hambúrguer");
                    items.valHam = items.valHam - 20.00;
                    items.qnt1 = items.qnt1 - 1;
                strSql = "insert into Cliente(email_clie,senha_clie,nome_clie,sobrenome_clie,idade,sexo)values(@email_clie,@senha_clie,@nome_clie,@sobrenome_clie,@idade,@sexo)";
                sqlCon = new SqlConnection(strCon);

                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@email_clie", SqlDbType.VarChar).Value = cboItem.Items.Add("Hamburguer");



            }
            else if (cboItem.SelectedIndex == cboItem.FindStringExact("Batata Frita"))
            {
                cboItem.Items.Remove("Batata Frita");
                items.valBata = items.valBata - 2.50;
                items.qnt2 = items.qnt2 - 1;
            }
            else if (cboItem.SelectedIndex == cboItem.FindStringExact("Cachorro Quente"))
            {
                cboItem.Items.Remove("Cachorro Quente");
                items.valCacho = items.valCacho - 15.00;
                items.qnt3 = items.qnt3 - 1;
            }
            else if (cboItem.SelectedIndex == cboItem.FindStringExact("Camarão"))
            {
                cboItem.Items.Remove("Camarão");
                items.valCama = items.valCama - 10.00;
                items.qnt4 = items.qnt4 - 1;
            }
            else if (cboItem.SelectedIndex == cboItem.FindStringExact("Lasanha"))
            {
                cboItem.Items.Remove("Lasanha");
                items.valLasa = items.valLasa - 30.00;
                items.qnt5 = items.qnt5 - 1;
            }
        }

        private void btnCalculo_Click_1(object sender, EventArgs e)
        {
            txtCod.Text = items.email;
         
            items.val_Gasta = items.valHam + items.valBata + items.valCacho + items.valCama + items.valLasa;
            items.qtdItem = items.qnt5 + items.qnt4 + items.qnt3 + items.qnt2 + items.qnt1;
            txtFinal.Text = "|Valor Total dos Itens: R$" + Convert.ToString(items.val_Gasta) + "    ||    Quantidade de Itens solicitados: " + Convert.ToString(items.qtdItem) + "|";


        }

        private void chkConf_CheckedChanged(object sender, EventArgs e)
        {
                if (MessageBox.Show("Realmente deseja terminar a sua compra?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    chkConf.Checked = false;
                }
                else if (chkConf.Checked == true)
                {
                    MessageBox.Show("|Valor da Sua Compra: R$" + Convert.ToString(items.val_Gasta = items.valHam + items.valBata + items.valCacho + items.valCama + items.valLasa) + "    ||    Quantidade de Itens Comprados: " +Convert.ToString(items.qtdItem = items.qnt5 + items.qnt4 + items.qnt3 + items.qnt2 + items.qnt1) + "|");
                            strSql = "update Cliente(val_Gasta,qtd_Item) values (@val_Gasta, @qtd_Item) select email_clie = @email_clie";

                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
                }
            
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}


/*if (cboItem.SelectedIndex == 1)
{
    txtItem.Text = Convert.ToString(cboItem.SelectedItem);
}
else if (cboItem.SelectedIndex == 2)
{
    txtItem.Text = Convert.ToString(cboItem.SelectedItem);
}*/

//cboItem.Items.Clear();

/*
if (cboItem.Text = "")
{
  cboItem.Items.Add("Débito");
    cboItem.Items.Add("Crédito");
}
if(rdbPao.Checked == true || rdbBata.Checked == false || rdbCacho.Checked == false || rdbCama.Checked == false || rdbLasa.Checked == false)
            {
                btnCal
*/