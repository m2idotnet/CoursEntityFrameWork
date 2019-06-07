using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursLinqToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq to Object
            List<Personne> maListe = new List<Personne>()
            {
                new Personne {Nom = "toto", Prenom="tata"},
                new Personne {Nom = "titi", Prenom ="Minet"}
            };

            List<Address> liste2 = new List<Address>()
            {
                new Address { Adresse = "tt", NomClient="titi" },
                new Address { Adresse = "oo", NomClient="toto" },
            };

            //IEnumerable<Personne> liste = from p in maListe where p.Nom == "toto" select p;
            // <=> en lambda expression
            IEnumerable<Personne> liste = maListe.Where(x=>x.Nom == "toto");
            
            
            //List<string> listeNom = (from p in maListe select p.Nom).ToList();
            // <=> en lambda expression
            List<string> listeNom = maListe.Select(x=>x.Nom).ToList();
            
            
            //var listeO = (from p in maListe where p.Nom.Contains("t") orderby p.Nom descending select new { n = p.Nom, p = p.Prenom }).ToList();
            // <=> en lambda expression
            var listeO = maListe.Where(x => x.Nom.Contains("t")).OrderByDescending(x => x.Nom).Select(x => new { n = x.Nom, p = x.Prenom }).ToList();

            
            //var listeMultiple = (from p1 in maListe from p2 in liste2 where p1.Nom.Contains("t") where p2.NomClient == p1.Nom select new { NomComplet = p1.Nom+" "+p1.Prenom, Adresse = p2.Adresse }).ToList();
            // <=> en lambda expression
            var listeMultiple = maListe.Where(x => x.Nom.Contains("t")).Join(liste2,x=>x.Nom,a=>a.NomClient,(x,a)=>new  { NomComplet = x.Nom + " " + x.Prenom, Adresse = a.Adresse });                            
            foreach(var i in listeMultiple)
            {
                Console.WriteLine(i.NomComplet);
            }
            Console.ReadLine();
        }
    }
}
