using System;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;

namespace eCampus.DAL.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(IeCampusContext context, IOperationResult logResult) 
            : base(context, logResult)
        {
        }
    }
}
