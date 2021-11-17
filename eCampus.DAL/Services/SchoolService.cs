using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;
using eCampus.DAL.Repositories;

namespace eCampus.DAL.Services
{
    public class SchoolService : SchoolRepository
    {
        private ISchoolRepository _schoolRepository;
        public SchoolService(IeCampusContext context, IOperationResult logResult, ISchoolRepository schoolRepository) 
            : base(context, logResult)
        {
            _schoolRepository = schoolRepository;
        }

        public async Task<IList<School>> GetAllAsync(){
            var schools = (await _schoolRepository.GetAllObjects());
            return schools;
        }

        public async Task<School> GetByIdAsync(string id){
            return (await _schoolRepository.GetObjectById( id));
        }

    }
}
