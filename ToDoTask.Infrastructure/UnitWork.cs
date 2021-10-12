using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ToDoTask.Domain.Interfaces;
using ToDoTask.Infrastructure.Context;
using ToDoTask.Infrastructure.Repository;

namespace ToDoTask.Infrastructure
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;

        public ITaskRepository task { get; set; }

        public UnitOfWork(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");
            task = new TaskRepository(context, _logger);
        }

        

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}