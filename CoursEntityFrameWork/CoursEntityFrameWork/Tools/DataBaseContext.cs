using CoursEntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursEntityFrameWork.Tools
{
    public class DataBaseContext : DbContext
    {
        private static readonly string connectionString = @"Data Source=(LocalDb)\DataBaseEntityFrameWork;Integrated Security=True";

        public DataBaseContext() : base(connectionString)
        {

        }

        public DbSet<Client> Clients { get; set; }

    }
}
