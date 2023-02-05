using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;
using WebApi.Validations;
using WebApi.ViewModels;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AccountController(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        //Not Finished
        [HttpPost("registration")]
        public IActionResult Registration(AccountRegistrationViewModel accountViewModel)
        {
            AccountRegistrationViewModelValidator validator = new AccountRegistrationViewModelValidator();
            ValidationResult result = validator.Validate(accountViewModel);

            if (!result.IsValid)
            {
                return StatusCode(400);
            }

            if(_accountService.GetByEmail(accountViewModel.Email) != null)
            {
                return StatusCode(409);
            }

            //Запрос от авторизованного аккаунта - StatusCode(403)

            Account account = _mapper.Map<Account>(accountViewModel);
            _accountService.Add(account);
            return StatusCode(201);
        }
    }
}
