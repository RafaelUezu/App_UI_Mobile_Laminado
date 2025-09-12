using App_UI_Mobile_Laminado.MVVM.Popup;
using CommunityToolkit.Maui.Views;
using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Receitas;
using App_UI_Mobile_Laminado.Services.Communication.Variables;
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


    int iMaxTempRecipe = GVL.ConfSuper.iMaxTempRecipe.ReadWrite ?? 145;
    int iMinTempRecipe = GVL.ConfSuper.iMinTempRecipe.ReadWrite ?? 0;
    int iMaxTimeHourRecipe = 24;
    int iMaxTimeMinuteRecipe = 59;
    private async void Label_dTemperaturaSP01_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: iMinTempRecipe, valorMaximo: iMaxTempRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.dTemperaturaSP01_ReadWrite = resultado is double v ? (float)v : _viewModel.dTemperaturaSP01_ReadWrite;
    }
    private async void Label_dTemperaturaSP02_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: iMinTempRecipe, valorMaximo: iMaxTempRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.dTemperaturaSP02_ReadWrite = resultado is double v ? (float)v : _viewModel.dTemperaturaSP02_ReadWrite;
    }
    private async void Label_dTemperaturaSP03_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: iMinTempRecipe, valorMaximo: iMaxTempRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.dTemperaturaSP03_ReadWrite = resultado is double v ? (float)v : _viewModel.dTemperaturaSP03_ReadWrite;
    }
    private async void Label_dTemperaturaSP04_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: iMinTempRecipe, valorMaximo: iMaxTempRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.dTemperaturaSP04_ReadWrite = resultado is double v ? (float)v : _viewModel.dTemperaturaSP04_ReadWrite;
    }
    private async void Label_dTemperaturaSP05_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: iMinTempRecipe, valorMaximo: iMaxTempRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.dTemperaturaSP05_ReadWrite = resultado is double v ? (float)v : _viewModel.dTemperaturaSP05_ReadWrite;
    }
    private async void Label_dTemperaturaSP06_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: iMinTempRecipe, valorMaximo: iMaxTempRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.dTemperaturaSP06_ReadWrite = resultado is double v ? (float)v : _viewModel.dTemperaturaSP06_ReadWrite;
    }
    private async void Label_dTemperaturaSP07_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: iMinTempRecipe, valorMaximo: iMaxTempRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.dTemperaturaSP07_ReadWrite = resultado is double v ? (float)v : _viewModel.dTemperaturaSP07_ReadWrite;
    }
    private async void Label_dTemperaturaSP08_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: iMinTempRecipe, valorMaximo: iMaxTempRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.dTemperaturaSP08_ReadWrite = resultado is double v ? (float)v : _viewModel.dTemperaturaSP08_ReadWrite;
    }

    #region Declaração de variáveis para os tempos de rampa e patamar
    private async void Label_iMinutoRampa01_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoRampa01_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoRampa01_ReadWrite;
    }
    private async void Label_iHoraPatamar01_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeHourRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iHoraPatamar01_ReadWrite = resultado is double v ? (int)v : _viewModel.iHoraPatamar01_ReadWrite;
    }
    private async void Label_iMinutoPatamar01_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoPatamar01_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoPatamar01_ReadWrite;
    }
    private async void Label_iMinutoRampa02_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoRampa02_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoRampa02_ReadWrite;
    }
    private async void Label_iHoraPatamar02_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeHourRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iHoraPatamar02_ReadWrite = resultado is double v ? (int)v : _viewModel.iHoraPatamar02_ReadWrite;
    }
    private async void Label_iMinutoPatamar02_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoPatamar02_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoPatamar02_ReadWrite;
    }
    private async void Label_iMinutoRampa03_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoRampa03_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoRampa03_ReadWrite;
    }
    private async void Label_iHoraPatamar03_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeHourRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iHoraPatamar03_ReadWrite = resultado is double v ? (int)v : _viewModel.iHoraPatamar03_ReadWrite;
    }
    private async void Label_iMinutoPatamar03_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoPatamar03_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoPatamar03_ReadWrite;
    }
    private async void Label_iMinutoRampa04_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoRampa04_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoRampa04_ReadWrite;
    }
    private async void Label_iHoraPatamar04_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeHourRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iHoraPatamar04_ReadWrite = resultado is double v ? (int)v : _viewModel.iHoraPatamar04_ReadWrite;
    }
    private async void Label_iMinutoPatamar04_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoPatamar04_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoPatamar04_ReadWrite;
    }
    private async void Label_iMinutoRampa05_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoRampa05_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoRampa05_ReadWrite;
    }
    private async void Label_iHoraPatamar05_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeHourRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iHoraPatamar05_ReadWrite = resultado is double v ? (int)v : _viewModel.iHoraPatamar05_ReadWrite;
    }
    private async void Label_iMinutoPatamar05_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoPatamar05_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoPatamar05_ReadWrite;
    }
    private async void Label_iMinutoRampa06_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoRampa06_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoRampa06_ReadWrite;
    }
    private async void Label_iHoraPatamar06_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeHourRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iHoraPatamar06_ReadWrite = resultado is double v ? (int)v : _viewModel.iHoraPatamar06_ReadWrite;
    }
    private async void Label_iMinutoPatamar06_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoPatamar06_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoPatamar06_ReadWrite;
    }
    private async void Label_iMinutoRampa07_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoRampa07_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoRampa07_ReadWrite;
    }
    private async void Label_iHoraPatamar07_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeHourRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iHoraPatamar07_ReadWrite = resultado is double v ? (int)v : _viewModel.iHoraPatamar07_ReadWrite;
    }
    private async void Label_iMinutoPatamar07_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoPatamar07_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoPatamar07_ReadWrite;
    }
    private async void Label_iMinutoRampa08_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoRampa08_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoRampa08_ReadWrite;
    }
    private async void Label_iHoraPatamar08_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeHourRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iHoraPatamar08_ReadWrite = resultado is double v ? (int)v : _viewModel.iHoraPatamar08_ReadWrite;
    }
    private async void Label_iMinutoPatamar08_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iMinutoPatamar08_ReadWrite = resultado is double v ? (int)v : _viewModel.iMinutoPatamar08_ReadWrite;
    }
    private async void Label_iTempoBombaFim_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: iMaxTimeMinuteRecipe);
        var resultado = await this.ShowPopupAsync(popup);
        _viewModel.iTempoBombaFim_ReadWrite = resultado is double v ? (int)v : _viewModel.iTempoBombaFim_ReadWrite;
    }
    #endregion






}