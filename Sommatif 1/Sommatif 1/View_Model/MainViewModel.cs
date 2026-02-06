using Sommatif_1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommatif_1.View_Model
{
    public class MainViewModel : BaseViewModel
    {
        public LoginViewmodel LoginVM { get; }
        public InformationViewModel InformationVM { get; set; }

        private BaseViewModel _viewModelAfctif;
        public BaseViewModel ViewModelAfctif
        {
            get => _viewModelAfctif;
            set
            {
                if (_viewModelAfctif != value)
                {
                    _viewModelAfctif = value;
                    OnPropertyChanged(nameof(ViewModelAfctif));
                }
            }
        }
        private string _messageErreur;
        public string MessageErreur
        {
            get => _messageErreur;
            set
            {
                if (_messageErreur != value)
                {
                    _messageErreur = value;
                    OnPropertyChanged(nameof(MessageErreur));
                }
            }
        }
        public RelaisCommande VerrificationCommande { get; }

        public MainViewModel()
        {
            LoginVM = new LoginViewmodel();

            InformationVM = new InformationViewModel(LoginVM.Utilisateurs);

            ViewModelAfctif = LoginVM;

            VerrificationCommande = new RelaisCommande(Verrification);
        }

        public void Verrification()
        {
            MessageErreur = "";

            if (string.IsNullOrWhiteSpace(LoginVM.Username) ||
                string.IsNullOrWhiteSpace(LoginVM.Password))
            {
                MessageErreur = "Veuillez remplir tous les champs.";
                return;
            }

            LoginVM.LastLogin = DateTime.Now;

            var nouveau = new Utilisateur(LoginVM.Username, LoginVM.Password, LoginVM.LastLogin);
            LoginVM.Utilisateurs.Add(nouveau);
            InformationVM = new InformationViewModel(LoginVM.Utilisateurs);
            
            ViewModelAfctif = InformationVM;
        }
    }

}
