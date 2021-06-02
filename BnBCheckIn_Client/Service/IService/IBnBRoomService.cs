using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsDTO;

namespace BnBCheckIn_Client.Service.IService
{
    public interface IBnBRoomService
    {
        public Task<IEnumerable<RoomDTO>> GetBnBRooms(string checkInDate, string checkOutDate);
        public Task<RoomDTO> GetBnBRoomDetail(int roomId, string checkInDate, string checkOutDate);
    }
}
