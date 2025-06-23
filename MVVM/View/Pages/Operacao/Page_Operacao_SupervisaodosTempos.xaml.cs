
using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Operacao;
using System.Windows.Input;

namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Operacao;

public partial class Page_Operacao_SupervisaodosTempos : ContentPage
{

	private readonly VM_Page_Operacao_SupervisaodosTempos _viewModel;

    public Page_Operacao_SupervisaodosTempos()
	{
		InitializeComponent();
		_viewModel = new VM_Page_Operacao_SupervisaodosTempos();
        BindingContext = _viewModel;
    }


    

}