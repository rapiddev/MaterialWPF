using System;
using System.ComponentModel;

namespace MaterialWPF.UI
{
    public class NavItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Object Instance { get; set; }
        public Type Type { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public string Icon { get; set; }

        private bool _isActive = false;

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
