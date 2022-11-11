using Core.Persistence.Repositories;
using ETradeApi.Application.Services.Repositories;
using ETradeApi.Domain.Entities;
using ETradeApi.Persistance.Contexts;

namespace ETradeApi.Persistance.Repositories
{
    public class OrderRepository : EfRepositoryBase<Order, BaseDbContext>, IOrderRepository
    {
        public OrderRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
