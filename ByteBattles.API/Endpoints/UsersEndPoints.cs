
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

        private static async Task<IResult> SigIn()
        {
            throw new NotImplementedException();
        }

        private static async Task<IResult> SigUp()
        {
            throw new NotImplementedException();
        }
    }
}
