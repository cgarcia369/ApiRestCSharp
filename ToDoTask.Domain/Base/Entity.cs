using System.ComponentModel.DataAnnotations;

namespace ToDoTask.Domain.Base
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}