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
# Exemple d’application de contrôles Graph UWP

Ce module présente l’utilisation des contrôles [Microsoft Graph ](https://docs.microsoft.com/en-us/dotnet/api/microsoft.toolkit.uwp.ui.controls.graph?view=win-comm-toolkit-dotnet-stable) ([AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin), [ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard), [PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker), [SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist)) disponibles dans le Kit de ressources [Kit d’outils de la communauté Windows](https://github.com/Microsoft/WindowsCommunityToolkit) dans votre propre application UWP.

## Requêtes de base

Les contrôles Microsoft Toolkit Graph dépendent du [MicrosoftGraphService](https://docs.microsoft.com/en-us/windows/communitytoolkit/services/microsoftgraph) pour introduire une couche d’abstraction pour l’authentification de connexion. Notez que l’objet graphique sous-jacent a le même GraphServiceClient pour le kit de ressources et le kit de développement logiciel Graph. Pour un contrôle plus personnalisé de l’intégration de Graph, consultez le [module de formation Microsoft Graph : créer des applications UWP avec le kit de développement Microsoft Graph .NET](https://github.com/microsoftgraph/msgraph-training-uwp).

## Inscription de l’application 

1. Accédez au [Portail Microsoft Azure : enregistrement des applications](https://go.microsoft.com/fwlink/?linkid=2083908) pour enregistrer votre application. Connectez-vous à l’aide d’un **compte personnel** (alias : compte Microsoft) ou d’un **compte professionnel ou scolaire**. 
 
2. Sélectionnez **Nouvelle inscription**. Sur la page **Inscrire une application**, définissez les valeurs comme suit. 
 
* Attribuez un **Nom** à l’exemple d’application de contrôles Graph UWP. 
* Définissez **Types de comptes pris en charge** sur **Comptes figurant dans un annuaire organisationnel et comptes Microsoft personnels**. 
* Laissez **Redirect URI** vide. 
* Choisissez **Inscrire**. 
 
3. Sur la page **exemple de contrôles Graph UWP**, copiez les valeurs des **ID d’application (client)** et **Directory (locataire)**. Enregistrez ces deux valeurs, car vous en aurez besoin plus tard. 
 
4. Sélectionnez le lien **Ajouter un URI de redirection**. Dans la page **URI de redirection** Recherchez la section des **URI de redirection suggérés pour les clients publics (mobile, bureau)**. Sélectionnez l’URI qui commence par `msal` **et** l’URI**urn:ietf:wg:oauth:2.0:oob**. 
 
### Prolonger l’application UWP pour Azure AD Authentication

1. Ouvrez le fichier **App.xaml**.
2. Mettez à jour la valeur `ida:ClientID` avec celle que vous avez copiée lors de l’inscription de l’application Azure AD.

    ```
    <Application.Resources>
        <x:String x:Key="ida:ClientID">ENTER_APP_ID</x:String>
    </Application.Resources>
    ```
3. Vous pouvez également définir l’ID d’application via la page Paramètres de cet exemple.

### Explorez les contrôles Graph

Vous pouvez explorer les différents contrôles Graph en cliquant sur icônes de contrôle. Des documents détaillés sont disponibles pour chaque contrôle :
* [AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin)
* [ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard)
* [PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker)
* [SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist) 
