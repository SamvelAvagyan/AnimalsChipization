using System.Drawing;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Services
{
    public interface IAccountService : IBaseService<Account>
    {
        Account GetByEmail(string email);
        IQueryable<Account> Search(string? firstName, string? lastName, string? email, int from = 0, int size = 10);
    }
}
