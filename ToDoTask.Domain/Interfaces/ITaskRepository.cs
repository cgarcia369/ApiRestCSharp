using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoTask.Domain.Entities;

namespace ToDoTask.Domain.Interfaces
{
    public interface ITaskRepository : IGenericRespository<Tarea>
    {
        Task<List<Tarea>> getWithUser();
        Task<Tarea> getByIdWithUser(int id);
    }
}