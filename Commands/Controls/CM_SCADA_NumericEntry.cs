using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using System.Globalization;

namespace App_UI_Mobile_Laminado.Commands.Controls
{
    public class CM_SCADA_NumericEntry : Entry
    {
        public CM_SCADA_NumericEntry()
        {
            Keyboard = Keyboard.Numeric;
            TextChanged += OnTextChanged;
            Completed += OnCompleted;
            Unfocused += OnUnfocused;
        }

        // 🔥 Valor principal
        public static readonly BindableProperty ValueProperty =
            BindableProperty.Create(
                nameof(Value),
                typeof(double),
                typeof(CM_SCADA_NumericEntry),
                0d,
                BindingMode.TwoWay,
                propertyChanged: OnValueChanged);

        public double Value
        {
            get => (double)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        // 🔥 Define se aceita apenas inteiro
        public static readonly BindableProperty IsIntegerProperty =
            BindableProperty.Create(
                nameof(IsInteger),
                typeof(bool),
                typeof(CM_SCADA_NumericEntry),
                false);

        public bool IsInteger
        {
            get => (bool)GetValue(IsIntegerProperty);
            set => SetValue(IsIntegerProperty, value);
        }

        // 🔥 Valor mínimo permitido
        public static readonly BindableProperty MinValueProperty =
            BindableProperty.Create(
                nameof(MinValue),
                typeof(double),
                typeof(CM_SCADA_NumericEntry),
                double.MinValue);

        public double MinValue
        {
            get => (double)GetValue(MinValueProperty);
            set => SetValue(MinValueProperty, value);
        }

        // 🔥 Valor máximo permitido
        public static readonly BindableProperty MaxValueProperty =
            BindableProperty.Create(
                nameof(MaxValue),
                typeof(double),
                typeof(CM_SCADA_NumericEntry),
                double.MaxValue);

        public double MaxValue
        {
            get => (double)GetValue(MaxValueProperty);
            set => SetValue(MaxValueProperty, value);
        }

        // 🔥 Evento de confirmação
        public event EventHandler<double> ValueConfirmed;

        private bool _updating;

        private static void OnValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CM_SCADA_NumericEntry)bindable;
            if (control._updating) return;

            control._updating = true;

            double valor = (double)newValue;
            valor = control.ApplyLimitsWithAlert(valor);

            control.Text = control.IsInteger
                ? ((int)valor).ToString()
                : valor.ToString("F1", CultureInfo.InvariantCulture);

            control._updating = false;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (_updating) return;

            _updating = true;

            string texto = e.NewTextValue?.Replace(',', '.');

            if (double.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
            {
                if (IsInteger)
                    result = Math.Round(result);

                result = ApplyLimitsWithAlert(result);
                Value = result;
            }
            else
            {
                ShowMessageBox("Valor inválido.");
            }

            _updating = false;
        }

        private void OnCompleted(object sender, EventArgs e)
        {
            ValueConfirmed?.Invoke(this, Value);
        }

        private void OnUnfocused(object sender, FocusEventArgs e)
        {
            ValueConfirmed?.Invoke(this, Value);
        }

        private double ApplyLimitsWithAlert(double valor)
        {
            if (valor < MinValue)
            {
                ShowMessageBox($"Valor mínimo permitido é {MinValue}");
                return MinValue;
            }

            if (valor > MaxValue)
            {
                ShowMessageBox($"Valor máximo permitido é {MaxValue}");
                return MaxValue;
            }

            return valor;
        }

        private async void ShowMessageBox(string mensagem)
        {
            try
            {
                if (Application.Current?.MainPage != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Atenção", mensagem, "OK");
                }
            }
            catch
            {
                // Segurança para evitar erros se MainPage não estiver carregada
            }
        }
    }
}
