using System.Collections.Generic;
using AutoMapper;
using ToDoTask.Domain.DTO;
using ToDoTask.Domain.Entities;

namespace ToDoTask.Infrastructure.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Tarea, TaskResponseDto>();
            CreateMap<TaskResponseDto, Tarea>();
            CreateMap<TaskRequestDto, Tarea>();
        }
    }
}