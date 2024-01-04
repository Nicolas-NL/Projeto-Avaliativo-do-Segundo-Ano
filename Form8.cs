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
    public partial class Form8 : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "Integrated Security=SSPI;Initial Catalog=ProjetoBD_DDS;Data Source=DESKTOP-L7UN2LT;TrustServerCertificate=True;";
        //private string strCon = "Data Source =LI02-16; Initial Catalog = ProjetoBD_DDS; User ID = sa; password = 123456";
        private string strSql = "";
        SqlConnection ObjConect = null;//
        SqlConnection ObjCommand = null;//
        public Form8()
        {
            InitializeComponent();
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            txtEmail.Text = items.email;
            strSql = "Select * from Cliente where email_clie = @email_clie and nome_clie = @nome_clie and sobrenome_clie = @sobrenome_clie and idade = @idade and sexo = @sexo and senha_clie = @senha_clie";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            comando.Parameters.Add("@email_clie", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@senha_clie", SqlDbType.VarChar).Value = txtSenha.Text;
            comando.Parameters.Add("@nome_clie", SqlDbType.Char).Value = txtNome.Text;
            comando.Parameters.Add("@sobrenome_clie", SqlDbType.Char).Value = txtSobNom.Text;
            comando.Parameters.Add("@idade", SqlDbType.Int).Value = txtIdade.Text;
            comando.Parameters.Add("@sexo", SqlDbType.Char).Value = txtSex.Text;
            sqlCon.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                strSql = "delete from Cliente where email_clie = @email_clie and nome_clie = @nome_clie and sobrenome_clie = @sobrenome_clie and idade = @idade and sexo = @sexo and senha_clie = @senha_clie";

                sqlCon = new SqlConnection(strCon);
                SqlCommand com = new SqlCommand(strSql, sqlCon);
                com.Parameters.Add("@email_clie", SqlDbType.VarChar).Value = txtEmail.Text;
                com.Parameters.Add("@senha_clie", SqlDbType.VarChar).Value = txtSenha.Text;
                com.Parameters.Add("@nome_clie", SqlDbType.Char).Value = txtNome.Text;
                com.Parameters.Add("@sobrenome_clie", SqlDbType.Char).Value = txtSobNom.Text;
                com.Parameters.Add("@idade", SqlDbType.Int).Value = txtIdade.Text;
                com.Parameters.Add("@sexo", SqlDbType.Char).Value = txtSex.Text;
                sqlCon.Open();
                com.ExecuteNonQuery();
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
                MessageBox.Show("Conta Excluida com Sucesso");
            }
            else
            {
                MessageBox.Show("Dados Incorretos ou Incompletos");
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
  
}

