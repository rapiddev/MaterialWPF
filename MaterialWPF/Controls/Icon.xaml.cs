using System.Windows;
using System.Windows.Controls;

namespace MaterialWPF.Controls
{
    /// <summary>
    /// Interaction logic for Icon.xaml
    /// </summary>
    public partial class Icon : UserControl
    {
        public static readonly DependencyProperty GlyphProperty = DependencyProperty.Register("Glyph", typeof(UI.MaterialIcon), typeof(MaterialWPF.Controls.Icon));
        public static readonly DependencyProperty SizeProperty = DependencyProperty.Register("Size", typeof(double), typeof(MaterialWPF.Controls.Icon));

        public string RawGlyph
        {
            get
            {
                return UI.MiconIcons.ToGlyph((UI.MaterialIcon)(this.GetValue(GlyphProperty) as UI.MaterialIcon?));
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
                double? value = this.GetValue(SizeProperty) as double?;
                return value == null ? 13 : (double)value;
            }
            set
            {
                this.SetValue(SizeProperty, value);
            }
        }

        public Icon()
        {
            InitializeComponent();
        }
    }
}
