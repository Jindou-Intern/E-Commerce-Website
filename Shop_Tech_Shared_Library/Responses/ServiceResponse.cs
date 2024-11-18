
namespace Shop_Tech_Shared_Library.Responses
{
	public record class ServiceResponse(bool Flag, string Message=null!);
	public record class LoginResponse(bool Flag, string? Message,string Token=null!, string RefreshToken= null!);
	
}
