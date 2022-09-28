using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.Services.User;
using Domain.Repository;
using Domain.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _repository;
        private SigningConfigurations _signingConfigurations;
        private IConfiguration _configuration { get; }
        public LoginService(IUserRepository repository,
                            SigningConfigurations signingConfigurations,
                            IConfiguration configuration)
        {
            _repository = repository;
            _signingConfigurations = signingConfigurations;
            _configuration = configuration;
        }

        public async Task<object> FindByLogin(LoginDto user)
        {
            var baseUser = new UserEntity(); //Visa localizar o usuário na base, por isso invoca a entidade

            if (user != null && !string.IsNullOrWhiteSpace(user.UserEmail)) //Validação pra impedir submissão vazia
            {
                baseUser = await _repository.FindByLogin(user.UserEmail);

                if (baseUser == null)
                {
                    return new
                    {
                        authenticated = false,
                        message = "Autenticação falhou. Verifique as credenciais informadas."
                    };
                }
                else
                {
                    var identity = new ClaimsIdentity( //Instanciando os Claims do JWT
                        new GenericIdentity(user.UserEmail),
                        new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), //JTI é o identificador desse token, aqui convertido para String.
                            new Claim(JwtRegisteredClaimNames.UniqueName, user.UserEmail),
                        }
                    );

                    DateTime createDate = DateTime.UtcNow;
                    DateTime expirationDate = createDate + TimeSpan.FromSeconds(Convert.ToInt32(Environment.GetEnvironmentVariable("Seconds")));

                    var handler = new JwtSecurityTokenHandler();

                    //Cria o token...
                    string token = CreateToken(identity, createDate, expirationDate, handler);
                    return SuccessObject(createDate, expirationDate, token, baseUser);
                }
            }
            else
            {
                return new
                {
                    authenticated = false,
                    message = "Autenticação falhou. Verifique as credenciais informadas."
                };
            }
        }

        private string CreateToken(ClaimsIdentity identity, DateTime createDate, DateTime expirationDate, JwtSecurityTokenHandler handler)
        {
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = Environment.GetEnvironmentVariable("Issuer"),
                Audience = Environment.GetEnvironmentVariable("Audience"),
                SigningCredentials = _signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = createDate,
                Expires = expirationDate,
            });

            var token = handler.WriteToken(securityToken);
            return token;
        }

        private object SuccessObject(DateTime createDate, DateTime expirationDate, string token, UserEntity baseUser)
        {
            return new
            {
                authenticated = true,
                create = createDate.ToString("yyyy-MM-dd HH:mm:ss"),
                expiration = expirationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                accessToken = token,
                userId = baseUser.USEREMAIL,
                message = "Olá, " + baseUser.USERNAME + "! Token obtido com sucesso! A vaga na Deloitte é sua."
            };
        }

    }
}
