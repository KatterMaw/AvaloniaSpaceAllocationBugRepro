using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace TestTheme.Assists;

internal sealed class TextBoxAssist
{
	public static readonly AvaloniaProperty<IBrush?> WatermarkBrushProperty =
		AvaloniaProperty.RegisterAttached<TextBox, IBrush?>("WatermarkBrush", typeof(TextBoxAssist));

	public static readonly AvaloniaProperty<Thickness> LeftInnerContentMarginProperty =
		AvaloniaProperty.RegisterAttached<TextBox, Thickness>("LeftInnerContentMargin", typeof(TextBoxAssist));

	public static readonly AvaloniaProperty<Thickness> RightInnerContentMarginProperty =
		AvaloniaProperty.RegisterAttached<TextBox, Thickness>("RightInnerContentMargin", typeof(TextBoxAssist));
}