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
            //data.Clients.Add(new Client { Nom = "abadi", Prenom = "Ihab" });
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
            Client c = data.Clients.Find(2);
            data.Clients.Remove(c);
            data.SaveChanges();
        }
    }
}
