using AgendaWpf.Models;
using AgendaWpf.Tools;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AgendaWpf.ViewModels
{
    class AddContactViewModel : ViewModelBase
    {
        public Contact contact { get; set; }
        public string Nom { get { return contact.Nom; } set {contact.Nom = value; RaisePropertyChanged(); } }
        public string Prenom
        {
            get => contact.Prenom;
            set
            {
                contact.Prenom = value;
                RaisePropertyChanged();
            }
        }
        public string Tel
        {
            get => contact.Tel;
            set
            {
                contact.Tel = value;
                RaisePropertyChanged();
            }
        }

        public ICollection<AddressEmail> emails
        {
            get
            {
                return contact.emails;
            }
            set
            {
                contact.emails = value;
                RaisePropertyChanged();
            }
        }

        public ICommand addCommand { get; set; }

        public AddContactViewModel()
        {
            contact = new Contact();
            contact.emails = new List<AddressEmail>();
            addCommand = new RelayCommand(AddContact);
        }

        public void AddContact()
        {
            //Remettre les int à leur valeur par defaut car DataGrid auto incremente les ints ce qui posera probleme en ajoutant ces ids dans les tables
            (contact.emails as List<AddressEmail>).ForEach(e =>
            {
                e.Id = default(int);
                e.ContactId = default(int);
            });
            DataContext.Instance.Contacts.Add(contact);
            DataContext.Instance.SaveChanges();
        }
    }
}
