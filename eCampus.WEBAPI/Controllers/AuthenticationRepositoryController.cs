using System.Threading.Tasks;
using eCampus.COMMON;
using eCampus.DAL.Models;
using eCampus.DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System;

namespace eCampus.WEBAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AuthenticationRepositoryController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly eCampusContext _context;
        public AuthenticationRepositoryController(eCampusContext context, UserManager<IdentityUser> userManager ) 
        {
            _context = context;
            _userManager = userManager;
        }
        [HttpPost("create_user")]
        
        public async Task<OperationResult> PostUserItem(User user)
        {
            try
            {
                var identityUser = new IdentityUser();
                
                identityUser.Id = Guid.NewGuid().ToString();
                identityUser.UserName = user.Username;
                identityUser.Email = user.Email;
                identityUser.PhoneNumber = user.PhoneNumber;
                var Tresult = await _userManager.CreateAsync(identityUser, user.Password);

                var op = new OperationResult();

                if(Tresult.Succeeded){
                    op.AddMessage("User created successfully!!");
                    op.Success  =true;
                }
                else{
                    op.AddMessage($"User created failed!! {Tresult}");
                }
               
                return op;
            }
            catch (System.Exception)
            {
                   
                throw;
            }
        }
    }
}
