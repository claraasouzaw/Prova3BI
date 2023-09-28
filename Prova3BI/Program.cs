using Prova3BI;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor ensira de qual forma você deseja cadastrar: ");
        string escolha = Convert.ToString(Console.ReadLine());
        Console.WriteLine(escolha);

        Funcionario f = new Funcionario();

        if (escolha == "Médico")
        {
            fMedico m = new fMedico();

            List<fMedico> listmed = new List<fMedico>();
            listmed.Add(m);
        }

        else if (escolha == "Administrador")
        {
            Administrativo a = new Administrativo();
            a.InformarSalarioAdm();
            List<Administrativo> listadm = new List<Administrativo>();
            listadm.Add(a);
            foreach (Administrativo a1 in listadm)
            {
                Console.WriteLine($"O salario do administrador é: {a1.InformarSalarioAdm}");
            }
        }

        else
        {
            Console.WriteLine("Vihs!! Ocorreu um erro, por favor tente novamente!");
        }
    }
}

    