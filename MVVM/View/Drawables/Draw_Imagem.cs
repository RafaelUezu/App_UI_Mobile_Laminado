using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Platform;
using Microsoft.Maui.Storage; // para FileSystem

// Aliases para eliminar ambiguidades:
using GImage = Microsoft.Maui.Graphics.IImage;
using GFont = Microsoft.Maui.Graphics.Font;
using HAlign = Microsoft.Maui.Graphics.HorizontalAlignment;
using VAlign = Microsoft.Maui.Graphics.VerticalAlignment;
using GPlatformImage = Microsoft.Maui.Graphics.Platform.PlatformImage;

namespace App_UI_Mobile_Laminado.MVVM.View.Drawables
{
    public class Draw_Imagem : BindableObject, IDrawable
    {
        public enum ImgAspect { None, Fit, Fill }

        // --- Fonte da imagem ---
        public static readonly BindableProperty SourceProperty =
            BindableProperty.Create(nameof(Source), typeof(string), typeof(Draw_Imagem), default(string),
                propertyChanged: OnSourceChanged);

        // --- Posição / Tamanho ---
        public static readonly BindableProperty XProperty =
            BindableProperty.Create(nameof(X), typeof(float), typeof(Draw_Imagem), 0f, propertyChanged: OnAnyChanged);
        public static readonly BindableProperty YProperty =
            BindableProperty.Create(nameof(Y), typeof(float), typeof(Draw_Imagem), 0f, propertyChanged: OnAnyChanged);

        // Largura/Altura destino; se <= 0, usa tamanho natural
        public static readonly BindableProperty LarguraProperty =
            BindableProperty.Create(nameof(Largura), typeof(float), typeof(Draw_Imagem), -1f, propertyChanged: OnAnyChanged);
        public static readonly BindableProperty AlturaProperty =
            BindableProperty.Create(nameof(Altura), typeof(float), typeof(Draw_Imagem), -1f, propertyChanged: OnAnyChanged);

        // --- Estilo / Transform ---
        public static readonly BindableProperty AlinhamentoHorizontalProperty =
            BindableProperty.Create(nameof(AlinhamentoHorizontal), typeof(HAlign), typeof(Draw_Imagem),
                HAlign.Left, propertyChanged: OnAnyChanged);

        public static readonly BindableProperty AlinhamentoVerticalProperty =
            BindableProperty.Create(nameof(AlinhamentoVertical), typeof(VAlign), typeof(Draw_Imagem),
                VAlign.Top, propertyChanged: OnAnyChanged);

        public static readonly BindableProperty AspectProperty =
            BindableProperty.Create(nameof(Aspect), typeof(ImgAspect), typeof(Draw_Imagem),
                ImgAspect.None, propertyChanged: OnAnyChanged);

        public static readonly BindableProperty RotacaoGrausProperty =
            BindableProperty.Create(nameof(RotacaoGraus), typeof(float), typeof(Draw_Imagem),
                0f, propertyChanged: OnAnyChanged);

        public static readonly BindableProperty OpacidadeProperty =
            BindableProperty.Create(nameof(Opacidade), typeof(float), typeof(Draw_Imagem),
                1f, propertyChanged: OnAnyChanged);

        // --- Host para invalidar ---
        public static readonly BindableProperty HostProperty =
            BindableProperty.Create(nameof(Host), typeof(GraphicsView), typeof(Draw_Imagem));

        // Propriedades .NET
        public string? Source { get => (string?)GetValue(SourceProperty); set => SetValue(SourceProperty, value); }
        public float X { get => (float)GetValue(XProperty); set => SetValue(XProperty, value); }
        public float Y { get => (float)GetValue(YProperty); set => SetValue(YProperty, value); }
        public float Largura { get => (float)GetValue(LarguraProperty); set => SetValue(LarguraProperty, value); }
        public float Altura { get => (float)GetValue(AlturaProperty); set => SetValue(AlturaProperty, value); }

        public HAlign AlinhamentoHorizontal { get => (HAlign)GetValue(AlinhamentoHorizontalProperty); set => SetValue(AlinhamentoHorizontalProperty, value); }
        public VAlign AlinhamentoVertical { get => (VAlign)GetValue(AlinhamentoVerticalProperty); set => SetValue(AlinhamentoVerticalProperty, value); }
        public ImgAspect Aspect { get => (ImgAspect)GetValue(AspectProperty); set => SetValue(AspectProperty, value); }

        public float RotacaoGraus { get => (float)GetValue(RotacaoGrausProperty); set => SetValue(RotacaoGrausProperty, value); }
        public float Opacidade { get => (float)GetValue(OpacidadeProperty); set => SetValue(OpacidadeProperty, value); }

        public GraphicsView? Host { get => (GraphicsView?)GetValue(HostProperty); set => SetValue(HostProperty, value); }

        private GImage? _img;
        private SizeF _naturalSize;

        static void OnAnyChanged(BindableObject b, object oldV, object newV)
            => ((Draw_Imagem)b).Host?.Invalidate();

        static void OnSourceChanged(BindableObject b, object oldV, object newV)
            => _ = ((Draw_Imagem)b).LoadImageAsync(); // dispara carregamento assíncrono

        private async Task LoadImageAsync()
        {
            try
            {
                _img = null;
                _naturalSize = SizeF.Zero;

                var src = Source;
                if (string.IsNullOrWhiteSpace(src))
                {
                    Host?.Invalidate();
                    return;
                }

                using Stream stream =
                    (System.IO.Path.IsPathRooted(src) || src.StartsWith("/"))
                    ? System.IO.File.OpenRead(src)                              // caminho absoluto
                    : await FileSystem.OpenAppPackageFileAsync(src);            // de Resources/Images (MauiImage)

                // Cria a imagem do Graphics a partir do stream
                _img = GPlatformImage.FromStream(stream);
                if (_img is not null)
                    _naturalSize = new SizeF(_img.Width, _img.Height);
            }
            catch
            {
                _img = null;
                _naturalSize = SizeF.Zero;
            }
            finally
            {
                Host?.Invalidate();
            }
        }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            if (_img is null) return;

            // Tamanho destino
            float dstW = (Largura > 0) ? Largura : _naturalSize.Width;
            float dstH = (Altura > 0) ? Altura : _naturalSize.Height;

            if (Aspect != ImgAspect.None && Largura > 0 && Altura > 0 && _naturalSize.Width > 0 && _naturalSize.Height > 0)
            {
                var sx = Largura / _naturalSize.Width;
                var sy = Altura / _naturalSize.Height;
                var s = (Aspect == ImgAspect.Fit) ? MathF.Min(sx, sy) : MathF.Max(sx, sy);
                dstW = _naturalSize.Width * s;
                dstH = _naturalSize.Height * s;
            }

            // Âncora a partir de (X,Y)
            float x = X, y = Y;
            switch (AlinhamentoHorizontal)
            {
                case HAlign.Center: x -= dstW / 2f; break;
                case HAlign.Right: x -= dstW; break;
            }
            switch (AlinhamentoVertical)
            {
                case VAlign.Center: y -= dstH / 2f; break;
                case VAlign.Bottom: y -= dstH; break;
            }

            canvas.SaveState();

            // Opacidade e rotação
            canvas.Alpha = Math.Clamp(Opacidade, 0f, 1f);
            if (RotacaoGraus != 0f)
            {
                var cx = x + dstW / 2f;
                var cy = y + dstH / 2f;
                canvas.Translate(cx, cy);
                canvas.Rotate(RotacaoGraus);
                canvas.Translate(-cx, -cy);
            }

            canvas.DrawImage(_img, x, y, dstW, dstH);

            canvas.RestoreState();
        }
    }
}
