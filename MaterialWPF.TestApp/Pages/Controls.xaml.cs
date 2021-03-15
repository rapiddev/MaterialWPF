// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System.Windows;
using System.Windows.Controls;

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
            buttonSendToast.Control.Click += Button_Toast;
        }

        private void Button_PopUp(object sender, RoutedEventArgs e)
        {
            popupMain.Header = "Wow that's amazing!";
            popupMain.Message = "This popup contains a message, you can change it or something...";
            popupMain.Show();
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
    }
}
