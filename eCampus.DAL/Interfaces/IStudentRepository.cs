using System;
using System.Linq.Expressions;
using eCampus.DAL.Models;

namespace eCampus.DAL.Interfaces
{
    public interface IStudentRepository : IGenericRepository<Student, Expression<Func<Student, bool>>>
    {
    }
}
