![Screenshot](https://github.com/rapiddev/MaterialWPF/blob/master/.github/screenshot-1.jpg?raw=true)
# MaterialWPF
[Created with ![heart](http://i.imgur.com/oXJmdtz.gif) in Poland by RapidDev](https://rdev.cc/)<br />
Customize the WPF window in the style of modern Windows applications

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

### How can I help improve it?
The MaterialWPF team welcomes feedback and contributions!<br/>
If you have any suggestions or improvements, don't hesitate to create an issue.

### Third party solutions
- Micon Icons by the Mehdi HosseinZade<br/>[https://github.com/xtoolkit/Micon](https://github.com/xtoolkit/Micon)
- Lato by the Łukasz Dziedzic<br/>[https://www.latofonts.com/team/](https://www.latofonts.com/team/)
- TreeGridUX by the David Anson<br/>[https://dlaa.me/blog/post/9898803](https://dlaa.me/blog/post/9898803)

### License
MaterialWPF is free and open source software licensed under MPL 2.0. You can use it in private and commercial projects. Keep in mind that you must include a copy of the license in your project.