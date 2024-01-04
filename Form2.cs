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
    public partial class Form2 : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "Integrated Security=SSPI;Initial Catalog=ProjetoBD_DDS;Data Source=DESKTOP-L7UN2LT;TrustServerCertificate=True;";
        //private string strCon = "Data Source =LI08-02; Initial Catalog = ProjetoBD_DDS; User ID = sa; password = 123456";
        private string strSql = "";
        SqlConnection ObjConect = null;//
        SqlConnection ObjCommand = null;//

        string campos;

        public Form2()
        {
            InitializeComponent();
        }

        private void lklEsqSen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Por Favor, digite seu email na area indicada.");
            }
            else
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
                items.email = txtEmail.Text;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnt_Click(object sender, EventArgs e)
        {

            
                strSql = "SELECT * FROM Cliente WHERE senha_clie = @senha_clie AND email_clie = @email_clie";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@email_clie", SqlDbType.VarChar).Value = txtEmail.Text;
                comando.Parameters.Add("@senha_clie", SqlDbType.VarChar).Value = txtSenha.Text;

                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows == true)
            {
                Form7 f7 = new Form7();
                f7.Show();
                this.Hide();
                items.email = txtEmail.Text;
            }
            else
            {
                MessageBox.Show("Conta não extiste / Senha Incorreta");
                items.email = txtEmail.Text;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    /*
            txtNome.Text = Convert.ToString(dr["nome_clie"]);
            txtSobNom.Text = Convert.ToString(dr["sobrenome_clie"]);
            txtIdade.Text = Convert.ToString(dr["idade"]);
            txtSex.Text = Convert.ToString(dr["sexo"]);
            txtValAuto.Text = Convert.ToString(dr["val_Auto"]);
            txtValSeg.Text = Convert.ToString(dr["val_Seg"]);*/
}