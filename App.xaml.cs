// Demo app using .NET MAUI (Multi-platform App UI)
// by Joanne Hoar

/*
Just to keep things simple, both of these files are referred to as a single file. There are generally two files with any XAML file, the .xaml file itself, and a corresponding code file that is a child item of it in the Solution Explorer. The .xaml file contains XAML markup and the code file contains code created by the user to interact with the XAML markup.

The App.xaml file contains app-wide XAML resources, such as colors, styles, or templates. The App.xaml.cs file generally contains code that instantiates the Shell application. In this project, it points to the AppShell class.
*/

namespace MauiHelloUser;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}