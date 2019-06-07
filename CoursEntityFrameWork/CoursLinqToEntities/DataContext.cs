using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursLinqToEntities
{
    public class DataContext : DbContext
    {
        public DataContext() : base(@"Data Source=(LocalDb)\DataBaseEntityFrameWork;Integrated Security=True")
        {

        }

        public DbSet<Personne> Personnes { get; set; }

    }
}
