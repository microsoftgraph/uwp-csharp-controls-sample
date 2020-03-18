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
# Образец приложения UWP Graphs Controls

Этот раздел познакомит вас с работой с[Microsoft Graph Controls ([AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin), [ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard), [PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker), [SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist)), который находится в [наборе приложений для Windows Community](https://github.com/Microsoft/WindowsCommunityToolkit) в вашем собственном приложении UWP.

## Начало работы

Элементы управления Microsoft Toolkit Graph зависят от [MicrosoftGraphService](https://docs.microsoft.com/en-us/windows/communitytoolkit/services/microsoftgraph), которые вводят уровень абстракции для проверки подлинности при входе в систему. Обратите внимание, что базовый объект графа является одним и тем же GraphServiceClient как для Toolkit, так и для Graph SDK. Для более индивидуального управления интеграцией графиков, ознакомьтесь с [учебным модулем Microsoft Graph - создавайте приложения UWP с помощью Microsoft Graph .NET SDK](https://github.com/microsoftgraph/msgraph-training-uwp).

## Регистрация приложения 

1. Перейдите на страницу [регистрации приложений портала Azure](https://go.microsoft.com/fwlink/?linkid=2083908), чтобы зарегистрировать ваше приложение. Войдите с помощью **личной учетной записи** (т. е. учетной записи Майкрософт) или **рабочей или учебной учетной записи**. 
 
2. Выберите **Новая регистрация**. На странице **Регистрация приложения** задайте необходимые значения следующим образом: 
 
* Установите **Имя** для UWP Graph Controls Sample App. 
* Установите **Поддерживаемые типы учетных записей** в **Учетные записи в любом каталоге организации и личных учетных записях Microsoft**. 
* Оставьте поле **URI перенаправления** пустым. 
* Нажмите кнопку **Зарегистрировать**. 
 
3. На странице **Примера приложения UWP Graph Controls** скопируйте значения **Идентификатора приложения (клиента)** и **Идентификатора каталога (клиента)**. Сохраните эти два значения, так как они понадобятся позже. 
 
4. Выберите ссылку **добавить URI перенаправления**. На странице **URI перенаправления** найдите раздел **Предлагаемые URI перенаправления для общедоступных клиентов (мобильные, настольные)**. Выберите URI которые начинается с `msal` **и** URI **urn:ietf:wg:oauth:2.0:oob**. 
 
### Расширение приложения UWP для проверки подлинности Azure AD

1. Откройте файл **App.xaml**.
2. Обновите значение `ida:ClientID` до значения, которое вы скопировали при регистрации приложения Azure AD.

    ```
    <Application.Resources>
        <x:String x:Key="ida:ClientID">ENTER_APP_ID</x:String>
    </Application.Resources>
    ```
3. Идентификатор приложения также можно задать на странице "Параметры" в этом примере.

### Знакомьтесь с элементами управления графиком

Вы можете исследовать различные элементы управления графиком, щелкая значки элементов управления. Чтобы найти подробные описания для каждого элемента управления, выполните указанные ниже действия.
* [AadLogin](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/aadlogin)
* [ProfileCard](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/profilecard)
* [PeoplePicker](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/peoplepicker)
* [SharePointFileList](https://docs.microsoft.com/en-us/windows/communitytoolkit/graph/sharepointfilelist) 
