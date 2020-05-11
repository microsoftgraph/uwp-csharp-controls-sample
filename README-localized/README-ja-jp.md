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
# UWP Graph コントロール サンプル アプリ

このモジュールでは、開発者の UWP アプリケーションの [Windows コミュニティ ツールキット](https://github.com/Microsoft/WindowsCommunityToolkit)に含まれる [Microsoft Graph コントロール](https://docs.microsoft.com/en-us/dotnet/api/microsoft.toolkit.uwp.ui.controls.graph?view=win-comm-toolkit-dotnet-stable) ([AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin)、[ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard)、[PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker)、および [SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist)) の操作を紹介します。

## はじめに

Microsoft ツールキット Graph コントロールは、[MicrosoftGraphService](https://docs.microsoft.com/en-us/windows/communitytoolkit/services/microsoftgraph) に依存して、ログイン認証の抽象化レイヤーを導入します。基になるグラフ オブジェクトは、ツールキットと Graph SDK の両方で同じ Graph Service Client であることに注意してください。グラフ統合のカスタム コントロールについては、 「[Microsoft Graph .NET SDK を使用する UWP アプリの作成](https://github.com/microsoftgraph/msgraph-training-uwp)」を参照してください。

## アプリケーションの登録 

1. [Azure ポータル - アプリの登録](https://go.microsoft.com/fwlink/?linkid=2083908)ページに移動してアプリを登録します。**個人用アカウント** (別名:Microsoft アカウント) または**職場または学校のアカウント**を使用してログインします。 
 
2. [**新規登録**] を選択します。[**アプリケーションの登録**] ページで、次のように値を設定します。 
 
* UWP Graph コントロール サンプル アプリに [**名前**] を設定します。 
* [**サポートされているアカウントの種類**] を [**任意の組織のディレクトリ内のアカウントと個人用の Microsoft アカウント**] に設定します。 
* [**リダイレクト URI**] は空のままにします。 
* [**登録**] を選択します。 
 
3. [**UWP Graph コントロール サンプル アプリ**] ページで、[**アプリケーション (クライアント) ID**] と [**ディレクトリ (テナント) ID**] の両方の値をコピーします。これら 2 つの値は後で必要になるため、保存します。 
 
4. [**リダイレクト URI の追加**] リンク を選択します。[**リダイレクト URI**] ページで [**パブリック クライアント (モバイル、デスクトップ) に推奨されるリダイレクト URI**] セクションを見つけます。「`msal`」 から始まる URI **および** 「**urn:ietf:wg:oauth:2.0:oob**」 という URI を選択します。 
 
### Azure AD 認証用に UWP アプリを拡張する

1. **App.xaml** ファイルを開きます。
2. `ida：ClientID` 値を、Azure AD アプリケーションの登録時にコピーした値に更新します。

    ```
    <Application.Resources>
        <x:String x:Key="ida:ClientID">ENTER_APP_ID</x:String>
    </Application.Resources>
    ```
3. このサンプルの設定ページからアプリ ID を設定することもできます。

### Graph コントロールを確認する

コントロール アイコンをクリックすると、さまざまな Graph コントロールを検索できます。各コントロールの詳細なドキュメントは、こちらから入手できます。
* [AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin)
* [ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard)
* [PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker)
* [SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist) 
