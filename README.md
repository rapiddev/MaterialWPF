# MaterialWPF
Customize the WPF window in the style of modern Windows applications

## How to implement?
If you are not using MaterialDesignToolkit for WPF, change the static resource for the background<br/>
**Add resources to App.xaml**
```c#
<ResourceDictionary Source="pack://application:,,,/Styles/Material.xaml" />
```
**Add a template to your window**
```c#
<Window.Template>
        <ControlTemplate TargetType="{x:Type Window}">
            <Grid>
                <Grid Background="{DynamicResource MaterialDesignPaper}">
                    <Grid.RowDefinitions>
                        <RowDefinition Height="Auto" />
                        <RowDefinition Height="*" />
                    </Grid.RowDefinitions>
                    <Grid
                        Grid.Row="0"
                        Margin="1"
                        Background="{DynamicResource MaterialDesignPaper}"
                        MouseDown="DragWindow"
                        MouseLeftButtonDown="DragMaximize">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="*" />
                            <ColumnDefinition Width="Auto" />
                        </Grid.ColumnDefinitions>
                        <StackPanel
                            Grid.Column="0"
                            Margin="8,0"
                            Orientation="Horizontal">
                            <TextBlock VerticalAlignment="Center" Text="WPF like UWP #32" />
                        </StackPanel>
                        <StackPanel Grid.Column="1" Orientation="Horizontal">
                            <Button
                                Click="AppBarButton"
                                KeyboardNavigation.IsTabStop="False"
                                Style="{StaticResource MinimizeButtonStyle}"
                                Tag="minimize" />
                            <Button
                                x:Name="MaximizeButton"
                                Click="AppBarButton"
                                KeyboardNavigation.IsTabStop="False"
                                Style="{StaticResource MaximizeButtonStyle}"
                                Tag="maximize" />
                            <Button
                                Click="AppBarButton"
                                KeyboardNavigation.IsTabStop="False"
                                Style="{StaticResource CloseButtonStyle}"
                                Tag="close" />
                        </StackPanel>
                    </Grid>
                    <ContentPresenter Grid.Row="1" />
                </Grid>
                <Grid>
                    <Rectangle
                        Name="bottom"
                        Height="1"
                        Margin="1,0"
                        VerticalAlignment="Bottom"
                        Fill="#3f3f41"
                        MouseEnter="DisplayResizeCursor"
                        MouseLeave="ResetCursor"
                        PreviewMouseDown="Resize"
                        Stroke="{x:Null}" />
                    <Rectangle
                        Name="left"
                        Width="1"
                        Margin="0,1"
                        HorizontalAlignment="Left"
                        VerticalAlignment="Stretch"
                        Fill="#3f3f41"
                        MouseEnter="DisplayResizeCursor"
                        MouseLeave="ResetCursor"
                        PreviewMouseDown="Resize" />
                    <Rectangle
                        Name="right"
                        Width="1"
                        Margin="0,1"
                        HorizontalAlignment="Right"
                        VerticalAlignment="Stretch"
                        Fill="#3f3f41"
                        MouseEnter="DisplayResizeCursor"
                        MouseLeave="ResetCursor"
                        PreviewMouseDown="Resize" />
                    <Rectangle
                        Name="topLeft"
                        Width="1"
                        Height="1"
                        HorizontalAlignment="Left"
                        VerticalAlignment="Top"
                        Fill="#3f3f41"
                        MouseEnter="DisplayResizeCursor"
                        MouseLeave="ResetCursor"
                        PreviewMouseDown="Resize" />
                    <Rectangle
                        Name="bottomLeft"
                        Width="1"
                        Height="1"
                        Margin="0"
                        HorizontalAlignment="Left"
                        VerticalAlignment="Bottom"
                        Fill="#3f3f41"
                        MouseEnter="DisplayResizeCursor"
                        MouseLeave="ResetCursor"
                        PreviewMouseDown="Resize" />
                    <Rectangle
                        Name="bottomRight"
                        Width="1"
                        Height="1"
                        Margin="0"
                        HorizontalAlignment="Right"
                        VerticalAlignment="Bottom"
                        Fill="#3f3f41"
                        MouseEnter="DisplayResizeCursor"
                        MouseLeave="ResetCursor"
                        PreviewMouseDown="Resize" />
                    <Rectangle
                        Name="top"
                        Height="1"
                        Margin="1,0"
                        VerticalAlignment="Top"
                        AllowDrop="True"
                        Fill="#3f3f41"
                        MouseEnter="DisplayResizeCursor"
                        MouseLeave="ResetCursor"
                        PreviewMouseDown="Resize" />
                    <Rectangle
                        Name="topRight"
                        Width="1"
                        Height="1"
                        Margin="0"
                        HorizontalAlignment="Right"
                        VerticalAlignment="Top"
                        Fill="#3f3f41"
                        MouseEnter="DisplayResizeCursor"
                        MouseLeave="ResetCursor"
                        PreviewMouseDown="Resize" />
                </Grid>
            </Grid>
        </ControlTemplate>
    </Window.Template>
```

**Window logic**
```c#
[DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        private int _resizeDir;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AppBarButton(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Tag.ToString())
            {
                case "minimize":
                    App.Current.MainWindow.WindowState = WindowState.Minimized;
                    break;
                case "maximize":
                    if (App.Current.MainWindow.WindowState == WindowState.Normal)
                    {
                        (sender as Button).Style = (Style)App.Current.Resources["RestoreButtonStyle"];
                        App.Current.MainWindow.WindowState = WindowState.Maximized;
                    }
                    else
                    {
                        (sender as Button).Style = (Style)App.Current.Resources["MaximizeButtonStyle"];
                        App.Current.MainWindow.WindowState = WindowState.Normal;
                    }
                    break;
                case "close":
                    App.Current.Shutdown();
                    break;
            }
        }
        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        private void DragMaximize(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
                if (App.Current.MainWindow.WindowState == WindowState.Normal)
                {
                    (Template.FindName("MaximizeButton", this) as Button).Style = (Style)App.Current.Resources["RestoreButtonStyle"];
                    App.Current.MainWindow.WindowState = WindowState.Maximized;
                }
                else
                {
                    (Template.FindName("MaximizeButton", this) as Button).Style = (Style)App.Current.Resources["MaximizeButtonStyle"];
                    App.Current.MainWindow.WindowState = WindowState.Normal;
                }
        }
        private void Resize(object sender, MouseButtonEventArgs e)
        {
            if(App.Current.MainWindow.WindowState != WindowState.Maximized)
                SendMessage((PresentationSource.FromVisual((Visual)sender) as HwndSource).Handle, 0x112, (IntPtr)(61440 + _resizeDir), IntPtr.Zero);
        }
        private void ResetCursor(object sender, MouseEventArgs e)
        {
            if (Mouse.LeftButton != MouseButtonState.Pressed && App.Current.MainWindow.WindowState != WindowState.Maximized)
                this.Cursor = Cursors.Arrow;
        }
        private void DisplayResizeCursor(object sender, MouseEventArgs e)
        {
            Rectangle clickedRectangle = sender as Rectangle;
            if (App.Current.MainWindow.WindowState != WindowState.Maximized)
                switch (clickedRectangle.Name)
                {
                    case "top":
                        this.Cursor = Cursors.SizeNS;
                        this._resizeDir = 3;
                        break;
                    case "bottom":
                        this.Cursor = Cursors.SizeNS;
                        this._resizeDir = 6;
                        break;
                    case "left":
                        this.Cursor = Cursors.SizeWE;
                        this._resizeDir = 1;
                        break;
                    case "right":
                        this.Cursor = Cursors.SizeWE;
                        this._resizeDir = 2;
                        break;
                    case "topLeft":
                        this.Cursor = Cursors.SizeNWSE;
                        this._resizeDir = 4;
                        break;
                    case "topRight":
                        this.Cursor = Cursors.SizeNESW;
                        this._resizeDir = 5;
                        break;
                    case "bottomLeft":
                        this.Cursor = Cursors.SizeNESW;
                        this._resizeDir = 7;
                        break;
                    case "bottomRight":
                        this.Cursor = Cursors.SizeNWSE;
                        this._resizeDir = 8;
                        break;
                }
        }
```
