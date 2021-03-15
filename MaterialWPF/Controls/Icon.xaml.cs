// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System.Windows;
using System.Windows.Controls;

namespace MaterialWPF.Controls
{
    /// <summary>
    /// Interaction logic for Icon.xaml
    /// </summary>
    public partial class Icon : UserControl
    {
        public static readonly DependencyProperty
            GlyphProperty = DependencyProperty.Register("Glyph", typeof(UI.MaterialIcon), typeof(MaterialWPF.Controls.Icon), new PropertyMetadata(UI.MaterialIcon.Accept)),
            SizeProperty = DependencyProperty.Register("Size", typeof(double), typeof(MaterialWPF.Controls.Icon), new PropertyMetadata((double)13));

        public string RawGlyph
        {
            get
            {
                return UI.MiconIcons.ToString((UI.MaterialIcon)(this.GetValue(GlyphProperty) as UI.MaterialIcon?));
            }
        }
        
        public UI.MaterialIcon Glyph
        {
            get
            {
                return (UI.MaterialIcon)(this.GetValue(GlyphProperty) as UI.MaterialIcon?);
            }
            set
            {
                this.SetValue(GlyphProperty, value);
            }
        }

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

        public Icon()
        {
            InitializeComponent();
        }
    }
}
