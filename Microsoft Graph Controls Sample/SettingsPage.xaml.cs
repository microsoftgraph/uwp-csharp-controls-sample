using System.Text.RegularExpressions;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Microsoft_Graph_Controls_Sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            this.InitializeComponent();

            TxtClientID.Focus(FocusState.Programmatic);

            TxtClientID.Text = ApplicationData.Current.LocalSettings.Values["ClientID"].ToString();
            if (CheckAppID(TxtClientID.Text))
            {
                TxbValid.Text = "✔ App ID is valid.";
                BtnSave.IsEnabled = true;
            }
            else
            {
                TxbValid.Text = "❌ App ID is not valid.";
                BtnSave.IsEnabled = false;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            // get the textbox infos
            string NewID = TxtClientID.Text;
            ApplicationData.Current.LocalSettings.Values["ClientID"] = NewID;

            // this doesn't actually work
            // we'll need to use local app data store
            // https://docs.microsoft.com/en-us/windows/uwp/design/app-settings/store-and-retrieve-app-data#local-app-data
        }

        private void TxtClientID_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(CheckAppID(TxtClientID.Text))
            {
                TxbValid.Text = "✔ App ID is valid.";
                BtnSave.IsEnabled = true;
            }
            else
            {
                TxbValid.Text = "❌ App ID is not valid.";
                BtnSave.IsEnabled = false;
            }
        }

        public bool CheckAppID(string txt)
        {
            // as the user is typing, validate the app id
            Regex regex = new Regex("([a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12})");

            if (regex.Match(txt).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
