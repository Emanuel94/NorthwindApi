using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using Northwind.UnitOfWork;
using NorthWind.WebApi.Authentication;
using System;

namespace NorthWind.WebApi.Controllers
{
    [Route("api/token")]
    public class TokenController: Controller
    {
        private ITokenProvider _tokenProvider;
        private IUnitOfWork _unitOfWOrk;

        public TokenController(ITokenProvider tokenProvider, IUnitOfWork unitOfWork)
        {
            _tokenProvider = tokenProvider;
            _unitOfWOrk = unitOfWork;
        }
        [HttpPost]
        public JsonWebToken Post([FromBody]User UserLogin)
        {
            var user = _unitOfWOrk.User.ValidateUser(UserLogin.Email, UserLogin.Password);
            if(user == null)
            {
                throw new UnauthorizedAccessException();
            }
            var token = new JsonWebToken
            {
                Access_Token = _tokenProvider.createToken(user, DateTime.UtcNow.AddHours(8)),
                Expire_in = 480 //minutes
            };
            return token;
        }
    }
}
