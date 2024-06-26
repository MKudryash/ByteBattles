﻿
using ByteBattles.API.Contracts.Users;
using ByteBattles.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ByteBattles.API.Endpoints
{
    public static class UsersEndPoints
    {
        public static IEndpointRouteBuilder MapUsersEndpoints(this IEndpointRouteBuilder app)
        {
             app.MapPost("api/SignUp", SigUp).RequireAuthorization();
            app.MapPost("api/SignIn", SigIn);

            return app;
        }
        private static async Task<IResult> SigUp([FromBody] SignUpRequest signUpRequest, UsersServices usersServices)
        {
            await usersServices.SignUp(signUpRequest.UserName,signUpRequest.Email,signUpRequest.Password);

            return Results.Ok();
        }
       

        private static async Task<IResult> SigIn(SignInRequest request,UsersServices usersServices, HttpContext context)
        {
            var token = await usersServices.SignIn(request.Email, request.Password);
            context.Response.Cookies.Append("secretCookie", token);
            return Results.Ok(token);
        }
    }
}
