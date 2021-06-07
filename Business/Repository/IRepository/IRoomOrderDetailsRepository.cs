using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IRoomOrderDetailsRepository
    {
        public Task<RoomOrderDetailsDTO> Create(CreateRoomOrderDetailsDTO createDetailsDTO);
        
        public Task<RoomOrderDetailsDTO> MarkPaymentSuccessful(int id);
        
        public Task<RoomOrderDetailsDTO> GetRoomOrderDetails(int roomOrderId);
        
        public Task<IEnumerable<RoomOrderDetailsDTO>> GetAllRoomOrderDetails();

        public Task<bool> UpdateOrderStatus(int roomOrderId, string status);
    }
}
