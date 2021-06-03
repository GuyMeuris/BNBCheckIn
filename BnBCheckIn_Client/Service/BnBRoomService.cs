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
        // First we need to include our 'HttpClient'-object using depency injection.
        private readonly HttpClient _client;

        public BnBRoomService(HttpClient client)
        {
            _client = client;
        }

        //*************************************************************************************

        // Here we can start detailing our 'CRUD'-operations in the form of actions (= methods).

        public async Task<RoomDTO> GetBnBRoomDetail(int roomId, string checkInDate, string checkOutDate)
        {
            var response = await _client.GetAsync($"api/room/GetRoomByRoomId/{roomId}?checkInDate={checkInDate}&checkOutDate={checkOutDate}");
            var content = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            var room = JsonConvert.DeserializeObject<RoomDTO>(content);
            return room;

        }

        public async Task<IEnumerable<RoomDTO>> GetBnBRooms(string checkInDate, string checkOutDate)
        {
            var response = await _client.GetAsync($"api/room/GetAllRooms?checkInDate={checkInDate}&checkOutDate={checkOutDate}");
            var content = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            var rooms = JsonConvert.DeserializeObject<IEnumerable<RoomDTO>>(content);
            return rooms;
        }
    }
}
