// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUITest
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices.WindowsRuntime;
    using Microsoft.UI.Xaml;
    using Microsoft.UI.Xaml.Controls;
    using Microsoft.UI.Xaml.Controls.Primitives;
    using Microsoft.UI.Xaml.Data;
    using Microsoft.UI.Xaml.Input;
    using Microsoft.UI.Xaml.Media;
    using Microsoft.UI.Xaml.Navigation;
    using Windows.Foundation;
    using Windows.Foundation.Collections;

    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        public void Load()
        {
            this.WebView2.Source = new Uri("https://github.com/ffmpeginteropx/FFmpegInteropX/pull/379#issuecomment-1802559586");
        }

        private async void myButton_Click(object sender, RoutedEventArgs e)
        {
            var mpe = this.MediaPlayerElement;

            var test = new PlayerProject.PlayerTestClass();
            var player = test.CreatePlayer();

            mpe.SetMediaPlayer(player);

            await test.TestSetVideoToPlayer(player);
        }
    }
}
