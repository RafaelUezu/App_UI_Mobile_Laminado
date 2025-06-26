

namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Operacao;
using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Operacao;
public partial class Page_Operacao_Manual : ContentPage
{
	private readonly VM_Page_Operacao_Manual _viewModel;


    public Page_Operacao_Manual()
	{
		InitializeComponent();
		_viewModel = new VM_Page_Operacao_Manual();
		BindingContext = _viewModel;
    }

}