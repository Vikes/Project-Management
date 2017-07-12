using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management.Model
{
    public class Client : Compte
    {
        public Client(string siteWeb, string telephone, string siren, string siret, string rib, string adresse, string nom) : base(siteWeb, telephone, siren, siret, rib, adresse, nom)
        {
        }
    }
}