using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StripeIntegration.Client.Store
{
    public class PaymentState
    {
		public bool IsLoading { get; private set; }
		public string ErrorMessage { get; private set; }
		public string Token { get; private set; }

		public PaymentState(bool isLoading, string errorMessage, string token)
		{
			IsLoading = isLoading;
			ErrorMessage = errorMessage;
			Token = token;
		}
	}
}
