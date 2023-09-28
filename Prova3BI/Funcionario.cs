using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3BI
{
    internal class Funcionario
    {
            public string Nome { get; set; }

            public string CPF { get; set; }

            public string Matricula { get; set; }

            public DateTime Datnascimento { get; set; }

            public string Sexo { get; set; }

            public double Salario { get; set; }

            public Funcionario() { }
            public Funcionario(string nome, string cpf, string matricula, DateTime datanasc, string sexo, double salario)
            {
                Nome = nome;
                CPF = cpf;
                Matricula = matricula;
                Datnascimento = datanasc;
                Sexo = sexo;
                Salario = salario;

            }

            public virtual void InformarSalarioAdm()
            {

            }
        
    }
}

