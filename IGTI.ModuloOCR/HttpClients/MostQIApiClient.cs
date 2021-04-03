using IGTI.ModuloOCR.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IGTI.ModuloOCR.UI.HttpClients
{
    public class MostQIApiClient
    {
        private readonly HttpClient _httpClient;

        public MostQIApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        private void AddBearerToken()
        {
            var token = "";
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public async Task<MostQIApi> PostContentExtraction()
        {
            AddBearerToken();
            var content = new MultipartContent();

            var resposta = await _httpClient.PostAsync($"process-image/content-extraction/cnh", content);
            
            resposta.EnsureSuccessStatusCode();
            string apiResponse = await resposta.Content.ReadAsStringAsync();
            var objMostQIApi = JsonConvert.DeserializeObject<MostQIApi>(apiResponse);

            return objMostQIApi;

        }
    }
}
