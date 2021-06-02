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
    public class BnBRoomService : IBnBRoomService
    {
        private readonly HttpClient _client;

        public BnBRoomService(HttpClient client)
        {
            _client = client;
        }
        public Task<RoomDTO> GetBnBRoomDetail(int roomId, string checkInDate, string checkOutDate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RoomDTO>> GetBnBRooms(string checkInDate, string checkOutDate)
        {
            var response = await _client.GetAsync($"api/room?checkInDate={checkInDate}&checkOutDate={checkOutDate}");
            var content = await response.Content.ReadAsStringAsync();
            //response.EnsureSuccessStatusCode();
            var rooms = JsonConvert.DeserializeObject<IEnumerable<RoomDTO>>(content);
            return rooms;
        }
    }
}
