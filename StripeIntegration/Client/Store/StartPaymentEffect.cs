using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StripeIntegration.Client.Store
{
    public class StartPaymentEffect : Effect<InitiatePaymentAction>
    {
        private readonly HttpClient httpClient;

        public StartPaymentEffect(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        protected async override Task HandleAsync(InitiatePaymentAction action, IDispatcher dispatcher)
        {
            try
            {
                var token = await httpClient.GetStringAsync("startpayment");
                dispatcher.Dispatch(new StartPaymentSuccessAction(token));
            }
            catch (Exception e)
            {
                dispatcher.Dispatch(new StartPaymentFailedAction("Failed to retrieve token " + e.Message));

            }
        }
    }
}
