using JwtAuthDotNet9.Dtos.Request;
using JwtAuthDotNet9.Dtos.Response;
using JwtAuthDotNet9.Models;

namespace JwtAuthDotNet9.Interfaces
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<TokenResponseDto?> LoginAsync(UserDto request);
    }
}
