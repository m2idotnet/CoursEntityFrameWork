using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursLinqToEntities
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext data = new DataContext();
            // ajouter un jeu de donnée
            //data.Personnes.Add(new Personne { Nom = "toto", Prenom = "tata" });
            //data.Personnes.Add(new Personne { Nom = "titi", Prenom = "minet" });
            //data.SaveChanges();

            //Linq to entites

            //List<Personne> mPersonnes = (from p in data.Personnes where p.Prenom.Contains("m") select p).ToList();
            // <=> lambda expression
            List<Personne> mPersonnes = data.Personnes.Where(p => p.Prenom.Contains("m")).ToList();
            foreach(Personne p in mPersonnes)
            {
                Console.WriteLine(p.Nom + " " + p.Prenom);
            }

            Console.ReadLine();
        }
    }
}
