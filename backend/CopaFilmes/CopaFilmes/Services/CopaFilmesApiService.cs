using CopaFilmes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CopaFilmes.Services
{
    public class CopaFilmesApiService
    {
        public HttpClient Client { get; set; }

        public CopaFilmesApiService(HttpClient client)
        {
            client.BaseAddress = new Uri("http://copafilmes.azurewebsites.net/api/filmes");
            Client = client;
        }

        public async Task<IEnumerable<Filme>> GetFilmes()
        {
            var response = await Client.GetAsync("filmes");
            response.EnsureSuccessStatusCode();
            using var responseStream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<IEnumerable<Filme>>(responseStream);
        }
    }
}
