using MaterialWPF.UI;
using System.Collections.ObjectModel;
using System.Windows;

namespace MaterialWPF.Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Splash();

            rootNavigation.Frame = rootFrame;
            rootNavigation.Items = new ObservableCollection<NavItem>
            {
                new NavItem { Icon = MaterialIcon.GridView, Name = "Dashboard", Tag = "dashboard", Type = typeof(Pages.Dashboard)},
                new NavItem { Icon = MaterialIcon.AdjustHologram, Name = "Controls", Tag = "controls", Type = typeof(Pages.Controls)},
                new NavItem { Icon = MaterialIcon.Input, Name = "Forms", Tag = "fields", Type = typeof(Pages.Fields)},
                new NavItem { Icon = MaterialIcon.Color, Name = "Colors", Tag = "colors", Type = typeof(Pages.Colors)},
                new NavItem { Icon = MaterialIcon.Calories, Name = "Icons", Tag = "icons", Type = typeof(Pages.Icons)},
#if DEBUG
                new NavItem { Icon = MaterialIcon.AlignLeft, Name = "Tree List", Tag = "treelist", Type = typeof(Pages.TreeList)}
#endif
            };

            rootNavigation.Footer = new ObservableCollection<NavItem>
            {
                new NavItem { Icon = MaterialIcon.Settings, Name = "Settings", Tag = "Settings", Type = typeof(Pages.Settings), Action = OnSettingsNavigate}
            };

            rootNavigation.OnNavigate = OnNavigate;
            rootNavigation.Navigate("dashboard");
        }

        public void OnNavigate()
        {
            System.Diagnostics.Debug.WriteLine($"Navigated to: {rootNavigation.PageNow}");
        }

        public void OnSettingsNavigate()
        {
            System.Diagnostics.Debug.WriteLine("User clicked to navigate to settings");
        }

        private async void Splash()
        {
            System.Version? version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            if (version != null)
                mainSplash.Version = version.ToString();

            mainSplash.Logo = new System.Windows.Media.Imaging.BitmapImage(new System.Uri("pack://application:,,,/Assets/banner-dark.png"));
            mainSplash.SubTitle = "Loading a fantastic demo app...";

            await System.Threading.Tasks.Task.Run(() =>
            {
                System.Threading.Thread.Sleep(3000);

                App.Current.Dispatcher.Invoke(() =>
                {
                    mainSplash.Visibility = Visibility.Hidden;
                    toggleTheme.Visibility = Visibility.Visible;
                });
            });
        }

        private void ToggleTheme(object sender, RoutedEventArgs e)
        {
            bool isChecked = (bool)(sender as MaterialWPF.Controls.ToggleButton).IsChecked;

            if (rootNavigation.PageNow == "dashboard")
                (rootNavigation.Items[0].Instance as Pages.Dashboard).ToggleTheme(isChecked);

            if (!isChecked)
                MaterialWPF.Theme.Switch(MaterialWPF.MaterialTheme.Light);
            else
                MaterialWPF.Theme.Switch(MaterialWPF.MaterialTheme.Dark);
        }
    }
}
