// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System;

//Based on WPF NotifyIcon created by Philipp Sumi under The Code Project Open License (CPOL)

namespace MaterialWPF.UI
{
    /// <summary>
    /// Interpreting the system tray icon using <see langword="shell32.dll"/>, without using WindowsForms. It only contains the basic functionality to display the icon.
    /// </summary>
    public class Tray
    {
        /// <summary>
        /// Creates, updates or deletes the taskbar icon.
        /// </summary>
        //[DllImport("shell32.Dll", CharSet = CharSet.Unicode)]
        //public static extern bool Shell_NotifyIcon(NotifyCommand cmd, [In] ref NotifyIconData data);

        private string
            _text = string.Empty;

        private Uri
            _icon = null;

        private Action
            _click = null,
            _doubleClick = null,
            _rightClick = null,
            _doubleRightClick = null;

        /// <summary>
        /// Gets or sets the text that appears when you hover over the icon in Tray.
        /// </summary>
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        /// <summary>
        /// Gets or sets an absolute <see cref="Uri"/> address for icon in <see cref="System.Windows.Application.Resources"/>, preferably <c>.ico</c>
        /// </summary>
        public Uri Icon
        {
            get { return this._icon; }
            set { this._icon = value; }
        }

        /// <summary>
        /// Gets or sets a method that will be triggered when user left-click on an icon in the Tray.
        /// </summary>
        public Action Click
        {
            get { return this._click; }
            set { this._click = value; }
        }

        /// <summary>
        /// Gets or sets a method that will be triggered when user double-left-click on an icon in the Tray.
        /// </summary>
        public Action DoubleClick
        {
            get { return this._doubleClick; }
            set { this._doubleClick = value; }
        }

        /// <summary>
        /// Gets or sets a method that will be triggered when user right-click on an icon in the Tray.
        /// </summary>
        public Action RightClick
        {
            get { return this._rightClick; }
            set { this._rightClick = value; }
        }

        /// <summary>
        /// Gets or sets a method that will be triggered when user double-right-click on an icon in the Tray.
        /// </summary>
        public Action DoubleRightClick
        {
            get { return this._doubleRightClick; }
            set { this._doubleRightClick = value; }
        }
        

        public Tray()
        {
            //
        }

        public void Initialize()
        {

        }

        public void Dispose()
        {

        }
    }
}
