// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System.Windows;
using System.Windows.Controls;

namespace MaterialWPF.Demo.Pages
{
    /// <summary>
    /// Interaction logic for Controls.xaml
    /// </summary>
    public partial class Controls : Page
    {
        public Controls()
        {
            InitializeComponent();

            dialogMain.ActionButtonGlyph = UI.MiconIcons.ActionCenter;
            dialogMain.ActionButtonClick = OnDialogClick;
        }

        public void OnDialogClick()
        {
            dialogMain.Hide();
            snackbarMain.Header = "This snackbar has been opened by an OnDialogClick action!";
            snackbarMain.Message = textboxDialog.Text;
            snackbarMain.Show();
        }

        //This method is triggered by MaterialWPF.Controls.Navigation when navigating to this page.
        public void OnNavigationRequest()
        {
            snackbarMain.Header = "This snackbar has been opened by an OnNavigationRequest!";
            snackbarMain.Message = "Each of your pages may contain such a method and respond to user navigation or whatever...";
            snackbarMain.Show();
        }

        private void Button_Snackbar(object sender, RoutedEventArgs e)
        {
            snackbarMain.Header = "Wow that's amazing!";
            snackbarMain.Message = "This snackbar contains a message, you can change it or something...";
            snackbarMain.Show();
        }

        private void Button_Dialog(object sender, RoutedEventArgs e)
        {
            dialogMain.Show();
        }

        private void Button_Toast(object sender, RoutedEventArgs e)
        {
            MaterialWPF.UI.Toast toast = new MaterialWPF.UI.Toast();

            toast.Header = "Sample toast";
            toast.Message = "When your application is running e.g. in the background, you can send a notification to the user to finally get up from his desk and eat something. Well, for example ...";
            toast.Footer = "Created with Material WPF";

            toast.Send();
        }

        private void Button_MessageBox(object sender, RoutedEventArgs e)
        {
            MaterialWPF.Controls.MessageBox mBox = new MaterialWPF.Controls.MessageBox()
            {
                Title = "This is window title",
                //Header = "Wow, it's even looks nice",
                Message = "You can write a message here. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse"
            };

            mBox.ShowDialog();
        }
    }
}
