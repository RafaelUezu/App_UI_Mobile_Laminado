using System.ComponentModel;
using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages;
namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Manutencao;

public partial class Page_Manutencao_Saidas : ContentPage
{
	public Page_Manutencao_Saidas()
	{
		InitializeComponent();
		BindingContext = new VM_Page_Manutencao_Saidas();

    }





}