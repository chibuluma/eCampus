using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using eCampus.DAL.Models;

namespace eCampus.DAL.Interfaces
{
    public interface ISchoolRepository : IGenericRepository<School, Expression<Func<School, bool>>>
    {
    }
}
