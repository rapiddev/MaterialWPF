// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

namespace MaterialWPF.UI
{
    /// <summary>
    /// List of all available icons
    /// <para>May be converted to <see langword="char"/> using <see cref="MiconIcons.ToGlyph(MaterialIcon?)"/> or to <see langword="string"/> using <see cref="MiconIcons.ToString(MaterialIcon?)"/></para>
    /// </summary>
    public enum MaterialIcon
    {
        Accept,
        Accident,
        AccidentSolid,
        Accounts,
        ActionCenter,
        ActionCenterAsterisk,
        ActionCenterMirrored,
        ActionCenterNotification,
        ActionCenterNotificationMirrored,
        ActionCenterQuiet,
        ActionCenterQuietNotification,
        Add,
        AddFriend,
        AddRemoteDevice,
        AddSurfaceHub,
        AddTo,
        AdjustHologram,
        Admin,
        Airplane,
        AirplaneSolid,
        AlignCenter,
        AlignLeft,
        AlignRight,
        AllApps,
        AllAppsMirrored,
        Annotation,
        AppIconDefault,
        Apps,
        AreaChart,
        ArrowDown8,
        ArrowLeft8,
        ArrowRight8,
        ArrowUp8,
        AspectRatio,
        Asterisk,
        AsteriskBadge12,
        Attach,
        AttachCamera,
        Audio,
        Back,
        BackMirrored,
        BackSpaceQWERTYLg,
        BackSpaceQWERTYMd,
        BackSpaceQWERTYSm,
        BackToWindow,
        BackgroundToggle,
        Badge,
        BandBattery0,
        BandBattery1,
        BandBattery2,
        BandBattery3,
        BandBattery4,
        BandBattery5,
        BandBattery6,
        Bank,
        BarcodeScanner,
        Calories,
        GridView
    }

    public static class MiconIcons
    {
        public static readonly char
            Accept = '\uEA01',
            Accident = '\uEA02',
            AccidentSolid = '\uEA03',
            Accounts = '\uEA04',
            ActionCenter = '\uEA05',
            ActionCenterAsterisk = '\uEA06',
            ActionCenterMirrored = '\uEA07',
            ActionCenterNotification = '\uEA08',

            ActionCenterNotificationMirrored = '\uEA09',
            ActionCenterQuiet = '\uEA0A',
            ActionCenterQuietNotification = '\uEA0B',
            Add = '\uEA0C',
            AddFriend = '\uEA0D',
            AddRemoteDevice = '\uEA0E',
            AddSurfaceHub = '\uEA0F',
            AddTo = '\uEA10',

            AdjustHologram = '\uEA11',
            Admin = '\uEA12',
            Airplane = '\uEA13',
            AirplaneSolid = '\uEA14',
            AlignCenter = '\uEA15',
            AlignLeft = '\uEA16',
            AlignRight = '\uEA17',
            AllApps = '\uEA18',
            
            AllAppsMirrored = '\uEA19',
            Annotation = '\uEA1A',
            AppIconDefault = '\uEA1B',
            Apps = '\uEA1C',
            AreaChart = '\uEA1D',
            ArrowDown8 = '\uEA1E',
            ArrowLeft8 = '\uEA1F',
            ArrowRight8 = '\uEA20',
            
            ArrowUp8 = '\uEA21',
            AspectRatio = '\uEA22',
            Asterisk = '\uEA23',
            AsteriskBadge12 = '\uEA24',
            Attach = '\uEA25',
            AttachCamera = '\uEA26',
            Audio = '\uEA27',
            Back = '\uEA28',
            
            BackMirrored = '\uEA29',
            BackSpaceQWERTYLg = '\uEA2B',
            BackSpaceQWERTYMd = '\uEA2C',
            BackSpaceQWERTYSm = '\uEA2D',
            BackToWindow = '\uEA2E',
            BackgroundToggle = '\uEA2F',
            Badge = '\uEA30',
            BandBattery0 = '\uEA31',
            
            BandBattery1 = '\uEA32',
            BandBattery2 = '\uEA33',
            BandBattery3 = '\uEA34',
            BandBattery4 = '\uEA35',
            BandBattery5 = '\uEA36',
            BandBattery6 = '\uEA37',
            Bank = '\uEA38',
            BarcodeScanner = '\uEA39',

            Calories = '\uEAA3',

            GridView = '\uEBDE';

        /// <summary>
        /// Converts <see cref="MaterialIcon"/> to <see langword="char"/> based on the ID, if <see langword="null"/> or error, returns <see cref="MiconIcons.Accept"/>
        /// </summary>
        public static char ToGlyph(UI.MaterialIcon? icon)
        {
            if (icon == null)
                return MiconIcons.Accept;

            char? character = typeof(MiconIcons).GetField(icon.ToString()).GetValue(null) as char?;

            if (character == null)
                return MiconIcons.Accept;
            else
                return (char)character;
        }

        /// <summary>
        /// Converts <see cref="MaterialIcon"/> to <see langword="string"/> based on the ID, if <see langword="null"/> or error, returns <see cref="MiconIcons.Accept"/>
        /// </summary>
        public static string ToString(UI.MaterialIcon? icon)
        {
            return MiconIcons.ToGlyph(icon).ToString();
        }
    }
}
