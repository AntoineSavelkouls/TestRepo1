using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVC.Models
{
    public class Verhuisdoos
    {
        public int VerhuisdoosId { get; set; }

        public string VerhuisdoosNaam { get; set; }

        public string VerhuisdoosOmschrijving { get; set; }

        public List<Verhuisitem> VerhuisitemLijst { get; set; }

    }
}
