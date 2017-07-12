using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management.Model.Entite
{
    public class Utilisateur
    {

        String login;
        String mdp;

        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }
    }
}
