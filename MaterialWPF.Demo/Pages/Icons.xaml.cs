using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using MaterialWPF.UI;

namespace MaterialWPF.Demo.Pages
{
    public struct DisplayableIcon
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public MaterialIcon Icon { get; set; }
    }

    /// <summary>
    /// Interaction logic for Icons.xaml
    /// </summary>
    public partial class Icons : Page
    {
        private string _activeGlyph = "Accept";
        public Icons()
        {
            InitializeComponent();
            this.FillIcons();
        }

        private async void FillIcons()
        {
            List<DisplayableIcon> icons = new List<DisplayableIcon> { };
            DataContext = this;

            await Task.Run(() =>
            {
                foreach (string iconName in Enum.GetNames(typeof(UI.MaterialIcon)))
                {
                    MaterialIcon icon = (MaterialIcon)Enum.Parse(typeof(MaterialIcon), iconName);
                    //System.Diagnostics.Debug.WriteLine(icon);

                    icons.Add(new DisplayableIcon
                    {
                        Name = iconName,
                        Icon = icon,
                        Code = ((int)MiconIcons.ToGlyph(icon)).ToString("X4")
                    });
                }

                App.Current.Dispatcher.Invoke(() =>
                {
                    iconsList.ItemsSource = icons;
                });

                Thread.Sleep(1000);

                App.Current.Dispatcher.Invoke(() =>
                {
                    gridLoading.Visibility = Visibility.Hidden;
                });
            });
        }

        private void ChangeGlyps()
        {
            textGlyph.Text = this._activeGlyph;
        }

        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this._activeGlyph = (sender as Border).Tag.ToString();
            this.ChangeGlyps();
        }
    }
}
