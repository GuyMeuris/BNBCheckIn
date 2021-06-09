using Business.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
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
        private readonly IEmailSender _emailSender;
        public BnBRoomOrderController(IRoomOrderDetailsRepository repository, IEmailSender emailSender)
        {
            _repository = repository;
            _emailSender = emailSender;
        }

        [HttpPost(Name = "Create")]
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

        [HttpPost(Name = "PaymentSuccessful")]
        public async Task<IActionResult> PaymentSuccessful([FromBody] RoomOrderDetailsDTO details)
        {
            // First we have to validate if payment was really successful or not
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
                await _emailSender.SendEmailAsync(details.Email, "Bevestiging boeking B&B CheckIn", "Hierbij is Uw boeking bevestigd en Uw betaling aanvaard, met bestelnummer: " + details.OrderId + ".");
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
