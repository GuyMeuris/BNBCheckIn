using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsDTO;

namespace BnBCheckIn_Client.Service.IService
{
    public interface IBnBService
    {
        public Task<IEnumerable<BnBDTO>> GetBnBs(string province);
    }
}
