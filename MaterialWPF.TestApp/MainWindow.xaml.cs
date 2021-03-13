using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Navigation;
using MaterialWPF.UI;

namespace MaterialWPF.TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            rootNavigation.Frame = rootFrame;
            rootNavigation.Items = new ObservableCollection<NavItem>
            {
                new NavItem { Icon = MaterialIcon.GridView, Name = "Dashboard", Tag = "dashboard", Type = typeof(Pages.Dashboard)},
                new NavItem { Icon = MaterialIcon.AdjustHologram, Name = "Controls", Tag = "controls", Type = typeof(Pages.Controls)},
                new NavItem { Icon = MaterialIcon.Calories, Name = "Icons", Tag = "icons", Type = typeof(Pages.Icons)},
                new NavItem { Icon = MaterialIcon.AlignLeft, Name = "Tree List", Tag = "treelist", Type = typeof(Pages.TreeList)}
            };

            rootNavigation.Navigate("dashboard");
        }
    }
}
