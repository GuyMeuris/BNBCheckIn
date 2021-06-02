using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BnBCheckIn_Client.Service.IService
{
    public interface IAmenityService
    {
        public Task<IEnumerable<AmenityDTO>> GetAmenities();
        
        public Task<IEnumerable<AmenityDTO>> GetAmenitiesByBnBId(int bnbId);
        
        public Task<IEnumerable<AmenityDTO>> GetAmenitiesByRoomId(int roomId);
    }
}
