using System;
using System.Linq.Expressions;
using eCampus.DAL.Models;

namespace eCampus.DAL.Interfaces
{
    public interface ICourseRepository : IGenericRepository<Course, Expression<Func<Course, bool>>>
    {
    }
}
