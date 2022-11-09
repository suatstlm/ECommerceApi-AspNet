using Core.Persistence.Repositories;
using Core.Security.Entities;
using ETradeApi.Application.Services.Repositories;
using ETradeApi.Persistance.Contexts;

namespace ETradeApi.Persistance.Repositories
{
    public class UserOperationClaimRepository : EfRepositoryBase<UserOperationClaim, BaseDbContext>, IUserOperationClaimRepository
    {
        public UserOperationClaimRepository(BaseDbContext context) : base(context)
        {
        }
    }

}
