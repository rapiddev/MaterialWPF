﻿using MaterialWPF.UI;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Navigation;

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
                new NavItem { Icon = MiconIcons.GridView, Name = "Dashboard", Tag = "dashboard", Type = typeof(Pages.Dashboard)},
                new NavItem { Icon = MiconIcons.Calories, Name = "Icons", Tag = "icons", Type = typeof(Pages.Icons)}
            };

            rootNavigation.Navigate("dashboard");
        }

        private void FrameOnNavigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.Content == null)
                return;

            rootFrame.NavigationService.RemoveBackEntry();
        }
    }
}
