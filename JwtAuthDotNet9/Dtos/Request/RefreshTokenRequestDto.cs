namespace JwtAuthDotNet9.Dtos.Request
{
    public class RefreshTokenRequestDto
    {
        public Guid UserId { get; set; }
        public required  string RefreshToken { get; set; }
    }
}
