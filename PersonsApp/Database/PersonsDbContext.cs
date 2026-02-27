using Microsoft.EntityFrameworkCore;
using PersonsApp.Entities;

namespace PersonsApp.Database
{
    public class PersonsDbContext : DbContext //Viene de un paquete nugget, necesitamos hacer un metodo constructor
    {
        public PersonsDbContext (DbContextOptions options) : base(options) //options es un parámetro que le vamos a mandar a la clase
        {
            
        }
        public DbSet<PersonEntity> Persons { get; set; } 
    }
}