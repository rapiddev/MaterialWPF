using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;
using System.Reflection;

namespace MaterialWPF.UI
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>")]
    public class Toast
    {
        private string
            _header = string.Empty,
            _message = string.Empty,
            _footer = string.Empty,
            _imagePath = string.Empty,
            _assemblyTitle = string.Empty,
            _xmlTemplate = string.Empty;

        public string Header
        {
            get => this._header;
            set => this._header = value;
        }

        public string Message
        {
            get => this._message;
            set => this._message = value;
        }

        public string Footer
        {
            get => this._footer;
            set => this._footer = value;
        }

        public string Image
        {
            get => this._imagePath;
            set => this._imagePath = value;
        }

        public void Send()
        {
            this.SetAppTitle();
            this.BuildToastTemplate();
            
            XmlDocument toastXmlDocument = new XmlDocument();
            toastXmlDocument.LoadXml(this._xmlTemplate);

            ToastNotification toast = new ToastNotification(toastXmlDocument);
            ToastNotificationManager.CreateToastNotifier(this._assemblyTitle).Show(toast);
        }

        public void SetAppTitle(string title = null)
        {
            if (string.IsNullOrEmpty(title))
                this._assemblyTitle = Assembly.GetEntryAssembly().GetName().Name;
            else
                this._assemblyTitle = title;
        }

        private void BuildToastTemplate()
        {
            //Base start
            this._xmlTemplate = "<toast><visual>";

            //Template start
            this._xmlTemplate += "<binding template=\"ToastText02\">";
            
            if (!string.IsNullOrEmpty(this._header))
                this._xmlTemplate += "<text id =\"1\">" + this._header + "</text>";
            if(!string.IsNullOrEmpty(this._message))
                this._xmlTemplate += "<text id=\"2\">" + this._message + "</text>";
            if (!string.IsNullOrEmpty(this._footer))
                this._xmlTemplate += "<text placement=\"attribution\">" + this._footer + "</text>";

            //this._xmlTemplate += "<group><subgroup><text hint-style=\"base\">52 attendees</text><text hint-style=\"captionSubtle\">23 minute drive</text></subgroup><subgroup><text hint-style=\"captionSubtle\" hint-align=\"right\">1 Microsoft Way</text><text hint-style=\"captionSubtle\" hint-align=\"right\">Bellevue, WA 98008</text></subgroup></group>";
            //this._xmlTemplate += "<progress title=\"Weekly playlist\" value=\"0.6\" valueStringOverride=\"15/26 songs\" status=\"Downloading...\"/>";
            //this._xmlTemplate += "<image placement=\"hero\" hint-crop=\"circle\" src=\"https://picsum.photos/48?image=883\"/>";

            //Template end
            this._xmlTemplate += "</binding>";
            this._xmlTemplate += "<actions></actions>";

            //Sound
            //this._xmlTemplate += "<audio src=\"ms-winsoundevent:Notification.Reminder\"/>";

            //Base end
            this._xmlTemplate += "</visual></toast>";
        }
    }
}
