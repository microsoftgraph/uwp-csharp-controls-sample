---
page_type: sample
products:
- office-sp
- office-outlook
- ms-graph
languages:
- windows-uwp
- csharp
extensions:
  contentType: samples
  technologies:
  - Microsoft Graph
  - Microsoft identity platform
  services:
  - SharePoint 
  - Outlook
  - Microsoft identity platform
  createdDate: 9/5/2018 5:09:42 AM
---
# UWP Graph 控件示例应用

此模块将向你介绍 [Microsoft Graph 控件](https://docs.microsoft.com/en-us/dotnet/api/microsoft.toolkit.uwp.ui.controls.graph?view=win-comm-toolkit-dotnet-stable)（[AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin)、[ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard)、[PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker)、[SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist)）的使用方法，这些控件可在你自己的 UWP 应用程序中的 [Windows 社区工具包](https://github.com/Microsoft/WindowsCommunityToolkit)中找到。

## 开始使用

Microsoft 工具包 Graph 控件依赖 [MicrosoftGraphService](https://docs.microsoft.com/en-us/windows/communitytoolkit/services/microsoftgraph) 来引入登录身份验证的抽象层。请注意，基础图形对象对于工具包和 Graph SDK 都是相同的 GraphServiceClient。有关图形集成的更多自定义控制，请查看 [Microsoft Graph 培训模块 - 使用 Microsoft Graph .NET SDK 构建 UWP 应用](https://github.com/microsoftgraph/msgraph-training-uwp)。

## 注册应用程序 

1. 导航到 [Azure 门户 > 应用程序注册](https://go.microsoft.com/fwlink/?linkid=2083908)以注册应用。使用**个人帐户**（也称为：“Microsoft 帐户”）或**工作/学校帐户**登录。 
 
2. 选择“**新注册**”。在“**注册应用**”页面上，按如下方式设置值。 
 
* 将“**名称**”设置为 UWP Graph 控件示例应用。 
* 将“**受支持的帐户类型**”设置为“**任何组织目录中的帐户和个人 Microsoft 帐户**”。 
* 保留“**重定向 URI**”为空。 
* 选择“**注册**”。 
 
3. 在“**UWP Graph 控件示例应用**”页面上，复制“**应用程序（客户端）ID**”值和“**目录（租户）ID**”值。保存这两个值，因为随后需要它们。 
 
4. 选择“**添加重定向 URI**” 链接。在“**重定向 URL**”页面上，找到“**建议用于公共客户端（移动、桌面）的重定向 URI**”部分。选择以 `msal` 开头的 URI **以及** **urn:ietf:wg:oauth:2.0:oob** URI。 
 
### 扩展用于 Azure AD 身份验证的 UWP 应用

1. 打开 **App.xaml** 文件。
2. 将 `ida:ClientID` 值更新为注册 Azure AD 应用程序时复制的值。

    ```
    <Application.Resources>
        <x:String x:Key="ida:ClientID">ENTER_APP_ID</x:String>
    </Application.Resources>
    ```
3. 还可以通过此示例的“设置”页设置应用 ID。

### 浏览 Graph 控件

还可以通过单击控件图标来浏览不同的 Graph 控件。可在此处找到每个控件的详细文档：
* [AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin)
* [ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard)
* [PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker)
* [SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist) 
