using System;
using System.Linq.Expressions;
using eCampus.DAL.Models;

namespace eCampus.DAL.Interfaces
{
    public interface ILecturerRepository : IGenericRepository<Lecturer, Expression<Func<Lecturer, bool>>>
    {
    }
}
