# Archiving
Due to the release of Windows 11 this library will no longer be maintained. If you want similar functionality but in a newer release see [WPF UI](https://github.com/lepoco/wpfui).

## Material WPF
[Created with ❤️ in Poland by lepo.co](https://dev.lepo.co/)  
A simple and uncomplicated way to make your application written in WPF keep up with modern design trends. Library changes the base elements like Window, Page or Button, and also includes additional controls like Navigation, ToggleButton or Snackbar. It's not really material, but a mixture of Fluent, Material and Cupertino.

[![GitHub license](https://img.shields.io/github/license/rapiddev/MaterialWPF)](https://github.com/rapiddev/MaterialWPF/blob/master/LICENSE) [![NET](https://img.shields.io/badge/.NET-5.0.0-red)](https://github.com/rapiddev/MaterialWPF/blob/master/MaterialWPF/MaterialWPF.csproj) [![Nuget](https://img.shields.io/nuget/v/MaterialWPF)](https://www.nuget.org/packages/MaterialWPF/) [![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/MaterialWPF?label=nuget-pre)](https://www.nuget.org/packages/MaterialWPF/) [![Nuget](https://img.shields.io/nuget/dt/MaterialWPF?label=nuget-downloads)](https://www.nuget.org/packages/MaterialWPF/)


## What's included?
| Name| Framework | Build Status |
| --- | --- | --- | 
| **MaterialWPF**<br />Library that allows you to use all features in your own application | .NET 6.0 Windows,<br/>.NET 5.0 Windows,<br/>.NET Core 3.1<br/>.NET Framework 4.8 | [![Build status](https://github.com/rapiddev/MaterialWPF/workflows/CI/badge.svg)](https://github.com/rapiddev/MaterialWPF/actions) | 
| **MaterialWPF.Demo**<br />An application written in WPF .NET 5 where you can test the features. | .NET 6.0 Windows 11 | [![Build status](https://github.com/rapiddev/MaterialWPF/workflows/CI/badge.svg)](https://github.com/rapiddev/MaterialWPF/actions) | 


## Custom controls
| Control | Namespace | Description |
| --- | --- | --- |
| **Toast** | [MaterialWPF.UI](https://github.com/rapiddev/MaterialWPF/tree/master/MaterialWPF/UI) | Class with which you can send a Toast to the Windows notification center. |
| **MiconIcons** | [MaterialWPF.UI](https://github.com/rapiddev/MaterialWPF/tree/master/MaterialWPF/UI) | A collection of all [Micon](https://github.com/xtoolkit/Micon) font glyphs that you can use in an application. |
| **Dialog** | [MaterialWPF.Controls](https://github.com/rapiddev/MaterialWPF/tree/master/MaterialWPF/Controls) | A control that you can display in the middle of the application, e.g. with a "Save as" information or whatever... |
| **Hyperlink** | [MaterialWPF.Controls](https://github.com/rapiddev/MaterialWPF/tree/master/MaterialWPF/Controls) | A button that navigates to the browser window. |
| **Icon** | [MaterialWPF.Controls](https://github.com/rapiddev/MaterialWPF/tree/master/MaterialWPF/Controls) | Prepared TextBlock with "Glyph" attribute with which you can select an icon. |
| **MaterialButton** | [MaterialWPF.Controls](https://github.com/rapiddev/MaterialWPF/tree/master/MaterialWPF/Controls) | A modern button with all the possibilities of a regular "Button" and an icon on the left. |
| **MessageBox** | [MaterialWPF.Controls](https://github.com/rapiddev/MaterialWPF/tree/master/MaterialWPF/Controls) | A custom MessageBox that can contain selected controls. |
| **Navigation** | [MaterialWPF.Controls](https://github.com/rapiddev/MaterialWPF/tree/master/MaterialWPF/Controls) | Simple ListView with a hamburger menu button. After assigning elements and Frame, it allows to navigate through the application. |
| **Snackbar** | [MaterialWPF.Controls](https://github.com/rapiddev/MaterialWPF/tree/master/MaterialWPF/Controls) | A card with a pop-up animation that can act as a notification of an action for the user. |
| **Splash** | [MaterialWPF.Controls](https://github.com/rapiddev/MaterialWPF/tree/master/MaterialWPF/Controls) | The tab that can be used to cover the main view of the application while loading resources, the equivalent of UWP. |
| **ToggleButton** | [MaterialWPF.Controls](https://github.com/rapiddev/MaterialWPF/tree/master/MaterialWPF/Controls) | A button like a Checkbox that switches with animation. |
| **WindowNavigation** | [MaterialWPF.Controls](https://github.com/rapiddev/MaterialWPF/tree/master/MaterialWPF/Controls) | A set of buttons that can replace the default window navigation, giving it a new, modern look. |


## How to implement?
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
- TreeGridUX by the David Anson  
[https://dlaa.me/blog/post/9898803](https://dlaa.me/blog/post/9898803)

## License
MaterialWPF is free and open source software licensed under MPL 2.0. You can use it in private and commercial projects. Keep in mind that you must include a copy of the license in your project.
