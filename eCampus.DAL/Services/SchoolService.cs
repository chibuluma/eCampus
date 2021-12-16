using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;

namespace eCampus.DAL.Services
{
    public class SchoolService : ISchoolRepository
    {
        private readonly ISchoolRepository _schoolRepository;
        private readonly IOperationResult _operationResult;
        public SchoolService(ISchoolRepository schoolRepository, IOperationResult operationResult) 
        {
            _schoolRepository = schoolRepository;
            _operationResult = operationResult;
        }

        public IOperationResult Add(School t)
        {
            _schoolRepository.Add(t);
            return _operationResult;
        }

        public async Task<IList<School>> GetAllObjects()
        {
            return await _schoolRepository.GetAllObjects();
        }

        public async Task<School> GetObjectById(Expression<Func<School, bool>> filter)
        {
            return await _schoolRepository.GetObjectById(filter);
        }

        public IOperationResult RemoveObjectById(Expression<Func<School, bool>> s)
        {
            _schoolRepository.RemoveObjectById(s);
            return _operationResult;
        }

        public IOperationResult Update(School school, Expression<Func<School, bool>> filter)
        {
            _schoolRepository.Update(school, filter);
            return _operationResult;
        }
    }
}
