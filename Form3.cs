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
    public partial class Form3 : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "Integrated Security=SSPI;Initial Catalog=ProjetoBD_DDS;Data Source=DESKTOP-L7UN2LT;TrustServerCertificate=True;";
        //private string strCon = "Data Source =LI02-16; Initial Catalog = ProjetoBD_DDS; User ID = sa; password = 123456";
        private string strSql = "";
        SqlConnection ObjConect = null;//
        SqlConnection ObjCommand = null;//
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRedSen_Click(object sender, EventArgs e)
        {
            txtEmail.Text = items.email;
            strSql = "select * from Cliente where email_clie = @email_clie and nome_clie = @nome_clie and sobrenome_clie = @sobrenome_clie and idade = @idade and sexo = @sexo";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);
             comando.Parameters.Add("@email_clie", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@nome_clie", SqlDbType.Char).Value = txtNome.Text;
            comando.Parameters.Add("@sobrenome_clie", SqlDbType.Char).Value = txtSobNom.Text;
            comando.Parameters.Add("@idade", SqlDbType.Int).Value = txtIdade.Text;
            comando.Parameters.Add("@sexo", SqlDbType.VarChar).Value = txtSex.Text;
            sqlCon.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Dados Corretos, Você está autorizado a redefinir a sua senha");
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dados incorretos");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
