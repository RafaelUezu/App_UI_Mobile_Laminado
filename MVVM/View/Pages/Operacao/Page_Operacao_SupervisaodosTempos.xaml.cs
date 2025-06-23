
using App_UI_Mobile_Laminado.MVVM.Popup;
using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Operacao;
using CommunityToolkit.Maui.Views;
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


    private async void sLabel_rTempCxSupPatamar01_OnLabelTapped(object sender, TappedEventArgs e)
    {
        // Cria o Popup passando o valor mínimo e máximo
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);

        // Abre o Popup e espera o retorno
        var resultado = await this.ShowPopupAsync(popup);

        // Verifica se foi um valor válido (usuário apertou "Inserir")
        if (resultado is double valor)
        {
            // Atribui o valor no Label
            sLabel_rTempCxSupPatamar01.Text = valor.ToString("F1"); // Mostra com 1 casas decimais, opcional
        }
        else
        {
            // Usuário apertou "Cancelar" ou fechou o Popup
            Console.WriteLine("Cancelado.");
        }
    }

}