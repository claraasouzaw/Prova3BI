using Prova3BI;
using System; 

class Program
{
    static void Main(string[] args)
    {

    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleFuncionarios
{
    public partial class MainForm : Form
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string tipo = cboTipoFuncionario.Text;
            Funcionario funcionario = null;

            try
            {
                if (tipo == "Médico")
                {
                    funcionario = CadastrarMedico();
                }
                else if (tipo == "Administrativo")
                {
                    funcionario = CadastrarAdministrativo();
                }
                else
                {
                    MessageBox.Show("Selecione um tipo de funcionário válido.");
                    return;
                }

                funcionarios.Add(funcionario);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar funcionário: {ex.Message}");
            }
        }

        private Medico CadastrarMedico()
        {
            // Implemente a lógica para cadastrar um médico e retorne um objeto Medico.
        }

        private Administrativo CadastrarAdministrativo()
        {
            // Implemente a lógica para cadastrar um funcionário administrativo e retorne um objeto Administrativo.
        }

        private void LimparCampos()
        {
            // Implemente a lógica para limpar os campos de entrada.
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            foreach (var func in funcionarios)
            {
                if (func.CalcularSalarioComBeneficios() > 2000.00)
                {
                    lstResultados.Items.Add(func.ToString());
                }
            }
        }
    }
}