using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.View.Pages.Manutencao;

public partial class Page_Manutencao : ContentPage
{
	public Page_Manutencao()
	{
		InitializeComponent();
	}
    int E = 0;
    private async void Button_IOTest_Clicked(object sender, EventArgs e)
    {
        //for (int i = 0; i < 10; i++)
        //{
        //    Thread.Sleep(1000);
        //    System.Diagnostics.Debug.WriteLine("Button IO Test Clicked: " + E);
        //    E = E + 1;
        //}
       await Shell.Current.GoToAsync(nameof(Page_Manutencao_IOTest));

    }
}