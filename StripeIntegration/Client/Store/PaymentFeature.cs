using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StripeIntegration.Client.Store
{
    public class PaymentFeature : Feature<PaymentState>
    {
        public override string GetName() => "Payment";

        protected override PaymentState GetInitialState() => new PaymentState(
            isLoading: false,
            errorMessage: null,
            token: null);
    }
}
