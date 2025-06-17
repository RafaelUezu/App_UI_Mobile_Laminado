

using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.Manutencao;
namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Manutencao;

public partial class Page_Manutencao_Manual : ContentPage
{
    private readonly VM_Page_Manutencao_Manual _viewModel;
    private CancellationTokenSource _ctsAnimacao;

    public Page_Manutencao_Manual()
	{
		InitializeComponent();
        _viewModel = new VM_Page_Manutencao_Manual();
        BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.xSwitch_Read_Ventilador = true;
        StartRotationLoop();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _viewModel.xSwitch_Read_Ventilador = false;
    }

    private async void StartRotationLoop()
    {
        while ((bool)_viewModel.xSwitch_Read_Ventilador)
        {
            await DiscoImage.RotateTo(DiscoImage.Rotation + 3600, (uint)_viewModel.rVelocidade_Ventilador01, Easing.Linear);

            if (DiscoImage.Rotation >= 36000)
                DiscoImage.Rotation = 0;
        }
    }
}