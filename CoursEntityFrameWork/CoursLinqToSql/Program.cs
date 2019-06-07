using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursLinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqToSqlContextDataContext data = new LinqToSqlContextDataContext();
            //Client c = new Client();
            //c.Nom = "abadi linq";
            //c.Prenom = "abadi linq";
            //c.Tel = "0606060606";
            //data.Client.InsertOnSubmit(c);
            //data.SubmitChanges();
            //personne p = new personne();
            //totoClass t = new totoClass() { nom = "toto" };
            //data.totoClass.InsertOnSubmit(t);
            //data.SubmitChanges();

            //List<Client> clientSA = (from c in data.Client where c.Nom.StartsWith("a") select c).ToList();
            // <=> lambda expression

            List<Client> clientSA = data.Client.Where(c => c.Nom.StartsWith("a")).ToList();
        }
    }
}
