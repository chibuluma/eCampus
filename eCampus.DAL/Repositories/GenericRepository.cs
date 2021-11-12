using System;
using eCampus.DAL.Interfaces;
using System.Collections.Generic;
using eCampus.COMMON;
using eCampus.DAL.Models;

namespace eCampus.DAL.Repositories
{
    public class GenericRepository<T> where T : IGenericRepository<T, string>
    {
        private readonly eCampusContext _context;
        private readonly OperationResult _logResult;
        public GenericRepository(eCampusContext context, OperationResult logResult)
        {
            _context = context;
            _logResult = logResult;
        }
        public OperationResult Add(T t)
        {
            try
            {
                _context.Add(t);
                _context.SaveChanges();
                _logResult.AddMessage($"{t.GetType()} persisted successfully!!");
                return _logResult;
            }
            catch (System.Exception)
            {             
                throw;
            }
        }

        public IList<T> GetAllObjects()
        {
            throw new NotImplementedException();
        }

        public T GetObjectById(string filter)
        {
            throw new NotImplementedException();
        }

        public OperationResult RemoveObjectById(string s)
        {
            throw new NotImplementedException();
        }

        public OperationResult Update(T t, string s)
        {
            throw new NotImplementedException();
        }
    }
}
