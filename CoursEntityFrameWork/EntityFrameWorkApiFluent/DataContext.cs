using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkApiFluent
{
    public class DataContext : DbContext
    {
        public DataContext() : base(@"Data Source=(localDb)\CoursAdoNet;Integrated Security=True")
        {

        }

        public DbSet<Voiture> Voitures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Ajouter une clé primaire sur la propriété VoitureId
            modelBuilder.Entity<Voiture>().HasKey((v) => v.VoitureId);

            //Mettre taille column Model a 50 Max
            modelBuilder.Entity<Voiture>().Property(v => v.Model).HasMaxLength(50);
        }
    }
}
