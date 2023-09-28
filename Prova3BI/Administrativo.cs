using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3BI
{
    internal class Administrativo : Funcionario
    {
            public double Valetransporte { get; set; }
            public double ValeAlimento { get; set; }

            public Administrativo() { }
            public Administrativo(double valetrans, double valealim, string nome, string cpf, string matricula, DateTime datanasc, string sexo, double salario) :
            base(nome, cpf, matricula, datanasc, sexo, salario)
            {
                Valetransporte = valetrans;
                ValeAlimento = valealim;
            }

            public override void InformarSalarioAdm()
            {
                Salario = 0;
                Valetransporte = 250;
                double salariominimo = 2000;
                Salario = salariominimo + Valetransporte + (salariominimo * 17) / 100;
                Console.WriteLine($"Seu sálario é de: {Salario}");
                base.InformarSalarioAdm();
            }


        
    }
}
