using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.System;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Microsoft_Graph_Controls_Sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HelpPage : Page
    {
        public HelpPage()
        {
            this.InitializeComponent();

            LoadHelp();
        }

        private async void LoadHelp()
        {
            // load the help text from github
            // can't do this 'til the repo is public

            // get the file from assets for now
            Uri mdPath = new Uri("ms-appx:///Assets/README.md");
            StorageFile mdFile = await StorageFile.GetFileFromApplicationUriAsync(mdPath);

            string mdRaw = FileIO.ReadTextAsync(mdFile).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();

            MdbHelp.Text = mdRaw;
        }

        private async void MdbHelp_LinkClicked(object sender, Microsoft.Toolkit.Uwp.UI.Controls.LinkClickedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri(e.Link));
        }
    }
}
