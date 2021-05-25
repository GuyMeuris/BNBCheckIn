using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IRoomRepository
    {
        public Task<RoomDTO> CreateRoom(RoomDTO roomDTO);

        public Task<RoomDTO> UpdateRoom(int roomId, RoomDTO roomDTO);

        public Task<RoomDTO> GetRoom(int roomId);

        public Task<int> DeleteRoom(int roomId);

        public Task<IEnumerable<RoomDTO>> GetAllRooms();

        public Task<IEnumerable<RoomDTO>> GetRoomsbyBnBId(int bnbId);

        public Task<RoomDTO> IsRoomUnique(string name, int roomId = 0);
    }
}
