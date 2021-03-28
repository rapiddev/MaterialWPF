// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System;
using System.Windows;

namespace MaterialWPF.Controls
{
    public partial class MessageBox : System.Windows.Window
    {
        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register("Header", typeof(string), typeof(Controls.MessageBox), new PropertyMetadata(String.Empty));
        public static readonly DependencyProperty MessageProperty = DependencyProperty.Register("Message", typeof(string), typeof(Controls.MessageBox), new PropertyMetadata(String.Empty));
        
        //public static readonly DependencyProperty HeightProperty = DependencyProperty.Register("Height", typeof(string), typeof(Controls.MessageBox), new PropertyMetadata(String.Empty));

        public string Header
        {
            get
            {
                return this.GetValue(HeaderProperty) as string;
            }
            set
            {
                this.SetValue(HeaderProperty, value);
            }
        }

        public string Message
        {
            get
            {
                return this.GetValue(MessageProperty) as string;
            }
            set
            {
                this.SetValue(MessageProperty, value);
            }
        }

        public MessageBox() : base()
        {
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Owner = Application.Current.MainWindow;

            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            this.Left = (Application.Current.MainWindow.Left / 2) + (Application.Current.MainWindow.Width / 2);// - (this.Width / 2);
            this.Top = (Application.Current.MainWindow.Top / 2) + (Application.Current.MainWindow.Height / 2);// - (this.Height / 2);
        }
    }
}
