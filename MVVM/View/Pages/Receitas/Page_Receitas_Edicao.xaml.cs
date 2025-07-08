using App_UI_Mobile_Laminado.MVVM.Popup;
using CommunityToolkit.Maui.Views;
using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Receitas;
using MAUI_Opcua.Services.Communication.Variable;
using System.Numerics;

namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Receitas;


public partial class Page_Receitas_Edicao : ContentPage
{


    private readonly VM_Page_Receitas_Edicao _viewModel;


    public Page_Receitas_Edicao()
	{
		InitializeComponent();
        _viewModel = new VM_Page_Receitas_Edicao();
        BindingContext = _viewModel;
	}

    //int MaxValue = GVL.ConfSuper;

    private async void Label_dTemperaturaSP01_OnLabelTapped(object sender, TappedEventArgs e)
    {
        // Cria o Popup passando o valor mínimo e máximo
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);

        // Abre o Popup e espera o retorno
        var resultado = await this.ShowPopupAsync(popup);

        // Verifica se foi um valor válido (usuário apertou "Inserir")
        if (resultado is double valor)
        {
            // Atribui o valor no Label
            _viewModel.dTemperaturaSP01_ReadWrite = (float)valor; // Mostra com 1 casas decimais, opcional
        }
        else
        {
            // Usuário apertou "Cancelar" ou fechou o Popup
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_dTemperaturaSP02_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.dTemperaturaSP02_ReadWrite = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_dTemperaturaSP03_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.dTemperaturaSP03_ReadWrite = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_dTemperaturaSP04_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.dTemperaturaSP04_ReadWrite = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_dTemperaturaSP05_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.dTemperaturaSP05_ReadWrite = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_dTemperaturaSP06_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.dTemperaturaSP06_ReadWrite = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_dTemperaturaSP07_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.dTemperaturaSP07_ReadWrite = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_dTemperaturaSP08_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.dTemperaturaSP08_ReadWrite = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }


}