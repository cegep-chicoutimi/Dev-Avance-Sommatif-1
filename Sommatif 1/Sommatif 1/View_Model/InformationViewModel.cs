using Sommatif_1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommatif_1.View_Model
{
    public class InformationViewModel : BaseViewModel
    {
        private ObservableCollection<Utilisateur> _utilisateur;
        public ObservableCollection<Utilisateur> Utilisateurs
        {
            get => _utilisateur;
        }
        public InformationViewModel(ObservableCollection<Utilisateur> utilisateurs)
        {
            _utilisateur = utilisateurs;
        }
    }
}
