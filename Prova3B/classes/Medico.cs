using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3B.classes
{
    internal class Medico : Funcionario
    {
        public Medico(string nome, string cPF, DateTime dataNascimento, string matricula, double salario, double cRM, double valorHoraExtra, string especialidade, string sexo)
        {
            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
            Matricula = matricula;
            Salario = salario;
            CRM = cRM;
            ValorHoraExtra = valorHoraExtra;
            Especialidade = especialidade;
            Sexo = sexo;
        }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Matricula { get; set; }
        public double Salario { get; set; }
        public double CRM { get; set; }
        public double ValorHoraExtra { get; set; }
        public string Especialidade { get; set; }
        public string Sexo { get; set; }

        public override void

    }
}

       