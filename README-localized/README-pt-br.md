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
# Aplicativo de exemplo de controles de gráfico UWP

Este módulo apresenta você a trabalhar com [Controles do Microsoft Graph](https://docs.microsoft.com/en-us/dotnet/api/microsoft.toolkit.uwp.ui.controls.graph?view=win-comm-toolkit-dotnet-stable) ([AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin), [ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard), [PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker), [SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist)) encontrada no [Kit de ferramentas da Comunidade do Windows](https://github.com/Microsoft/WindowsCommunityToolkit) no aplicativo de UWP.

## Introdução

Os controles do Microsoft Toolkit Graph dependem da [MicrosoftGraphService](https://docs.microsoft.com/en-us/windows/communitytoolkit/services/microsoftgraph) apresentar uma camada de abstração para autenticação de logon. Observe que o objeto gráfico subjacente é o mesmo GraphServiceClient para o kit de ferramentas e o SDK do Graph. Para ter mais controle sobre a integração de gráfico, confira o [módulo de treinamento do Microsoft Graph-Build aplicativos UWP com o SDK do Microsoft Graph .NET](https://github.com/microsoftgraph/msgraph-training-uwp).

## Registrar o aplicativo 

1. Navegue até o [portal do Azure-registros de aplicativo](https://go.microsoft.com/fwlink/?linkid=2083908) para registrar seu aplicativo. Faça logon usando uma **conta pessoal** (também conhecida como: Conta Microsoft) **Conta Corporativa ou de Estudante**. 
 
2. Selecione **Novo registro**. Na página **Registrar um aplicativo**, defina os valores da seguinte forma. 
 
* Definir o **Nome** para o Aplicativo de exemplo de controles de gráfico UWP. 
* Defina **Tipos de contas com suporte** para **Contas em qualquer diretório organizacional e contas pessoais da Microsoft**. 
* Deixe o **URI de Redirecionamento** vazio. 
* Escolha **Registrar**. 
 
3. Na página **Aplicativo de exemplo de controles de gráfico UWP**, copie os valores do **ID do aplicativo (cliente)** e do **ID do Diretório (locatário)**. Salve esses dois valores, porque você vai precisar deles mais tarde. 
 
4. Selecione **adicionar uma URI de redirecionamento**. Na página **Redirecionamento de URIs**, localize a seção**URIs de redirecionamento sugeridas para clientes públicos (móvel, área de trabalho)**. Selecione a URI que começa com `msal` **e** URI **urn:ietf:wg:oauth:2.0:oob**. 
 
### Estender o aplicativo UWP para a autenticação do Azure AD

1. Abra o arquivo **App.xaml**.
2. Atualize o valor `ida: ClientID` para o que você copiou ao registrar o aplicativo Azure AD.

    ```
    <Application.Resources>
        <x:String x:Key="ida:ClientID">ENTER_APP_ID</x:String>
    </Application.Resources>
    ```
3. Você também pode definir a ID do aplicativo na página de configurações deste exemplo.

### Explorar os controles de gráfico

Para explorar os diferentes controles de gráfico, clique em ícones de controle. As documentações detalhadas de cada controle podem ser encontradas aqui:
* [AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin)
* [ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard)
* [PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker)
* [SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist) 
