using Projeto_Windows_Form_02_Cadastro_de_clientes.Screens;

namespace Projeto_Windows_Form_02_Cadastro_de_clientes
{
    internal static class Program
    {
        /// <summary>
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new RegisterScreen());
        }
    }
}