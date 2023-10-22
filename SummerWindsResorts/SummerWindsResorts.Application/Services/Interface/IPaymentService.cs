using SummerWindsResorts.Domain.Entities;
using Stripe.Checkout;

namespace SummerWindsResorts.Application.Services.Interface
{
    public interface IPaymentService
    {
        SessionCreateOptions CreateStripeSessionOptions(Booking booking, Villa villa, string domain);
        Session CreateStripeSession(SessionCreateOptions options);
    }
}
