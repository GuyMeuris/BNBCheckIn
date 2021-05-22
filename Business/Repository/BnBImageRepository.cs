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
    public class BnBImageRepository: IBnBImageRepository
    {
        // First we need to include our 'BnBDbContext'-object and
        // 'IMapper'-object using depency injection.
        private readonly BnBDbContext _context;

        private readonly IMapper _mapper;

        public BnBImageRepository(BnBDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //*************************************************************************************

        // Here we can start detailing our 'CRUD'-operations in the form of actions (= methods).

        public async Task<int> CreateImage(BnBImageDTO bnbimageDTO)
        {
            var image = _mapper.Map<BnBImageDTO, BnBImage>(bnbimageDTO);
            await _context.BnBImages.AddAsync(image);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteImageByImageId(int imageId)
        {
            var imageDetails = await _context.BnBImages.FindAsync(imageId);
            if (imageDetails is not null)
            {
                var image = await _context.BnBImages.FindAsync(imageId);
                _context.BnBImages.Remove(image);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<int> DeleteImageByImageUrl(string imageUrl)
        {
            var image = await _context.BnBImages.FirstOrDefaultAsync(x => x.BnBImageSourceUrl.ToLower() == imageUrl.ToLower());
            _context.BnBImages.Remove(image);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteImagesByBnBId(int bnbId)
        {
            var imageList = await _context.BnBImages.Where(x => x.BnBId == bnbId).ToListAsync();
            _context.BnBImages.RemoveRange(imageList);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BnBImageDTO>> GetHotelRoomImages(int bnbId)
        {
            return _mapper.Map<IEnumerable<BnBImage>, IEnumerable<BnBImageDTO>>(
            await _context.BnBImages.Where(x => x.BnBId == bnbId).ToListAsync());
        }
    }
}

