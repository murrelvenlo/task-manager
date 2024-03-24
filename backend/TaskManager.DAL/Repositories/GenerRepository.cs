using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL.Data;

namespace TaskManager.DAL.Repositories
{
    public class GenerRepository<T> : IGenerRepository<T> where T : class
    {
        protected TaskManagerContext _context;
        protected DbSet<T> _dbSet;
        public GenerRepository(TaskManagerContext context) 
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task Add(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> Delete(Guid id)
        {
            try
            {
                var entity = await _dbSet.FindAsync(id);
                if (entity != null)
                {
                    _dbSet.Remove(entity);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<T> GetById(Guid id)
        {
            try
            {
                return await _dbSet.FindAsync(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(T entity)
        {
            try
            {
                _dbSet.Update(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
