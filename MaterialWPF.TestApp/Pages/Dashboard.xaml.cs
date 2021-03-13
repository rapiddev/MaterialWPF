using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MaterialWPF.TestApp.Pages
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
