#pragma checksum "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff64bc6097b77d59db6893228026b50904c3374a"
// <auto-generated/>
#pragma warning disable 1591
namespace ShutUp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\_Imports.razor"
using ShutUp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\_Imports.razor"
using ShutUp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\_Imports.razor"
using ShutUp.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\_Imports.razor"
using ShutUp.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor"
using ShutUp.Client.Services.ApiServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor"
using ShutUp.Client.Services.StateContainers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor"
 if (_userState.User.LoggedIn)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "h2");
            __builder.AddContent(2, "Hej ");
            __builder.AddContent(3, 
#nullable restore
#line 12 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor"
             _userState.User.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n");
#nullable restore
#line 13 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor"

}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor"
     if (loading)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.AddMarkupContent(6, "<p>Loading...</p> \n");
#nullable restore
#line 20 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "        <br>\n        ");
            __builder.AddMarkupContent(8, "<h6>Välj en användare att logga in med:</h6>\n        <hr>\n        ");
            __builder.OpenElement(9, "ul");
            __builder.AddAttribute(10, "id", "messagesList");
            __builder.AddAttribute(11, "class", "list-group");
            __builder.AddMarkupContent(12, "\n");
#nullable restore
#line 27 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor"
             foreach (var user in registeredUsers)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "list-group-item");
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor"
                                           e => SelectUser(user.UserId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(20, "onclick", true);
            __builder.AddMarkupContent(21, "\n                        ");
            __builder.AddContent(22, 
#nullable restore
#line 31 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor"
                         user.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n");
#nullable restore
#line 34 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
#nullable restore
#line 36 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Index.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService _localStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserStateContainer _userState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserApiService _userApi { get; set; }
    }
}
#pragma warning restore 1591
