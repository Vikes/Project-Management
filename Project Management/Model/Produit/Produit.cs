using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management.Model
{
    public abstract class  Produit
    {
        protected Produit(string nom, string note)
        {
            Nom = nom;
            Note = note;
        }

        public string Nom { get; private set; }
        public string Note { get; private set; }
    }
}
