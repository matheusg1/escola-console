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
    public class AlunoService
    {
        public static async Task<List<Aluno>> GetAlunos()
        {
            RestClient client = new RestClient("https://localhost:44393/");
            RestRequest request = new RestRequest("Aluno/findAll", Method.Get);

            var response = await client.ExecuteAsync(request);
            int status = (int)response.StatusCode;

            if (status >= 200 && status < 300)
            {
                return JsonConvert.DeserializeObject<List<Aluno>>(response.Content.ToString());
            }
            return null;
        }

        public static async Task<Aluno> GetAlunoById(int id)
        {
            RestClient client = new RestClient("https://localhost:44393/");
            RestRequest request = new RestRequest("Aluno/findById", Method.Get).AddParameter("id", id);

            var response = await client.ExecuteAsync(request);
            int status = (int)response.StatusCode;

            if (status >= 200 && status < 300)
            {
                return JsonConvert.DeserializeObject<Aluno>(response.Content.ToString());
            }
            return null;
        }
    }
}
