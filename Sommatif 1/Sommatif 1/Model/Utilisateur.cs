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
        public DateTime DateLog {  get; set; }

        public Utilisateur(string user, string password, DateTime dateLog)
        {
            User = user;
            Password = password;
            DateLog = dateLog;
        }
    }
}
