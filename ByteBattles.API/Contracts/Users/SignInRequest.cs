using System.ComponentModel.DataAnnotations;

namespace ByteBattles.API.Contracts.Users
{
    public record SignInRequest
    (   [Required] string Email,
        [Required] string Password
    );
}
