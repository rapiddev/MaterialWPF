// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Media.Animation;
using System.Linq;

namespace MaterialWPF.Controls
{
    /// <summary>
    /// Interaction logic for Snackbar.xaml
    /// </summary>
    public partial class Snackbar : UserControl
    {
        private const string randomChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private string _threadControl = null;
        private bool _visible = false;

        public static readonly DependencyProperty
            EnabledProperty = DependencyProperty.Register("Enabled", typeof(bool), typeof(Controls.Snackbar), new PropertyMetadata(false)),
            MessageProperty = DependencyProperty.Register("Message", typeof(string), typeof(Controls.Snackbar), new PropertyMetadata(String.Empty)),
            HeaderProperty = DependencyProperty.Register("Header", typeof(string), typeof(Controls.Snackbar), new PropertyMetadata(String.Empty));

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

        private int? _timeout = 3000;
        public int? Timeout
        {
            get
            {
                return _timeout as int?;
            }
            set
            {
                _timeout = value;
            }
        }

        private bool _status = false;
        public Snackbar()
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

            this.UpdateThread();

            DoubleAnimation db = new DoubleAnimation();
            db.EasingFunction = new CubicEase { EasingMode = EasingMode.EaseOut };
            db.To = 0;
            db.From = this.ActualHeight;
            db.Duration = TimeSpan.FromSeconds(0.5);

            this.Visibility = Visibility.Visible;
            slideTransform.BeginAnimation(TranslateTransform.YProperty, db);

            this._visible = true;
            this._status = true;

            if (_timeout != null && _timeout > 0)
                this.HideTimeout();
        }

        public async void Show(string header, string message = null)
        {
            if(this._visible)
                this.UpdateThread();

            this.Hide();
            
            await Task.Run(() =>
            {
                Thread.Sleep((int)300);

                if (Application.Current == null)
                    return;

                Application.Current.Dispatcher.Invoke(() =>
                {
                    this.Header = header;
                    this.Message = message;

                    this.Show();
                });
            });
        }

        private async void HideTimeout()
        {
            string masterThread = this._threadControl;

            await Task.Run(() =>
            {
                Thread.Sleep((int)this._timeout);

                if (Application.Current == null)
                    return;

                Application.Current.Dispatcher.Invoke(() =>
                {
                    if(this._threadControl == masterThread)
                        this.Hide();
                });
            });
        }

        private void Hide()
        {
            if (!this._status)
                return;

            DoubleAnimation db = new DoubleAnimation();
            db.EasingFunction = new CubicEase { EasingMode = EasingMode.EaseIn };
            db.From = 0;
            db.To = this.ActualHeight;
            db.Duration = TimeSpan.FromSeconds(0.5);

            slideTransform.BeginAnimation(TranslateTransform.YProperty, db);

            this._visible = false;
            this._status = false;
        }

        private void UpdateThread()
        {
            Random random = new Random();
            this._threadControl = new string(Enumerable.Repeat(randomChars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void Button_Collapse(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
