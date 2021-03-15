// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace MaterialWPF.Controls
{
    /// <summary>
    /// Interaction logic for Dialog.xaml
    /// </summary>
    public partial class Dialog : UserControl
    {
        private bool _status = false;
        private Action _action = null;

        public static readonly DependencyProperty
            EnabledProperty = DependencyProperty.Register("Enabled", typeof(bool), typeof(Dialog), new PropertyMetadata(false));

        public bool? Enabled
        {
            get
            {
                return this.GetValue(EnabledProperty) as bool?;
            }
            set
            {
                this.SetValue(EnabledProperty, value);

                if (value == true)
                {
                    this.Visibility = Visibility.Visible;
                    this._status = true;
                }
                else
                {
                    this.Visibility = Visibility.Hidden;
                    this._status = false;
                }
            }
        }

        public Action Action
        {
            set
            {
                this._action = value;
            }
        }

        public Dialog()
        {
            InitializeComponent();

            if (Enabled == true)
            {
                this.Visibility = Visibility.Visible;
                this._status = true;
            }
            else
            {
                this.Visibility = Visibility.Hidden;
                this._status = false;
            }
        }

        public void Show()
        {
            if (this._status)
                return;

            DoubleAnimation db = new DoubleAnimation();
            db.EasingFunction = new CubicEase { EasingMode = EasingMode.EaseOut };
            db.To = 0;
            db.From = this.ActualHeight;
            db.Duration = TimeSpan.FromSeconds(0.5);

            this.Visibility = Visibility.Visible;
            //slideTransform.BeginAnimation(TranslateTransform.YProperty, db);

            this._status = true;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            this._status = false;
        }

        private void ButtonAction_Click(object sender, RoutedEventArgs e)
        {
            if (this._action != null)
                this._action();
        }
    }
}
