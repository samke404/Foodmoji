using Foodmoji.Api.Tools;
using Foodmoji_Application.Helpers.Extensions;
using Foodmoji_Application.Repository.DomainRepository;
using Foodmoji_Application.ViewModels.Account;
using Foodmoji_Domain.Models;
using Foodmoji_Infastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Security.Principal;

namespace Foodmoji.Api.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        //inject db

        private readonly IAccountRepository _accountRepo;
        public AccountController(IAccountRepository accountRepo)
        {
            _accountRepo = accountRepo;
        }

        [HttpPost]
        [Route("registerAccount")]
        public async Task<IActionResult> createUserAccount([FromBody] RegisterAccountViewModel account)
        {
            try
            {
                //If user does not meet data annotations requirememnt execute condition below

                if (!ModelState.IsValid) return BadRequest(ModelState);

                //Check if user already has an account using their email address

                var dbUser = _accountRepo.Where(user => user.Email == account.Email).FirstOrDefault();

                if (dbUser != null)
                {
                    return BadRequest("Email is already registered, please login");
                }
                else
                {
                    //create account
                    var newAccount = account.ToEntity();

                    //Add changes to db
                    _accountRepo.Create(newAccount);

                    _accountRepo.Save();
                    return Ok(newAccount.Id);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }




        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> userLogin([FromBody] LoginViewModel account)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                
                //String userPassword = password.hashPassword(account.Password);
                var dbUser = _accountRepo.Where(user => user.Email == account.Email && user.Password == account.Password).Select(user => new
                {
                    user.Id,
                    user.Email,
                    user.FirstName

                }).FirstOrDefault();

                if (dbUser == null)
                {
                    return BadRequest("Email or Password is incorrect, please enter valid credintials");
                }

                return Ok(dbUser);
            

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpPut]
        [Route("updateUserAccount")]
        public async Task<IActionResult> updateUserAccount([FromBody] UpdateAccountViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var userAccount = _accountRepo.Where(x => x.Id == model.Id).FirstOrDefault();

                if (userAccount != null)
                {
                   var updateAccount = model.ToEntity(userAccount);
                     _accountRepo.Update(updateAccount);
                    _accountRepo.Save();


                    return Ok(updateAccount);


                }

                return NotFound();




            } 
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("getAllAccounts")]
        public async Task<IActionResult> getAllAccounts()
        {
            try
            {
                
                return Ok(_accountRepo.FindAll);
            } 
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
            
        }

        [HttpGet]
        [Route("userAccount/{id}")]
        public async Task<IActionResult> getId(int id)
        { 
            
            return Ok(new {userID = id});
        }

        [HttpGet]
        [Route("Users/currentUser")]
        public async Task<IActionResult> getLoggedInUserID()
        {
            int id = Convert.ToInt32(HttpContext.User.FindFirstValue("userID"));

            return Ok(new { userID = id });
        }

    }
}
