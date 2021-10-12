using System;
using Microsoft.AspNetCore.Identity;
using ToDoTask.Domain.Base;

namespace ToDoTask.Domain.Entities
{
    public class Tarea : Entity
    {
        public string Titulo { get; set; }
        public Boolean Estado { get; set; } = true;
        public int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}