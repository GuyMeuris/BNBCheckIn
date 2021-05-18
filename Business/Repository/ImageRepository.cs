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
    public class ImageRepository : IImageRepository
    {
        // First we need to include our 'BnBDbContext'-object and
        // 'IMapper'-object using depency injection.
        private readonly BnBDbContext _context;

        private readonly IMapper _mapper;

        public ImageRepository(BnBDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //*************************************************************************************

        // Here we can start detailing our 'CRUD'-operations in the form of actions (= methods).

        public async Task<int> CreateImage(CreateImageDTO imageDTO)
        {
            var image = _mapper.Map<CreateImageDTO, Image>(imageDTO);
            await _context.Images.AddAsync(image);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteImageByImageId(int imageId)
        {
            var image = await _context.Images.FindAsync(imageId);
            _context.Images.Remove(image);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteImageByImageUrl(string imageUrl)
        {
            var image = await _context.Images.FirstOrDefaultAsync(x => x.ImageSourceUrl.ToLower() == imageUrl.ToLower());
            _context.Images.Remove(image);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteImagesByRoomId(int roomId)
        {
            var imageList = await _context.Images.Where(x => x.RoomId == roomId).ToListAsync();
            _context.Images.RemoveRange(imageList);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ImageDTO>> GetHotelRoomImages(int roomId)
        {
            return _mapper.Map<IEnumerable<Image>, IEnumerable<ImageDTO>>(
            await _context.Images.Where(x => x.RoomId == roomId).ToListAsync());
        }
    }
}
