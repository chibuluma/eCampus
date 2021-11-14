using System;
using eCampus.DAL.Interfaces;
using System.Collections.Generic;
using eCampus.COMMON;
using eCampus.DAL.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eCampus.DAL.Repositories
{
    public class GenericRepository<T> where T : class, IGenericRepository<T, Func<T, bool>>
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
                _logResult.Success = true;
                return _logResult;
            }
            catch (System.Exception e)
            {  
                _logResult.AddMessage($"{e.ToString()} persisted successfully!!");           
                throw;
            }
        }

        public async Task<IList<T>> GetAllObjects()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            }
            catch (System.Exception)
            {              
                throw;
            }
        }

        public T GetObjectById(Func<T, bool> condition)
        {
            try
            {
                 return _context.Set<T>()
                 .Where(condition).FirstOrDefault();
            }
            catch (System.Exception)
            {              
                throw;
            }
        }

        public OperationResult RemoveObjectById(Func<T, bool> condition)
        {
            try
            {
                var obj= _context.Set<T>()
                 .Where(condition).FirstOrDefault();
                _context.Remove(obj);
                _context.SaveChanges();
                _logResult.AddMessage($"{obj.GetType()} removed successfully!!");
                _logResult.Success = true;
                return _logResult;
            }
            catch (System.Exception e)
            {  
              _logResult.AddMessage($"error: {e.ToString()}");                   
                throw;
            }
        }

        public OperationResult Update(T t, Func<T, bool> condition)
        {
           try
           {
               var obj= _context.Set<T>()
                 .Where(condition).FirstOrDefault(); 
                _context.Update(obj);
                _context.SaveChanges();
                _logResult.AddMessage($"{obj.GetType()} updated successfully!!");
                _logResult.Success = true;
                return _logResult;
           }
           catch (System.Exception e)
           {
               _logResult.AddMessage($"error: {e.ToString()}");                              
               throw;
           }
        }
    }
}
