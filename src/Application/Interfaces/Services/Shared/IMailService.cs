using System.Threading.Tasks;
using WebApi.Boilerplate.Application.Requests.Shared;

namespace WebApi.Boilerplate.Application.Interfaces.Services.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}