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

        public Task<School> GetObjectById(Func<School, bool> condition)
        {
            return Task.FromResult(_context.Schools.Where(condition).FirstOrDefault());
        }
    }
}
