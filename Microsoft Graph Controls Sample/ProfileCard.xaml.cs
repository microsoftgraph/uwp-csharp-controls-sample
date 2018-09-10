
using Microsoft.Toolkit.Services.MicrosoftGraph;
using Microsoft.Toolkit.Uwp.UI.Controls.Graph;
using Microsoft.Toolkit.Uwp.UI.Extensions;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Microsoft_Graph_Controls_Sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProfileCard : Page
    {
        private MicrosoftGraphService GraphService => MicrosoftGraphService.Instance;

        public ProfileCard()
        {
            this.InitializeComponent();
            getUserId();
        }
        public async void getUserId()
        {
            System.Diagnostics.Debug.WriteLine("OnXamlRendered");

            if (ProfileCardControl != null)
            {
                GraphService.IsAuthenticatedChanged += async (s, e) =>
                {
                    if (GraphService.IsAuthenticated)
                    {
                        ProfileCardControl.UserId = (await GraphService.User.GetProfileAsync(new MicrosoftGraphUserFields[1] { MicrosoftGraphUserFields.Id })).Id;
                        System.Diagnostics.Debug.WriteLine("USERID:");
                        System.Diagnostics.Debug.WriteLine(ProfileCardControl.UserId);
                    }
                };

                if (GraphService.IsAuthenticated)
                {
                    ProfileCardControl.UserId = (await GraphService.User.GetProfileAsync(new MicrosoftGraphUserFields[1] { MicrosoftGraphUserFields.Id })).Id;
                    System.Diagnostics.Debug.WriteLine("USERID:");
                    System.Diagnostics.Debug.WriteLine(ProfileCardControl.UserId);
                }
            }
        }
    }
}
