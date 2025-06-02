using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao;


namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Manutencao;


public partial class Page_Manutencao_Entradas : ContentPage
{
	public Page_Manutencao_Entradas()
	{
		InitializeComponent();
        BindingContext = new VM_Page_Manutencao_Entradas();
		
    }
}