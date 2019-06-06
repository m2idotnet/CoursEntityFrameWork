using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWpf.Models
{
    public class AddressEmail
    {
        private int id;
        private string email;

        private int contactId;

        [Key]
        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }

        public int ContactId { get => contactId; set => contactId = value; }

        [ForeignKey("ContactId")]
        public Contact contact { get; set; }
    }
}
