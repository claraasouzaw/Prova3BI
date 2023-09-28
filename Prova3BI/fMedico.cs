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
        public fMedico() { }

        public fMedico(string crm, string nome, string cpf, string matricula, DateTime datanasc, string sexo, double salario);
    }
}
