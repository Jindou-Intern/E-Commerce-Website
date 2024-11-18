using Shop_Tech_Client.PrivateModels;
using Shop_Tech_Shared_Library.Models;
using Shop_Tech_Shared_Library.Responses;

namespace Shop_Tech_Client.Services
{
    public interface ICart
    {
        public Action? CartAction { get; set; } 
        public int CartCount { get;set; }
        Task GetCartCount();
        Task<ServiceResponse> AddToCart(Product model, int updateQuantity = 1);
        Task<List<Order>> MyOrders();
        Task<ServiceResponse>DeleteCart(Order cart);
        bool IsCartLoaderVisible { get; set; }
    }
}
