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
        // First we need to include our 'HttpClient'-object using depency injection.
        private readonly HttpClient _client;

        public BnBService(HttpClient client)
        {
            _client = client;
        }

        //*************************************************************************************

        // Here we can start detailing our 'CRUD'-operations in the form of actions (= methods).

        public async Task<IEnumerable<BnBDTO>> GetBnBs(string province)
        {

            var response = await _client.GetAsync($"api/bnb?province={province}");
            var content = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            var bnbs = JsonConvert.DeserializeObject<IEnumerable<BnBDTO>>(content);
            return bnbs;
        }

        public async Task<IEnumerable<BnBDTO>> GetAllBnBs()
        {

            var response = await _client.GetAsync($"api/bnb/All");
            var content = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            var bnbs = JsonConvert.DeserializeObject<IEnumerable<BnBDTO>>(content);
            return bnbs;
        }
    }
}
