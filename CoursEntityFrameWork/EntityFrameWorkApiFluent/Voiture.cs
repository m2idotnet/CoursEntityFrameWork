using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkApiFluent
{
    public class Voiture
    {
        private int voitureId;
        private string model;

        public int VoitureId { get => voitureId; set => voitureId = value; }
        public string Model { get => model; set => model = value; }
    }
}
