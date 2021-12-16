using System;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;

namespace eCampus.DAL.Repositories
{
    public class LecturerRepository : GenericRepository<Lecturer>, ILecturerRepository
    {
        public LecturerRepository(IeCampusContext context, IOperationResult logResult) 
            : base(context, logResult)
        {
        }
    }
}
