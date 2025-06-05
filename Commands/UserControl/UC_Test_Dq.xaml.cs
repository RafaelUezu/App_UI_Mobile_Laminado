using System.Windows.Input;
namespace App_UI_Mobile_Laminado.Commands.UserControl;

public partial class UC_Test_Dq : ContentView
{
    public UC_Test_Dq()
    {
        InitializeComponent();
    }
    
    public static readonly BindableProperty DqLabelProperty = BindableProperty.Create(nameof(DqLabel), typeof(string), typeof(UC_Test_Dq), default(string));
    public static readonly BindableProperty DqEstado_ReadProperty = BindableProperty.Create(nameof(DqEstado_Read), typeof(bool), typeof(UC_Test_Dq), default(bool), BindingMode.TwoWay);
    public static readonly BindableProperty DqDescricaoProperty = BindableProperty.Create(nameof(DqDescricao), typeof(string), typeof(UC_Test_Dq), default(string), BindingMode.TwoWay);

    public string DqLabel
    {
        get => (string)GetValue(DqLabelProperty);
        set => SetValue(DqLabelProperty, value);
    }

    public bool DqEstado_Read
    {
        get => (bool)GetValue(DqEstado_ReadProperty);
        set => SetValue(DqEstado_ReadProperty, value);
    }

    public string DqDescricao
    {
        get => (string)GetValue(DqDescricaoProperty);
        set => SetValue(DqDescricaoProperty, value);
    }

    public static readonly BindableProperty ComandoToggleProperty = BindableProperty.Create(nameof(ComandoToggle), typeof(ICommand), typeof(UC_Test_Dq), null);

    public ICommand ComandoToggle
    {
        get => (ICommand)GetValue(ComandoToggleProperty);
        set => SetValue(ComandoToggleProperty, value);
    }


}