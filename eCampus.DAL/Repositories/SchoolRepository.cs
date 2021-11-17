using System;
using System.Linq;
using System.Threading.Tasks;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace eCampus.DAL.Repositories
{
    public class SchoolRepository : GenericRepository<School>, ISchoolRepository
    {
        private readonly IeCampusContext _context;
        public SchoolRepository(IeCampusContext context, IOperationResult logResult)
            : base(context, logResult)
        {
        }

        public Task<School> GetObjectById(string condition) 
        {
            var school = _context.Schools.Where(s=>s.SchoolId == condition).FirstOrDefault();
            return Task.FromResult(school);
        }
    }
}
