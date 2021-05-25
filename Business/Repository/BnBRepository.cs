using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using ModelsDTO;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class BnBRepository : IBnBRepository
    {
        private readonly IMapper _mapper;
        private readonly BnBDbContext _context;
        public BnBRepository(IMapper mapper, BnBDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<BnBDTO> CreateBnB(CreateBnBDTO createBnBDTO) 
        {
            BnB bnb = _mapper.Map<CreateBnBDTO, BnB>(createBnBDTO);
            bnb.CreatedBy = "";
            bnb.CreatedOn = DateTime.Now;
            var addedBnb = await _context.BnBs.AddAsync(bnb);
            await _context.SaveChangesAsync();
            return _mapper.Map<BnB, BnBDTO>(addedBnb.Entity);
        }
        public async Task<BnBDTO> GetBnB(int bnbId)
        {
            try
            {
                BnBDTO bnb = _mapper.Map<BnB, BnBDTO>(
                    await _context.BnBs.Include(x => x.BnBImages).FirstOrDefaultAsync(x => x.BnBId == bnbId));
                return bnb;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "The B&B failed to load when invoking the 'GetBnB'-method.");
                return null;
            }
        }
        public async Task<IEnumerable<BnBDTO>> GetAllBnBs()
        {
            try
            {
                IEnumerable<BnBDTO> bnbDTOs = 
                     _mapper.Map<IEnumerable<BnB>, IEnumerable< BnBDTO>>(_context.BnBs.Include(x => x.BnBImages).Include(x => x.Rooms));
                return bnbDTOs;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "The B&B's failed to load when invoking the 'GetAllBnBs'-method.");
                return null;
            }
        }

        public async Task<BnBDTO> UpdateBnB(int bnbId, BnBDTO bnbDTO)
        {
            try
            {
                if (bnbId == bnbDTO.BnBId)
                {
                    BnB bnbDetails = await _context.BnBs.FindAsync(bnbId);
                    BnB bnb = _mapper.Map<BnBDTO, BnB>(bnbDTO, bnbDetails);
                    bnb.UpdatedBy = "";
                    bnb.UpdatedOn = DateTime.Now;
                    var updatedBnB = _context.BnBs.Update(bnb);
                    await _context.SaveChangesAsync();
                    return _mapper.Map<BnB, BnBDTO>(updatedBnB.Entity);
                }
                else
                {
                    Log.Error("The B&B's 'Id' does not match the bnbDTO.BnBId' when invoking the 'UpdatedBnB'-method.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "The B&B failed to update when invoking the 'UpdateBnB'-method.");
                return null;
            }
        }
        public async Task<int> DeleteBnB(int bnbId)
        {
            var bnbDetails = await _context.BnBs.FindAsync(bnbId);
            if (bnbDetails != null)
            {
                var allImages = await _context.BnBImages.Where(x => x.BnBId == bnbId).ToListAsync();
                _context.BnBImages.RemoveRange(allImages);

                _context.BnBs.Remove(bnbDetails);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }
        public async Task<BnBDTO> IsBnBUnique(string bnbName, int bnbId = 0)
        {
            try
            {
                if (bnbId == 0)
                {
                    BnBDTO bnb = _mapper.Map<BnB, BnBDTO>(
                     await _context.BnBs.FirstOrDefaultAsync(x => x.BnBName.ToLower() == bnbName.ToLower()));
                    return bnb;
                }
                else
                {
                    BnBDTO bnb = _mapper.Map<BnB, BnBDTO>(
                     await _context.BnBs.FirstOrDefaultAsync(x => x.BnBName.ToLower() == bnbName.ToLower()
                    && x.BnBId != bnbId));
                    return bnb;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "An error occured when invoking the 'IsBnBUnique'-method.");
                return null;
            }
        }

    }
}
