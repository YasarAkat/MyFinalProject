using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper //Kimlik bilgilerini imzalama olayını yapıyoruz.
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}

//NOT : Burada şifreleme için anahtar olarak securityKey algoritma olarak SecurityAlgorithms.HmacSha2565Signature kullan diyoruz.