using BusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Dtos;

namespace BusinessLayer.HttpService
{
    public class GetJsonResponse
    {
        private readonly HttpClient _httpClient;

        public GetJsonResponse()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.thingiverse.com/")
            };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task<String> GetJsonResponseAsync(string link)
        {
            string json = string.Empty;

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(link);
                response.EnsureSuccessStatusCode();

                json = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
            Console.WriteLine("GetJsonResponse: " + link);

            return json;
        }
    }
}

