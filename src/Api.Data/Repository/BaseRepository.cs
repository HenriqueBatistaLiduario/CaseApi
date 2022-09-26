using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        private DbSet<T> _dataset;
        public BaseRepository(MyContext context) //Injeção de dependência do Contexto, configurada na classe do Startup
        {
            _context = context; //Possibilita enxergar o contexto fora do método construtor e disponibilizá-lo para a classe. 
            _dataset = _context.Set<T>();
        }
        public async Task<bool> DeleteAsync(Guid GUID)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.GUID.Equals(GUID));
                if (result == null)
                {
                    return false;
                }

                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ExistAsync(Guid GUID)
        {
            return await _dataset.AnyAsync(p => p.GUID.Equals(GUID));
        }

        public async Task<T> InsertAsync(T entity)
        {
            try
            {
                if (entity.GUID == Guid.Empty)
                {
                    entity.GUID = Guid.NewGuid();
                }

                entity.CREATEDON = DateTime.UtcNow;
                _dataset.Add(entity);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public async Task<T> SelectAsync(Guid GUID)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.GUID.Equals(GUID));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            try
            {
                return await _dataset.ToListAsync(); //Select sem WHERE. Adaptar a partir do momento em que trafegar maior volume de dados. 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.GUID.Equals(entity.GUID));
                if (result == null)
                {
                    return null;
                }

                entity.UPDATEDON = DateTime.UtcNow;
                entity.CREATEDON = result.CREATEDON;

                _context.Entry(result).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }
    }
}
