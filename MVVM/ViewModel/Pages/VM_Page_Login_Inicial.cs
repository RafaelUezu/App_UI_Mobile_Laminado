using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using App_UI_Mobile_Laminado.Services.Authentication.Login;
using App_UI_Mobile_Laminado.MVVM.Model.Pages;
using App_UI_Mobile_Laminado.Services.db.Login;


namespace App_UI_Mobile_Laminado.MVVM.ViewModel.Pages
{
    public class VM_Page_Login_Inicial : INotifyPropertyChanged
    {
        private string _usuario;
        public string sUserName
        {
            get => _usuario;
            set
            {
                if (_usuario != value)
                {
                    _usuario = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _senha;
        public string sPassword
        {
            get => _senha;
            set
            {
                if (_senha != value)
                {
                    _senha = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _mensagemErro;
        public string MensagemErro
        {
            get => _mensagemErro;
            set
            {
                if (_mensagemErro != value)
                {
                    _mensagemErro = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Command_Login { get; }

        public VM_Page_Login_Inicial()
        {
            Command_Login = new Command(ExecutarLogin);
        }

        private async void ExecutarLogin()
        {
            if (string.IsNullOrWhiteSpace(sUserName))
            {
                MensagemErro = "Usuário obrigatório.";
                return;
            }

            if (string.IsNullOrWhiteSpace(sPassword))
            {
                MensagemErro = "Senha obrigatória.";
                return;
            }

            var user = UsuariosDB.ValidarLogin(sUserName, sPassword);
            if (user == null)
            {
                MensagemErro = "Usuário ou senha inválidos.";
                return;
            }
            Preferences.Set("UsuarioLogado", user.Nome);
            Preferences.Set("NivelAcesso", (int)user.Nivel);

            Application.Current.MainPage = new AppShell();

        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string nome = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nome));

    }
}
