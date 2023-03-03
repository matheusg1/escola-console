using escola_console.Models;
using escola_console.Services;
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
        async static Task Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");

            var v1 = new EscolaService();
            var listaEscolas = await v1.GetEscolas();
            
            foreach(var item in listaEscolas)
            {
                Console.WriteLine(item.Nome);
            }*/

            var v2 = new AlunoService();
            var v3 = await v2.GetAlunoById(2);
            Console.WriteLine(v3.Nome);
        }
    }
}
