# UWP Graph Controls Sample App

This module will introduce you to working with the [Microsoft Graph Controls](https://docs.microsoft.com/en-us/dotnet/api/microsoft.toolkit.uwp.ui.controls.graph?view=win-comm-toolkit-dotnet-stable) ([AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin), [ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard), [PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker), [SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist)) found in the [Windows Community Toolkit](https://github.com/Microsoft/WindowsCommunityToolkit) in your own UWP application.

## Getting Started

The Microsoft Toolkit Graph Controls depend on the [MicrosoftGraphService](https://docs.microsoft.com/en-us/windows/communitytoolkit/services/microsoftgraph) to introduce a layer of abstraction for login authentication. Note that the underlying graph object is the same GraphServiceClient for both the Toolkit and the Graph SDK. For more custom control of graph integration, check out the [Microsoft Graph Training Module - Build UWP apps with the Microsoft Graph .NET SDK](https://github.com/microsoftgraph/msgraph-training-uwp).

## Register the application 

1. Navigate to the [the Azure portal - App registrations](https://go.microsoft.com/fwlink/?linkid=2083908) to register your app. Login using a **personal account** (aka: Microsoft Account) or **Work or School Account**. 
 
2. Select **New registration**. On the **Register an application** page, set the values as follows. 
 
* Set **Name** to UWP Graph Controls Sample App. 
* Set **Supported account types** to **Accounts in any organizational directory and personal Microsoft accounts**. 
* Leave **Redirect URI** empty. 
* Choose **Register**. 
 
3. On the **UWP Graph Controls Sample App** page, copy the values of both the **Application (client) ID** and the **Directory (tenant) ID**. Save these two values, since you will need them later. 
 
4. Select the **Add a Redirect URI** link. On the **Redirect URIs** page, locate the **Suggested Redirect URIs for public clients (mobile, desktop)** section. Select the URI that begins with `msal` **and** the **urn:ietf:wg:oauth:2.0:oob** URI. 
 
### Extend the UWP app for Azure AD Authentication

1. Open the **App.xaml** file.
2. Update the `ida:ClientID` value to the one you copied when registering the Azure AD application.

    ```
    <Application.Resources>
        <x:String x:Key="ida:ClientID">ENTER_APP_ID</x:String>
    </Application.Resources>
    ```
3. You can also set the app ID through the settings page of this sample.

### Explore the Graph Controls

You can explore the different Graph Controls by clicking on control icons. Detailed documentations for each control can be found here:
* [AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin) 
* [ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard)
* [PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker) 
* [SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist) 
