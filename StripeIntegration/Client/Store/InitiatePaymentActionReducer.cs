using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StripeIntegration.Client.Store
{
    public class InitiatePaymentActionReducer : Reducer<PaymentState, InitiatePaymentAction>
    {
        public override PaymentState Reduce(PaymentState state, InitiatePaymentAction action)
        {
            return new PaymentState(
                isLoading: true,
                errorMessage: null,
                token: null
                );
        }
    }
}
