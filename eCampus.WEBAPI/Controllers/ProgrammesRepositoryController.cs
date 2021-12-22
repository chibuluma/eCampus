using System.Threading.Tasks;
using eCampus.COMMON;
using eCampus.DAL.Models;
using eCampus.DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCampus.WEBAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProgrammesRepositoryController : ControllerBase
    {
        private readonly ProgrammeService _programmeService;
        public ProgrammesRepositoryController(ProgrammeService programmeService)
        {
            _programmeService = programmeService;
        }

        [HttpGet("get_all_programmes")]
        public async Task<IActionResult> GetAllAsync()
        {
            var allProgrammes = await _programmeService.GetAllObjects();

            return Ok(allProgrammes);
        }

        [HttpGet("get_programme_by_id")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var filtered_school = await _programmeService.GetObjectById( i => i.ProgrammeId == id);

            return Ok(filtered_school);
        }

        [HttpGet("remove_programme_by_id")]
        public IActionResult RemoveByIdAsync(string id)
        {
            var filtered_school =  _programmeService.RemoveObjectById( i => i.ProgrammeId == id);

            return Ok(filtered_school);
        }
        
        [HttpPost("post_programme")]
        [Authorize]
        public Task<IOperationResult> PostProgrammeItem(Programme programme){
            try
            {
                var result = _programmeService.Add(programme);
                return Task.FromResult(result); 
            }
            catch (System.Exception)
            {           
                throw;
            }

        }
    }
}
