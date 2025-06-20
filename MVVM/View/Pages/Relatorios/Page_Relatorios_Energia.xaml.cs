using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Relatorios;
namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Relatorios;

public partial class Page_Relatorios_Energia : ContentPage
{
	private readonly VM_Pages_Relatorios_Energia _viewModel;
    public Page_Relatorios_Energia()
	{
		InitializeComponent();
		_viewModel = new VM_Pages_Relatorios_Energia();
		BindingContext = _viewModel;
    }
}