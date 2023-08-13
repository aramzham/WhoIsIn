using Microsoft.EntityFrameworkCore;
using WhoIsIn.Api.Data.Models;

namespace WhoIsIn.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Match> Matches => Set<Match>();
    public DbSet<Player> Players => Set<Player>();
}