using System.Windows;
using System.Windows.Controls;

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
        }

        //This method is triggered by MaterialWPF.Controls.Navigation when navigating to this page.
        public void OnNavigationRequest()
        {
            System.Diagnostics.Debug.WriteLine("You've just been navigated to the Dashboard!");
        }

        public void ToggleTheme(bool isDark)
        {
            if (isDark)
                mainBanner.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri("pack://application:,,,/Assets/banner-dark.png"));
            else
                mainBanner.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri("pack://application:,,,/Assets/banner-light.png"));
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
    }
}
