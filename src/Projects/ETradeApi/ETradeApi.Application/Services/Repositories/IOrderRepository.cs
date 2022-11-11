using Core.Persistence.Repositories;
using ETradeApi.Domain.Entities;

namespace ETradeApi.Application.Services.Repositories
{
    public interface IOrderRepository : IAsyncRepository<Order>, IRepository<Order>
    {
    }
}
