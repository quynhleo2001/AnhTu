using BanYeu.Models;
using Microsoft.EntityFrameworkCore;

namespace BanYeu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
     
         public DbSet<Student> Students {get; set;}
         public DbSet<Employee> Employees {get; set;}
     
     
        
       

        

    
    }
}