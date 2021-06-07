using Business.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsDTO;
using Serilog;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BnBCheckIn_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BnBRoomOrderController : ControllerBase
    {
        private readonly IRoomOrderDetailsRepository _repository;

        public BnBRoomOrderController(IRoomOrderDetailsRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RoomOrderDetailsDTO details)
        {
            if (ModelState.IsValid)
            {
                var result = await _repository.Create(details);
                return Ok(result);
            }
            else
            {
                Log.Error("The creation of the room order details was unsuccessful.");
                return BadRequest(new ErrorResponseDTO { ErrorMessage = "Error while creating room order details." });
            }
        }

        [HttpPost]
        public async Task<IActionResult> PaymentSuccessful([FromBody] RoomOrderDetailsDTO details)
        {
            // First we have to validate was really successful or not
            var service = new SessionService();
            var sessionDetails = service.Get(details.StripeSessionId);

            if (sessionDetails.PaymentStatus == "paid")
            {
                var result = await _repository.MarkPaymentSuccessful(details.OrderId);
                if (result is null)
                {
                    Log.Error("The payment of the order was unsuccessful.");
                    return BadRequest(new ErrorResponseDTO { ErrorMessage = "Payment was unsuccesful." });
                }
                return Ok(result);
            }
            else
            {
                Log.Error("The payment status was not 'paid'.");
                return BadRequest(new ErrorResponseDTO { ErrorMessage = "Payment status not 'paid'." });
            }
        }
    }
}
