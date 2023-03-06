using escola_console.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola_console.Services
{
    public class TurmaService
    {
        public static async Task<List<Turma>> GetTurmas()
        {
            RestClient client = new RestClient("https://localhost:44393/");
            RestRequest request = new RestRequest("Turma/findAll", Method.Get);

            var response = await client.ExecuteAsync(request);
            int status = (int)response.StatusCode;

            if (status >= 200 && status < 300)
            {
                return JsonConvert.DeserializeObject<List<Turma>>(response.Content.ToString());
            }
            return null;
        }

        public static async Task<Turma> GetTurmaById(int id)
        {
            RestClient client = new RestClient("https://localhost:44393/");
            RestRequest request = new RestRequest("Turma/findById", Method.Get).AddParameter("id", id);

            var response = await client.ExecuteAsync(request);
            int status = (int)response.StatusCode;

            if (status >= 200 && status < 300)
            {
                return JsonConvert.DeserializeObject<Turma>(response.Content.ToString());
            }
            return null;
        }
    }
}
