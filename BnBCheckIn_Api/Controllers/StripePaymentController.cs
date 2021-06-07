using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
    public class StripePaymentController : ControllerBase
    {
        private readonly IConfiguration _config;

        public StripePaymentController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Create(StripePaymentDTO payment)
        {
            try
            {
                var domain = _config.GetValue<string>("BnBCheckIn_Client_URL");
                var options = new SessionCreateOptions
                {
                    PaymentMethodTypes = new List<string>
                    {
                        "card"
                    },
                    LineItems = new List<SessionLineItemOptions> 
                    { 
                        new SessionLineItemOptions
                        {
                            PriceData = new SessionLineItemPriceDataOptions
                            {
                                UnitAmount = payment.Amount,     
                                Currency = "EUR",
                                ProductData = new SessionLineItemPriceDataProductDataOptions
                                {
                                    Name = payment.BnBRoomProduct
                                }
                            },
                            Quantity = 1
                        }
                    },
                    Mode = "payment",
                    SuccessUrl = domain + "/success-payment?session_id={{CHECKOUT_SESSION_ID}}",
                    CancelUrl = domain + payment.ReturnUrl
                };

                var service = new SessionService();
                Session session = await service.CreateAsync(options);

                return Ok(new SuccessResponseDTO()
                {
                    Data = session.Id      // Most important variable! Contains all the Stripe payment details!
                });
            }
            catch (Exception ex)
            {
                Log.Error("The creation of a payment object was unsuccessful.");
                return BadRequest(new ErrorResponseDTO { ErrorMessage = ex.Message});
            }
        }
    }
}
