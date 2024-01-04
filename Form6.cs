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
    public partial class Form6 : Form
    {
        SqlConnection sqlCon = null;
        //private string strCon = "Integrated Security=SSPI;Initial Catalog=ProjetoBD_DDS;Data Source=DESKTOP-HKMM7TL";
        private string strCon = "Data Source =LI08-02; Initial Catalog = ProjetoBD_DDS; User ID = sa; password = 123456";
        private string strSql = "";
        SqlConnection ObjConect = null;//
        SqlConnection ObjCommand = null;//

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEmail.Text = items.email;
            strSql = "select sum(val_Gasta)  from Cliente Where email_clie = 'NicolasNL'";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@email_clie", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@val_gasta", SqlDbType.Real).Value = txtVTG.Text;

            sqlCon.Open();
           

            SqlDataReader dr = comando.ExecuteReader(); 
            if (dr.HasRows == true)
            {
                dr.Read();

                txtVTG.Text = Convert.ToString(dr["(val_gasta)"]);
                //   txtVTI.Text = Convert.ToString(dr["COMA"]);
            }
            else
            {

            }
        }

        private void txtVTG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
