using Microsoft.EntityFrameworkCore;
using CrudMySql.Models;

namespace CrudMySql.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Tarea> Tareas { get; set; }
}