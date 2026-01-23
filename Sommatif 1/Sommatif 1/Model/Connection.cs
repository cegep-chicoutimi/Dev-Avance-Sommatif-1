using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommatif_1.Model
{
    public class Connection
    {
        public List<Utilisateur> utilisateurs {  get; set; }
        public DateTime DateDeConnection { get; set; }

        public Connection()
        {

        }
    }
}
