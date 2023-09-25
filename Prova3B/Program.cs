using Prova3B.classes;
using System;
using System.Collections.Generic;

class Program
{

    
    static void Main(Medicoo medico)
    {
        List<Medico> m = new List<Medico>();
        List<FuncionarioAdministrativo> administrativos = new List<FuncionarioAdministrativo>();

        while (true)
        {
            Console.WriteLine("Digite qual funcionario será cadastrado (1-Médico, 2-Funcionário Administrativo, 0 para sair):");
            int tipo = Convert.ToInt32(Console.ReadLine());

            if (tipo == 0)
                break;
          
            Console.WriteLine("Digite o nome do funcionário:");
           
            Console.WriteLine("Digite o CPF do funcionário:");
            
            Console.WriteLine("Digite a matrícula do funcionário:");
            
            Console.WriteLine("Digite a data de nascimento do funcionário:");
          
            Console.WriteLine("Digite o sexo do funcionário :");
           
            Console.WriteLine("Digite o salário do funcionário:");
           

            string nome = Console.ReadLine();
            string cpf = Console.ReadLine();
            string matricula = Console.ReadLine();
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            string sexo = Console.ReadLine();
            double salario = Convert.ToDouble(Console.ReadLine());

           
        }

}

    
}
