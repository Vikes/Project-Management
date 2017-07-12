using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management.Model
{
    public class Element : Produit
    {
        public Element(string nom, string note, string fournisseur) : base(nom, note)
        {
            this.Fournisseur = fournisseur;
        }

        public string Fournisseur { get; private set; }
    }
}