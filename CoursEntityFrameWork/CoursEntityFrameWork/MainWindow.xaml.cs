using CoursEntityFrameWork.Models;
using CoursEntityFrameWork.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoursEntityFrameWork
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataBaseContext data = new DataBaseContext();
            //Insertion Dans dataContext
            //Client c = new Client { Nom = "abadi", Prenom = "Ihab" };
            //c.monAdresse = new Adresse { Rue = "tourcoing", Ville = "tourcoing" };
            //data.Clients.Add(c);

            //data.SaveChanges();
            //Select dans DataContext
            //select by primary Key
            //Client c = data.Clients.Find(1);
            //select one by others properties
            //Client c = data.Clients.FirstOrDefault((x) => x.Nom == "abadi");
            //Select Many 
            //List<Client> cs = data.Clients.Where((x) => x.Nom == "abadi").ToList();
            //Update DataContext
            //Client c = data.Clients.FirstOrDefault((x) => x.Nom == "abadi");
            //c.Nom = "toto";
            //c.Prenom = "tata";
            //data.SaveChanges();
            //Remove DataContext
            //Client c = data.Clients.Find(2);
            //data.Clients.Remove(c);
            //data.SaveChanges();

            //SElect with foreignKey
            //Client c = data.Clients.Find(1);
            //c.monAdresse = data.Adresses.Find(c.AdresseId);

            //Insertion One To Many
            //Client c = new Client { Nom = "abadi", Prenom = "Ihab" };
            //List<Adresse> listeAdresses = new List<Adresse>()
            //{
            //    new Adresse
            //    {
            //        Rue  = "t",
            //        Ville = "T",
            //    },
            //    new Adresse
            //    {
            //        Rue  = "r",
            //        Ville = "R",
            //    },
            //};
            //c.Adresses = listeAdresses;
            //data.Clients.Add(c);
            //data.SaveChanges();

            //Many to many

            Client c = new Client { Nom = "abadi", Prenom = "Ihab" };
            List<Adresse> listeAdresses = new List<Adresse>()
            {
                new Adresse
                {
                    Rue  = "t",
                    Ville = "T",
                },
                new Adresse
                {
                    Rue  = "r",
                    Ville = "R",
                },
            };
            c.Adresses = listeAdresses;
            data.Clients.Add(c);
            data.SaveChanges();
        }
    }
}
