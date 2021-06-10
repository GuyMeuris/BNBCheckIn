using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using ModelsDTO;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class AmenityRepository : IAmenityRepository
    {
        // First we need to include our 'BnBDbContext'-object and
        // 'IMapper'-object using depency injection.
        private readonly BnBDbContext _context;

        private readonly IMapper _mapper;

        public AmenityRepository(BnBDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //*************************************************************************************

        // Here we can start detailing our 'CRUD'-operations in the form of actions (= methods).

        public async Task<AmenityDTO> CreateAmenity(CreateAmenityDTO amenityDTO)
        {
            var amenity = _mapper.Map<CreateAmenityDTO, Amenity>(amenityDTO);
            amenity.CreatedOn = DateTime.Now;
            amenity.CreatedBy = "";
            var addedAmenity = await _context.Amenities.AddAsync(amenity);
            await _context.SaveChangesAsync();
            return _mapper.Map<Amenity, AmenityDTO>(addedAmenity.Entity);
        }

        public async Task<int> DeleteAmenity(int amenityId)
        {
            var amenityDetails = await _context.Amenities.FindAsync(amenityId);
            if (amenityDetails != null)
            {
                _context.Amenities.Remove(amenityDetails);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<AmenityDTO>> GetAllAmenities()
        {
            return _mapper.Map<IEnumerable<Amenity>, IEnumerable<AmenityDTO>>
                (await _context.Amenities.ToListAsync());
        }

        public async Task<AmenityDTO> GetAmenity(int amenityId)
        {
            var amenity = await _context.Amenities.FirstOrDefaultAsync(x => x.AmenityId == amenityId);
            if (amenity == null)
            {
                return null;
            }
            return _mapper.Map<Amenity, AmenityDTO>(amenity);
        }

        public async Task<AmenityDTO> GetAmenityByName(string amenityName)
        {
            var amenity = await _context.Amenities.FirstOrDefaultAsync(x => x.AmenityName == amenityName);
            if (amenity == null)
            {
                return null;
            }
            return _mapper.Map<Amenity, AmenityDTO>(amenity);
        }

        // If unique returns null else returns the amenity obj
        public async Task<AmenityDTO> IsAmenityUnique(string name, int amenityId = 0)
        {
            try
            {
                if (amenityId == 0)
                {
                    var amenityDetails = await _context.Amenities.FirstOrDefaultAsync
                                        (x => x.AmenityName.ToLower().Trim() == name.ToLower().Trim());
                    return _mapper.Map<Amenity, AmenityDTO>(amenityDetails);
                }
                else
                {
                    var amenityDetails = await _context.Amenities.FirstOrDefaultAsync
                    (x => x.AmenityName.ToLower().Trim() == name.ToLower().Trim() && x.AmenityId != amenityId);
                    return _mapper.Map<Amenity, AmenityDTO>(amenityDetails);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<AmenityDTO> UpdateAmenity(int amenityId, AmenityDTO amenityDTO)
        {
            if (amenityId == amenityDTO.AmenityId)
            {
                var amenityDetails = await _context.Amenities.FindAsync(amenityId);
                var amenity = _mapper.Map<AmenityDTO, Amenity>(amenityDTO, amenityDetails);
                amenity.UpdatedOn = DateTime.Now;
                amenity.UpdatedBy = "";
                var updatedAmenity = _context.Amenities.Update(amenity);
                await _context.SaveChangesAsync();
                return _mapper.Map<Amenity, AmenityDTO>(updatedAmenity.Entity);
            }
            else
            {
                Log.Error("The room failed to update when invoking the 'UpdateRoom'-method.");
                return null;
            }

        }
    }
}
