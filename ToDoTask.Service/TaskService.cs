using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Threading.Tasks;
using ToDoTask.Domain.DTO;
using ToDoTask.Domain.Entities;
using ToDoTask.Domain.Interfaces;
using ToDoTask.Domain.Interfaces.Services;

namespace ToDoTask.Service
{
    public class TaskService: ITaskService
    {
        private readonly IUnitOfWork _work;

        public TaskService(IUnitOfWork work)
        {
            _work = work;
        }

        public async Task<Tarea> Get(int id)
        {
            return await _work.task.getByIdWithUser(id);
        }

        public async Task<List<Tarea>> GetAll()
        {
            return await _work.task.getWithUser();
        }

        public async Task<Tarea> Post(Tarea entity)
        {
            await _work.task.Add(entity);
            await _work.CompleteAsync();
            return await _work.task.getByIdWithUser(entity.UserId);
        }
        public async Task<T>
    }
}