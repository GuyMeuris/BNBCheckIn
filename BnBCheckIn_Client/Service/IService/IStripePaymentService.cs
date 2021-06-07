using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BnBCheckIn_Client.Service.IService
{
    public interface IStripePaymentService
    {
        public Task<SuccessResponseDTO> CheckOut(StripePaymentDTO model);
    }
}
