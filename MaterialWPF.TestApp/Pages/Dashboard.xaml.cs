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
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            /*Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            */

            System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo(e.Uri.AbsoluteUri)
            {
                UseShellExecute = true,
            };
            System.Diagnostics.Process.Start(sInfo);

            e.Handled = true;
        }
    }
}
