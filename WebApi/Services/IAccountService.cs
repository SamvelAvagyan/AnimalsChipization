using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Services
{
    public interface IAccountService : IBaseService<Account>
    {
        Account GetByEmail(string email);
    }
}
