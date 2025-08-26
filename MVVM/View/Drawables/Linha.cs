using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App_UI_Mobile_Laminado.MVVM.View.Drawables
{
    public class Linha : BindableObject, IDrawable
    {
        public enum TipoDeLinha
        {
            Continua,
            Tracejada,
            Pontilhada,
            TracoPonto
        }

        // Coordenadas
        public static readonly BindableProperty X1Property =
            BindableProperty.Create(nameof(X1), typeof(float), typeof(Linha), 0f, propertyChanged: OnAnyChanged);
        public static readonly BindableProperty Y1Property =
            BindableProperty.Create(nameof(Y1), typeof(float), typeof(Linha), 0f, propertyChanged: OnAnyChanged);
        public static readonly BindableProperty X2Property =
            BindableProperty.Create(nameof(X2), typeof(float), typeof(Linha), 0f, propertyChanged: OnAnyChanged);
        public static readonly BindableProperty Y2Property =
            BindableProperty.Create(nameof(Y2), typeof(float), typeof(Linha), 0f, propertyChanged: OnAnyChanged);

        // Estilo base
        public static readonly BindableProperty CorProperty =
            BindableProperty.Create(nameof(Cor), typeof(Color), typeof(Linha), Colors.Black, propertyChanged: OnAnyChanged);
        public static readonly BindableProperty EspessuraProperty =
            BindableProperty.Create(nameof(Espessura), typeof(float), typeof(Linha), 2f, propertyChanged: OnAnyChanged);
        public static readonly BindableProperty PontaProperty =
            BindableProperty.Create(nameof(Ponta), typeof(LineCap), typeof(Linha), LineCap.Round, propertyChanged: OnAnyChanged);

        // Tipo de linha (contínua/tracejada/...) e escala do padrão
        public static readonly BindableProperty TipoLinhaProperty =
            BindableProperty.Create(nameof(TipoLinha), typeof(TipoDeLinha), typeof(Linha), TipoDeLinha.Continua, propertyChanged: OnAnyChanged);

        public static readonly BindableProperty EscalaTipoDeLinhaProperty =
            BindableProperty.Create(nameof(EscalaTipoDeLinha), typeof(float), typeof(Linha), 1f, propertyChanged: OnAnyChanged);

        // Host para invalidar
        public static readonly BindableProperty HostProperty =
            BindableProperty.Create(nameof(Host), typeof(GraphicsView), typeof(Linha));

        public float X1 { get => (float)GetValue(X1Property); set => SetValue(X1Property, value); }
        public float Y1 { get => (float)GetValue(Y1Property); set => SetValue(Y1Property, value); }
        public float X2 { get => (float)GetValue(X2Property); set => SetValue(X2Property, value); }
        public float Y2 { get => (float)GetValue(Y2Property); set => SetValue(Y2Property, value); }

        public Color Cor { get => (Color)GetValue(CorProperty); set => SetValue(CorProperty, value); }
        public float Espessura { get => (float)GetValue(EspessuraProperty); set => SetValue(EspessuraProperty, value); }
        public LineCap Ponta { get => (LineCap)GetValue(PontaProperty); set => SetValue(PontaProperty, value); }

        public TipoDeLinha TipoLinha { get => (TipoDeLinha)GetValue(TipoLinhaProperty); set => SetValue(TipoLinhaProperty, value); }
        public float EscalaTipoDeLinha { get => (float)GetValue(EscalaTipoDeLinhaProperty); set => SetValue(EscalaTipoDeLinhaProperty, value); }

        public GraphicsView? Host { get => (GraphicsView?)GetValue(HostProperty); set => SetValue(HostProperty, value); }

        static void OnAnyChanged(BindableObject b, object oldV, object newV)
            => ((Linha)b).Host?.Invalidate();

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.SaveState();

            canvas.StrokeColor = Cor;
            canvas.StrokeSize = Espessura;
            canvas.StrokeLineCap = Ponta;

            // Define o padrão de traço conforme o tipo + escala
            var escala = EscalaTipoDeLinha;
            if (escala <= 0f) escala = 0.1f; // clamp mínimo para evitar valores inválidos

            switch (TipoLinha)
            {
                case TipoDeLinha.Continua:
                    canvas.StrokeDashPattern = null; // sólido
                    break;

                case TipoDeLinha.Tracejada:
                    // traço 8, espaço 4 (escalados)
                    canvas.StrokeDashPattern = new float[] { 8f * escala, 4f * escala };
                    break;

                case TipoDeLinha.Pontilhada:
                    // ponto 1, espaço 3 (escalados)
                    canvas.StrokeDashPattern = new float[] { 1f * escala, 3f * escala };
                    break;

                case TipoDeLinha.TracoPonto:
                    // traço 8, espaço 4, ponto 1, espaço 4 (escalados)
                    canvas.StrokeDashPattern = new float[] { 8f * escala, 4f * escala, 1f * escala, 4f * escala };
                    break;
            }

            canvas.DrawLine(X1, Y1, X2, Y2);
            canvas.RestoreState();
        }
    }
}
