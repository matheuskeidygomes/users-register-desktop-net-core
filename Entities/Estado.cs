using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Windows_Form_02_Cadastro_de_clientes.Entities
{
    internal class Estado
    {
        public string? Nome { get; set; }
        public string? Sigla { get; set; }
        
        public Estado()
        {
        }

        public Estado(string sigla, string name)
        {
            Sigla = sigla;
            Nome = name;
        }

    }
}
