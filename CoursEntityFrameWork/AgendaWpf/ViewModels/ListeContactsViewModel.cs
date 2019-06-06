using AgendaWpf.Models;
using AgendaWpf.Tools;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWpf.ViewModels
{
    public class ListeContactsViewModel : ViewModelBase
    {
        public List<Contact> contacts { get; set; }

        public ListeContactsViewModel()
        {
            contacts = DataContext.Instance.Contacts.Include("emails").ToList();
        }
    }
}
