﻿// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System;
using System.Windows;

namespace MaterialWPF.Controls
{
    public partial class Hyperlink : System.Windows.Controls.Button
    {
        public static readonly DependencyProperty NavigateUriProperty = DependencyProperty.Register("NavigateUri", typeof(string), typeof(Controls.Hyperlink), new PropertyMetadata(String.Empty));

        public string NavigateUri
        {
            get
            {
                return this.GetValue(NavigateUriProperty) as string;
            }
            set
            {
                this.SetValue(NavigateUriProperty, value);
            }
        }

        public Hyperlink()
        {
            this.Click += RequestNavigate;
        }

        private void RequestNavigate(object sender, RoutedEventArgs e)
        {
            if(NavigateUri != null)
            {
                System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo(new Uri(NavigateUri).AbsoluteUri)
                {
                    UseShellExecute = true,
                };
                System.Diagnostics.Process.Start(sInfo);
            }
        }
    }
}
