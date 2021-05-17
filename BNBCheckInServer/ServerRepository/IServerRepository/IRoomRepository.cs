using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNBCheckInServer.ServerRepository.IServerRepository
{
    public interface IRoomRepository 
    {
        public Task<RoomDTO> CreateRoom(CreateRoomDTO roomDTO);

        public Task<RoomDTO> UpdateRoom(int roomId, RoomDTO roomDTO);

        public Task<RoomDTO> GetRoom(int roomId);

        public Task<int> DeleteRoom(int roomId);

        public Task<IList<RoomDTO>> GetAllRooms();

        public Task<RoomDTO> IsRoomUnique(string name);
    }
}
