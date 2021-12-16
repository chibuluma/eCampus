using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using eCampus.COMMON;
using eCampus.DAL.Interfaces;
using eCampus.DAL.Models;

namespace eCampus.DAL.Services
{
    public class CourseService : ICourseRepository
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IOperationResult _operationResult;
        public CourseService(ICourseRepository courseRepository, IOperationResult operationResult)
        {
            _courseRepository = courseRepository;
            _operationResult = operationResult;
        }
        public IOperationResult Add(Course course)
        {
            _courseRepository.Add(course);
            return _operationResult;
        }

        public Task<IList<Course>> GetAllObjects()
        {
            return _courseRepository.GetAllObjects();
        }

        public Task<Course> GetObjectById(Expression<Func<Course, bool>> filter)
        {
            return _courseRepository.GetObjectById(filter);
        }

        public IOperationResult RemoveObjectById(Expression<Func<Course, bool>> s)
        {
            _courseRepository.RemoveObjectById(s);
            return _operationResult;
        }

        public IOperationResult Update(Course course, Expression<Func<Course, bool>> s)
        {
            _courseRepository.Update(course, s);
            return _operationResult;
        }
    }
}
