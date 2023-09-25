using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3B.classes
{
    internal class Medico : Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Matricula { get; set; }
        public double Salario { get; set; }
        public string CRM { get; set; }
        public double ValorHoraExtra { get; set; }
        public string Especialidade { get; set; }
        public string Sexo { get; set; }
    }
}


       