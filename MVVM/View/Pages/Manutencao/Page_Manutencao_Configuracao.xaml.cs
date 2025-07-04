using CommunityToolkit.Maui.Views;
using App_UI_Mobile_Laminado.MVVM.Popup;
using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao;

namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Manutencao;

public partial class Page_Manutencao_Configuracao : ContentPage
{
    private readonly VM_Page_Manutencao_Configuracao _viewModel;

    public Page_Manutencao_Configuracao()
	{
		InitializeComponent();
        _viewModel = new VM_Page_Manutencao_Configuracao();
        BindingContext = _viewModel;
    }

    private async void Label_iTimeOutPing_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 10000);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iTimeOutPing_ReadWrite = (int)valor;
        }
    }
    private async void Label_iTimeRequest_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 10000);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iTimeRequest_ReadWrite = (int)valor;
        }
    }
    private async void Label_iMaxAgeOpcUa_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 10000);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iMaxAgeOpcUa_ReadWrite = (int)valor;
        }
    }
    private async void Label_iMedAgeOpcUa_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 10000);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iMedAgeOpcUa_ReadWrite = (int)valor;
        }
    }
    private async void Label_iMinAgeOpcUa_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 10000);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iMinAgeOpcUa_ReadWrite = (int)valor;
        }
    }
    private async void Label_iZeroAgeOpcUa_OnLabelTapped(object sender, TappedEventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 10000);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is double valor)
        {
            _viewModel.iZeroAgeOpcUa_ReadWrite = (int)valor;
        }
    }

}