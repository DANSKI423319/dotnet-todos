using DotnetTodos.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreExample;

public class AppDbContext : DbContext
{
    private readonly IConfiguration Configuration;

    public DbSet<Todo> Todos { get; set; }

    public AppDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = Configuration.GetConnectionString("Default");

        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}
