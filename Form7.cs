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
    public partial class Form7 : Form
    {
        SqlConnection sqlCon = null;
        private string strCon = "Integrated Security=SSPI;Initial Catalog=ProjetoBD_DDS;Data Source=DESKTOP-L7UN2LT;TrustServerCertificate=True;";
        //private string strCon = "Data Source =LI02-16; Initial Catalog = ProjetoBD_DDS; User ID = sa; password = 123456";
        private string strSql = "";
        SqlConnection ObjConect = null;//
        SqlConnection ObjCommand = null;//

        string campos;
        public Form7()
        {
            InitializeComponent();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo apagar sua conta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Form8 f8 = new Form8();
                f8.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ent blz");
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            txtEmail.Text = items.email;
            btnApagar.Enabled = true;
            btnSair.Enabled = true;
            btnLoja.Enabled = true;
            btnLiberar.Visible = false;
            btnLiberar.Enabled = false;

            strSql = "select* from Cliente where email_clie = @email_clie";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@email_clie", SqlDbType.VarChar).Value = txtEmail.Text;

            sqlCon.Open();
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                txtNome.Text = Convert.ToString(dr["nome_clie"]);
                txtSobNom.Text = Convert.ToString(dr["sobrenome_clie"]);
                txtIdade.Text = Convert.ToString(dr["idade"]);
                txtSexo.Text = Convert.ToString(dr["sexo"]);

            }
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            frmLoja fr = new frmLoja();
            fr.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void gpbInfPesso_Enter(object sender, EventArgs e)
        {

        }
    }
}
