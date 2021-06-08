using BnBCheckIn_Client.Service.IService;
using ModelsDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BnBCheckIn_Client.Service
{
    public class RoomOrderDetailsService : IRoomOrderDetailsService
    {
        // First we need to include our 'HttpClient'-object using depency injection.
        private readonly HttpClient _client;

        public RoomOrderDetailsService(HttpClient client)
        {
            _client = client;
        }
        //*************************************************************************************

        // Here we can start detailing our 'CRUD'-operations in the form of actions (= methods).

        public async Task<RoomOrderDetailsDTO> MarkPaymentSuccessful(RoomOrderDetailsDTO detailsDTO)
        {
            var content = JsonConvert.SerializeObject(detailsDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/bnbroomorder/paymentsuccessful", bodyContent);
            var contentTemp = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            var result = JsonConvert.DeserializeObject<RoomOrderDetailsDTO>(contentTemp);
            return result;
        }

        public async Task<RoomOrderDetailsDTO> SaveRoomOrderDetails(CreateRoomOrderDetailsDTO createDetailsDTO)
        {
            /*createDetailsDTO.UserId = "dummy user";*/      // Used this while we had no authentication functionality
            var content = JsonConvert.SerializeObject(createDetailsDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/bnbroomorder/create", bodyContent);

            // Extra info while debugging, place a breakpoint here to see the response result
            //string res = response.Content.ReadAsStringAsync().Result;

            var contentTemp = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            var result = JsonConvert.DeserializeObject<RoomOrderDetailsDTO>(contentTemp);
            return result;
        }
    }
}
