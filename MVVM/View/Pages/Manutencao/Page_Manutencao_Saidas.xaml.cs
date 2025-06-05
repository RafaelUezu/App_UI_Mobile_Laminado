using System.ComponentModel;
using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao;
namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Manutencao;

public partial class Page_Manutencao_Saidas : ContentPage
{
    private readonly VM_Page_Manutencao_Saidas _viewModel;

    public Page_Manutencao_Saidas()
	{
		InitializeComponent();
        _viewModel = new VM_Page_Manutencao_Saidas();
        BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is VM_Page_Manutencao_Saidas vm)
            vm.StartAtualizacaoDQ(); // Liga a leitura periódica
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        if (BindingContext is VM_Page_Manutencao_Saidas vm)
            vm.StopAtualizacaoDQ(); // Evita leitura fora da tela
    }



}