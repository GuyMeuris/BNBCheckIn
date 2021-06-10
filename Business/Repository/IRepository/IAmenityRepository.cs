using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IAmenityRepository
    {
        public Task<AmenityDTO> CreateAmenity(CreateAmenityDTO hotelAmenity);

        public Task<AmenityDTO> UpdateAmenity(int amenityId, AmenityDTO hotelAmenity);

        public Task<int> DeleteAmenity(int amenityId);

        public Task<IEnumerable<AmenityDTO>> GetAllAmenities();

        public Task<AmenityDTO> GetAmenity(int amenityId);

        public Task<AmenityDTO> GetAmenityByName(string amenityName);

        public Task<AmenityDTO> IsAmenityUnique(string name, int amenityId = 0);
    }
}
