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
    public class StudentsRepositoryController : ControllerBase
    {
        private readonly StudentService _studentService;
        public StudentsRepositoryController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("get_all_students")]
        public async Task<IActionResult> GetAllAsync()
        {
            var allSchools = await _studentService.GetAllObjects();

            return Ok(allSchools);
        }

        [HttpGet("get_student_by_id")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var filtered_school = await _studentService
                .GetObjectById( i => i.StudentId == id);

            return Ok(filtered_school);
        }

        [HttpGet("remove_student_by_id")]
        public IActionResult RemoveByIdAs_schoolServiceync(string id)
        {
            var filtered_school =  _studentService.RemoveObjectById( i => i.StudentId == id);

            return Ok(filtered_school);
        }
        
        [HttpPost("post_student")]
        [Authorize]
        public Task<IOperationResult> PostStudentItem(Student student){
            try
            {
                var result = _studentService.Add(student);
                return Task.FromResult(result); 
            }
            catch (System.Exception)
            {           
                throw;
            }

        }
    }
}

