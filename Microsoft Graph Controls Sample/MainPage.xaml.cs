using Microsoft.Toolkit.Services.MicrosoftGraph;
using Microsoft.Toolkit.Uwp.UI.Controls.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
                App.Current.Resources["ida:ClientID"].ToString(),
                MicrosoftGraphEnums.ServicesToInitialize.UserProfile, 
                new string[] { "User.Read", "User.ReadBasic.All", "People.Read", "Files.ReadWrite.All" }
            );
        }

        private void checkRegistration()
        {
            if(App.Current.Resources["ida:ClientID"].ToString() != null)
            {
                Registration_Warning.Visibility = Visibility.Collapsed;
                initializGraphService();
            } else
            {
                Registration_Warning.Visibility = Visibility.Visible;
            }
        }

        private void AadLoginButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(AadLogin));
        }

        private void ProfileCardButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(ProfileCard));
        }

        private void PeoplePickerButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(PeoplePicker));
        }

        private void SharepointButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Sharepoint));
        }
    }
}
