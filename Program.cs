 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
    public static class items
    {
        public static double valHam = 0;
        public static double valBata = 0;
        public static double valCacho = 0;
        public static double valCama = 0;
        public static double valLasa = 0;
        public static int qnt1 = 0;
        public static int qnt2 = 0;
        public static int qnt3 = 0;
        public static int qnt4 = 0;
        public static int qnt5 = 0;
        public static int qtdItem = 0;
        public static double val_Gasta = 0;
        public static string email;
    }
}
