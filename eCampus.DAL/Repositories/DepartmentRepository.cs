using System;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;

namespace eCampus.DAL.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(IeCampusContext context, IOperationResult logResult)
          : base(context, logResult)
        {
            
        }
    }
}
