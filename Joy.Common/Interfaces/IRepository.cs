using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyCore.Interfaces;

public interface IRepository<T, TK> where T : class, IEntity<TK>, new() where TK : IConvertible
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(TK id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }




