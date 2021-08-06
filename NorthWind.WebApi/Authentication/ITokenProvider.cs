using Microsoft.IdentityModel.Tokens;
using Northwind.Models;
using System;

namespace NorthWind.WebApi.Authentication
{
    public interface ITokenProvider
    {
        string createToken(User user, DateTime expire);
        TokenValidationParameters GetValidationParameters();
    }
}
