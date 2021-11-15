using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eCampus.DAL.Models;

namespace eCampus.DAL.Interfaces
{
    public interface ISchoolRepository
    {
        Task<IList<School>> GetAllObjects();
        Task<School> GetObjectById(Func<School, bool> condition);
    }
}
