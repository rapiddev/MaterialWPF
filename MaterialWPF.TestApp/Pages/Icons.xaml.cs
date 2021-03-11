using MaterialWPF.UI;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MaterialWPF.TestApp.Pages
{
    public struct DisplayableIcon
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Icon { get; set; }
    }
    /// <summary>
    /// Interaction logic for Icons.xaml
    /// </summary>
    public partial class Icons : Page
    {
        public Icons()
        {
            InitializeComponent();

            this.FillIcons();
        }

        private async void FillIcons()
        {
            DisplayableIcon[] icons;
            DataContext = this;

            await Task.Run(() =>
            {
                icons = new DisplayableIcon[]
                {
                    new DisplayableIcon() { Icon = MiconIcons.Accept, Name = "Accept", Code = "EA01" },
                    new DisplayableIcon() { Icon = MiconIcons.Accident, Name = "Accident", Code = "EA02" },
                    new DisplayableIcon() { Icon = MiconIcons.AccidentSolid, Name = "AccidentSolid", Code = "EA03" },
                    new DisplayableIcon() { Icon = MiconIcons.Accounts, Name = "Accounts", Code = "EA04" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenter, Name = "ActionCenter", Code = "EA05" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenterAsterisk, Name = "ActionCenterAsterisk", Code = "EA06" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenterMirrored, Name = "ActionCenterMirrored", Code = "EA07" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenterNotification, Name = "ActionCenterNotification", Code = "EA08" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenterNotificationMirrored, Name = "ActionCenterNotificationMirrored", Code = "EA09" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenterQuiet, Name = "ActionCenterQuiet", Code = "EA0A" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenterQuietNotification, Name = "ActionCenterQuietNotification", Code = "EA0B" },
                    new DisplayableIcon() { Icon = MiconIcons.Add, Name = "Add", Code = "EA0C" },
                    new DisplayableIcon() { Icon = MiconIcons.AddFriend, Name = "AddFriend", Code = "EA0D" },
                    new DisplayableIcon() { Icon = MiconIcons.AddRemoteDevice, Name = "AddRemoteDevice", Code = "EA0E" },
                    new DisplayableIcon() { Icon = MiconIcons.AddSurfaceHub, Name = "AddSurfaceHub", Code = "EA0F" },
                    new DisplayableIcon() { Icon = MiconIcons.AddTo, Name = "AddTo", Code = "EA10" },
                    new DisplayableIcon() { Icon = MiconIcons.AdjustHologram, Name = "AdjustHologram", Code = "EA11" },
                    new DisplayableIcon() { Icon = MiconIcons.Admin, Name = "Admin", Code = "EA12" },
                    new DisplayableIcon() { Icon = MiconIcons.Airplane, Name = "Airplane", Code = "EA13" },
                    new DisplayableIcon() { Icon = MiconIcons.AirplaneSolid, Name = "AirplaneSolid", Code = "EA14" },
                    new DisplayableIcon() { Icon = MiconIcons.AlignCenter, Name = "AlignCenter", Code = "EA15" },
                    new DisplayableIcon() { Icon = MiconIcons.AlignLeft, Name = "AlignLeft", Code = "EA16" },
                    new DisplayableIcon() { Icon = MiconIcons.AlignRight, Name = "AlignRight", Code = "EA17" },
                    new DisplayableIcon() { Icon = MiconIcons.AllApps, Name = "AllApps", Code = "EA18" },
                    new DisplayableIcon() { Icon = MiconIcons.AllAppsMirrored, Name = "AllAppsMirrored", Code = "EA19" },
                    new DisplayableIcon() { Icon = MiconIcons.Annotation, Name = "Annotation", Code = "EA1A" },
                    new DisplayableIcon() { Icon = MiconIcons.AppIconDefault, Name = "AppIconDefault", Code = "EA1B" },
                    new DisplayableIcon() { Icon = MiconIcons.Apps, Name = "Apps", Code = "EA1C" },
                    new DisplayableIcon() { Icon = MiconIcons.AreaChart, Name = "AreaChart", Code = "EA1D" },
                    new DisplayableIcon() { Icon = MiconIcons.ArrowDown8, Name = "ArrowDown8", Code = "EA1E" },
                    new DisplayableIcon() { Icon = MiconIcons.ArrowLeft8, Name = "ArrowLeft8", Code = "EA1F" },
                    new DisplayableIcon() { Icon = MiconIcons.ArrowRight8, Name = "ArrowRight8", Code = "EA20" },
                    new DisplayableIcon() { Icon = MiconIcons.ArrowUp8, Name = "ArrowUp8", Code = "EA21" },
                    new DisplayableIcon() { Icon = MiconIcons.AspectRatio, Name = "AspectRatio", Code = "EA22" },
                    new DisplayableIcon() { Icon = MiconIcons.Asterisk, Name = "Asterisk", Code = "EA23" },
                    new DisplayableIcon() { Icon = MiconIcons.AsteriskBadge12, Name = "AsteriskBadge12", Code = "EA24" },
                    new DisplayableIcon() { Icon = MiconIcons.Attach, Name = "Attach", Code = "EA25" },
                    new DisplayableIcon() { Icon = MiconIcons.AttachCamera, Name = "AttachCamera", Code = "EA26" },
                    new DisplayableIcon() { Icon = MiconIcons.Audio, Name = "Audio", Code = "EA27" },
                    new DisplayableIcon() { Icon = MiconIcons.Back, Name = "Back", Code = "EA28" },
                    new DisplayableIcon() { Icon = MiconIcons.BackMirrored, Name = "BackMirrored", Code = "EA29" },
                    new DisplayableIcon() { Icon = MiconIcons.BackSpaceQWERTYLg, Name = "BackSpaceQWERTYLg", Code = "EA2B" },
                    new DisplayableIcon() { Icon = MiconIcons.BackSpaceQWERTYMd, Name = "BackSpaceQWERTYMd", Code = "EA2C" },
                    new DisplayableIcon() { Icon = MiconIcons.BackSpaceQWERTYSm, Name = "BackSpaceQWERTYSm", Code = "EA2D" },
                    new DisplayableIcon() { Icon = MiconIcons.BackToWindow, Name = "BackToWindow", Code = "EA2E" },
                    new DisplayableIcon() { Icon = MiconIcons.BackgroundToggle, Name = "BackgroundToggle", Code = "EA2F" },
                    new DisplayableIcon() { Icon = MiconIcons.Badge, Name = "Badge", Code = "EA30" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery0, Name = "BandBattery0", Code = "EA31" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery1, Name = "BandBattery1", Code = "EA32" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery2, Name = "BandBattery2", Code = "EA33" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery3, Name = "BandBattery3", Code = "EA34" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery4, Name = "BandBattery4", Code = "EA35" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery5, Name = "BandBattery5", Code = "EA36" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery6, Name = "BandBattery6", Code = "EA37" },
                    new DisplayableIcon() { Icon = MiconIcons.Bank, Name = "Bank", Code = "EA38" },
                    new DisplayableIcon() { Icon = MiconIcons.BarcodeScanner, Name = "BarcodeScanner", Code = "EA39" },
                    new DisplayableIcon() { Icon = MiconIcons.Accept, Name = "Accept", Code = "EA01" },
                    new DisplayableIcon() { Icon = MiconIcons.Accident, Name = "Accident", Code = "EA02" },
                    new DisplayableIcon() { Icon = MiconIcons.AccidentSolid, Name = "AccidentSolid", Code = "EA03" },
                    new DisplayableIcon() { Icon = MiconIcons.Accounts, Name = "Accounts", Code = "EA04" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenter, Name = "ActionCenter", Code = "EA05" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenterAsterisk, Name = "ActionCenterAsterisk", Code = "EA06" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenterMirrored, Name = "ActionCenterMirrored", Code = "EA07" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenterNotification, Name = "ActionCenterNotification", Code = "EA08" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenterNotificationMirrored, Name = "ActionCenterNotificationMirrored", Code = "EA09" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenterQuiet, Name = "ActionCenterQuiet", Code = "EA0A" },
                    new DisplayableIcon() { Icon = MiconIcons.ActionCenterQuietNotification, Name = "ActionCenterQuietNotification", Code = "EA0B" },
                    new DisplayableIcon() { Icon = MiconIcons.Add, Name = "Add", Code = "EA0C" },
                    new DisplayableIcon() { Icon = MiconIcons.AddFriend, Name = "AddFriend", Code = "EA0D" },
                    new DisplayableIcon() { Icon = MiconIcons.AddRemoteDevice, Name = "AddRemoteDevice", Code = "EA0E" },
                    new DisplayableIcon() { Icon = MiconIcons.AddSurfaceHub, Name = "AddSurfaceHub", Code = "EA0F" },
                    new DisplayableIcon() { Icon = MiconIcons.AddTo, Name = "AddTo", Code = "EA10" },
                    new DisplayableIcon() { Icon = MiconIcons.AdjustHologram, Name = "AdjustHologram", Code = "EA11" },
                    new DisplayableIcon() { Icon = MiconIcons.Admin, Name = "Admin", Code = "EA12" },
                    new DisplayableIcon() { Icon = MiconIcons.Airplane, Name = "Airplane", Code = "EA13" },
                    new DisplayableIcon() { Icon = MiconIcons.AirplaneSolid, Name = "AirplaneSolid", Code = "EA14" },
                    new DisplayableIcon() { Icon = MiconIcons.AlignCenter, Name = "AlignCenter", Code = "EA15" },
                    new DisplayableIcon() { Icon = MiconIcons.AlignLeft, Name = "AlignLeft", Code = "EA16" },
                    new DisplayableIcon() { Icon = MiconIcons.AlignRight, Name = "AlignRight", Code = "EA17" },
                    new DisplayableIcon() { Icon = MiconIcons.AllApps, Name = "AllApps", Code = "EA18" },
                    new DisplayableIcon() { Icon = MiconIcons.AllAppsMirrored, Name = "AllAppsMirrored", Code = "EA19" },
                    new DisplayableIcon() { Icon = MiconIcons.Annotation, Name = "Annotation", Code = "EA1A" },
                    new DisplayableIcon() { Icon = MiconIcons.AppIconDefault, Name = "AppIconDefault", Code = "EA1B" },
                    new DisplayableIcon() { Icon = MiconIcons.Apps, Name = "Apps", Code = "EA1C" },
                    new DisplayableIcon() { Icon = MiconIcons.AreaChart, Name = "AreaChart", Code = "EA1D" },
                    new DisplayableIcon() { Icon = MiconIcons.ArrowDown8, Name = "ArrowDown8", Code = "EA1E" },
                    new DisplayableIcon() { Icon = MiconIcons.ArrowLeft8, Name = "ArrowLeft8", Code = "EA1F" },
                    new DisplayableIcon() { Icon = MiconIcons.ArrowRight8, Name = "ArrowRight8", Code = "EA20" },
                    new DisplayableIcon() { Icon = MiconIcons.ArrowUp8, Name = "ArrowUp8", Code = "EA21" },
                    new DisplayableIcon() { Icon = MiconIcons.AspectRatio, Name = "AspectRatio", Code = "EA22" },
                    new DisplayableIcon() { Icon = MiconIcons.Asterisk, Name = "Asterisk", Code = "EA23" },
                    new DisplayableIcon() { Icon = MiconIcons.AsteriskBadge12, Name = "AsteriskBadge12", Code = "EA24" },
                    new DisplayableIcon() { Icon = MiconIcons.Attach, Name = "Attach", Code = "EA25" },
                    new DisplayableIcon() { Icon = MiconIcons.AttachCamera, Name = "AttachCamera", Code = "EA26" },
                    new DisplayableIcon() { Icon = MiconIcons.Audio, Name = "Audio", Code = "EA27" },
                    new DisplayableIcon() { Icon = MiconIcons.Back, Name = "Back", Code = "EA28" },
                    new DisplayableIcon() { Icon = MiconIcons.BackMirrored, Name = "BackMirrored", Code = "EA29" },
                    new DisplayableIcon() { Icon = MiconIcons.BackSpaceQWERTYLg, Name = "BackSpaceQWERTYLg", Code = "EA2B" },
                    new DisplayableIcon() { Icon = MiconIcons.BackSpaceQWERTYMd, Name = "BackSpaceQWERTYMd", Code = "EA2C" },
                    new DisplayableIcon() { Icon = MiconIcons.BackSpaceQWERTYSm, Name = "BackSpaceQWERTYSm", Code = "EA2D" },
                    new DisplayableIcon() { Icon = MiconIcons.BackToWindow, Name = "BackToWindow", Code = "EA2E" },
                    new DisplayableIcon() { Icon = MiconIcons.BackgroundToggle, Name = "BackgroundToggle", Code = "EA2F" },
                    new DisplayableIcon() { Icon = MiconIcons.Badge, Name = "Badge", Code = "EA30" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery0, Name = "BandBattery0", Code = "EA31" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery1, Name = "BandBattery1", Code = "EA32" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery2, Name = "BandBattery2", Code = "EA33" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery3, Name = "BandBattery3", Code = "EA34" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery4, Name = "BandBattery4", Code = "EA35" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery5, Name = "BandBattery5", Code = "EA36" },
                    new DisplayableIcon() { Icon = MiconIcons.BandBattery6, Name = "BandBattery6", Code = "EA37" },
                    new DisplayableIcon() { Icon = MiconIcons.Bank, Name = "Bank", Code = "EA38" },
                    new DisplayableIcon() { Icon = MiconIcons.BarcodeScanner, Name = "BarcodeScann", Code = "EA39" }
                };

                App.Current.Dispatcher.Invoke(() =>
                {
                    iconsList.ItemsSource = icons;
                });

                Thread.Sleep(1000);

                App.Current.Dispatcher.Invoke(() =>
                {
                    gridLoading.Visibility = Visibility.Hidden;
                });
            });
        }
    }
}
