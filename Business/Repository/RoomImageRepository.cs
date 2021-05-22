using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class RoomImageRepository : IRoomImageRepository
    {
        // First we need to include our 'BnBDbContext'-object and
        // 'IMapper'-object using depency injection.
        private readonly BnBDbContext _context;

        private readonly IMapper _mapper;

        public RoomImageRepository(BnBDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //*************************************************************************************

        // Here we can start detailing our 'CRUD'-operations in the form of actions (= methods).

        public async Task<int> CreateImage(RoomImageDTO imageDTO)
        {
            var image = _mapper.Map<RoomImageDTO, RoomImage>(imageDTO);
            await _context.RoomImages.AddAsync(image);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteImageByImageId(int imageId)
        {
            var imageDetails = await _context.RoomImages.FindAsync(imageId);
            if (imageDetails is not null)
            {
                var image = await _context.RoomImages.FindAsync(imageId);
                _context.RoomImages.Remove(image);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<int> DeleteImageByImageUrl(string imageUrl)
        {
            var image = await _context.RoomImages.FirstOrDefaultAsync(x => x.RoomImageSourceUrl.ToLower() == imageUrl.ToLower());
            _context.RoomImages.Remove(image);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteImagesByRoomId(int roomId)
        {
            var imageList = await _context.RoomImages.Where(x => x.RoomId == roomId).ToListAsync();
            _context.RoomImages.RemoveRange(imageList);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<RoomImageDTO>> GetHotelRoomImages(int roomId)
        {
            return _mapper.Map<IEnumerable<RoomImage>, IEnumerable<RoomImageDTO>>(
            await _context.RoomImages.AsNoTracking().Where(x => x.RoomId == roomId).ToListAsync());
        }
    }
}
