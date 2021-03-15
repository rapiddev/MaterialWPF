// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

namespace MaterialWPF.UI
{
    public class MiconBrands
    {
        public static readonly char
            _500px = '\uEF66',
            Microsoft = '\uF04F';

        /// <summary>
        /// Converts <see cref="MaterialBrand"/> to <see langword="char"/> based on the ID, if <see langword="null"/> or error, returns <see cref="MiconBrands.Microsoft"/>
        /// </summary>
        public static char ToGlyph(UI.MaterialBrand? brand)
        {
            if (brand == null)
                return MiconBrands.Microsoft;

            char? character = typeof(MiconIcons).GetField(brand.ToString()).GetValue(null) as char?;

            if (character == null)
                return MiconBrands.Microsoft;
            else
                return (char)character;
        }

        /// <summary>
        /// Converts <see cref="MaterialBrand"/> to <see langword="string"/> based on the ID, if <see langword="null"/> or error, returns <see cref="MiconBrands.Microsoft"/>
        /// </summary>
        public static string ToString(UI.MaterialBrand? brand)
        {
            return MiconBrands.ToGlyph(brand).ToString();
        }
    }
}
