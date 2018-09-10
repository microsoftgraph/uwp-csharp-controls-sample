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
    public sealed partial class AadLogin : Page
    {

        public AadLogin()
        {
            this.InitializeComponent();
            createControls();
        }

        private void createControls()
        {
            //ViewType Control
            ViewTypeControl.Items.Add("PictureOnly");
            ViewTypeControl.Items.Add("EmailOnly");
            ViewTypeControl.Items.Add("LargeProfilePhotoLeft");
            ViewTypeControl.Items.Add("LargeProfilePhotoRight");
            ViewTypeControl.Items.Add("SmallProfilePhotoLeft");
            ViewTypeControl.Items.Add("SmallProfilePhotoRight");
            ViewTypeControl.SelectedIndex = 0;

            //MultipleSignIn Control

        }

       
        private void ViewTypeControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ViewTypeControl == null) return;
            var item = ViewTypeControl.SelectedItem;

            switch (item.ToString())
            {
                case "PictureOnly":
                    AadLoginControl.View = Microsoft.Toolkit.Uwp.UI.Controls.Graph.ViewType.PictureOnly;
                    break;
                case "EmailOnly":
                    AadLoginControl.View = Microsoft.Toolkit.Uwp.UI.Controls.Graph.ViewType.EmailOnly;
                    break;
                case "LargeProfilePhotoLeft":
                    AadLoginControl.View = Microsoft.Toolkit.Uwp.UI.Controls.Graph.ViewType.LargeProfilePhotoLeft;
                    break;
                case "LargeProfilePhotoRight":
                    AadLoginControl.View = Microsoft.Toolkit.Uwp.UI.Controls.Graph.ViewType.LargeProfilePhotoRight;
                    break;
                case "SmallProfilePhotoLeft":
                    AadLoginControl.View = Microsoft.Toolkit.Uwp.UI.Controls.Graph.ViewType.SmallProfilePhotoLeft;
                    break;
                case "SmallProfilePhotoRight":
                    AadLoginControl.View = Microsoft.Toolkit.Uwp.UI.Controls.Graph.ViewType.SmallProfilePhotoRight;
                    break;
            }
        }

        private void DifferentUserControl_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
