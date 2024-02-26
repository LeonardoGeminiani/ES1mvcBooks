using ES1.Models;
using Microsoft.EntityFrameworkCore;

public class OspedaleContext : DbContext
{
    public DbSet<Farmaco> Farmaci {get; set;}
    public DbSet<Medico> Medici {get; set;}
    public DbSet<Paziente> Pazienti {get; set;}
    public DbSet<Reparto> Reparti {get; set;}
    public DbSet<Terapia> Terapie {get; set;}
    public DbSet<Visita> Visite {get; set;}

    public OspedaleContext(DbContextOptions<OspedaleContext> options) : base(options) {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Terapia>().HasKey(k => new {
            k.CF, k.FarmacoId
        });
        modelBuilder.Entity<Paziente>().HasKey(k => k.CF);
        
    }
}