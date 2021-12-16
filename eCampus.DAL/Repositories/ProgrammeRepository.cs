using System;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;

namespace eCampus.DAL.Repositories
{
    public class ProgrammeRepository : GenericRepository<Programme>, IProgrammeRepository
    {
        public ProgrammeRepository(IeCampusContext context, IOperationResult logResult) 
            : base(context, logResult)
        {
        }
    }
}
