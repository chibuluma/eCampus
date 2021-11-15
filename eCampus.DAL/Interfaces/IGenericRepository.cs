using eCampus.COMMON;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eCampus.DAL.Interfaces
{
    public interface IGenericRepository<T, S>
    {
        IOperationResult Add(T t); // generic add method
        Task<T> GetObjectById (S filter); // generic filter by id method
        Task<IList<T>> GetAllObjects(); // generic return all result sets methos
        IOperationResult Update(T t, S s); // generic update method
        IOperationResult RemoveObjectById(S s); // generic remove method
    }
}
