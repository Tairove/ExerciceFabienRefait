using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Groupe.Models
{
    public class Personne
    {
        public int PersonneID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public int PaysID { get; set; } 
        public virtual Pays Pays { get; set; } //don 1 seul pays par personne

    }

}