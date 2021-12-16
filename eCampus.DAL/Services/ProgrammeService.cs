using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;

namespace eCampus.DAL.Services
{
    public class ProgrammeService : IProgrammeRepository
    {
        private readonly IProgrammeRepository _programmeRepository;
        private readonly IOperationResult _operationResult;
        public ProgrammeService(IProgrammeRepository programmeRepository, IOperationResult operationResult)
        {
            _programmeRepository = programmeRepository;
            _operationResult = operationResult;
        }

        public IOperationResult Add(Programme programme)
        {
            _programmeRepository.Add(programme);
            return _operationResult;
        }

        public Task<IList<Programme>> GetAllObjects()
        {
            return _programmeRepository.GetAllObjects();
        }

        public Task<Programme> GetObjectById(Expression<Func<Programme, bool>> filter)
        {
            return _programmeRepository.GetObjectById(filter);
        }

        public IOperationResult RemoveObjectById(Expression<Func<Programme, bool>> s)
        {
            _programmeRepository.RemoveObjectById(s);
            return _operationResult;
        }

        public IOperationResult Update(Programme programme, Expression<Func<Programme, bool>> s)
        {
            _programmeRepository.Update(programme, s);
            return _operationResult;
        }
    }
}
