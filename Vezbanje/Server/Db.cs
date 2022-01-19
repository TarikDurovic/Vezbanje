
using Microsoft.EntityFrameworkCore;
using Vezbanje.Shared;

namespace Vezbanje.Server
{
    public class Db:DbContext
    { 
        public Db(DbContextOptions<Db>opcije):base(opcije)
        {
        } 
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<Osoba>().HasKey(o => o.Id);
            modelbuilder.Entity<Osoba>()
                .HasIndex(o => o.Phone)
                .IsUnique();
            modelbuilder.Entity<Predavac>().HasData(new[]
            {
                new Predavac{Id = 1,Name="Tarik",LastName="Durovic",Phone="0613",Mail="eu@rg"}, 
                new Predavac{Id = 2,Name="Ajna",LastName="Ikic",Phone="5322",Mail="wr@eg"}, 
                new Predavac{Id=3,Name="Nedzo",LastName="Pepic",Phone ="3535",Mail="fww@wfgw"}, 
                new Predavac{Id=4,Name="Miki",LastName="Alijagic",Phone="3532",Mail="wf@fewg"}
            });
            modelbuilder.Entity<Polaznici>().HasData(new[]
            {
                new Polaznici{Id = 1,Name="Redzy",LastName="Redzepovic",Phone="3535",Mail ="eg@eg"}, 
                new Polaznici {Id = 2,Name="Sejla",LastName="Redzepovic",Phone="47247",Mail="fw@egg"}, 
                new Polaznici{Id=3,Name="Ismihana",LastName="Redzepovic",Phone="632482",Mail="wf@dg"}
            }); 
        }
        public DbSet<Osoba> Osobas { get; set; } 
        public DbSet<Predavac> Predavacs { get; set; } 
        public DbSet<Polaznici> Polaznicis { get; set; }

    }
}
