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
    public class CoursesRepositoryController : ControllerBase
    {
        private readonly CourseService _courseService;
        public CoursesRepositoryController(CourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("get_all_courses")]
        public async Task<IActionResult> GetAllAsync()
        {
            var allCourses = await _courseService.GetAllObjects();

            return Ok(allCourses);
        }

        [HttpGet("get_course_by_id")]
        public async Task<IActionResult> GetByIdAsync(string programmeId,string id)
        {
            var filtered_school = await _courseService
                .GetObjectById(  i => i.CourseId == id && i.ProgrammeId == programmeId);

            return Ok(filtered_school);
        }

        [HttpGet("remove_course_by_id")]
        public IActionResult RemoveByIdAsync(string programmeId, string id)
        {
            var filtered_course =  _courseService
                .RemoveObjectById( i => i.CourseId == id && i.ProgrammeId == programmeId);

            return Ok(filtered_course);
        }
        
        [HttpPost("post_course")]
        [Authorize]
        public Task<IOperationResult> PostCourseItem(Course course){
            try
            {
                var result = _courseService.Add(course);
                return Task.FromResult(result); 
            }
            catch (System.Exception)
            {           
                throw;
            }

        }
    }
}
