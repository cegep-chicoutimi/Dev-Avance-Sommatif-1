using Sommatif_1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommatif_1.View_Model
{
    public class LoginViewmodel : BaseViewModel
    {
        private string _username = string.Empty;
        public string Username
        {
            get => _username; set
            {
                if (value != _username)
                {
                    _username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }
        private DateTime _lastLogin;
        public DateTime LastLogin
        {
            get => _lastLogin;
            set
            {
                _lastLogin = value;
            }
        }
        private string _password = string.Empty;
        public string Password
        {
            get => _password;
            set
            {
                if (value != _password)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }
        private ObservableCollection<Utilisateur> _utilisateur = new ObservableCollection<Utilisateur>();
        public ObservableCollection<Utilisateur> Utilisateurs
        {
            get => _utilisateur;
        }   
        
        public LoginViewmodel()
        {

        }
        
    }
}
