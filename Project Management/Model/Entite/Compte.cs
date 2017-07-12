using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management.Model
{
    public abstract class Compte
    {
        protected Compte(string siteWeb, string telephone, string siren, string siret, string rib, string adresse, string nom)
        {
            SiteWeb = siteWeb;
            Telephone = telephone;
            Siren = siren;
            Siret = siret;
            Rib = rib;
            Adresse = adresse;
            Nom = nom;
        }

        public string Nom { get; private set; }
        public string Adresse { get; private set; }
        public string Rib { get; private set; }
        public string Siret { get; private set; }
        public string Siren { get; private set; }
        public string Telephone { get; private set; }
        public string SiteWeb { get; private set; }
    }
}