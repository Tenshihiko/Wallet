using System;
using System.Collections.Generic;
using Wallet.Core.Entities;

namespace Wallet.Core.Interfaces
{
    public interface ICrudBll<T>
    {
        T Create(T entity);
        T Get(int id);
        T Update(T entity);
        void Delete(T entity);

        IEnumerable<T> GetAll();
        IEnumerable<T> GetByFilter(int id, Filter<T> filter);
    }
}
