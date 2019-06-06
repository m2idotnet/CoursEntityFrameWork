using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursEntityFrameWork.Models
{
    
    [Table("mesClients")]
    public class Client
    {
        private int clientId;
        private string nom;
        private string prenom;
        //private int adresseId;

        [Column("nom_client")]
        [StringLength(255)]
        public string Nom { get => nom; set => nom = value; }

        [Column("prenom_client")]
        [StringLength(255)]
        public string Prenom { get => prenom; set => prenom = value; }

        [Key]
        public int ClientId { get => clientId; set => clientId = value; }

        //[ForeignKey("AdresseId")]
        //public Adresse monAdresse { get; set; }
        //public int AdresseId { get => adresseId; set => adresseId = value; }

        public ICollection<Adresse> Adresses { get; set; }

        public Client()
        {
            Adresses = new List<Adresse>();
        }
    }
}
