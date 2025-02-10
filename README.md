# Demo of .NET MAUI App #

by Joanne Hoar

## Create the Project ##

Create a new .NET MAUI Shell app.

```
mkdir MauiHelloUser
cd MauiHelloUser
dotnet new maui
```

Now you have some generated code. MainPage.xaml and MainPage.xaml.cs contain the user interface controls and the code-behind for the demo.

AppShell.xaml and AppShell.xaml.cs contain the visual hierarchy/navigation. This is where you add another tab for another page for example. In this demo, it instantiates the MainPage class.

App.xaml and App.xaml.cs contain app-wide XAML resources, such as colors, styles, or templates. The App.xaml.cs file contains code that instantiates the AppShell class.

MauiProgram.cs is the cross-platform entry point, or "bootstrap". The startup code here points to the App class.

## Build and Run ##

Look at MauiHelloUser.csproj this file defines all the target frameworks and how to build them. Build for your machine, eg.

```
dotnet build -t:Build -f net9.0-windows10.0.19041.0

```
Run the executable:
```
.\bin\Debug\net9.0-windows10.0.19041.0\win10-x64\MauiHelloUser.exe
```

## Modify the Code ##

Start in MainPage.xaml and MainPage.xaml.cs.

Try adding a Entry component to get the username.

Customize the greeting for the user.

## Go Further ##

Try adding another page (eg. AboutPage.xaml) with a navigation tab from AppShell.

Refer to this tutorial:
https://learn.microsoft.com/en-us/dotnet/maui/tutorials/notes-app/?view=net-maui-9.0


## Optional: Android Device ##

Install Android Studio and agree to the licenses with sdkmanager. Create a new emulator through device manager. Start the emulator from the command line. Eg.

```
emulator -list-avds
```

```
emulator -avd Nexus_S_API_35
```

From another command prompt, install and launch your App on the emulator.

```
build -t:Run -f net9.0-android
```

Now you can pair your device through the device manager for wi-fi or USB debugging.

May need to enable developer options on device: under the About Phone menu, tap Build several times. May need to clean and re-build. May need to enable EmbedAssembliesIntoApk in project file.

```
	<PropertyGroup Condition=" '$(Configuration)' == 'Debug' ">
		<EmbedAssembliesIntoApk>true</EmbedAssembliesIntoApk>
	</PropertyGroup>
```
