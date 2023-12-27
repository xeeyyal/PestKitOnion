using PestKitOnionAB104.Application.DTOs.Users;

namespace PestKitOnionAB104.Application.Abstractions.Services
{
    public interface IAuthenticationService
    {
        Task Register(RegisterDto dto);
    }
}
