using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDoTask.Domain.Entities;


namespace ToDoTask.Infrastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,IdentityRole<int>,int>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Tarea> Tasks { get; set; }   
    }
}