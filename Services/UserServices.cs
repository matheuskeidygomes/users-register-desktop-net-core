using Projeto_Windows_Form_02_Cadastro_de_clientes.Entities;
using Projeto_Windows_Form_02_Cadastro_de_clientes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Windows_Form_02_Cadastro_de_clientes.Services
{
    internal class UserServices
    {
        public static List<Usuario> usuarios = Usuarios.Listagem;

        public static void InsertUser(Usuario usuario)
        {
            usuario.Codigo = usuarios.Count + 1;
            usuarios.Add(usuario);
        }

    }
}
