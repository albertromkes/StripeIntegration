using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StripeIntegration.Client.Store
{
    public class StartPaymentSuccessActionReducer : Reducer<PaymentState, StartPaymentSuccessAction>
    {
        public override PaymentState Reduce(PaymentState state, StartPaymentSuccessAction action)
        {
            return new PaymentState(
                isLoading: false,
                errorMessage: null,
                token: action.token
                );
        }
    }
}
