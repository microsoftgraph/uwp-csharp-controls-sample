using Microsoft.Toolkit.Services.MicrosoftGraph;
using Microsoft.Toolkit.Uwp.UI.Controls.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
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

            // load the help file to the frame
            ContentFrame.Navigate(typeof(HelpPage));

            // see if we can load help doc
            
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
            string currID = "";
            currID = App.Current.Resources["ida:ClientID"].ToString();

            if (localSettings.Values["ClientID"] == null)
            {
                if (currID != null && (new SettingsPage().CheckAppID(currID)))
                {
                    NavMain.Header = "";
                    localSettings.Values["ClientID"] = currID;
                    initializGraphService();
                }
                else
                {
                    NavMain.Header = "⛔Azure App ID not set! Save your app ID before proceeding.⛔";
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
        private async void NavMain_Navigate(NavigationViewItem item)
        {
            string mdbase = "https://raw.githubusercontent.com/MicrosoftDocs/WindowsCommunityToolkitDocs/master/docs/graph/";

            string mdraw = "";

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = new HttpResponseMessage();            

            switch (item.Tag)
            {
                case "home":
                    ContentFrame.Navigate(typeof(HelpPage));
                    mdraw = "";
                    break;
                case "aadlogin":
                    ContentFrame.Navigate(typeof(AadLogin));
                    mdbase += "AadLogin.md";
                    response = await httpClient.GetAsync(new Uri(mdbase));
                    mdraw = await response.Content.ReadAsStringAsync();
                    break;
                case "usrcard":
                    ContentFrame.Navigate(typeof(ProfileCard));
                    mdbase += "ProfileCard.md";
                    response = await httpClient.GetAsync(new Uri(mdbase));
                    mdraw = await response.Content.ReadAsStringAsync();
                    break;
                case "pplpicker":
                    ContentFrame.Navigate(typeof(PeoplePicker));
                    mdbase += "PeoplePicker.md";
                    response = await httpClient.GetAsync(new Uri(mdbase));
                    mdraw = await response.Content.ReadAsStringAsync();
                    break;
                case "splist":
                    ContentFrame.Navigate(typeof(Sharepoint));
                    mdbase += "SharePointFileList.md";
                    response = await httpClient.GetAsync(new Uri(mdbase));
                    mdraw = await response.Content.ReadAsStringAsync();
                    break;
            }

            // if the app ID isn't valid, display an alert here
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            SettingsPage spage = new SettingsPage();
            if (spage.CheckAppID(localSettings.Values["ClientID"].ToString()))
            {
                NavMain.Header = "";
            }
            else
            {
                NavMain.Header = "⛔Azure App ID not set! Save your app ID before proceeding.⛔";
            }

            // clean up the markdown text
            string reg = "---([\\s\\S]*)---";
            Regex rx = new Regex(reg);
            mdraw = mdraw.Substring(rx.Match(mdraw).Length);

            mdraw = mdraw.Replace("../", "https://raw.githubusercontent.com/MicrosoftDocs/WindowsCommunityToolkitDocs/master/docs/");

            MdbReadme.Text = mdraw;
        }
    }
}
