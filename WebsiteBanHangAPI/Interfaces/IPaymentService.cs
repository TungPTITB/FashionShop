using WebsiteBanHangAPI.Entities;
using WebsiteBanHangAPI.Entities.OrderAggregate;


namespace WebsiteBanHangAPI.Interfaces
{
    public interface IPaymentService
    {
        Task<CustomerBasket> CreateOrUpdatePaymentIntent(string basketId);
        Task<Order> UpdateOrderPaymentSucceeded(string paymentIntentId);
        Task<Order> UpdateOrderPaymentFailed(string paymentIntentId);
    }
}
