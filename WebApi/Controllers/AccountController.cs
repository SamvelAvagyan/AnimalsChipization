using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Services;
using WebApi.Validations;
using WebApi.ViewModels;

namespace WebApi.Controllers
{
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
            AccountGetViewModel accountGetViewModel = _mapper.Map<AccountGetViewModel>(_accountService.GetByEmail(account.Email));
            return Created("registration", accountGetViewModel);
        }

        [HttpGet("accounts/{accountId}")]
        public IActionResult GetById(int? accountId)
        {
            if(accountId == null || accountId < 0)
            {
                return StatusCode(400);
            }

            Account account = _accountService.GetById(accountId);
            if (account == null)
            {
                return StatusCode(404);
            }

            //Неверные авторизационные данные - 401

            AccountGetViewModel accountViewModel = _mapper.Map<AccountGetViewModel>(account);
            return StatusCode(200, accountViewModel);
        }
    }
}
