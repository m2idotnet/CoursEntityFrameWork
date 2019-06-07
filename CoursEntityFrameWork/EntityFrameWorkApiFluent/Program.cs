using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkApiFluent
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext data = new DataContext();
            Voiture v = new Voiture
            {
                Model = "Ford"
            };
            data.Voitures.Add(v);
            data.SaveChanges();
        }
    }
}
