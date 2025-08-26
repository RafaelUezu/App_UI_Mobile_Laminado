using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.MVVM.View.Drawables
{
    public class QuadradoDrawable : BindableObject, IDrawable
    {
        // Propriedades bindlable X,Y e Lado
        public static readonly BindableProperty XProperty =
            BindableProperty.Create(nameof(X), typeof(float), typeof(QuadradoDrawable), 0f, propertyChanged: OnChanged);
        public static readonly BindableProperty YProperty =
            BindableProperty.Create(nameof(Y), typeof(float), typeof(QuadradoDrawable), 0f, propertyChanged: OnChanged);
        public static readonly BindableProperty LadoProperty =
            BindableProperty.Create(nameof(Lado), typeof(float), typeof(QuadradoDrawable), 50f, propertyChanged: OnChanged);

        // Referência ao GraphicsView para poder invalidar
        public static readonly BindableProperty HostProperty =
            BindableProperty.Create(nameof(Host), typeof(GraphicsView), typeof(QuadradoDrawable));

        public float X { get => (float)GetValue(XProperty); set => SetValue(XProperty, value); }
        public float Y { get => (float)GetValue(YProperty); set => SetValue(YProperty, value); }
        public float Lado { get => (float)GetValue(LadoProperty); set => SetValue(LadoProperty, value); }
        public GraphicsView? Host { get => (GraphicsView?)GetValue(HostProperty); set => SetValue(HostProperty, value); }

        static void OnChanged(BindableObject bindable, object oldValue, object newValue)
            => ((QuadradoDrawable)bindable).Host?.Invalidate();

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            var r = new RectF(X, Y, Lado, Lado);

            canvas.FillColor = Colors.SteelBlue;
            canvas.FillRectangle(r);

            canvas.StrokeColor = Colors.Black;
            canvas.StrokeSize = 2;
            canvas.DrawRectangle(r);
        }
    }
}
