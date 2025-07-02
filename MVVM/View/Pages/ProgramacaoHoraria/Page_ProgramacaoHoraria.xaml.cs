
using App_UI_Mobile_Laminado.MVVM.Popup;
using App_UI_Mobile_Laminado.MVVM.ViewModel.Pages.ProgramacaoHorario;
using CommunityToolkit.Maui.Views;

namespace App_UI_Mobile_Laminado.MVVM.View.Pages.ProgramacaoHoraria;

public partial class Page_ProgramacaoHoraria : ContentPage
{
	private readonly VM_Page_ProgramacaoHoraria _viewModel;
	public Page_ProgramacaoHoraria()
	{
		InitializeComponent();
		_viewModel = new VM_Page_ProgramacaoHoraria();
		BindingContext = _viewModel;
    }

	private async void Label_uHorProgramado_OnLabelTapped(object sender, EventArgs e)
	{
		var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 23);
		var resultado = await this.ShowPopupAsync(popup);
        if (resultado is int valor)
        {
			_viewModel.uHorProgramado_Write = (uint)valor;
        }
    }
    private async void Label_uMinProgramado_OnLabelTapped(object sender, EventArgs e)
    {
        var popup = new NumericEntryPopup(valorMinimo: 0, valorMaximo: 59);
        var resultado = await this.ShowPopupAsync(popup);
        if (resultado is int valor)
        {
            _viewModel.uMinProgramado_Write = (uint)valor;
        }
    }

}