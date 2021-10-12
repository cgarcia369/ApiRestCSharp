using System.Threading.Tasks;

namespace ToDoTask.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ITaskRepository task { get; set; }
        Task CompleteAsync();
    }
}