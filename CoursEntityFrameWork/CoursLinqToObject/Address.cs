using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursLinqToObject
{
    public class Address
    {
        private string adresse;
        private string nomClient;

        public string Adresse { get => adresse; set => adresse = value; }
        public string NomClient { get => nomClient; set => nomClient = value; }
    }
}
