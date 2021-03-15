// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MaterialWPF.Controls
{
    /// <summary>
    /// Interaction logic for MaterialHyperlink.xaml
    /// </summary>
    public partial class MaterialHyperlink : UserControl
    {
        public static readonly DependencyProperty
            SizeProperty = DependencyProperty.Register("Size", typeof(double), typeof(MaterialWPF.Controls.MaterialHyperlink), new PropertyMetadata((double)13)),
            UrlProperty = DependencyProperty.Register("Url", typeof(string), typeof(MaterialWPF.Controls.MaterialHyperlink), new PropertyMetadata(string.Empty)),
            TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(MaterialWPF.Controls.MaterialHyperlink), new PropertyMetadata(string.Empty));

        public double Size
        {
            get
            {
                return (double)(this.GetValue(SizeProperty) as double?);
            }
            set
            {
                this.SetValue(SizeProperty, value);
            }
        }

        public string Url
        {
            get
            {
                return this.GetValue(UrlProperty) as string;
            }
            set
            {
                this.SetValue(UrlProperty, value);
            }
        }

        public string Text
        {
            get
            {
                return this.GetValue(TextProperty) as string;
            }
            set
            {
                this.SetValue(TextProperty, value);
            }
        }

        public MaterialHyperlink()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            /*Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            */

            if(e.Uri.AbsoluteUri != null)
            {
                System.Diagnostics.ProcessStartInfo sInfo = new System.Diagnostics.ProcessStartInfo(e.Uri.AbsoluteUri)
                {
                    UseShellExecute = true,
                };
                System.Diagnostics.Process.Start(sInfo);
            }

            e.Handled = true;
        }
    }
}
