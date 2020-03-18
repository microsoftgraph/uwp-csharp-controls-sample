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
# Aplicación de ejemplo de controles de Graph para UWP

En este módulo se describe cómo trabajar con los [controles de Microsoft Graph](https://docs.microsoft.com/es-es/dotnet/api/microsoft.toolkit.uwp.ui.controls.graph?view=win-comm-toolkit-dotnet-stable) ([AadLogin](https://docs.microsoft.com/es-es/windows/communitytoolkit/graph/aadlogin), [ProfileCard](https://docs.microsoft.com/es-es/windows/communitytoolkit/graph/profilecard), [PeoplePicker](https://docs.microsoft.com/es-es/windows/communitytoolkit/graph/peoplepicker), [SharePointFileList](https://docs.microsoft.com/es-es/windows/communitytoolkit/graph/sharepointfilelist)) hallados en [Windows Community Toolkit](https://github.com/Microsoft/WindowsCommunityToolkit) en su propia aplicación de UWP.

## Introducción

Los controles de Microsoft Toolkit Graph dependen de [MicrosoftGraphService](https://docs.microsoft.com/es-es/windows/communitytoolkit/services/microsoftgraph) para introducir una capa de abstracción para la autenticación del inicio de sesión. Tenga en cuenta que el objeto de Graph subyacente es el mismo GraphServiceClient para el kit de herramientas y para el SDK de Graph. Para obtener un control más personalizado de la integración de Graph, consulte el [Módulo de aprendizaje de Microsoft Graph: Cómo crear apps de UWP con el SDK de Microsoft Graph .NET](https://github.com/microsoftgraph/msgraph-training-uwp).

## Registrar la aplicación 

1. Vaya a la página de [registro de aplicaciones de Azure Portal](https://go.microsoft.com/fwlink/?linkid=2083908) para registrar la aplicación. Inicie sesión con una **cuenta personal** (por ejemplo: una cuenta de Microsoft) o una **cuenta profesional o educativa**. 
 
2. Haga clic en **Nuevo registro**. En la página **Registrar una aplicación**, establezca los valores como se indica a continuación. 
 
* Establezca **Nombre** en Aplicación de ejemplo de controles de Graph para UWP. 
* Establezca **Tipos de cuenta compatibles** en **	Cuentas en cualquier directorio organizativo y cuentas de Microsoft personales**. 
* Deje vacía la opción de **URI de redirección**. 
* Haga clic en **Registrar**. 
 
3. En la página **Aplicación de ejemplo de controles de Graph para UWP**, copie los valores de **Id. de aplicación (cliente)** y **Id. de directorio (inquilino)**. Guarde estos dos valores, ya que los necesitará más adelante. 
 
4. Haga clic en el vínculo **Agregar un URI de redirección**. En la página **URI de redirección**, localice la sección **URI de redirección sugeridos para clientes públicos (para dispositivos móviles o de escritorio)**. Seleccione el URI que comience por `msal` **y** el URI **urn:ietf:wg:oauth:2.0:oob**. 
 
### Extender la aplicación de UWP para la Autenticación de Azure AD

1. Abra el archivo **App.xaml**.
2. Actualice el valor de `ida:ClientID` con el que copió al registrar la aplicación de Azure AD.

    ```
    <Application.Resources>
        <x:String x:Key="ida:ClientID">ENTER_APP_ID</x:String>
    </Application.Resources>
    ```
3. También puede establecer el Id. de aplicación a través de la página de configuración de este ejemplo.

### Explorar los controles de Graph

Para explorar los distintos controles de Graph, haga clic en iconos de control. Se puede encontrar documentación detallada para cada control en los siguientes vínculos:
* [AadLogin](https://docs.microsoft.com/es-es/windows/communitytoolkit/graph/aadlogin)
* [ProfileCard](https://docs.microsoft.com/es-es/windows/communitytoolkit/graph/profilecard)
* [PeoplePicker](https://docs.microsoft.com/es-es/windows/communitytoolkit/graph/peoplepicker)
* [SharePointFileList](https://docs.microsoft.com/es-es/windows/communitytoolkit/graph/sharepointfilelist) 
