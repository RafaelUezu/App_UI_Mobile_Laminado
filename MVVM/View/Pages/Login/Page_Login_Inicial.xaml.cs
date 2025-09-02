using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Login;

public partial class Page_Login_Inicial : ContentPage
{
    private VM_Page_Login_Inicial _viewModel;

    public Page_Login_Inicial()
	{
		InitializeComponent();
        _viewModel = new VM_Page_Login_Inicial();
        BindingContext = _viewModel;

        _viewModel.PropertyChanged += ViewModel_PropertyChanged;
    }

    private async void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(VM_Page_Login_Inicial.MensagemErro))
        {
            if (!string.IsNullOrWhiteSpace(_viewModel.MensagemErro))
            {
                await DisplayAlert("Erro", _viewModel.MensagemErro, "OK");

                // Se quiser limpar a mensagem depois
                _viewModel.MensagemErro = string.Empty;
            }
        }

    }


    private void Button_ByPass_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell();
    }
}