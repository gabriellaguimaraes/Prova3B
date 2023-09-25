using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3B.classes
{
  internal class FuncionarioAdministrativo : Funcionario
    {
        public FuncionarioAdministrativo(DateTime dataNascimento, string matricula, string cPF, string sexo, string nome, double salario, string funcao)
        {
            DataNascimento = dataNascimento;
            Matricula = matricula;
            CPF = cPF;
            Sexo = sexo;
            Nome = nome;
            Salario = salario;
            Funcao = funcao;
        }

        public DateTime DataNascimento { get; set; }
        public string Matricula { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public string Funcao { get; set; }


 

    }
}
