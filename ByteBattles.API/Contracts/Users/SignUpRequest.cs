using System.ComponentModel.DataAnnotations;

namespace ByteBattles.API.Contracts.Users
{
    public record SignUpRequest(
    [Required] string UserName,
    [Required] string Password,
    [Required] string Email);

}
