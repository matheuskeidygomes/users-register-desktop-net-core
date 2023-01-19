using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Windows_Form_02_Cadastro_de_clientes.Entities.Enums;

namespace Projeto_Windows_Form_02_Cadastro_de_clientes.Entities
{
    internal class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Renda { get; set; }
        public Estado Nacionalidade { get; set; }
        public string Cpf { get; set; }
        public string PlacaVeiculo { get; set; }
        public bool Filhos { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nome, EstadoCivil estadoCivil, DateTime dataNascimento, decimal renda, Estado nacionalidade, string cpf, string placaVeiculo, bool filhos)
        {
            Codigo = 0;
            Nome = nome;
            EstadoCivil = estadoCivil;
            DataNascimento = dataNascimento;
            Renda = renda;
            Nacionalidade = nacionalidade;
            Cpf = cpf;
            PlacaVeiculo = placaVeiculo;
            Filhos = filhos;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + ", Estado Civil: " + EstadoCivil + ", Data de Nascimento: " + DataNascimento + ", Renda: " + Renda + ", Nacionalidade: " + Nacionalidade + ", CPF: " + Cpf + ", Placa do Veículo: " + PlacaVeiculo + ", Filhos: " + Filhos;
        }

    }
}
