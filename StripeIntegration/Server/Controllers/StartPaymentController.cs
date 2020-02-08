using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StripeIntegration.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]    
    public class StartPaymentController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            StripeConfiguration.ApiKey = "sk_test_very_secret_should_come_from_azure_key_vault"; //Get it from your stripe dashboard

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card",
                    "ideal"
                },                
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        Name = $"Pants with 3 legs",
                        Description = $"Pants for those who have 3 legs",
                        Amount = 100, // 1 euro
                        Currency = "eur",
                        Quantity = 1
                    }
                },
                SuccessUrl = "https://localhost:5001/success?session_id={CHECKOUT_SESSION_ID}",
                CancelUrl = "https://localhost:5001/failed"
            };

            var service = new SessionService();
            Session session = await service.CreateAsync(options);
            return Ok(session.Id);
        }
    }
}
