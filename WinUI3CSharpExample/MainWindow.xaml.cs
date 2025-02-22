using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using WinUI3CSharpExample.Pages;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.
namespace WinUI3CSharpExample
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public ObservableCollection<string> Pages { get; } = new();

        private Dictionary<string, Type> _pages = new()
        {
            { "ToastPage", typeof(ToastPage) },
            // { "CursorControllerPage", typeof(CursorControllerPage) },
            // { "ConvertersPage", typeof(ConvertersPage) },
            // { "BadgePage", typeof(BadgePage) },
            // { "TriggersPage", typeof(TriggersPage) },
            // { "GroupBoxPage", typeof(GroupBoxPage) },
            // { "CharmBarPage", typeof(CharmBarPage) },
            // { "SettingsCardPage", typeof(SettingsCardPage) },
            // { "SettingsExpanderPage", typeof(SettingsExpanderPage) },
            // { "DependentValuePage", typeof(DependentValuePage) },
            // { "MarqueeContainerPage", typeof(MarqueeContainerPage) },
            // { "GlyphsPage", typeof(GlyphsPage) },
            // { "TilesPage", typeof(TilesPage) },
            // { "IconButtonPage", typeof(IconButtonPage) },
            // { "ProgressBarExPage", typeof(ProgressBarExPage) },
            // { "UIElementExtensionPage", typeof(UIElementExtensionsPage) },
            // { "SegmentedPage", typeof(SegmentedPage) },
            // { "UriPage", typeof(UriPage) },
            // { "ShimmerPage", typeof(ShimmerPage) },
            // { "ImageExtensionPage", typeof(ImageExtensionPage) },
            // { "SwitchPresenterPage", typeof(SwitchPresenterPage) }
        };

        public MainWindow()
        {
            this.InitializeComponent();
            foreach (var pagesKey in _pages.Keys ) Pages.Add(pagesKey);

        }


        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (sender.SelectedItem is string t) ContentFrame.Navigate(_pages[t]);
        }
    }
}
