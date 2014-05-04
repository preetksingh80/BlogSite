using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Abstractions
{
    public class InMemoryRepository<T> : IRepository<T> where T : class
    {
        private ICollection<T> List { get; set; }
        public InMemoryRepository(ICollection<T> list )
        {
            List = list;

        }

        public T Find(Func<T, bool> finder)
        {
            return List.FirstOrDefault(finder);
        }

        public void Add(T item)
        {
            List.Add(item);
        }
    }
}