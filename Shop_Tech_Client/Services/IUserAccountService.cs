using Shop_Tech_Shared_Library.DTOs;
using Shop_Tech_Shared_Library.Responses;

namespace Shop_Tech_Client.Services
{
    public interface IUserAccountService
    {
        Task<ServiceResponse> Register(UserDTO model);
        Task<LoginResponse>Login(LoginDTO model);
    }
}
