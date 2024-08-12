using System.Globalization;
using SextaAtividade.Entities;
using SextaAtividade.Services;
using SextaAtividade.Validators;

namespace SextaAtividade;

public class Program
{
    static void Main(string[] args)
    {
        Admin adm = new Admin(new CadastroService());
        Funcionario funcionario;
        try
        {

            Console.WriteLine("Vamos começar!");
            Console.WriteLine("Primeiro preenche o formulário abaixo com as informações no funcionário: ");
            Console.Write("Nome: ");
            string? nome = Console.ReadLine();
            Console.Write("CPF: ");
            string? cpf = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Matricula da Empresa: ");
            string? matricula = Console.ReadLine();
            Console.Write("CNPJ da Empresa: ");
            string? cnpj = Console.ReadLine();
        
            funcionario = new Funcionario(new CadastroService(), nome, cpf, idade, matricula, cnpj);
            adm.CadastrarFuncionario(funcionario);


            Console.WriteLine();
            Console.WriteLine("Agora vamos cadastrar um pessoa para vacinar:");
            Console.WriteLine("Preenche o formulário abaixo com as informações do paciente: ");

            char continuar;
            do
            {
                Console.Write("Nome: ");
                string? nomeCidadao = Console.ReadLine();
                Console.Write("CPF: ");
                string? cpfCidadao = Console.ReadLine();
                Console.Write("Idade: ");
                int idadeCidadao = int.Parse(Console.ReadLine() ?? string.Empty);
                Cidadao cidadao = new Cidadao(nomeCidadao, cpfCidadao, idadeCidadao);
                funcionario.CadastrarCidadao(cidadao);

                Console.Write("Vaciná-lo? [s/n]: ");
                char vacinar = char.Parse(Console.ReadLine() ?? string.Empty);

                if (vacinar == 's' || vacinar == 'S')
                {
                    cidadao.Vacinar();
                }

                Console.WriteLine();
                Console.Write("Cadastrar outro paciente? [s/n]: ");
                continuar = char.Parse(Console.ReadLine() ?? string.Empty);
            } while (continuar == 's' || continuar == 'S');

            Console.WriteLine();
            Console.WriteLine(funcionario);
            Console.WriteLine();
            Console.WriteLine("Você deseja: ");
            Console.WriteLine("1 - Atualizar um CPF; ");
            Console.WriteLine("2 - Atualizar o numero de matricular;");
            Console.WriteLine("3 - Realizar a gendamento;");
            Console.WriteLine("4 - Sair: ");
            int userResponse = int.Parse(Console.ReadLine() ?? string.Empty);

            switch (userResponse)
            {
                case 1:
                    Console.Write("Informe o CPF atual: ");
                    string? cpfAtual = Console.ReadLine();
                    Console.Write("Informe o novo CPF: ");
                    string? novoCpf = Console.ReadLine();
                    adm.AlterarCpf(cpfAtual, novoCpf);
                    break;
                case 2:
                    Console.Write("Informe a matricula atual: ");
                    string? matriculaAtual = Console.ReadLine();
                    Console.Write("Informe a nova matricula: ");
                    string? novamatricula = Console.ReadLine();
                    adm.AlterarMatricula(matriculaAtual, novamatricula);
                    Console.WriteLine("Matricula Atualizada!");
                    break;
                case 3:
                    Console.Write("Informe o CPF da cidadao: ");
                    string? cpfParaAgendamento = Console.ReadLine();
                    Console.Write("Infome a data dd/MM/yyyy HH:mm: ");
                    DateTime dataDeVacinacao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",
                        CultureInfo.InvariantCulture);
                    funcionario.AgendarVacinacao(cpfParaAgendamento, dataDeVacinacao);
                    break;
                default:
                    Console.WriteLine("Programa encerrado!");
                    break;
            }
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
        Console.ReadLine();
    }
}