using Microsoft.EntityFrameworkCore;
using proyFinal_g63.Shared.Model;

namespace proyFinal_g63.Server  
{
    public class ApplicationDbContext:DbContext
    {
            //Aca se crean las tres tablas:
            public DbSet<Movie> Movies{get;set;}
            public DbSet<Category> Categories{get;set;}
            public DbSet<CategoryMovie> CategoriesMovie{get;set;}

            //Se genera la conexion con el SQL Server:
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){

            }

            //Modelo que genera las relaciones entre las tablas 
            //uno a uno - uno a muchos - muchos a muchos
            protected override void OnModelCreating(ModelBuilder modelBuilder){
                modelBuilder.Entity<CategoryMovie>().HasKey( x=>new {x.CategoryId, x.MovieId} );
                base.OnModelCreating(modelBuilder);
            }
    }
}