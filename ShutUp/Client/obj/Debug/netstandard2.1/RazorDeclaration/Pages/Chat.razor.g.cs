#pragma checksum "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "123c953d6e6ed62b1631961dd7b2b2f50241f500"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
using ShutUp.Client.Services.StateContainers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
using ShutUp.Client.Services.ApiServices;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserStateContainer _userState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageApiService _messageApi { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageStateContainer _messageState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
