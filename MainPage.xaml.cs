// Demo app using .NET MAUI (Multi-platform App UI)
// by Joanne Hoar

// MainPage
// this c# class represents the code-behind the controls for the startup page
// for more on controls see here: https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls


namespace MauiHelloUser;

public partial class MainPage : ContentPage
{
	string? name;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnUserNameEntered(object sender, EventArgs e)
	{
		name = ((Entry)sender).Text;		
		Greeting.Text = $"Hello, {name}!";
	}
}

