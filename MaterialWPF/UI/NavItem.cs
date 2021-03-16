// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System;
using System.ComponentModel;

namespace MaterialWPF.UI
{
    /// <summary>
    /// An interactive element that is a block in the menu for the <see cref="MaterialWPF.Controls.Navigation"/> control.
    /// </summary>
    public class NavItem : INotifyPropertyChanged
    {
        private bool _isActive = false;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the instance of <see cref="System.Windows.Controls.Page"/> that will be used to display in frame.
        /// </summary>
        public Object Instance { get; set; }

        /// <summary>
        /// Gets or sets the type of <see cref="System.Windows.Controls.Page"/> that will be used to create the instance.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the item that will be displayed on the menu.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an identifier by which the menu can be navigated with the help of <see cref="Controls.Navigation.Navigate(string, bool)"/>.
        /// </summary>
        public string Tag { get; set; }

        public bool IsDropdown { get { return SubItems != null && SubItems.Length > 0; } }

        public NavItem[] SubItems { get; set; }

        /// <summary>
        /// Gets the icon that will be displayed in the menu.
        /// </summary>
        public UI.MaterialIcon Icon { get; set; }

        /// <summary>
        /// Gets the unicode character that corresponds to the selected icon.
        /// </summary>
        public char RawIcon => UI.MiconIcons.ToGlyph(Icon);

        /// <summary>
        /// Gets or sets whether the current item is active at the moment.
        /// </summary>
        public bool IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                if (value != this._isActive)
                {
                    this._isActive = value;
                    this.OnPropertyChanged("IsActive");
                }
            }
        }

        protected void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
