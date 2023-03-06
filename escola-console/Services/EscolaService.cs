using escola_console.Models;
using FluentResults;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola_console.Services
{
    public class EscolaService
    {
        public static async Task<List<Escola>> GetEscolas()
        {
            RestClient client = new RestClient("https://localhost:44393/");
            RestRequest request = new RestRequest("Escola/findAll", Method.Get);

            var response = await client.ExecuteAsync(request);
            int status = (int) response.StatusCode;

            if (status >= 200 && status < 300)
            {
                return JsonConvert.DeserializeObject<List<Escola>>(response.Content.ToString());
            }
            return null;
        }
        public static async Task<Escola> GetEscolaById(int id)
        {
            RestClient client = new RestClient("https://localhost:44393/");
            RestRequest request = new RestRequest("Escola/findById", Method.Get).AddParameter("id", id);

            var response = await client.ExecuteAsync(request);
            int status = (int)response.StatusCode;

            if (status >= 200 && status < 300)
            {
                return JsonConvert.DeserializeObject<Escola>(response.Content.ToString());
            }
            return null;
        }

        public static async Task<Result> DeleteEscola(int id)
        {
            RestClient client = new RestClient("https://localhost:44393/");
            RestRequest request = new RestRequest("Escola/delete", Method.Delete).AddParameter("id", id);

            var response = await client.ExecuteAsync(request);
            int status = (int)response.StatusCode;

            if (status >= 200 && status < 300)
            {
                return Result.Ok();
            }
            return Result.Fail("Falha ao deletar");
        }
    }
}