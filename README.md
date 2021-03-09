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
    xmlns:controls="clr-namespace:MaterialWPF.Controls;assembly=MaterialWPF"
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
        <controls:Navigation
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
        <controls:WindowNavigation Grid.Row="0" Grid.Column="1" />
    </Grid>
</Window>
```