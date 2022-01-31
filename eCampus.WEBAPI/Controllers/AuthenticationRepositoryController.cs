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
        private readonly eCampusContext _context;
        public AuthenticationRepositoryController(eCampusContext context)
        {
            _context = context;
        }
        [HttpPost("create_user")]
        public Task<OperationResult> PostUserItem(User user)
        {
            try
            {
                var identityUser = new IdentityUser();
                
                identityUser.Id = Guid.NewGuid().ToString();
                identityUser.Email = user.Email;
                identityUser.PhoneNumber = user.PhoneNumber;
                identityUser.PasswordHash = user.Password;

                var result = _context.Users.Add(identityUser);
                var op = new OperationResult();
                op.AddMessage("User created successfully!!");
                op.Success  =true;
                
                return Task.FromResult(op);
            }
            catch (System.Exception)
            {
                throw;
            }

        }
    }
}
