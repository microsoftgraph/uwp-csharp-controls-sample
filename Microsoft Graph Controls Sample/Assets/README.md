# UWP Graph Controls Sample App

This module will introduce you to working with the [Microsoft Graph Controls](https://docs.microsoft.com/en-us/dotnet/api/microsoft.toolkit.uwp.ui.controls.graph?view=win-comm-toolkit-dotnet-stable) ([AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin), [ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard), [PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker), [SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist)) found in the [Windows Community Toolkit](https://github.com/Microsoft/WindowsCommunityToolkit) in your own UWP application.

## Getting Started

The Microsoft Toolkit Graph Controls depend on the [MicrosoftGraphService](https://docs.microsoft.com/en-us/windows/communitytoolkit/services/microsoftgraph) to introduce a layer of abstraction for login authentication. Note that the underlying graph object is the same GraphServiceClient for both the Toolkit and the Graph SDK. For more custom control of graph integration, check out the [Microsoft Graph Training Module - Build UWP apps with the Microsoft Graph .NET SDK](https://github.com/microsoftgraph/msgraph-training-uwp).

### Register the App to use Azure AD v2 Endpoint

1. Go to the [App Registration Portal](https://apps.dev.microsoft.com)
2. Click in the "Add an app" button.
3. Enter the app name and click "create"
4. Once the App is created, copy the Application Id to use it later.
5. Next, add a Platform to the App clicking in "Add Platform" and select "Native Application" tile.
6. Scroll to the Microsoft Graph Permissions section (by default the User.Read permission is added). Add the following permissions: Sign in and read user profile, Read user mail, Send mail as a user, Read user calendars.
7. Finally, save your changes.

### Extend the UWP app for Azure AD Authentication

1. Open the **App.xaml** file.
2. Update the `ida:ClientID` value to the one you copied when registering the Azure AD application.

    ```
    <Application.Resources>
        <x:String x:Key="ida:ClientID">ENTER_APP_ID</x:String>
    </Application.Resources>
    ```

### Explore the Graph Controls

You can explore the different Graph Controls by clicking on control icons. Detailed documentations for each control can be found here:
>* [AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin) 
>* [ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard)
>* [PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker) 
>* [SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist) 

