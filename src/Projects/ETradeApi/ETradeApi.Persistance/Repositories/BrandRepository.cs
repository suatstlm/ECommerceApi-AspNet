using Core.Persistence.Repositories;
using ETradeApi.Application.Services.Repositories;
using ETradeApi.Domain.Entities;
using ETradeApi.Persistance.Contexts;

namespace ETradeApi.Persistance.Repositories
{
    public class BrandRepository: EfRepositoryBase<Brand, BaseDbContext>, IBrandRepository
    {
        public BrandRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
