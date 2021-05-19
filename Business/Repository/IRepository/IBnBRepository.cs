using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsDTO;

namespace Business.Repository.IRepository
{
    public interface IBnBRepository
    {
        public Task<BnBDTO> CreateBnB(CreateBnBDTO createBnBDTO);
        public Task<BnBDTO> GetBnB(int bnbId);
        //public Task<IEnumerable<BnBDTO>> GetBnBsByProvince(string province);
        public Task<IEnumerable<BnBDTO>> GetAllBnBs();
        public Task<BnBDTO> UpdateBnB(int bnbId, BnBDTO bnbDTO);
        public Task<int> DeleteBnB(int bnbId);
        public Task<BnBDTO> IsBnBUnique(string bnbName, int bnbId = 0);
    }
}
