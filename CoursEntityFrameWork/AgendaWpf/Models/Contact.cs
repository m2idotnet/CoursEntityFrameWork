using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWpf.Models
{

    public class Contact
    {
        private int id;
        private string nom;
        private string prenom;
        private string tel;

        [Key]
        public int Id { get => id; set => id = value; }
        
        [StringLength(50)]
        public string Nom { get => nom; set => nom = value; }
        [StringLength(50)]
        public string Prenom { get => prenom; set => prenom = value; }
        [StringLength(13)]
        public string Tel { get => tel; set => tel = value; }

        public ICollection<AddressEmail> emails { get; set; }
    }
}
