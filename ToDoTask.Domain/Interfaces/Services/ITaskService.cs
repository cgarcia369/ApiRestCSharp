using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoTask.Domain.DTO;
using ToDoTask.Domain.Entities;

namespace ToDoTask.Domain.Interfaces.Services
{
    public interface ITaskService
    {
        Task<Tarea> Get(int id);
        Task<List<Tarea>> GetAll();
        Task<Tarea> Post(Tarea entity);
    }
}