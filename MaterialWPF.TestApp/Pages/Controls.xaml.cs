using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaterialWPF.TestApp.Pages
{
    /// <summary>
    /// Interaction logic for Controls.xaml
    /// </summary>
    public partial class Controls : Page
    {
        public Controls()
        {
            InitializeComponent();

            buttonShowPopup.Control.Click += Button_PopUp;
            buttonShowDialog.Control.Click += Button_Dialog;
        }

        private void Button_PopUp(object sender, RoutedEventArgs e)
        {
            popupMain.Header = "Wow that's amazing!";
            popupMain.Message = "This popup contains a message, you can change it or something ...";
            popupMain.Show();
        }

        private void Button_Dialog(object sender, RoutedEventArgs e)
        {
            dialogMain.Show();
        }
    }
}
