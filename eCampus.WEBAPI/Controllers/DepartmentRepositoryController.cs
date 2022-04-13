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

    public class DepartmentRepositoryController : ControllerBase
    {
         private readonly DepartmentService _departmentservice;
        public DepartmentRepositoryController(DepartmentService departmentservice)
        
        {
                    _departmentservice = departmentservice;

        }

        [HttpGet("get_all_departments")]
        public async Task<IActionResult> GetAllAsync()
        {
            var alldepartments = await _departmentservice.GetAllObjects();

            return Ok(alldepartments);
        }

         [HttpGet("get_department_by_id")]
        public async Task<IActionResult> GetByIdAsync(string institutionid,string schoolid, string departmentid)
        {
            var filtered_school = await _departmentservice
                .GetObjectById(  i => i.InstitutionId == institutionid && i.SchoolId == schoolid && i.DepartmentId == departmentid );

            return Ok(filtered_school);
        }


    }
}
