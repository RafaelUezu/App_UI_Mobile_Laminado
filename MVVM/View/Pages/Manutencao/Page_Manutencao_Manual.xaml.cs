namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Manutencao;

public partial class Page_Manutencao_Manual : ContentPage
{
	public Page_Manutencao_Manual()
	{
		InitializeComponent();
        
    }

    private bool _girando = true;
    private int _velocidadeMs = 1000;

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _girando = true;
        StartRotationLoop();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _girando = false;
    }

    private async void StartRotationLoop()
    {
        while (_girando)
        {
            await DiscoImage.RotateTo(DiscoImage.Rotation + 3600, (uint)_velocidadeMs, Easing.Linear);

            if (DiscoImage.Rotation >= 36000)
                DiscoImage.Rotation = 0;
        }
    }

}