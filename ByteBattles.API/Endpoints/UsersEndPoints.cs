
using ByteBattles.API.Contracts.Users;
using ByteBattles.Application.Services;

namespace ByteBattles.API.Endpoints
{
    public static class UsersEndPoints
    {
        public static IEndpointRouteBuilder MapUsersEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("SignUp", SigUp);
            app.MapPost("SignIn", SigIn);

            return app;
        }

        private static async Task<IResult> SigUp(SignUpRequest signUpRequest, UsersServices usersServices)
        {
            await usersServices.SignUp(signUpRequest.UserName,signUpRequest.Email,signUpRequest.Password);

            return Results.Ok();
        }

        private static async Task<IResult> SigIn()
        {
            throw new NotImplementedException();
        }
    }
}
