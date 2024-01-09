using Flyhigh.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Flyhigh.Desktop.Service
{
    public class GepService : IGepService
    {
        private readonly HttpClient? _httpClient;

        public GepService(IHttpClientFactory? httpClientFactory)
        {
            if (httpClientFactory is not null)
            {
                _httpClient = httpClientFactory.CreateClient("KretaApi");
            }
        }

        public async Task<List<GepAdatok>> SelectAllGep()
        {
            if (_httpClient is object)
            {
                List<GepAdatok>? result = await _httpClient.GetFromJsonAsync<List<GepAdatok>>("api/Student");
                if (result is object)
                    return result;
            }
            return new List<GepAdatok>();
        }
    }
}
