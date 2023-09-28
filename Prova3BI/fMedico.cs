using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3BI
{
    internal class fMedico : Funcionario
    {
            public string CRM { get; set; }
            public double Valorex { get; set; }
            public fMedico() { }


            public fMedico(string crm, double valorex, string nome, string cpf, string matricula, DateTime datanasc, string sexo, double salario) :
            base(nome, cpf, matricula, datanasc, sexo, salario)
            {
                CRM = crm;
                Valorex = valorex;
            }
    }

}
