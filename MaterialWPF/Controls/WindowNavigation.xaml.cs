// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MaterialWPF.Controls
{
    /// <summary>
    /// Interaction logic for WindowNavigation.xaml
    /// </summary>
    public partial class WindowNavigation : UserControl
    {
        public WindowNavigation()
        {
            InitializeComponent();
        }

        private void AppBarButton(object sender, RoutedEventArgs e)
        {
            switch ((sender as System.Windows.Controls.Button).Tag.ToString())
            {
                case "minimize":
                    Application.Current.MainWindow.WindowState = WindowState.Minimized;
                    break;
                case "maximize":
                    this.Maximize();
                    break;
                case "close":
                    Application.Current.Shutdown();
                    break;
            }
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                Application.Current.MainWindow.DragMove();
        }

        private void DragMaximize(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
                this.Maximize();
        }

        private void Maximize()
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
            {
                Application.Current.MainWindow.ResizeMode = ResizeMode.NoResize;
                MaximizeButton.Style = (Style)Application.Current.Resources["RestoreButton"];
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.ResizeMode = ResizeMode.CanResize;
                MaximizeButton.Style = (Style)Application.Current.Resources["MaximizeButton"];
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }
    }
}
