using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace ETradeApi.Application.Services.Repositories
{
    public interface IEmailAuthenticatorRepository : IAsyncRepository<EmailAuthenticator>, IRepository<EmailAuthenticator>
    {
    }
}
