using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ToDoTask.Domain.Base;
using ToDoTask.Domain.Interfaces;
using ToDoTask.Infrastructure.Context;

namespace ToDoTask.Infrastructure
{
    public class GenericRepository<T> : IGenericRespository<T> where T : Entity
    {
        protected readonly ApplicationDbContext _context;
        private readonly ILogger _logger;

        public GenericRepository(ApplicationDbContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> Get(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public async Task<Boolean> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return true;
        }

        public async Task<Boolean> Update(T entity)
        {
            var entityInDb = await _context.Set<T>().AnyAsync(x => x.Id == entity.Id);
            if (!entityInDb)
                return false;
            _context.Set<T>().Update(entity);
            return true;
        }

        public async Task<Boolean> Delete(int id)
        {
            var entityInDb = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            if (entityInDb == null)
                return false;
            _context.Set<T>().Remove(entityInDb);
            return true;
        }
    }
}