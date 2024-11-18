using Shop_Tech_Shared_Library.DTOs;
using Shop_Tech_Shared_Library.Responses;

namespace Shop_Tech_Server.Repositories
{
    public interface IUserAccount
    {
        Task<ServiceResponse> Register(UserDTO model);
        Task<LoginResponse> Login(LoginDTO model);
        Task<UserSession>GetUserByToken(string token);
        Task<LoginResponse> GetRefreshToken(PostRefreshTokenDTO model);
    }
}
