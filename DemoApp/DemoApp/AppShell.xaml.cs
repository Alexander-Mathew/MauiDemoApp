using DemoApp.Views;

namespace DemoApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(HomeView), typeof(HomeView));
	}
}

