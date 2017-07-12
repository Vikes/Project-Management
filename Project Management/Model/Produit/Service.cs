using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management.Model
{
    public class Service : Produit
    {
        public Service(string nom, string note, string type) : base(nom, note)
        {
            this.Type = type;
        }

        public string Type { get; private set; }
    }
}