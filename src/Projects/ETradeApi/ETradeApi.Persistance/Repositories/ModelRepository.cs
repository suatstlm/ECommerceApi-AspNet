using Core.Persistence.Repositories;
using ETradeApi.Application.Services.Repositories;
using ETradeApi.Domain.Entities;
using ETradeApi.Persistance.Contexts;

namespace ETradeApi.Persistance.Repositories
{
    public class ModelRepository : EfRepositoryBase<Model, BaseDbContext>, IModelRepository
    {
        public ModelRepository(BaseDbContext context) : base(context)
        {
        }
    }

}
