using Core.Persistence.Repositories;
using Core.Security.Entities;
using ETradeApi.Application.Services.Repositories;
using ETradeApi.Persistance.Contexts;

namespace ETradeApi.Persistance.Repositories
{
    public class OperationClaimRepository : EfRepositoryBase<OperationClaim, BaseDbContext>, IOperationClaimRepository
    {
        public OperationClaimRepository(BaseDbContext context) : base(context)
        {
        }
    }

}
