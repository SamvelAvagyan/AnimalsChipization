using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Services.Impl
{
    public class AccountService : BaseService<Account>, IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IBaseRepository<Account> baseRepository, IAccountRepository accountRepository)
            : base(baseRepository)
        {
            _accountRepository = accountRepository;
        }

        public Account GetByEmail(string email)
        {
            return _accountRepository.GetAll().FirstOrDefault(account => account.Email == email);
        }

        public IQueryable<Account> Search(string? firstName, string? lastName, string? email, int from = 0, int size = 10)
        {
            firstName = firstName?.ToUpper();
            lastName = lastName?.ToUpper();
            email = email?.ToUpper();

            return _accountRepository.GetAll().Where(acc => acc.FirstName == firstName && acc.LastName == lastName && acc.Email == email).Take(size);
        }
    }
}
