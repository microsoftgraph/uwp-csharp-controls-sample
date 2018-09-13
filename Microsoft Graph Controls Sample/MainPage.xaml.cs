using Microsoft.Toolkit.Services.MicrosoftGraph;
using Microsoft.Toolkit.Uwp.UI.Controls.Graph;
using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Microsoft_Graph_Controls_Sample
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            checkRegistration();
        }

        public void initializGraphService()
        {
            MicrosoftGraphService.Instance.AuthenticationModel = MicrosoftGraphEnums.AuthenticationModel.V2;

            MicrosoftGraphService.Instance.Initialize(
                ApplicationData.Current.LocalSettings.Values["ClientID"].ToString(),
                MicrosoftGraphEnums.ServicesToInitialize.UserProfile, 
                new string[] { "User.Read", "User.ReadBasic.All", "People.Read", "Files.ReadWrite.All" }
            );
        }

        private void checkRegistration()
        {
            // if the app has no localSettings entry for ClientID, save the ID from App.xaml
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;

            if (localSettings.Values["ClientID"] == null)
            {
                if (App.Current.Resources["ida:ClientID"].ToString() != null)
                {
                    NavMain.Header = "";
                    localSettings.Values["ClientID"] = App.Current.Resources["ida:ClientID"];
                    initializGraphService();
                }
                else
                {
                    
                    ContentFrame.Navigate(typeof(SettingsPage));
                }
            }
            else
            {
                NavMain.Header = "";
                // we have a client id, so initialize the Graph service
                initializGraphService();
            }
        }

        private void AadLoginButton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(AadLogin));
        }

        private void ProfileCardButton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(ProfileCard));
        }

        private void PeoplePickerButton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(PeoplePicker));
        }

        private void SharepointButton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Sharepoint));
        }

        private void NavMain_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                // find NavigationViewItem with Content that equals InvokedItem
                var item = sender.MenuItems.OfType<NavigationViewItem>().First(x => (string)x.Content == (string)args.InvokedItem);
                NavMain_Navigate(item as NavigationViewItem);
            }
        }
        private void NavMain_Navigate(NavigationViewItem item)
        {
            switch (item.Tag)
            {
                case "aadlogin":
                    ContentFrame.Navigate(typeof(AadLogin));
                    break;
                case "usrcard":
                    ContentFrame.Navigate(typeof(ProfileCard));
                    break;
                case "pplpicker":
                    ContentFrame.Navigate(typeof(PeoplePicker));
                    break;
                case "splist":
                    ContentFrame.Navigate(typeof(Sharepoint));
                    break;
            }
        }
    }
}
