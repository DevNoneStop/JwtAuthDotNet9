using JwtAuthDotNet9.Dtos;
using JwtAuthDotNet9.Models;

namespace JwtAuthDotNet9.Interfaces
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<string?> LoginAsync(UserDto request);
    }
}
