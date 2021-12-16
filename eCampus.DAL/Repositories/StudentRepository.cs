using System;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;

namespace eCampus.DAL.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(IeCampusContext context, IOperationResult logResult)
            :base(context, logResult)
        {
        }
    }
}
