

namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Operacao;
using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Operacao;
using System.ComponentModel;

public partial class Page_Operacao_Manual : ContentPage
{
    private readonly VM_Page_Operacao_Manual _viewModel;
    private double _posicaoInicialY = 0;

    public Page_Operacao_Manual()
    {
        InitializeComponent();
        _viewModel = new VM_Page_Operacao_Manual();
        BindingContext = _viewModel;
        _viewModel.PropertyChanged += ViewModel_PropertyChanged;
    }

    private async void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(_viewModel.wStatusPortaEsq_Read))
        {
            int status = _viewModel.wStatusPortaEsq_Read;

            double destinoY = status switch
            {
                0 => _posicaoInicialY - 60,
                1 => _posicaoInicialY,
                2 => _posicaoInicialY - 123,
                _ => _posicaoInicialY
            };

            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await PortaFornoSuperior.TranslateTo(0, destinoY, 1000, Easing.Linear);
            });
        }
    }

}