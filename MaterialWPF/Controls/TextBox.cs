// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;

namespace MaterialWPF.Controls
{
    public class TextBox : System.Windows.Controls.TextBox
    {
        public static readonly DependencyProperty
            MaskProperty = DependencyProperty.Register("Mask", typeof(string), typeof(MaterialWPF.Controls.TextBox),
                new PropertyMetadata(string.Empty)),
            PlaceholderProperty = DependencyProperty.Register("Placeholder", typeof(string),
                typeof(MaterialWPF.Controls.TextBox), new PropertyMetadata(string.Empty));

        public string Mask
        {
            get { return this.GetValue(MaskProperty) as string; }
            set { this.SetValue(MaskProperty, value); }
        }

        public string Placeholder
        {
            get { return this.GetValue(PlaceholderProperty) as string; }
            set { this.SetValue(PlaceholderProperty, value); }
        }

        public TextBox() : base()
        {
            this.PreviewTextInput += TextBox_PreviewTextInput;
            this.TextChanged += TextBox_TextChanged;
        }

        //TODO MASK
        private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("Preview Text Input");
            //System.Diagnostics.Debug.WriteLine(((sender as TextBox).GetTemplateChild("materialTextBox") as TextBox).Text);
            //System.Diagnostics.Debug.WriteLine(e.Text.Last());

            if (string.IsNullOrEmpty(this.Mask))
                return;

            char[] mask = this.Mask.ToCharArray();

            if (e.Text.Length > mask.Length)
            {
                e.Handled = false;
            }
            else if (mask[e.Text.Length] == '9')
            {
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.Text.Last().ToString());
            }
            else if (mask[e.Text.Length] == 'a')
            {
                Regex regex = new Regex("[^a-zA-Z]+");
                e.Handled = regex.IsMatch(e.Text.Last().ToString());
            }
            else if (mask[e.Text.Length] == '*')
            {
                e.Handled = true;
            }
            else
            {
                this.Text += mask[e.Text.Length + 1].ToString();
                e.Handled = true;
            }
        }

        //TODO MASK
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("Text Changed");
            /*
            if (System.Text.RegularExpressions.Regex.IsMatch((sender as TextBox).Text, "[^0-9]"))
            {
                //MessageBox.Show("Please enter only numbers.");
                (sender as TextBox).Text = (sender as TextBox).Text.Remove((sender as TextBox).Text.Length - 1);
            }
            */
        }
    }
}