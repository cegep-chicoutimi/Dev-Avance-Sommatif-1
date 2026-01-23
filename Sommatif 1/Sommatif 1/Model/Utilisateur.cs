using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommatif_1.Model
{
    public class Utilisateur
    {
        public string User {  get; set; }
        public string Password { get; set; }

        public Utilisateur(string user, string password)
        {
            User = user;
            Password = password;
        }
    }
}
