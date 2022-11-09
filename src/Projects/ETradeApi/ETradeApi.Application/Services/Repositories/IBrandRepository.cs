using Core.Persistence.Repositories;
using ETradeApi.Domain.Entities;

namespace ETradeApi.Application.Services.Repositories
{
    public interface IBrandRepository: IAsyncRepository<Brand>, IRepository<Brand>
    {
    }
}
