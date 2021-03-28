// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System;
using System.Windows;
using System.Windows.Input;

namespace MaterialWPF.Controls
{
    public partial class Dialog : System.Windows.Controls.ContentControl
    {
        private bool _status = false;
        
        private Action
            _closeButtonClickAction = null,
            _actionButtonClickAction = null;

        public static readonly DependencyProperty
            EnabledProperty = DependencyProperty.Register("Enabled", typeof(bool), typeof(Controls.Dialog), new PropertyMetadata(false)),
            CloseButtonTextProperty = DependencyProperty.Register("CloseButtonText", typeof(string), typeof(Controls.Dialog), new PropertyMetadata("Close")),
            CloseButtonGlyphProperty = DependencyProperty.Register("CloseButtonGlyph", typeof(char), typeof(Controls.Dialog), new PropertyMetadata(UI.MiconIcons.Cancel)),
            CloseButtonCommandProperty = DependencyProperty.Register("CloseButtonCommand", typeof(ICommand), typeof(Controls.Dialog), new UIPropertyMetadata(null)),
            ActionButtonTextProperty = DependencyProperty.Register("ActionButtonText", typeof(string), typeof(Controls.Dialog), new PropertyMetadata("Action Button")),
            ActionButtonGlyphProperty = DependencyProperty.Register("ActionButtonGlyph", typeof(char), typeof(Controls.Dialog), new PropertyMetadata(UI.MiconIcons.Accept)),
            ActionButtonCommandProperty = DependencyProperty.Register("ActionButtonCommand", typeof(ICommand), typeof(Controls.Dialog), new UIPropertyMetadata(null));

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

        public string CloseButtonText
        {
            get
            {
                return this.GetValue(CloseButtonTextProperty) as string;
            }
            set
            {
                this.SetValue(CloseButtonTextProperty, value);
            }
        }

        public char CloseButtonGlyph
        {
            get
            {
                return (char)(this.GetValue(CloseButtonGlyphProperty) as char?);
            }
            set
            {
                this.SetValue(CloseButtonGlyphProperty, value);
            }
        }

        public string ActionButtonText
        {
            get
            {
                return this.GetValue(ActionButtonTextProperty) as string;
            }
            set
            {
                this.SetValue(ActionButtonTextProperty, value);
            }
        }

        public char ActionButtonGlyph
        {
            get
            {
                return (char)(this.GetValue(ActionButtonGlyphProperty) as char?);
            }
            set
            {
                this.SetValue(ActionButtonGlyphProperty, value);
            }
        }

        public Action CloseButtonClick
        {
            set
            {
                this._closeButtonClickAction = value;
            }
        }

        public Action ActionButtonClick
        {
            set
            {
                this._actionButtonClickAction = value;
            }
        }

        public Dialog() : base()
        {
            this.SetValue(CloseButtonCommandProperty, new UI.RelayCommand(
                param => this.CloseButtonCommandAction()
            ));

            this.SetValue(ActionButtonCommandProperty, new UI.RelayCommand(
                param => this.ActionButtonCommandAction()
            ));

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

            /*
            DoubleAnimation db = new DoubleAnimation();
            db.EasingFunction = new CubicEase { EasingMode = EasingMode.EaseOut };
            db.To = 0;
            db.From = this.ActualHeight;
            db.Duration = TimeSpan.FromSeconds(0.5);

            
            slideTransform.BeginAnimation(TranslateTransform.YProperty, db);
            */
            
            this.Visibility = Visibility.Visible;
            this._status = true;
        }

        public void Hide()
        {
            this.Visibility = Visibility.Hidden;
            this._status = false;
        }

        private void CloseButtonCommandAction()
        {
            this.Hide();

            if (this._closeButtonClickAction != null)
                this._closeButtonClickAction();
        }

        private void ActionButtonCommandAction()
        {
            if (this._actionButtonClickAction != null)
                this._actionButtonClickAction();
        }
    }
}
