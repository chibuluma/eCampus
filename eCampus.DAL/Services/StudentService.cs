using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;

namespace eCampus.DAL.Services
{
    public class StudentService : IStudentRepository
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IOperationResult _operationResult;

        public StudentService(IStudentRepository studentRepository, IOperationResult operationResult)
        {
            _studentRepository = studentRepository;
            _operationResult = operationResult;
        }
        public IOperationResult Add(Student student)
        {
           _studentRepository.Add(student);
           return _operationResult;
        }

        public Task<IList<Student>> GetAllObjects()
        {
            return _studentRepository.GetAllObjects();
        }

        public Task<Student> GetObjectById(Expression<Func<Student, bool>> filter)
        {
            return _studentRepository.GetObjectById(filter);
        }

        public IOperationResult RemoveObjectById(Expression<Func<Student, bool>> s)
        {
            _studentRepository.RemoveObjectById(s);
            return _operationResult;
        }

        public IOperationResult Update(Student student, Expression<Func<Student, bool>> s)
        {
            _studentRepository.Update(student, s);
            return _operationResult;
        }
    }
}
