using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;
using System.IO;
using System.Windows;
using System.Reflection;

namespace MaterialWPF.UI
{
    public class Toast
    {
        private string
            _header = string.Empty,
            _message = string.Empty,
            _assemblyTitle = string.Empty;

        private XmlDocument _toastNotificationTemplate;
        private ToastTemplateType _templateType = ToastTemplateType.ToastText02;

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

        public ToastTemplateType Type
        {
            get => this._templateType;
            set => this._templateType = value;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>")]
        public void Send()
        {
            this.SetAppTitle();
            this.BuildToastTemplate();
            /*
            String imagePath = "file:///" + Path.GetFullPath("toastImageAndText.png");
            XmlNodeList imageElements = toastXml.GetElementsByTagName("image");
            imageElements[0].Attributes.GetNamedItem("src").NodeValue = imagePath;
            */

            ToastNotification toast = new ToastNotification(this._toastNotificationTemplate);
            ToastNotificationManager.CreateToastNotifier(this._assemblyTitle).Show(toast);
        }

        public void SetAppTitle(string title = null)
        {
            if (string.IsNullOrEmpty(title))
                this._assemblyTitle = Assembly.GetEntryAssembly().GetName().Name;
            else
                this._assemblyTitle = title;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "<Pending>")]
        private void BuildToastTemplate()
        {
            this._toastNotificationTemplate = ToastNotificationManager.GetTemplateContent(this._templateType);
            XmlNodeList stringElements = this._toastNotificationTemplate.GetElementsByTagName("text");

            if (stringElements.Length > 0)
                stringElements[0].AppendChild(this._toastNotificationTemplate.CreateTextNode(this._header));

            if (stringElements.Length > 1)
                stringElements[1].AppendChild(this._toastNotificationTemplate.CreateTextNode(this._message));
        }
    }
}
