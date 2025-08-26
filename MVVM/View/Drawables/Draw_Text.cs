using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.View.Drawables
{
    using GFont = Microsoft.Maui.Graphics.Font;
    using HAlign = Microsoft.Maui.Graphics.HorizontalAlignment;
    using VAlign = Microsoft.Maui.Graphics.VerticalAlignment;

    public class Texto : BindableObject, IDrawable
    {
        // Conteúdo e posição
        public static readonly BindableProperty ConteudoProperty =
            BindableProperty.Create(nameof(Conteudo), typeof(string), typeof(Texto), string.Empty, propertyChanged: OnAnyChanged);

        public static readonly BindableProperty XProperty =
            BindableProperty.Create(nameof(X), typeof(float), typeof(Texto), 0f, propertyChanged: OnAnyChanged);

        public static readonly BindableProperty YProperty =
            BindableProperty.Create(nameof(Y), typeof(float), typeof(Texto), 0f, propertyChanged: OnAnyChanged);

        // Estilo de texto
        public static readonly BindableProperty CorProperty =
            BindableProperty.Create(nameof(Cor), typeof(Color), typeof(Texto), Colors.Black, propertyChanged: OnAnyChanged);

        public static readonly BindableProperty TamanhoFonteProperty =
            BindableProperty.Create(nameof(TamanhoFonte), typeof(float), typeof(Texto), 14f, propertyChanged: OnAnyChanged);

        // Nome/alias de fonte registrado no MauiProgram (ex.: "OpenSansSemibold")
        public static readonly BindableProperty FonteProperty =
            BindableProperty.Create(nameof(Fonte), typeof(string), typeof(Texto), default(string), propertyChanged: OnAnyChanged);

        // Alinhamento relativo ao ponto (X,Y)
        public static readonly BindableProperty AlinhamentoHorizontalProperty =
            BindableProperty.Create(nameof(AlinhamentoHorizontal), typeof(HAlign), typeof(Texto), HAlign.Left, propertyChanged: OnAnyChanged);

        public static readonly BindableProperty AlinhamentoVerticalProperty =
            BindableProperty.Create(nameof(AlinhamentoVertical), typeof(VAlign), typeof(Texto), VAlign.Top, propertyChanged: OnAnyChanged);

        // Rotação (graus, em torno do centro do bloco do texto)
        public static readonly BindableProperty RotacaoGrausProperty =
            BindableProperty.Create(nameof(RotacaoGraus), typeof(float), typeof(Texto), 0f, propertyChanged: OnAnyChanged);

        // Fundo e padding (opcionais)
        public static readonly BindableProperty FundoProperty =
            BindableProperty.Create(nameof(Fundo), typeof(Color), typeof(Texto), Colors.Transparent, propertyChanged: OnAnyChanged);

        public static readonly BindableProperty PaddingProperty =
            BindableProperty.Create(nameof(Padding), typeof(float), typeof(Texto), 0f, propertyChanged: OnAnyChanged);

        // Host para invalidar
        public static readonly BindableProperty HostProperty =
            BindableProperty.Create(nameof(Host), typeof(GraphicsView), typeof(Texto));

        public string Conteudo { get => (string)GetValue(ConteudoProperty); set => SetValue(ConteudoProperty, value); }
        public float X { get => (float)GetValue(XProperty); set => SetValue(XProperty, value); }
        public float Y { get => (float)GetValue(YProperty); set => SetValue(YProperty, value); }

        public Color Cor { get => (Color)GetValue(CorProperty); set => SetValue(CorProperty, value); }
        public float TamanhoFonte { get => (float)GetValue(TamanhoFonteProperty); set => SetValue(TamanhoFonteProperty, value); }
        public string? Fonte { get => (string?)GetValue(FonteProperty); set => SetValue(FonteProperty, value); }

        public HAlign AlinhamentoHorizontal { get => (HAlign)GetValue(AlinhamentoHorizontalProperty); set => SetValue(AlinhamentoHorizontalProperty, value); }
        public VAlign AlinhamentoVertical { get => (VAlign)GetValue(AlinhamentoVerticalProperty); set => SetValue(AlinhamentoVerticalProperty, value); }

        public float RotacaoGraus { get => (float)GetValue(RotacaoGrausProperty); set => SetValue(RotacaoGrausProperty, value); }
        public Color Fundo { get => (Color)GetValue(FundoProperty); set => SetValue(FundoProperty, value); }
        public float Padding { get => (float)GetValue(PaddingProperty); set => SetValue(PaddingProperty, value); }

        public GraphicsView? Host { get => (GraphicsView?)GetValue(HostProperty); set => SetValue(HostProperty, value); }

        static void OnAnyChanged(BindableObject b, object oldV, object newV)
            => ((Texto)b).Host?.Invalidate();

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            var texto = Conteudo ?? string.Empty;
            if (string.IsNullOrEmpty(texto))
                return;

            canvas.SaveState();

            var font = string.IsNullOrWhiteSpace(Fonte)
                ? Microsoft.Maui.Graphics.Font.Default
                : new Microsoft.Maui.Graphics.Font(Fonte);

            canvas.Font = font;
            canvas.FontSize = TamanhoFonte;
            canvas.FontColor = Cor;

            // Mede o texto para alinhar manualmente (sem usar RectF)
            var med = canvas.GetStringSize(texto, font, TamanhoFonte);

            float x = X, y = Y;

            // Alinhamento horizontal (ajusta X)
            switch (AlinhamentoHorizontal)
            {
                case Microsoft.Maui.Graphics.HorizontalAlignment.Center: x -= med.Width / 2f; break;
                case Microsoft.Maui.Graphics.HorizontalAlignment.Right: x -= med.Width; break;
                    // Left: nada
            }

            // Alinhamento vertical (ajusta Y)
            switch (AlinhamentoVertical)
            {
                case Microsoft.Maui.Graphics.VerticalAlignment.Center: y -= med.Height / 2f; break;
                case Microsoft.Maui.Graphics.VerticalAlignment.Bottom: y -= med.Height; break;
                    // Top: nada
            }

            // Rotação em torno do centro do bloco
            var cx = x + med.Width / 2f;
            var cy = y + med.Height / 2f;
            if (RotacaoGraus != 0f)
            {
                canvas.Translate(cx, cy);
                canvas.Rotate(RotacaoGraus);
                canvas.Translate(-cx, -cy);
            }

            // Fundo (sem quebrar linha)
            if (Fundo.Alpha > 0)
            {
                var pad = Padding;
                var back = new RectF(x - pad, y - pad, med.Width + 2 * pad, med.Height + 2 * pad);
                canvas.FillColor = Fundo;
                canvas.FillRectangle(back);
            }

            // *** Chamada que NÃO quebra linha ***
            // Usa a sobrecarga por ponto; alinhamento horizontal é aplicado pelo MAUI,
            // mas como já ajustamos x/y acima, desenhe "Left/Top" para não re-alinhar.
            canvas.DrawString(texto, X, Y, AlinhamentoHorizontal);

            canvas.RestoreState();
        }
    }
}
