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
    }
}
