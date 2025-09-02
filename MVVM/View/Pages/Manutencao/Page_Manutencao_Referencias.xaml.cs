using CommunityToolkit.Maui.Views;
using App_UI_Mobile_Laminado.MVVM.Popup;
using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao;


namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Manutencao;

public partial class Page_Manutencao_Referencias : ContentPage
{
    private readonly VM_Page_Manutencao_Referencias _viewModel;

    public Page_Manutencao_Referencias()
	{
		InitializeComponent();
        _viewModel = new VM_Page_Manutencao_Referencias();
        BindingContext = _viewModel;

    }
    private async void Label_TempoExaustorMinSup_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 120);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iTempoExaustorMinSup_Write = (Int16)valor;
        }
    }
    private async void Label_TemperaturaMinimaSup_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 80);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.rTemperaturaMinimaSup_Write = (float)valor;
        }
    }
    private async void Label_TempoAberturaSup_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 120);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iTempoAberturaSup_Write = (Int16)valor;
        }
    }
    private async void Label_FreqManCxSuperior_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 60);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iFreqManCxSuperior_Write = (Int16)valor;
        }
    }
    private async void Label_SpContHorProgB01_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 5000);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iSpContHorProgB01_Write = (Int16)valor;
        }
    }
    private async void Label_TemperaturaSegurancaSup_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 160);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iTemperaturaSegurancaSup_Write = (Int16)valor;
        }
    }
}