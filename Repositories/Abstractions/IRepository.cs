using System;

namespace Repositories.Abstractions
{
    public interface IRepository<T> where T: class 
    {
        T Find(Func<T, bool> finder);
        void Add(T item);
    }
}