using System;
using System.Windows.Forms;

namespace Projeto_Teste
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // String usada para conectar com a database "ProjetoTeste"
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ProjetoTeste;Trusted_Connection=True;";

            Application.Run(new Form1(connectionString));

        }
    }
}
