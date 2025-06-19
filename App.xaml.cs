namespace MyMauiApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell(); // << this loads the TabBar

	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}