// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System.Windows;

namespace MaterialWPF.Controls
{
    public partial class MaterialButton : System.Windows.Controls.Button
    {
        public static readonly DependencyProperty GlyphProperty = DependencyProperty.Register("Glyph", typeof(UI.MaterialIcon), typeof(MaterialWPF.Controls.MaterialButton), new PropertyMetadata(UI.MaterialIcon.Accept, new PropertyChangedCallback(OnGlyphChanged)));
        public static readonly DependencyProperty RawGlyphProperty = DependencyProperty.Register("RawGlyph", typeof(string), typeof(MaterialWPF.Controls.MaterialButton), new PropertyMetadata("\uEA01"));

        private static void OnGlyphChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MaterialButton).SetValue(RawGlyphProperty, UI.MiconIcons.ToString((d as MaterialButton).Glyph as UI.MaterialIcon?));
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
    }
}
