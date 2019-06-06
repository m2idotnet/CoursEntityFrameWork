using AgendaWpf.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWpf.Tools
{
    public class DataContext : DbContext
    {
        private static object _lock = new object();
        private static DataContext _instance = null;
        private static readonly string connectionString = @"Data Source=(LocalDb)\DataBaseEntityFrameWork;Integrated Security=True";

        public static DataContext Instance
        {
            get
            {
                lock(_lock)
                {
                    if (_instance == null)
                        _instance = new DataContext();
                    return _instance;
                }
            }
        }

        private DataContext() : base(connectionString)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<AddressEmail> Emails { get; set; }
    }
}
