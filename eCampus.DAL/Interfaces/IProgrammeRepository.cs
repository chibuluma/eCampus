using System;
using System.Linq.Expressions;
using eCampus.DAL.Models;

namespace eCampus.DAL.Interfaces
{
    public interface IProgrammeRepository : IGenericRepository<Programme, Expression<Func<Programme, bool>>>
    {
    }
}
