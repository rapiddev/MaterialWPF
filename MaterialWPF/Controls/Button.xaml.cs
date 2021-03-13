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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaterialWPF.Controls
{
    /// <summary>
    /// Interaction logic for Button.xaml
    /// </summary>
    public partial class Button : UserControl
    {
        public static readonly DependencyProperty
            GlyphProperty = DependencyProperty.Register("Glyph", typeof(UI.MaterialIcon), typeof(MaterialWPF.Controls.Button), new PropertyMetadata(UI.MaterialIcon.Accept)),
            SizeProperty = DependencyProperty.Register("Size", typeof(double), typeof(MaterialWPF.Controls.Button), new PropertyMetadata((double)13)),
            TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(MaterialWPF.Controls.Button), new PropertyMetadata(string.Empty));

        public System.Windows.Controls.Button Control => rootButton;

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

        public string Text
        {
            get
            {
                return this.GetValue(TextProperty) as string;
            }
            set
            {
                this.SetValue(TextProperty, value);
            }
        }

        public Button()
        {
            InitializeComponent();
        }
    }
}
