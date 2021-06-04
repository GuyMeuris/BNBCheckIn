using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BnBCheckIn_Client.Service.IService;
using ModelsDTO;
using Newtonsoft.Json;

namespace BnBCheckIn_Client.Service
{
    public class BnBService : IBnBService
    {
        private readonly HttpClient _client;

        public BnBService(HttpClient client)
        {
            _client = client;
        }
        public async Task<IEnumerable<BnBDTO>> GetBnBs(string province)
        {

            var response = await _client.GetAsync($"api/bnb/GetBnBByProvince?province={province}");
            var content = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            var bnbs = JsonConvert.DeserializeObject<IEnumerable<BnBDTO>>(content);
            return bnbs;
        }
    }
}
