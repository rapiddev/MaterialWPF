![Logo](https://github.com/rapiddev/MaterialWPF/blob/master/MaterialWPF.Demo/Assets/banner.png?raw=true)
# Material WPF
[Created with ![heart](http://i.imgur.com/oXJmdtz.gif) in Poland by RapidDev](https://rdev.cc/)  
A simple and uncomplicated way to make your application written in WPF keep up with modern design trends. Library changes the base elements like Window, Page or Button, and also includes additional controls like Navigation or Popup.

[![GitHub license](https://img.shields.io/github/license/rapiddev/MaterialWPF)](https://github.com/rapiddev/MaterialWPF/blob/master/LICENSE) [![NET](https://img.shields.io/badge/.NET-5.0.0-red)](https://github.com/rapiddev/MaterialWPF/blob/master/MaterialWPF.csproj) [![Nuget](https://img.shields.io/nuget/v/MaterialWPF)](https://www.nuget.org/packages/MaterialWPF/) [![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/MaterialWPF?label=nuget-pre)](https://www.nuget.org/packages/MaterialWPF/) [![Nuget](https://img.shields.io/nuget/dt/MaterialWPF?label=nuget-downloads)](https://www.nuget.org/packages/MaterialWPF/)


## What's included?
| Name| Framework | Build Status |
| --- | --- | --- | 
| **MaterialWPF**<br />Library that allows you to use all features in your own application | .NET 5.0 Windows<br/>.NET 5.0 Windows 10 1809 | [![Build status](https://github.com/rapiddev/MaterialWPF/workflows/CI/badge.svg)](https://github.com/rapiddev/MaterialWPF/actions) | 
| **MaterialWPF.Demo**<br />An application written in WPF .NET 5 where you can test the features. | .NET 5.0 Windows 10 1809 | [![Build status](https://github.com/rapiddev/MaterialWPF/workflows/CI/badge.svg)](https://github.com/rapiddev/MaterialWPF/actions) | 


## Custom controls
| Control | Namespace | Description |
| --- | --- | --- |
| **Toast** | MaterialWPF.UI | Class with which you can send a Toast to the Windows notification center. |
| **MiconIcons** | MaterialWPF.UI | A collection of all [Micon](https://github.com/xtoolkit/Micon) font glyphs that you can use in an application. |
| **Icon** | MaterialWPF.Controls | Prepared TextBlock with "Glyph" attribute with which you can select an icon. |
| **Popup** | MaterialWPF.Controls | A card with a pop-up animation that can act as a notification of an action for the user. |
| **Dialog** | MaterialWPF.Controls | A control that you can display in the middle of the application, e.g. with a "Save as" information or whatever... |
| **Splash** | MaterialWPF.Controls | The tab that can be used to cover the main view of the application while loading resources, the equivalent of UWP. |
| **Navigation** | MaterialWPF.Controls | Simple ListView with a hamburger menu button. After assigning elements and Frame, it allows to navigate through the application. |
| **WindowNavigation** | MaterialWPF.Controls | A set of buttons that can replace the default window navigation, giving it a new, modern look. |


## How to implement?
**Set the target of your project to a minimum of Windows 10 1809**
```c#
<Project Sdk="Microsoft.NET.Sdk.WindowsDesktop">
  <PropertyGroup>
    <TargetFrameworks>net5.0-windows10.0.17763.0</TargetFrameworks>
    <TargetPlatformVersion>10.0</TargetPlatformVersion>
    <LangVersion>latest</LangVersion>
  </PropertyGroup>
</Project>
```

**Add resources to App.xaml**
```c#
<Application
  x:Class="YourMainNamespace.App"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  xmlns:local="clr-namespace:YourMainNamespace"
  StartupUri="MainWindow.xaml">
  <Application.Resources>
    <ResourceDictionary>
      <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="pack://application:,,,/MaterialWPF;component/Styles/ThemeDark.xaml" />
        <ResourceDictionary Source="pack://application:,,,/MaterialWPF;component/Styles/Material.xaml" />
      </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
  </Application.Resources>
</Application>
```

## Sample Window
**(without logic)**
```c#
<Window
  x:Class="YourMainNamespace.MainWindow"
  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
  xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
  xmlns:materialwpf="clr-namespace:MaterialWPF.Controls;assembly=MaterialWPF"
  xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
  Width="1160"
  Height="612"
  Style="{StaticResource MaterialNavigationWindow}"
  WindowStartupLocation="CenterScreen"
  mc:Ignorable="d">
  <Grid>
    <!--  An example of splitting the window grid to make everything look nice  -->
    <Grid.ColumnDefinitions>
      <ColumnDefinition Width="Auto" />
      <ColumnDefinition Width="*" />
    </Grid.ColumnDefinitions>
    <Grid.RowDefinitions>
      <RowDefinition Height="Auto" />
      <RowDefinition Height="*" />
    </Grid.RowDefinitions>

    <!--  Navigation Control, displays buttons for navigating pages  -->
    <materialwpf:Navigation
      x:Name="rootNavigation"
      Grid.Row="0"
      Grid.RowSpan="2"
      Grid.Column="0" />

    <!--  Main content frame, instances of the Page class are loaded into it  -->
    <Grid Grid.Row="1" Grid.Column="1">
      <Frame x:Name="rootFrame" />
    </Grid>

    <!--  Buttons for navigating the application window (minimize, maximize, close)  -->
    <materialwpf:WindowNavigation Grid.Row="0" Grid.Column="1" />

    <!--  Splash to make the app look nice on startup. You can use it while loading resources  -->
    <materialwpf:Splash
      x:Name="mainSplash"
      Grid.RowSpan="2"
      Grid.ColumnSpan="2" />
  </Grid>
</Window>
```

## How can I help improve it?
The MaterialWPF team welcomes feedback and contributions!  
If you have any suggestions or improvements, don't hesitate to create an issue.

## Third party solutions
- Micon Icons by the Mehdi HosseinZade  
[https://github.com/xtoolkit/Micon](https://github.com/xtoolkit/Micon)
- Lato by the Łukasz Dziedzic  
[https://www.latofonts.com/team/](https://www.latofonts.com/team/)
- TreeGridUX by the David Anson  
[https://dlaa.me/blog/post/9898803](https://dlaa.me/blog/post/9898803)

## License
MaterialWPF is free and open source software licensed under MPL 2.0. You can use it in private and commercial projects. Keep in mind that you must include a copy of the license in your project.
