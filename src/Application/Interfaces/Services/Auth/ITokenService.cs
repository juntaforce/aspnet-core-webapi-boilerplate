using System.Threading.Tasks;
using WebApi.Boilerplate.Application.Requests.Auth;
using WebApi.Boilerplate.Application.Responses.Auth;
using WebApi.Boilerplate.Application.Wrapper;

namespace WebApi.Boilerplate.Application.Interfaces.Services.Auth
{
    public interface ITokenService
    {
        Task<IResult<TokenResponse>> GetTokenAsync(TokenRequest model,string ipAddress);

        Task<IResult<TokenResponse>> RefreshTokenAsync(RefreshTokenRequest model, string ipAddress);
    }
}

