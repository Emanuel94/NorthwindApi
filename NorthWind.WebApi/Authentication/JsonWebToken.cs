using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.WebApi.Authentication
{
    public class JsonWebToken
    {
        public string Access_Token { get; set; }
        public string Token_type { get; set; } = "bearer";
        public int Expire_in { get; set; } 
        public string Refresh_Token { get; set; }  

    }
}
