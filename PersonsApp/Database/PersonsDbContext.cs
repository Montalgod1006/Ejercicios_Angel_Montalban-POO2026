using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonsApp.Entities;

namespace PersonsApp.Database
{
    public class PersonsDbContext : IdentityDbContext <UserEntity, RoleEntity, string> //Viene de un paquete nugget, necesitamos hacer un metodo constructor
    {
        public PersonsDbContext (DbContextOptions options) : base(options) //options es un parámetro que le vamos a mandar a la clase
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SetIndentityTableNames(builder);
        }

        private static void SetIndentityTableNames (ModelBuilder builder)
        {
            builder.Entity<UserEntity>().ToTable("users");
            builder.Entity<UserEntity>().ToTable("roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("users_roles").HasKey(ur => new {ur.UserId, ur.RoleId});
            builder.Entity<IdentityUserRole<string>>().ToTable("users_claims");
            builder.Entity<IdentityUserRole<string>>().ToTable("roles_claims");
            builder.Entity<IdentityUserRole<string>>().ToTable("users_login");
            builder.Entity<IdentityUserRole<string>>().ToTable("users_tokens");

        }

        public DbSet<PersonEntity> Persons { get; set; } 
        public DbSet<CountryEntity> Countries { get; set; } 
    }
}