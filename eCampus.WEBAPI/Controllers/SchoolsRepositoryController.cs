using System;
using System.Threading.Tasks;
using eCampus.COMMON;
using eCampus.DAL.Models;
using eCampus.DAL.Repositories;
using eCampus.DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCampus.WEBAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class SchoolsRepositoryController : ControllerBase
    {
        private readonly SchoolService _schoolService;
        public SchoolsRepositoryController(SchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpGet("schools")]
        public async Task<IActionResult> GetAllAsync()
        {
            var allSchools = await _schoolService.GetAllObjects();

            return Ok(allSchools);
        }

        [HttpPost]
        [Authorize]
        public Task<IOperationResult> PostSchoolItem(School school){
            var result = _schoolService.Add(school);
            return Task.FromResult(result);
        }
    }
}
