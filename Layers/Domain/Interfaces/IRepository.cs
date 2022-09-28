using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity //Configuração para receber qualquer tipo de entidade 
    {
        Task<T> InsertAsync(T entity); //Thread
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(Guid GUID);
        Task<T> SelectAsync(Guid GUID);
        Task<IEnumerable<T>> SelectAsync(); //SELECT S/ WHERE
        Task<bool> ExistAsync(Guid GUID);
    }
}
