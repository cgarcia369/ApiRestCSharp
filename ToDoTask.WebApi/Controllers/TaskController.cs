using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToDoTask.Domain.DTO;
using ToDoTask.Domain.Entities;
using ToDoTask.Domain.Interfaces;
using ToDoTask.Domain.Interfaces.Services;

namespace ToDoTask.WebApi.Controllers
{
    [ApiController]
    [Route("/test")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        private readonly IMapper _mapper;

        public TaskController(ITaskService taskService,IMapper mapper)
        {
            _taskService = taskService;
            _mapper = mapper;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<TaskResponseDto>> Get(int id)
        {
            var tarea = await _taskService.Get(id);
            return _mapper.Map<TaskResponseDto>(tarea);
        }
        [HttpGet()]
        public async Task<ActionResult<List<TaskResponseDto>>> GetAll()
        {
            var tareas = await _taskService.GetAll();
            return _mapper.Map<List<TaskResponseDto>>(tareas);
        }

        [HttpPost]
        public async Task<ActionResult<TaskResponseDto>> Post(TaskRequestDto entity)
        {
            var tareaReq = _mapper.Map<Tarea>(entity);
            var tarea = await _taskService.Post(tareaReq);
            return _mapper.Map<TaskResponseDto>(tarea);
        }
    }
}