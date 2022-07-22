using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class LogoutService
    {
        private SignInManager<CustomIdentityUser> _signinMenager;

        public LogoutService(SignInManager<CustomIdentityUser> signinMenager)
        {
            _signinMenager = signinMenager;
        }

        public Result DeslogaUsuario()
        {
            var resultadoIdentity = _signinMenager.SignOutAsync();

            if (resultadoIdentity.IsCompletedSuccessfully) return Result.Ok();

            return Result.Fail("Logout falhou");
        }
    }
}
