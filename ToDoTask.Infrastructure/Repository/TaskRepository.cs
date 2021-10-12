
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ToDoTask.Domain.Entities;
using ToDoTask.Domain.Interfaces;
using ToDoTask.Infrastructure.Context;

namespace ToDoTask.Infrastructure.Repository
{
    public class TaskRepository : GenericRepository<Tarea>, ITaskRepository
    {
        public TaskRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public async Task<List<Tarea>> getWithUser()
        {
            return await _context.Tasks.Include(e => e.User).ToListAsync();
        }

        public async Task<Tarea> getByIdWithUser(int id)
        {
            return await _context.Tasks.Include(e => e.User).FirstOrDefaultAsync(x=> x.Id == id);
        }
    }
}