using System.Windows.Input;

namespace App_UI_Mobile_Laminado.Commands.UserControl;

public partial class UC_Switch_StatusDescription : ContentView
{
	public UC_Switch_StatusDescription()
	{
		InitializeComponent();
	}


	public static readonly BindableProperty sLabel_DispositivoProperty = BindableProperty.Create(nameof(sLabel_Dispositivo), typeof(string), typeof(UC_Switch_StatusDescription), default(string));
	public static readonly BindableProperty sLabel_StatusProperty = BindableProperty.Create(nameof(sLabel_Status), typeof(string), typeof(UC_Switch_StatusDescription), default(string));
	public static readonly BindableProperty xSwitch_ReadProperty = BindableProperty.Create(nameof(xSwitch_Read), typeof(bool), typeof(UC_Switch_StatusDescription), default(bool));

    public string sLabel_Dispositivo
	{
		get => (string)GetValue(sLabel_DispositivoProperty);
		set => SetValue(sLabel_DispositivoProperty, value);
	}
    public string sLabel_Status
    {
        get => (string)GetValue(sLabel_StatusProperty);
        set => SetValue(sLabel_StatusProperty, value);
    }
    public bool xSwitch_Read
    {
        get => (bool)GetValue(xSwitch_ReadProperty);
        set => SetValue(xSwitch_ReadProperty, value);
    }
    public static readonly BindableProperty CommandToggleProperty = BindableProperty.Create(nameof(CommandToggle), typeof(ICommand), typeof(UC_Switch_StatusDescription), null);
    public ICommand CommandToggle
    {
        get => (ICommand)GetValue(CommandToggleProperty);
        set => SetValue(CommandToggleProperty, value);
    }

}