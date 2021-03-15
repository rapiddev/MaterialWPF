using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MaterialWPF.Demo.Pages
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();

            buttonIcons.Control.Click += Button_Icons;
            buttonControls.Control.Click += Button_Controls;

            buttonLight.Control.Click += Button_ThemeLight;
            buttonDark.Control.Click += Button_ThemeDark;
        }

        private void Navigate(string tag)
        {
            (App.Current.MainWindow as MainWindow).rootNavigation.Navigate(tag);
        }

        private void Button_Icons(object sender, RoutedEventArgs e)
        {
            this.Navigate("icons");
        }

        private void Button_Controls(object sender, RoutedEventArgs e)
        {
            this.Navigate("controls");
        }

        private void Button_ThemeLight(object sender, RoutedEventArgs e)
        {
            (System.Windows.Application.Current as App).SwitchTheme(Theme.Light);
            mainBanner.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri("pack://application:,,,/Assets/banner-light.png"));
        }

        private void Button_ThemeDark(object sender, RoutedEventArgs e)
        {
            (System.Windows.Application.Current as App).SwitchTheme(Theme.Dark);
            mainBanner.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri("pack://application:,,,/Assets/banner-dark.png"));
        }
    }
}
