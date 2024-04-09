using Microsoft.EntityFrameworkCore;
using Telemarketing.API.Models;

namespace Telemarketing.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Coleta> Coletas { get; set; }
    public DbSet<Indicador> Indicadores { get; set; }
}
