using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Casgem_Jwt_Example.Models
{
    public class BuildToken
    {
       public string CreateToken()
        {
            var bytes = Encoding.UTF8.GetBytes("casgemprojectest");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token = new JwtSecurityToken(issuer: "Http://localhost", audience: "Http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(1), signingCredentials: credentials);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();    
            return handler.WriteToken(token);
        }
    }
}
