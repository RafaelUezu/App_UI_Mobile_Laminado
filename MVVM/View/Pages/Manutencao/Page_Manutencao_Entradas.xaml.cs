
using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao;
namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Manutencao;

public partial class Page_Manutencao_Entradas : ContentPage
{
    private readonly VM_Page_Manutencao_Entradas _viewModel;

    public Page_Manutencao_Entradas()
	{
		InitializeComponent();
        _viewModel = new VM_Page_Manutencao_Entradas();
        BindingContext = _viewModel;

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is VM_Page_Manutencao_Entradas vm)
            vm.StartAtualizacaoDI(); // Liga a leitura periódica
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        if (BindingContext is VM_Page_Manutencao_Entradas vm)
            vm.StopAtualizacaoDI(); // Evita leitura fora da tela
    }


}