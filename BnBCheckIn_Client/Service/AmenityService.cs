using BnBCheckIn_Client.Service.IService;
using ModelsDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BnBCheckIn_Client.Service
{
    public class AmenityService : IAmenityService
    {
        // First we need to include our 'HttpClient'-object using depency injection.
        private readonly HttpClient _client;

        public AmenityService(HttpClient client)
        {
            _client = client;
        }

        //*************************************************************************************

        // Here we can start detailing our 'CRUD'-operations in the form of actions (= methods).

        public async Task<IEnumerable<AmenityDTO>> GetAmenities()
        {
            var response = await _client.GetAsync($"api/amenity/getallamenities");
            var content = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            var amenities = JsonConvert.DeserializeObject<IEnumerable<AmenityDTO>>(content);
            return amenities;
        }

        public async Task<IEnumerable<AmenityDTO>> GetAmenitiesByBnBId(int bnbId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AmenityDTO>> GetAmenitiesByRoomId(int roomId)
        {
            throw new NotImplementedException();
        }
    }
}
