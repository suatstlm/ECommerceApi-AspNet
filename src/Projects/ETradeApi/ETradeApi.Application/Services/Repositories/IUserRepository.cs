using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace ETradeApi.Application.Services.Repositories
{
    public interface IUserRepository : IAsyncRepository<User>, IRepository<User>
    {
    }
}
