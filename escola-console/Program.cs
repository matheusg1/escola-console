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
            int? v2 = null;
            while (v2 != 0)
            {
                Console.WriteLine("Obter informações sobre:");
                Console.WriteLine("1: Escolas");
                Console.WriteLine("2: Turmas");
                Console.WriteLine("3: Matérias");
                Console.WriteLine("4: Alunos");
                Console.WriteLine("0: Sair");

                try
                {
                    v2 = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Valor inválido, insira um valor numérico");
                }
            }
            /*
            Console.WriteLine("Hello World!");

            var v1 = new EscolaService();
            var listaEscolas = await v1.GetEscolas();
            
            foreach(var item in listaEscolas)
            {
                Console.WriteLine(item.Nome);
            }*/

            //var v2 = new AlunoService();
            //var v3 = await v2.GetAlunoById(2);
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
}
