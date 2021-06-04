using BnBCheckIn_Client.Service.IService;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        public Task<RoomOrderDetailsDTO> MarkPaymentSuccessful(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RoomOrderDetailsDTO> SaveRoomOrderDetails(CreateRoomOrderDetailsDTO createDetailsDTO)
        {
            throw new NotImplementedException();
        }
    }
}
