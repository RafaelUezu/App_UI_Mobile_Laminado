using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Operacao;

namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Operacao;

public partial class Page_Operacao_Automatica : ContentPage
{
	private readonly VM_Page_Operacao_Automatica _viewModel;

    public Page_Operacao_Automatica()
	{
		InitializeComponent();
		_viewModel = new VM_Page_Operacao_Automatica();
		BindingContext = _viewModel;
    }
}