using System.ComponentModel.DataAnnotations;

namespace ByteBattles.API.Contracts.Users
{
    public record SignInRequest
    ([Required] string Password,
    [Required] string Email);
}
