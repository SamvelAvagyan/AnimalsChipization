using AutoMapper;
using WebApi.Models;
using WebApi.ViewModels;

namespace WebApi.Mappings
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<AccountRegistrationViewModel, Account>();
            CreateMap<Account, AccountGetViewModel>();
        }
    }
}
