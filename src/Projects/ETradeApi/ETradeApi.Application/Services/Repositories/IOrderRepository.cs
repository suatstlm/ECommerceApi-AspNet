using Core.Persistence.Repositories;
using RentACar.Domain.Entities;

namespace RentACar.Application.Services.Repositories
{
    public interface IOrderRepository : IAsyncRepository<Order>, IRepository<Order>
    {
    }
}
