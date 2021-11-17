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

        [HttpGet("get_all_schools")]
        public async Task<IActionResult> GetAllAsync()
        {
            var allSchools = await _schoolService.GetAllObjects();

            return Ok(allSchools);
        }

        [HttpGet("get_school_by_id")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var filtered_school = await _schoolService.GetObjectById( i => i.SchoolId == id);

            return Ok(filtered_school);
        }

        [HttpGet("remove_school_by_id")]
        public IActionResult RemoveByIdAsync(string id)
        {
            var filtered_school =  _schoolService.RemoveObjectById( i => i.SchoolId == id);

            return Ok(filtered_school);
        }
        
        [HttpPost("post_school")]
        [Authorize]
        public Task<IOperationResult> PostSchoolItem(School school){
            var result = _schoolService.Add(school);
            return Task.FromResult(result);
        }
    }
}
