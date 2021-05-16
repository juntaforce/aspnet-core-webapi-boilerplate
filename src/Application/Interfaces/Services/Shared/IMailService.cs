using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Boilerplate.Application.Requests.Shared;

namespace WebApi.Boilerplate.Application.Interfaces.Services.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}
