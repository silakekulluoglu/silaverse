using BusinessLayer.Dtos;
using BusinessLayer.HttpService;
using System.Text.Json;

using DataAccessLayer.Entities;
using Riok.Mapperly.Abstractions;
using System.Text;
using BusinessLayer.Enums;
using System.Reflection;

namespace BusinessLayer.ThingService
{
    public class GetPopularThings
    {
        private readonly GetJsonResponse _getJsonResponse;
        private readonly string _baseAddress = "https://api.thingiverse.com";
        private readonly string _access_token = "/?access_token=e8e90732c487dc9b7c578b3aa14fb256";
        public int _total; // jsonda getirilen productların toplam sayısı


        public GetPopularThings(GetJsonResponse getJsonResponse)
        {
            _getJsonResponse = getJsonResponse;
        }

        public async Task<List<ThingDto>> GetPopularThingsAsync(int page = 1, int per_page = 12, string endpoint = "", string searchTerm = "")
        {
            string page_link = $"&page={page}&per_page={per_page}";
            string link = _baseAddress + $"/search/{searchTerm}" + _access_token + page_link + endpoint;
            
            string jsonResponse = await _getJsonResponse.GetJsonResponseAsync(link);

            Console.WriteLine("endpoint: " + endpoint);

            JsonDocument doc = JsonDocument.Parse(jsonResponse);
            JsonElement root = doc.RootElement;

            if (root.GetProperty("total").ValueKind == JsonValueKind.Number)
            {
                _total = root.GetProperty("total").GetInt32();

                var things = JsonSerializer.Deserialize<List<Thing>>(root.GetProperty("hits").ToString());
                var thingDtos = things?.Select(thing => ThingMapper.ThingToThingDto(thing)).ToList();

                return thingDtos ?? new List<ThingDto>();

            }
            else
            {
                _total = 0;
                return new List<ThingDto>();
            }
        }
        public async Task<ThingDetailDto> GetThingDetailAsync(int thing_id)
        {
            string link = _baseAddress + $"/things/{thing_id}" + _access_token;

            string jsonResponse = await _getJsonResponse.GetJsonResponseAsync(link);

            JsonDocument doc = JsonDocument.Parse(jsonResponse);
            JsonElement root = doc.RootElement;

            var thing = JsonSerializer.Deserialize<ThingDetail>(root);
            var thingDetailDto = ThingDetailMapper.ThingToThingDetailDto(thing);

            return thingDetailDto;
        }
    }
}