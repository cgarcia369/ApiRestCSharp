using System;
using System.Collections.Generic;
using ToDoTask.Domain.Entities;

namespace ToDoTask.Domain.DTO
{
    public class TaskResponseDto
    {
        public int Id { get; set; }
        public string  Titulo { get; set; }
        public Boolean Estado { get; set; }
        public ApplicationUser User { get; set; }
    }
}