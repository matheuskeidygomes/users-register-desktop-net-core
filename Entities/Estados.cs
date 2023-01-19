using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Windows_Form_02_Cadastro_de_clientes.Entities
{
    internal class Estados
    {
        public static List<Estado> Listagem { get; private set; } = new List<Estado>();

        static Estados()
        {
            Listagem.Add(new Estado("AC", "Acre"));
            Listagem.Add(new Estado("AL", "Alagoas"));
            Listagem.Add(new Estado("AP", "Amapá"));
            Listagem.Add(new Estado("AM", "Amazonas"));
            Listagem.Add(new Estado("BA", "Bahia"));
            Listagem.Add(new Estado("CE", "Ceará"));
            Listagem.Add(new Estado("DF", "Distrito Federal"));
            Listagem.Add(new Estado("ES", "Espírito Santo"));
            Listagem.Add(new Estado("GO", "Goiás"));
            Listagem.Add(new Estado("MA", "Maranhão"));
            Listagem.Add(new Estado("MT", "Mato Grosso"));
            Listagem.Add(new Estado("MS", "Mato Grosso do Sul"));
            Listagem.Add(new Estado("MG", "Minas Gerais"));
            Listagem.Add(new Estado("PA", "Pará"));
            Listagem.Add(new Estado("PB", "Paraíba"));
            Listagem.Add(new Estado("PR", "Paraná"));
            Listagem.Add(new Estado("PE", "Pernambuco"));
            Listagem.Add(new Estado("PI", "Piauí"));
            Listagem.Add(new Estado("RJ", "Rio de Janeiro"));
            Listagem.Add(new Estado("RN", "Rio Grande do Norte"));
            Listagem.Add(new Estado("RS", "Rio Grande do Sul"));
            Listagem.Add(new Estado("RO", "Rondônia"));
            Listagem.Add(new Estado("RR", "Roraima"));
            Listagem.Add(new Estado("SC", "Santa Catarina"));
            Listagem.Add(new Estado("SP", "São Paulo"));
            Listagem.Add(new Estado("SE", "Sergipe"));
            Listagem.Add(new Estado("TO", "Tocantins"));
        }

    }
}
