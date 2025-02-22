using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3CSharpExample.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ToastPage : Page
    {
        public ToastPage()
        {
            this.InitializeComponent();
        }

        private void ToastBuilderBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ImageWithTwoLineHeaderAndBody_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ImageWithHeaderAndTwoSingleLineBody_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ImageWithHeaderAndBodyBtn_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ImageWithBodyOnly_Click(object sender, RoutedEventArgs e)
        {
        }

        private void HeaderWithTwoSingleLineBody_Click(object sender, RoutedEventArgs e)
        {
        }

        private void TwoLineHeaderWithBodyBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void SingleLineHeaderWithBodyBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BodyTextOnlyBtn_Click(object sender, RoutedEventArgs e)
        {
            var text = "BodyText";
            var doc = new XmlDocument();
            doc.LoadXml($@"
<toast>
    <visual>
        <binding template='ToastText01'>
            <text id='1'>{text}</text>
        </binding>  
    </visual>
</toast>");
            ToastNotificationManager.CreateToastNotifier().Show(new ToastNotification(doc));
        }
    }
}
