using WebApi.Data;
using WebApi.Models;

namespace WebApi.Repositories.Impl
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        public AccountRepository(AnimalsChipizationDbContext dbContext)
            : base(dbContext)
        { }
    }
}
