using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MaterialWPF.TestApp.Pages
{
    public struct ColorDisplayable
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public SolidColorBrush Color { get { return (SolidColorBrush)Application.Current.Resources[ID]; } }

    }
    /// <summary>
    /// Interaction logic for Colors.xaml
    /// </summary>
    public partial class Colors : Page
    {
        public List<ColorDisplayable> ThemeColors = new List<ColorDisplayable>();
        public List<ColorDisplayable> PaletteColors = new List<ColorDisplayable>();
        public Colors()
        {
            InitializeComponent();
            this.FillColors();

            listTheme.ItemsSource = ThemeColors;
            listPalette.ItemsSource = PaletteColors;
        }

        private void FillColors()
        {
            ThemeColors = new List<ColorDisplayable>
            {
                new ColorDisplayable { Name = "Accent", ID = "ThemeAccent"},
                new ColorDisplayable { Name = "Hyperlink", ID = "ThemeHyperlink" },
                new ColorDisplayable { Name = "Background", ID = "ThemeBackground"},
                new ColorDisplayable { Name = "Background Transparent", ID = "ThemeBackgroundTransparent"},
                new ColorDisplayable { Name = "Splash", ID = "ThemeSplash"},
                new ColorDisplayable { Name = "Foreground", ID = "ThemeForeground"},
                new ColorDisplayable { Name = "Foreground Secondary", ID = "ThemeForegroundSecondary"},
                new ColorDisplayable { Name = "Interactive", ID = "ThemeInteractive"},
                new ColorDisplayable { Name = "Interactive Border", ID = "ThemeInteractiveBorder"},
                new ColorDisplayable { Name = "Interactive Disabled", ID = "ThemeInteractiveDisabled"},
                new ColorDisplayable { Name = "Interactive Hover", ID = "ThemeInteractiveHover"},
                new ColorDisplayable { Name = "Interactive Selected", ID = "ThemeInteractiveSelected"},
                new ColorDisplayable { Name = "Element", ID = "ThemeElement"},
                new ColorDisplayable { Name = "Element Border", ID = "ThemeElementBorder"},
                new ColorDisplayable { Name = "Element Hover", ID = "ThemeElementHover"},
                new ColorDisplayable { Name = "Element Selected", ID = "ThemeElementSelected"},
                new ColorDisplayable { Name = "Placeholder", ID = "ThemePlaceholder"},
                new ColorDisplayable { Name = "Navigation", ID = "ThemeNavigation"},
                new ColorDisplayable { Name = "Navigation Button", ID = "ThemeNavigationButton"},
                new ColorDisplayable { Name = "Navigation Hover", ID = "ThemeNavigationHover"},
            };

            PaletteColors = new List<ColorDisplayable>
            {
                new ColorDisplayable { Name = "Palette Primary", ID = "PalettePrimary"},
                new ColorDisplayable { Name = "Palette Red", ID = "PaletteRed" },
                new ColorDisplayable { Name = "Palette Pink", ID = "PalettePink"},
                new ColorDisplayable { Name = "Palette Purple", ID = "PalettePurple"},
                new ColorDisplayable { Name = "Palette Deep Purple", ID = "PaletteDeepPurple"},
                new ColorDisplayable { Name = "Palette Indigo", ID = "PaletteIndigo"},
                new ColorDisplayable { Name = "Palette Blue", ID = "PaletteBlue"},
                new ColorDisplayable { Name = "Palette Light Blue", ID = "PaletteLightBlue"},
                new ColorDisplayable { Name = "Palette Cyan", ID = "PaletteCyan"},
                new ColorDisplayable { Name = "Palette Teal", ID = "PaletteTeal"},
                new ColorDisplayable { Name = "Palette Green", ID = "PaletteGreen"},
                new ColorDisplayable { Name = "Palette Light Green", ID = "PaletteLightGreen"},
                new ColorDisplayable { Name = "Palette Lime", ID = "PaletteLime"},
                new ColorDisplayable { Name = "Palette Yellow", ID = "PaletteYellow"},
                new ColorDisplayable { Name = "Palette Amber", ID = "PaletteAmber"},
                new ColorDisplayable { Name = "Palette Orange", ID = "PaletteOrange"},
                new ColorDisplayable { Name = "Palette Deep Orange", ID = "PaletteDeepOrange"},
                new ColorDisplayable { Name = "Palette Brown", ID = "PaletteBrown"},
                new ColorDisplayable { Name = "Palette Grey", ID = "PaletteGrey"},
                new ColorDisplayable { Name = "Palette Blue Grey", ID = "PaletteBlueGrey"},
            };
        }
    }
}
