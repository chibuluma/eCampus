using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;

namespace eCampus.DAL.Services
{
    public class DepartmentService : IDepartmentRepository
    {
        private readonly IDepartmentRepository _DepartmentRepository;
        private readonly IOperationResult _operationResult;
        public DepartmentService(IDepartmentRepository DepartmentRepository, IOperationResult operationResult)
        {
            _DepartmentRepository = DepartmentRepository;
            _operationResult = operationResult;
        }

        public IOperationResult Add (Department Department)
        {
            _DepartmentRepository.Add(Department);
            return _operationResult;
        }

        public Task<IList<Department>> GetAllObjects()
        {
            return _DepartmentRepository.GetAllObjects();
        }

        public Task<Department> GetObjectById(Expression<Func<Department, bool>> filter)
        {
            return _DepartmentRepository.GetObjectById(filter);
        }

        public IOperationResult RemoveObjectById(Expression<Func<Department, bool>> s)
        {
            _DepartmentRepository.RemoveObjectById(s);
            return _operationResult;
        }

        public IOperationResult Update(Department Department, Expression<Func<Department, bool>> s)
        {
            _DepartmentRepository.Update(Department, s);
            return _operationResult;
        }
    }
}
