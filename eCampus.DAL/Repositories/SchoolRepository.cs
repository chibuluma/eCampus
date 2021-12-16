using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;
using   System.Linq;

namespace eCampus.DAL.Repositories
{
    public class SchoolRepository : GenericRepository<School>, ISchoolRepository
    {
        private readonly IeCampusContext _context;
        public SchoolRepository(IeCampusContext context, IOperationResult logResult)
            : base(context, logResult)
        {
            _context = context;
        }

        public async Task<IList<Department>> GetDepartments(string schoolCode)
        {
            var results = await GetObjectById(x=>x.SchoolCode == schoolCode);

            if(results != null)
               return results.Departments.ToList();
               
            return null;
        }
    }
}
