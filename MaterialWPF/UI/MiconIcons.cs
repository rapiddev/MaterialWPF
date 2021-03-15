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

        Battery0,
        Battery1,
        Battery10,
        Battery2,
        Battery3,
        Battery4,
        Battery5,
        Battery6,

        Battery7,
        Battery8,
        Battery9,
        BatteryCharging0,
        BatteryCharging1,
        BatteryCharging10,
        BatteryCharging2,
        BatteryCharging3,

        BatteryCharging4,
        BatteryCharging5,
        BatteryCharging6,
        BatteryCharging7,
        BatteryCharging8,
        BatteryCharging9,
        BatterySaver0,
        BatterySaver1,

        BatterySaver10,
        BatterySaver2,
        BatterySaver3,
        BatterySaver4,
        BatterySaver5,
        BatterySaver6,
        BatterySaver7,
        BatterySaver8,

        BatterySaver9,
        BatteryUnknown,
        Beta,
        BidiLtr,
        BidiRtl,
        BlockContact,
        Blocked,
        BlueLight,

        Bluetooth,
        BodyCam,
        Bold,
        BoldF,
        BoldG,
        BoldKorean,
        BoldN,
        BoldRussion,

        Bookmarks,
        BookmarksMirrored,
        Brightness,
        Broom,
        BrowsePhotos,
        BrushSize,
        Bug,
        BuildingEnergy,

        BulletedList,
        BulletedListMirrored,
        Bullseye,
        BumperLeft,
        BumperRight,
        Bus,
        BusSolid,
        ButtonA,

        ButtonB,
        ButtonMenu,
        ButtonView2,
        ButtonX,
        ButtonY,
        CC,
        CCEuro,
        CCJapan,

        Cafe,
        Calculator,
        CalculatorAddition,
        CalculatorBackspace,
        CalculatorDivide,
        CalculatorEqualTo,
        CalculatorMultiply,
        CalculatorNegate,

        CalculatorPercentage,
        CalculatorSquareroot,
        CalculatorSubtract,
        Calendar,
        CalendarDay,
        CalendarMirrored,
        CalendarReply,
        CalendarSolid,

        CalendarWeek,
        CallForwardInternational,
        CallForwardInternationalMirrored,
        CallForwardRoaming,
        CallForwardRoamingMirrored,
        CallForwarding,
        CallForwardingMirrored,
        CalligraphyFill,

        CalligraphyPen,
        Calories,
        Camera,
        Cancel,
        Caption,
        Car,
        CaretBottomRightSolidCenter8,
        CaretDownSolid8,

        CaretLeftSolid8,
        CaretRight8,
        CaretRightSolid8,
        CaretUpSolid8,
        CashDrawer,
        CellPhone,
        Certificate,
        CharacterAppearance,

        Characters,
        ChatBubbles,
        CheckList,
        CheckMark,
        Checkbox,
        Checkbox14,
        CheckboxComposite,
        CheckboxComposite14,

        Color,
        GridView,

        Input
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

            Battery0 = '\uEA3A',
            Battery1 = '\uEA3B',
            Battery10 = '\uEA3C',
            Battery2 = '\uEA3D',
            Battery3 = '\uEA3E',
            Battery4 = '\uEA3F',
            Battery5 = '\uEA40',
            Battery6 = '\uEA41',

            Battery7 = '\uEA42',
            Battery8 = '\uEA43',
            Battery9 = '\uEA44',
            BatteryCharging0 = '\uEA45',
            BatteryCharging1 = '\uEA46',
            BatteryCharging10 = '\uEA47',
            BatteryCharging2 = '\uEA48',
            BatteryCharging3 = '\uEA49',

            BatteryCharging4 = '\uEA4A',
            BatteryCharging5 = '\uEA4B',
            BatteryCharging6 = '\uEA4C',
            BatteryCharging7 = '\uEA4D',
            BatteryCharging8 = '\uEA4E',
            BatteryCharging9 = '\uEA4F',
            BatterySaver0 = '\uEA50',
            BatterySaver1 = '\uEA51',

            BatterySaver10 = '\uEA52',
            BatterySaver2 = '\uEA53',
            BatterySaver3 = '\uEA54',
            BatterySaver4 = '\uEA55',
            BatterySaver5 = '\uEA56',
            BatterySaver6 = '\uEA57',
            BatterySaver7 = '\uEA58',
            BatterySaver8 = '\uEA59',

            BatterySaver9 = '\uEA5A',
            BatteryUnknown = '\uEA5B',
            Beta = '\uEA5C',
            BidiLtr = '\uEA5D',
            BidiRtl = '\uEA5E',
            BlockContact = '\uEA5F',
            Blocked = '\uEA61',
            BlueLight = '\uEA62',

            Bluetooth = '\uEA63',
            BodyCam = '\uEA64',
            Bold = '\uEA65',
            BoldF = '\uEA67',
            BoldG = '\uEA69',
            BoldKorean = '\uEA6B',
            //BoldNN = '\uEA6C',
            BoldN = '\uEA6D',
            BoldRussion = '\uEA6F',

            Bookmarks = '\uEA70',
            BookmarksMirrored = '\uEA71',
            Brightness = '\uEA72',
            Broom = '\uEA73',
            BrowsePhotos = '\uEA74',
            BrushSize = '\uEA75',
            Bug = '\uEA76',
            BuildingEnergy = '\uEA77',

            BulletedList = '\uEA78',
            BulletedListMirrored = '\uEA79',
            Bullseye = '\uEA7A',
            BumperLeft = '\uEA7B',
            BumperRight = '\uEA7C',
            Bus = '\uEA7D',
            BusSolid = '\uEA7E',
            ButtonA = '\uEA7F',

            ButtonB = '\uEA80',
            ButtonMenu = '\uEA81',
            ButtonView2 = '\uEA82',
            ButtonX = '\uEA83',
            ButtonY = '\uEA84',
            CC = '\uEA85',
            CCEuro = '\uEA87',
            CCJapan = '\uEA89',

            Cafe = '\uEA8A',
            Calculator = '\uEA8B',
            CalculatorAddition = '\uEA8C',
            CalculatorBackspace = '\uEA8D',
            CalculatorDivide = '\uEA8E',
            CalculatorEqualTo = '\uEA8F',
            CalculatorMultiply = '\uEA90',
            CalculatorNegate = '\uEA91',

            CalculatorPercentage = '\uEA92',
            CalculatorSquareroot = '\uEA93',
            CalculatorSubtract = '\uEA94',
            Calendar = '\uEA95',
            CalendarDay = '\uEA96',
            CalendarMirrored = '\uEA97',
            CalendarReply = '\uEA98',
            CalendarSolid = '\uEA99',

            CalendarWeek = '\uEA9A',
            CallForwardInternational = '\uEA9B',
            CallForwardInternationalMirrored = '\uEA9C',
            CallForwardRoaming = '\uEA9D',
            CallForwardRoamingMirrored = '\uEA9E',
            CallForwarding = '\uEA9F',
            CallForwardingMirrored = '\uEAA0',
            CalligraphyFill = '\uEAA1',

            CalligraphyPen = '\uEAA2',
            Calories = '\uEAA3',
            Camera = '\uEAA4',
            Cancel = '\uEAA5',
            Caption = '\uEAA6',
            Car = '\uEAA7',
            CaretBottomRightSolidCenter8 = '\uEAA8',
            CaretDownSolid8 = '\uEAA9',

            CaretLeftSolid8 = '\uEAAA',
            CaretRight8 = '\uEAAB',
            CaretRightSolid8 = '\uEAAC',
            CaretUpSolid8 = '\uEAAD',
            CashDrawer = '\uEAAE',
            CellPhone = '\uEAAF',
            Certificate = '\uEAB0',
            CharacterAppearance = '\uEAB1',

            Characters = '\uEAB2',
            ChatBubbles = '\uEAB3',
            CheckList = '\uEAB4',
            CheckMark = '\uEAB5',
            Checkbox = '\uEAB6',
            Checkbox14 = '\uEAB7',
            CheckboxComposite = '\uEAB8',
            CheckboxComposite14 = '\uEAB9',

            Color = '\uEB03',

            GridView = '\uEBDE',

            Input = '\uEC31';

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
