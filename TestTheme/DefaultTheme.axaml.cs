using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace TestTheme;

public sealed class DefaultTheme : Styles
{
	public DefaultTheme(IServiceProvider? serviceProvider = null)
	{
		AvaloniaXamlLoader.Load(serviceProvider, this);
	}
}