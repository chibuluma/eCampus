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
        private readonly IDepartmentRepository _departmentRepository;
         private readonly IOperationResult _operationResult;
         public DepartmentService (IDepartmentRepository DepartmentRepository, IOperationResult operationResult)
         {

                _departmentRepository = departmentRepository;
                _operationResult = operationResult;
         }

        public IOperationResult Add (Department Department)
        {
            _departmentRepository.Add(Department);
            return _operationResult;
        }

        public Task<IList<Department>> GetAllObjects()
        {
            return _departmentRepository.GetAllObjects();
        }

        public Task<Department> GetObjectById( i = i.InstitutionId == institutionid && i.SchoolId == schoolid && i.DepartmentId == departmentid )
        {
            return _departmentRepository.GetObjectById(filter);
        }

        public IOperationResult RemoveObjectById(Expression<Func<Department, bool>> s)
        {
            _departmentRepository.RemoveObjectById(s);
            return _operationResult;
        }


            public IOperationResult Update(Department Department, Expression<Func<Department, bool>> s)
        {
            _departmentRepository.Update(Department, s);
            return _operationResult;
        }

    }
}
