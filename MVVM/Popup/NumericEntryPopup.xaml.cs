
namespace App_UI_Mobile_Laminado.MVVM.Popup;
using CommunityToolkit.Maui.Views;

public partial class NumericEntryPopup : Popup
{
    private string _valorDigitado = "";
    private readonly double _valorMinimo;
    private readonly double _valorMaximo;

    public NumericEntryPopup(double valorMinimo, double valorMaximo)
    {
        InitializeComponent();
        _valorMinimo = valorMinimo;
        _valorMaximo = valorMaximo;

        lblLimites.Text = $"(Min: {_valorMinimo} | Max: {_valorMaximo})";
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            string texto = btn.Text;

            if (texto == ",")
            {
                if (!_valorDigitado.Contains(","))
                    _valorDigitado += ",";
            }
            else if (texto == "-")
            {
                if (_valorDigitado.StartsWith("-"))
                    _valorDigitado = _valorDigitado.TrimStart('-');
                else
                    _valorDigitado = "-" + _valorDigitado;
            }
            else
            {
                _valorDigitado += texto;
            }

            AtualizaDisplay();
        }
    }

    private void OnBackspaceClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(_valorDigitado))
        {
            _valorDigitado = _valorDigitado.Substring(0, _valorDigitado.Length - 1);
            AtualizaDisplay();
        }
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        _valorDigitado = "";
        AtualizaDisplay();
    }

    private void AtualizaDisplay()
    {
        lblDisplay.Text = string.IsNullOrEmpty(_valorDigitado) ? "0" : _valorDigitado;
    }

    private void OnCancelar(object sender, EventArgs e)
    {
        Close(null);
    }

    private void OnInserir(object sender, EventArgs e)
    {
        if (double.TryParse(_valorDigitado.Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double valor))
        {
            if (valor < _valorMinimo)
            {
                Application.Current.MainPage.DisplayAlert("Erro", $"Valor menor que {_valorMinimo}", "OK");
                return;
            }

            if (valor > _valorMaximo)
            {
                Application.Current.MainPage.DisplayAlert("Erro", $"Valor maior que {_valorMaximo}", "OK");
                return;
            }

            Close(valor);
        }
        else
        {
            Application.Current.MainPage.DisplayAlert("Erro", "Valor inválido.", "OK");
        }
    }
}