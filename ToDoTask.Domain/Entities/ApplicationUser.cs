using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ToDoTask.Domain.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public List<Tarea> Tasks { get; set; }
    }
}