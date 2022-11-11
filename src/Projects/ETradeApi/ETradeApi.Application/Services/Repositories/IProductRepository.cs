using Core.Persistence.Repositories;
using ETradeApi.Domain.Entities;

namespace ETradeApi.Application.Services.Repositories
{
    public interface IProductRepository : IAsyncRepository<Product>, IRepository<Product>
    {
    }
}
