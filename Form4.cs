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
    public partial class Form4 : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "Integrated Security=SSPI;Initial Catalog=ProjetoBD_DDS;Data Source=DESKTOP-L7UN2LT;TrustServerCertificate=True;";
        //private string strCon = "Data Source =LI02-16; Initial Catalog = ProjetoBD_DDS; User ID = sa; password = 123456";
        private string strSql = "";
        SqlConnection ObjConect = null;//
        SqlConnection ObjCommand = null;//

        public Form4()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if(txtNovSen.Text == txtRepSen.Text)
            {
                txtEmail.Text = items.email;
                MessageBox.Show("Sua senha foi redefinida com sucesso.");
                strSql = "update Cliente set senha_clie = @senha_clie where email_clie = @email_clie";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@email_clie", SqlDbType.VarChar).Value = txtEmail.Text;
                comando.Parameters.Add("@senha_clie", SqlDbType.VarChar).Value = txtNovSen.Text;

                sqlCon.Open();

                comando.ExecuteNonQuery();
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("As Senhas não estão iguais.");
            }
        }

        private void gpbNovSen_Enter(object sender, EventArgs e)
        {

        }
    }
}
