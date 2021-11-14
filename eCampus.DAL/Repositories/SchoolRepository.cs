using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;

namespace eCampus.DAL.Repositories{
    public class SchoolRepository : GenericRepository<Student>
    {
        public SchoolRepository(eCampusContext context, OperationResult logResult) 
            : base(context, logResult)
        {
        }
    }
}
