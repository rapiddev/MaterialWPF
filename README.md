# Material WPF
[Created with ![heart](http://i.imgur.com/oXJmdtz.gif) in Poland by RapidDev](https://rdev.cc/)  
A simple and uncomplicated way to make your application written in WPF keep up with modern design trends. Library changes the base elements like Window, Page or Button, and also includes additional controls like Navigation or Popup.

[![GitHub license](https://img.shields.io/github/license/rapiddev/MaterialWPF)](https://github.com/rapiddev/MaterialWPF/blob/master/LICENSE) [![NET](https://img.shields.io/badge/.NET-5.0.0-red)](https://github.com/rapiddev/MaterialWPF/blob/master/MaterialWPF.csproj) [![Nuget](https://img.shields.io/nuget/v/MaterialWPF)](https://www.nuget.org/packages/MaterialWPF/) [![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/MaterialWPF?label=nuget-pre)](https://www.nuget.org/packages/MaterialWPF/) [![Nuget](https://img.shields.io/nuget/dt/MaterialWPF?label=nuget-downloads)](https://www.nuget.org/packages/MaterialWPF/)


## Custom controls
| Control | Namespace | Description |
| --- | --- | --- | 
| **Navigation** | MaterialWPF.Controls | Simple ListView with a hamburger menu button. After assigning elements and Frame, it allows to navigate through the application. |
| **Popup** | MaterialWPF.Controls | A card with a pop-up animation that can act as a notification of an action for the user. |
| **Splash** | MaterialWPF.Controls | The tab that can be used to cover the main view of the application while loading resources, the equivalent of UWP. |
| **WindowNavigation** | MaterialWPF.Controls | A set of buttons that can replace the default window navigation, giving it a new, modern look. |


## How to implement?
**Add resources to App.xaml**
```c#
<Application>
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="pack://application:,,,/MaterialWPF;component/Styles/ThemeLight.xaml" />
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
    xmlns:materialwpf="clr-namespace:MaterialWPF.Controls;assembly=MaterialWPF"
    MaxWidth="{Binding Source={x:Static SystemParameters.WorkArea}, Path=Width}"
    MaxHeight="{Binding Source={x:Static SystemParameters.WorkArea}, Path=Height}"
    Style="{StaticResource MaterialWindow}"
    ResizeMode="CanResize"
    WindowStyle="None">
    <WindowChrome.WindowChrome>
        <WindowChrome
            CaptionHeight="0"
            CornerRadius="0"
            GlassFrameThickness="0"
            ResizeBorderThickness="6"
            UseAeroCaptionButtons="False" />
    </WindowChrome.WindowChrome>
    <Grid x:Name="MainGrid">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="Auto" />
            <ColumnDefinition Width="*" />
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto" />
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>

        <!--  Navigation  -->
        <materialwpf:Navigation
            x:Name="rootNavigation"
            Grid.Row="0"
            Grid.RowSpan="2"
            Grid.Column="0" />

        <!--  Content Frame  -->
        <Grid Grid.Row="1" Grid.Column="1">
            <Frame
                x:Name="rootFrame"
                Navigating="FrameOnNavigating"
                NavigationUIVisibility="Hidden" />
        </Grid>

        <!--  Window buttons  -->
        <materialwpf:WindowNavigation Grid.Row="0" Grid.Column="1" />
    </Grid>
</Window>
```

## How can I help improve it?
The MaterialWPF team welcomes feedback and contributions!<br/>
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
