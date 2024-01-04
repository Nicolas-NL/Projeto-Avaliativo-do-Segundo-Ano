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
    public partial class Form5 : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "Integrated Security=SSPI;Initial Catalog=ProjetoBD_DDS;Data Source=DESKTOP-L7UN2LT;TrustServerCertificate=True;";
        //private string strCon = "Data Source =LI02-16; Initial Catalog = ProjetoBD_DDS; User ID = sa; password = 123456";
        private string strSql = "";
        SqlConnection ObjConect = null;//
        SqlConnection ObjCommand = null;//

        string campos;
        public Form5()
        {
            InitializeComponent();
        }

        private void btnTemCad_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtIdade.Text == "" || txtNome.Text == "" || txtSenha.Text == "" || txtSobNom.Text == "" || txtSex.Text == "")
            {
                MessageBox.Show("Por favor, Preencha todos os campos");
            }
            else
            {


                if (txtSenha.Text != txtRepSen.Text || txtRepSen.Text == "")
                {
                    MessageBox.Show("Por favor, repita a senha corretamente");
                }
                else
                {

                    strSql = "insert into Cliente(email_clie,senha_clie,nome_clie,sobrenome_clie,idade,sexo)values(@email_clie,@senha_clie,@nome_clie,@sobrenome_clie,@idade,@sexo)";
                    sqlCon = new SqlConnection(strCon);

                    SqlCommand comando = new SqlCommand(strSql, sqlCon);
                    comando.Parameters.Add("@email_clie", SqlDbType.VarChar).Value = txtEmail.Text;
                    comando.Parameters.Add("@senha_clie", SqlDbType.VarChar).Value = txtSenha.Text;
                    comando.Parameters.Add("@nome_clie", SqlDbType.Char).Value = txtNome.Text;
                    comando.Parameters.Add("@sobrenome_clie", SqlDbType.Char).Value = txtSobNom.Text;
                    comando.Parameters.Add("@idade", SqlDbType.Int).Value = txtIdade.Text;
                    comando.Parameters.Add("@sexo", SqlDbType.Char).Value = txtSex.Text;

                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso");
                    sqlCon.Close();
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
            }
        }

        private void gpbCadastro_Enter(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
