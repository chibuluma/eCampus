using System;
using eCampus.COMMON;
using System.Collections.Generic;

namespace eCampus.DAL.Interfaces
{
    public interface IGenericRepository<T, S>
    {
        OperationResult Add(T t); // generic add method
        T GetObjectById (S filter); // generic filter by id method
        IList<T> GetAllObjects(); // generic return all result sets methos
        OperationResult Update(T t, S s); // generic update method
        OperationResult RemoveObjectById(S s); // generic remove method
    }
}
