
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


    // Remover depois de testar---------------------------------------------------
    /*
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is VM_Page_Operacao_SupervisaodosTempos vm)
            vm.StartAtualizacaoDI(); // Liga a leitura periódica
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        if (BindingContext is VM_Page_Operacao_SupervisaodosTempos vm)
            vm.StopAtualizacaoDI(); // Evita leitura fora da tela
    }
    */
    // Remover depois de testar---------------------------------------------------



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
            _viewModel.rTempCxSupPatamar01_Write = (float)valor; // Mostra com 1 casas decimais, opcional
        }
        else
        {
            // Usuário apertou "Cancelar" ou fechou o Popup
            Console.WriteLine("Cancelado.");
        }
    }
    private async void sLabel_rTempCxSupPatamar02_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.rTempCxSupPatamar02_Write = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void sLabel_rTempCxSupPatamar03_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.rTempCxSupPatamar03_Write = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void sLabel_rTempCxSupPatamar04_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.rTempCxSupPatamar04_Write = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void sLabel_rTempCxSupPatamar05_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.rTempCxSupPatamar05_Write = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void sLabel_rTempCxSupPatamar06_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.rTempCxSupPatamar06_Write = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void sLabel_rTempCxSupPatamar07_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.rTempCxSupPatamar07_Write = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void sLabel_rTempCxSupPatamar08_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 155);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.rTempCxSupPatamar08_Write = (float)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iHorCxSupPatamar01_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 24);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iHorCxSupPatamar01_Write = (Int16)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iMinCxSupPatamar01_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 59);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iMinCxSupPatamar01_Write = (Int16)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iHorCxSupPatamar02_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 24);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iHorCxSupPatamar02_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iMinCxSupPatamar02_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 59);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iMinCxSupPatamar02_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iHorCxSupPatamar03_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 24);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iHorCxSupPatamar03_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iMinCxSupPatamar03_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 59);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iMinCxSupPatamar03_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iHorCxSupPatamar04_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 24);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iHorCxSupPatamar04_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iMinCxSupPatamar04_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 59);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iMinCxSupPatamar04_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iHorCxSupPatamar05_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 24);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iHorCxSupPatamar05_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iMinCxSupPatamar05_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 59);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iMinCxSupPatamar05_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iHorCxSupPatamar06_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 24);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iHorCxSupPatamar06_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iMinCxSupPatamar06_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 59);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iMinCxSupPatamar06_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iHorCxSupPatamar07_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 24);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iHorCxSupPatamar07_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iMinCxSupPatamar07_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 59);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iMinCxSupPatamar07_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iHorCxSupPatamar08_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 24);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iHorCxSupPatamar08_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }
    private async void Label_iMinCxSupPatamar08_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 59);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iMinCxSupPatamar08_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }


    private async void Label_iMinTasbCxSup_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 59);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iMinTasbCxSup_Write = (int)valor;
        }
        else
        {
            Console.WriteLine("Cancelado.");
        }
    }



}