namespace MAUI_ECommerce.Pages.Controls;


public class StarRatingControl : GraphicsView
{
    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create(nameof(Value), typeof(double), typeof(StarRatingControl), 0.0,
            propertyChanged: (bindable, oldValue, newValue) => ((StarRatingControl)bindable).Invalidate());

    public static readonly BindableProperty MaximumProperty =
        BindableProperty.Create(nameof(Maximum), typeof(int), typeof(StarRatingControl), 5);

    public static readonly BindableProperty StarColorProperty =
        BindableProperty.Create(nameof(StarColor), typeof(Color), typeof(StarRatingControl), Colors.Gold);

    public static readonly BindableProperty EmptyStarColorProperty =
        BindableProperty.Create(nameof(EmptyStarColor), typeof(Color), typeof(StarRatingControl), Colors.LightGray);

    public static readonly BindableProperty IsInteractiveProperty =
        BindableProperty.Create(nameof(IsInteractive), typeof(bool), typeof(StarRatingControl), true,
            propertyChanged: OnIsInteractiveChanged);


    public StarRatingControl()
    {
        Drawable = new StarDrawable(this);
        UpdateInteractionHandlers(IsInteractive);
    }

    public double Value
    {
        get => (double)GetValue(ValueProperty);
        set => SetValue(ValueProperty, Math.Round(value, 2));
    }

    public int Maximum
    {
        get => (int)GetValue(MaximumProperty);
        set => SetValue(MaximumProperty, value);
    }

    public Color StarColor
    {
        get => (Color)GetValue(StarColorProperty);
        set => SetValue(StarColorProperty, value);
    }

    public Color EmptyStarColor
    {
        get => (Color)GetValue(EmptyStarColorProperty);
        set => SetValue(EmptyStarColorProperty, value);
    }

    public bool IsInteractive
    {
        get => (bool)GetValue(IsInteractiveProperty);
        set => SetValue(IsInteractiveProperty, value);
    }

    private void OnTouchInteraction(object sender, TouchEventArgs e)
    {
        if (Width <= 0) return;

        var touchX = e.Touches[0].X;
        var newValue = (touchX / Width) * Maximum;
        Value = Math.Max(0, Math.Min(newValue, Maximum));
    }

    private static void OnIsInteractiveChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (StarRatingControl)bindable;
        control.UpdateInteractionHandlers((bool)newValue);
    }

    private void UpdateInteractionHandlers(bool isInteractive)
    {
        StartInteraction -= OnTouchInteraction;
        DragInteraction -= OnTouchInteraction;

        if (isInteractive)
        {
            StartInteraction += OnTouchInteraction;
            DragInteraction += OnTouchInteraction;
        }
    }

    private class StarDrawable : IDrawable
    {
        private readonly StarRatingControl _control;

        public StarDrawable(StarRatingControl control)
        {
            _control = control;
        }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            var starSize = dirtyRect.Height;
            var starSpacing = starSize * 0.2f;
            var totalWidth = (_control.Maximum * starSize) + ((_control.Maximum - 1) * starSpacing);
            var startX = (dirtyRect.Width - totalWidth) / 2;

            for (int i = 0; i < _control.Maximum; i++)
            {
                var x = startX + i * (starSize + starSpacing);
                var rect = new RectF(x, 0, starSize, starSize);

                DrawEmptyStar(canvas, rect);
                DrawFilledStar(canvas, rect, i);
            }
        }

        private void DrawEmptyStar(ICanvas canvas, RectF rect)
        {
            var path = CreateStarPath(rect);
            canvas.FillColor = _control.EmptyStarColor;
            canvas.FillPath(path);
        }

        private void DrawFilledStar(ICanvas canvas, RectF rect, int starIndex)
        {
            var filledFraction = Math.Clamp(_control.Value - starIndex, 0, 1);
            if (filledFraction <= 0) return;

            var clipRect = new RectF(rect.Left, rect.Top, rect.Width * (float)filledFraction, rect.Height);
            var path = CreateStarPath(rect);

            canvas.SaveState();
            canvas.ClipRectangle(clipRect);

            canvas.FillColor = _control.StarColor;
            canvas.FillPath(path);

            canvas.RestoreState();
        }

        private PathF CreateStarPath(RectF rect)
        {
            var center = new PointF(rect.Center.X, rect.Center.Y);
            var outerRadius = rect.Width / 2;
            var innerRadius = outerRadius * 0.4f;

            var path = new PathF();
            path.MoveTo(center.X, center.Y - outerRadius);

            for (int i = 1; i < 10; i++)
            {
                var angle = i * Math.PI / 5 - Math.PI / 2;
                var radius = i % 2 == 0 ? outerRadius : innerRadius;
                var point = new PointF(
                    center.X + (float)(radius * Math.Cos(angle)),
                    center.Y + (float)(radius * Math.Sin(angle)));

                path.LineTo(point);
            }

            path.Close();
            return path;
        }
    }
}
