using Foodmoji_Application.Helpers.Extensions;
using Foodmoji_Application.ViewModels.Account;
using Foodmoji_Domain.Models;
using Foodmoji_Infastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;



namespace Foodmoji.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        //inject db

        private readonly ApplicationDbContext _db;
        public AccountController(ApplicationDbContext db)
        {
            _db = db;   
        }

        [HttpPost]
        [Route("registerAccount")]
        public async Task<IActionResult> createUserAccount([FromBody] RegisterAccountViewModel account)
        {
            //If user does not meet data annotations requirememnt execute condition below

            if (!ModelState.IsValid) return BadRequest(ModelState);

            //Check if user already has an account using their email address

            var dbUser = _db.Accounts.Where(u => u.Email == account.Email).FirstOrDefault();

            if (dbUser != null)
            {
                return BadRequest("Email is already registered, please login");
            }
            else
            { //create account
                var newAccount = account.ToEntity();

                //Add changes to db
                _db.Accounts.Add(newAccount);
                await _db.SaveChangesAsync();

                return Ok(newAccount.Id);
            }
           
        }

    }
}
