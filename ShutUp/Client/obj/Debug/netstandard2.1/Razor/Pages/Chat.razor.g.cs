#pragma checksum "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8346d46dd9df178b52b916e87878ee625672bd46"
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
            __builder.AddMarkupContent(0, "<h3>Chatt</h3>\n");
#nullable restore
#line 13 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
 if (loading)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Loading</p>\n");
#nullable restore
#line 16 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "label");
            __builder.AddMarkupContent(8, "\n            User:\n            ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
                          userInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userInput = __value, userInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "\n         ");
            __builder.OpenElement(18, "label");
            __builder.AddMarkupContent(19, "\n            Message:\n            ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "size", "50");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
                          messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
                      Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "disabled", 
#nullable restore
#line 31 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
                                        !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n");
            __builder.AddMarkupContent(32, "    <hr>\n");
            __builder.AddContent(33, "    ");
            __builder.OpenElement(34, "ul");
            __builder.AddAttribute(35, "id", "messagesList");
            __builder.AddAttribute(36, "class", "list-group");
            __builder.AddMarkupContent(37, "\n");
#nullable restore
#line 36 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
         foreach (var message in _messageState.Messages)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "            ");
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", "list-group-item");
            __builder.AddMarkupContent(41, "\n                ");
            __builder.AddContent(42, 
#nullable restore
#line 39 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
                 message.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(43, " ");
            __builder.OpenElement(44, "i");
            __builder.AddAttribute(45, "class", "small");
            __builder.AddContent(46, 
#nullable restore
#line 39 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
                                                message.Date.ToString("yyyy-MM-dd HH:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "<br>\n                ");
            __builder.AddContent(48, 
#nullable restore
#line 40 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
                 message.MessageText

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(49, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n");
#nullable restore
#line 42 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n");
#nullable restore
#line 44 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Chat.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageApi _messageApi { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageStateContainer _messageState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
