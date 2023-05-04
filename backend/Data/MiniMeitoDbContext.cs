#nullable disable
using Microsoft.EntityFrameworkCore;
using MiniMeitoBackend.Models;
using Pomelo.EntityFrameworkCore.MySql;
namespace MiniMeitoBackend.Data
{
  public class MiniMeitoDbContext: DbContext
  {
    public MiniMeitoDbContext(DbContextOptions<MiniMeitoDbContext> options) : base(options)
    {
    }

    public DbSet<PocketMonster> PocketMonsters { get; set; }
  }
}