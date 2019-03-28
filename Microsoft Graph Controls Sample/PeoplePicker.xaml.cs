using Microsoft.Toolkit.Services.MicrosoftGraph;
using Microsoft.Toolkit.Uwp.UI.Controls.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class PeoplePicker : Page
    {
        public PeoplePicker()
        {
            this.InitializeComponent();
            initializGraphService();
            selectionChanged();
        }

        public void initializGraphService()
        {
            MicrosoftGraphService.Instance.AuthenticationModel = MicrosoftGraphEnums.AuthenticationModel.V2;

            MicrosoftGraphService.Instance.Initialize(
                App.Current.Resources["ida:ClientID"].ToString(),
                MicrosoftGraphEnums.ServicesToInitialize.UserProfile,
                Microsoft.Toolkit.Uwp.UI.Controls.Graph.PeoplePicker.RequiredDelegatedPermissions
            );
        }

        public void selectionChanged()
        {
        
            if (PeoplePickerControl != null)
            {
                PeoplePickerControl.SelectionChanged += PeopleSelectionChanged;
            }
        }

        private async void PeopleSelectionChanged(object sender, PeopleSelectionChangedEventArgs e)
        {
            if (e.Selections != null)
            {
                await new MessageDialog($"Selected Person Counter {e.Selections.Count}", "Selection Changed").ShowAsync();
            }
        }
    }
}
