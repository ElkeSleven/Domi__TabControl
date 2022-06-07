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

//  Bekijk de Xaml
/*// TabControl
 * Tabbladen (zoals in webbrowsers).
 * Handig om veel info op 1 Window te krijgen en te verdelen.
 * Wisselen tussen tabbladen: Ctrl+Tab
 * Properties:
 *   - Items: bevat de tabbladen
 *   - TabStripPlacement: waar komen tabknoppen (Left, Right, Top, Bottom).
 * Methods:
 *   - Focus zetten op 1ste tabblad: tabMijnTabblad.SelectedIndex = 0; // index -1: geen tabblad
 * XAML van TabControl:
 *   - TabControl bestaat uit TabItems (tabbladen) met een Header (titel).
 *   - In elk TabItem kan je een Grid, DockPanel, StackPanel,... zetten.
 *   - HorizontalAlignment="Stretch" en VerticalAlignment="Stretch“
 *   - Tabblad zowel horizontaal als verticaal uitrekken bij resizen van Window
 *   - Binnen de Header kan je ook Images of andere controls zetten gebruik hiervoor een StackPanel
 */

/*// StatusBar
 * StatusBar = statusbalk ⇒ status weergeven van toepassing
 * Kan je onderverdelen in verschillende controls
 * Staat meestal onderaan Window
 * 
 */





namespace Domi__TabControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
