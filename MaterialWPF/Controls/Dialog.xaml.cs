using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaterialWPF.Controls
{
    /// <summary>
    /// Interaction logic for Dialog.xaml
    /// </summary>
    public partial class Dialog : UserControl
    {
        private bool _status = false;

        public static readonly DependencyProperty
            EnabledProperty = DependencyProperty.Register("Enabled", typeof(bool), typeof(Dialog), new PropertyMetadata(false));

        public bool? Enabled
        {
            get
            {
                return this.GetValue(EnabledProperty) as bool?;
            }
            set
            {
                this.SetValue(EnabledProperty, value);

                if (value == true)
                {
                    this.Visibility = Visibility.Visible;
                    this._status = true;
                }
                else
                {
                    this.Visibility = Visibility.Hidden;
                    this._status = false;
                }
            }
        }

        public Dialog()
        {
            InitializeComponent();

            if (Enabled == true)
            {
                this.Visibility = Visibility.Visible;
                this._status = true;
            }
            else
            {
                this.Visibility = Visibility.Hidden;
                this._status = false;
            }
        }

        public void Show()
        {
            if (this._status)
                return;

            DoubleAnimation db = new DoubleAnimation();
            db.EasingFunction = new CubicEase { EasingMode = EasingMode.EaseOut };
            db.To = 0;
            db.From = this.ActualHeight;
            db.Duration = TimeSpan.FromSeconds(0.5);

            this.Visibility = Visibility.Visible;
            //slideTransform.BeginAnimation(TranslateTransform.YProperty, db);

            this._status = true;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            this._status = false;
        }
    }
}
