namespace App_UI_Mobile_Laminado.Commands.UserControl;

public partial class UC_Switch : ContentView
{
    public UC_Switch()
    {
        InitializeComponent();
        Loaded += (_, _) => UpdateVisual();
    }

    //Propriedade SwitchHeight com notification manual
    public static readonly BindableProperty SwitchHeightProperty =
        BindableProperty.Create(nameof(SwitchHeight), typeof(double), typeof(UC_Switch), 50.0,
            propertyChanged: (bindable, oldVal, newVal) =>
            {
                var control = (UC_Switch)bindable;
                control.OnPropertyChanged(nameof(ThumbSize));
                control.UpdateVisual();
            });

    public double SwitchHeight
    {
        get => (double)GetValue(SwitchHeightProperty);
        set => SetValue(SwitchHeightProperty, value);
    }

    public static readonly BindableProperty SwitchWidthProperty =
        BindableProperty.Create(nameof(SwitchWidth), typeof(double), typeof(UC_Switch), 100.0,
            propertyChanged: (bindable, oldVal, newVal) =>
            {
                var control = (UC_Switch)bindable;
                control.UpdateVisual();
            });

    public double SwitchWidth
    {
        get => (double)GetValue(SwitchWidthProperty);
        set => SetValue(SwitchWidthProperty, value);
    }

    // Calculado dinamicamente
    public double ThumbSize => 0.9*SwitchHeight;

    // Track color (opcional)
    public Color TrackColor => IsToggled ? Colors.LimeGreen : Colors.Gray;

    // Toggle
    public static readonly BindableProperty IsToggledProperty =
        BindableProperty.Create(nameof(IsToggled), typeof(bool), typeof(UC_Switch), false,
            BindingMode.TwoWay, propertyChanged: (b, o, n) => ((UC_Switch)b).UpdateVisual());

    public bool IsToggled
    {
        get => (bool)GetValue(IsToggledProperty);
        set => SetValue(IsToggledProperty, value);
    }

    private void OnClicked(object sender, EventArgs e) => IsToggled = !IsToggled;

    private void UpdateVisual()
    {
        if (!IsLoaded) return;

        Track.BackgroundColor = TrackColor;

        // Atualiza o tamanho real
        Thumb.WidthRequest = ThumbSize;
        Thumb.HeightRequest = ThumbSize;

        // Atualiza posição
        double targetX = IsToggled ? SwitchWidth - ThumbSize - 0.05*SwitchWidth : 2;
        Thumb.TranslateTo(targetX, 0, 100, Easing.CubicInOut);
    }
}