using escola_console.Models;
using escola_console.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace escola_console
{
    public class Program
    {
        public const string api = "https://localhost:44393/";
        public EscolaService _escolaService;
        public TurmaService _turmaService;
        public MateriaService _materiaService;
        public AlunoService _alunoService;

        public Program(EscolaService escolaService, TurmaService turmaService, MateriaService materiaService, AlunoService alunoService)
        {
            _escolaService = escolaService;
            _turmaService = turmaService;
            _materiaService = materiaService;
            _alunoService = alunoService;
        }

        async static Task Main(string[] args)
        {
            int? opcao1 = null;
            while (opcao1 != 0)
            {
                Console.WriteLine("1: Visualizar");
                Console.WriteLine("2: Cadastrar");
                Console.WriteLine("3: Alterar");
                Console.WriteLine("4: Remover");
                Console.WriteLine("0: Sair");

                try
                {
                    opcao1 = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Valor inválido, insira um valor numérico");
                }

                if (opcao1 == 1) { await Visualizar(); }
                if (opcao1 == 4) { await Deletar(); }


            }
        }

        private static async Task Visualizar()
        {
            Console.WriteLine("0: Visualizar escolas");
            Console.WriteLine("1: Visualizar turmas");
            Console.WriteLine("2: Visualizar matérias");
            Console.WriteLine("3: Visualizar alunos");
            int? opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Carregando...");
            switch (opcao)
            {
                case 0:
                    var listaEscolas = await EscolaService.GetEscolas();
                    Console.WriteLine("ID  Nome");
                    foreach (var x in listaEscolas) { Console.WriteLine(x); }
                    break;
                case 1:
                    var listaTurmas = await TurmaService.GetTurmas();
                    Console.WriteLine("ID  Código");
                    foreach (var x in listaTurmas) { Console.WriteLine(x); }
                    break;
                case 2:
                    var listaMaterias = await MateriaService.GetMaterias();
                    Console.WriteLine("ID  Nome");
                    foreach (var x in listaMaterias) { Console.WriteLine(x); }
                    break;
                case 3:
                    var listaAlunos = await AlunoService.GetAlunos();
                    Console.WriteLine("ID  Nome");
                    foreach (var x in listaAlunos) { Console.WriteLine(x); }
                    break;
                default:
                    break;
            }
        }

        private static async Task Deletar()
        {
            Console.WriteLine("0: Deletar escola");
            Console.WriteLine("1: Deletar turma");
            Console.WriteLine("2: Deletar matéria");
            Console.WriteLine("3: Deletar aluno");
            int? opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Carregando...");
            switch (opcao)
            {
                case 0:
                    var listaEscolas = await EscolaService.GetEscolas();
                    Console.WriteLine("ID  Nome");
                    foreach (var x in listaEscolas) { Console.WriteLine(x); }

                    Console.WriteLine("Digite o ID da escola a ser removida");
                    var id = int.Parse(Console.ReadLine());

                    var result = await EscolaService.DeleteEscola(id);
                    if (result.IsSuccess) { Console.WriteLine("Escola removida com sucesso"); }
                    if (result.IsFailed) { Console.WriteLine("Falha ao remover escola"); }
                    break;

                case 1:
                    Console.WriteLine("Digite o ID da qual escola à qual a turma pertence");
                    listaEscolas = await EscolaService.GetEscolas();
                    Console.WriteLine("ID  Código");
                    Console.WriteLine();
                    foreach (var x in listaEscolas) { Console.WriteLine(x); }
                    break;
                case 2:
                    var listaMaterias = await MateriaService.GetMaterias();
                    Console.WriteLine("ID  Nome");
                    foreach (var x in listaMaterias) { Console.WriteLine(x); }
                    break;
                case 3:
                    var listaAlunos = await AlunoService.GetAlunos();
                    Console.WriteLine("ID  Nome");
                    foreach (var x in listaAlunos) { Console.WriteLine(x); }
                    break;
                default:
                    break;
            }
        }
    }




    /*
    public async List<Escola> ExibeEscolas()
    {

    }

    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<>;
    }*/
}

