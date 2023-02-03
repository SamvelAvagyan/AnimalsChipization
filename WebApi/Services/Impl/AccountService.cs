﻿using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Services.Impl
{
    public class AccountService : BaseService<Account>, IAccountService
    {
        public AccountService(IBaseRepository<Account> baseRepository) 
            : base(baseRepository)
        { }
    }
}