using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursEntityFrameWork.Models
{
    public class Adresse
    {
        private int id;
        private string rue;
        private string ville;
        private int clientId;

        public int Id { get => id; set => id = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Ville { get => ville; set => ville = value; }

        //public Client client { get; set; }

        //public int ClientId { get => clientId; set => clientId = value; }

        public ICollection<Client> clients { get; set; }
        public Adresse()
        {
            clients = new List<Client>();
        }
    }
}
