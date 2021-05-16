using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Boilerplate.Application.Requests.Users;
using WebApi.Boilerplate.Application.Wrapper;

namespace WebApi.Boilerplate.Application.Interfaces.Services.Users
{
    public interface IUserService
    {

        Task<IResult> RegisterAsync(RegisterRequest request, string origin);

        Task<IResult<string>> ConfirmEmailAsync(string userId, string code);

        Task<IResult> ForgotPasswordAsync(string emailId, string origin);

        Task<IResult> ResetPasswordAsync(ResetPasswordRequest request);
    }
}
