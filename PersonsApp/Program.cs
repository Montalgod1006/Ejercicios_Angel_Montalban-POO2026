using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PersonsApp.Database;
using PersonsApp.Services.Persons;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container 
builder.Services.AddDbContext<PersonsDbContext> (Options => 
    Options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
//Cuando dice que espera un genérico se pone <>

/*builder.Services.AddScoped
builder.Services.AddSingleton*/

// después de la , va la clase para la conexión de la base de datos, cada referencia lleva una instancia
//si cambio la base de datos solo cambio la instancia y no me complico mucho
builder.Services.AddTransient<IPersonService, PersonService>();


builder.Services.AddOpenApi();

builder.Services.AddControllers();

var app = builder.Build(); //apartir de aquí se esta ejecutando nuestra aplicación

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseAuthorization(); //Sirve que cuando queramos que ciertas zonas de nuestra aplicación estén protegidas pues se protejan XD

app.UseHttpsRedirection(); //Cuando estemos en un servidor obliga a usar https

app.MapControllers(); //Todas las clases que terminen con Controller, lo va mapear como parte de rutas

app.Run();