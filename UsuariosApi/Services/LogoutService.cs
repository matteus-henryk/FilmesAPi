using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;

namespace UsuariosApi.Services
{
    public class LogoutService
    {
        private SignInManager<IdentityUser<int>> _signinMenager;

        public LogoutService(SignInManager<IdentityUser<int>> signinMenager)
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
