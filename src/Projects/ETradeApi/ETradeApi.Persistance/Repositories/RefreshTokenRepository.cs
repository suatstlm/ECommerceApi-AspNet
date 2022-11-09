using Core.Persistence.Repositories;
using Core.Security.Entities;
using ETradeApi.Application.Services.Repositories;
using ETradeApi.Persistance.Contexts;

namespace ETradeApi.Persistance.Repositories
{
    public class RefreshTokenRepository : EfRepositoryBase<RefreshToken, BaseDbContext>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(BaseDbContext context) : base(context)
        {
        }
    }

}
