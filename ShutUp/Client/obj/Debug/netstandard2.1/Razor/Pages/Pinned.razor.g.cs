#pragma checksum "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e26fe7fcde4931f0c12c70797acc86a86a88bfef"
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
#line 2 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
using ShutUp.Client.Services.StateContainers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
using ShutUp.Client.Services.ApiServices;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pinned")]
    public partial class Pinned : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2 class=\"text-center beanie mb-5 text-green\">Viktiga meddelanden <span class=\"oi oi-pin transform\"></span></h2>\n\n");
#nullable restore
#line 14 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
 if (loading)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Loading...</p>\n");
#nullable restore
#line 17 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\n");
#nullable restore
#line 23 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
             foreach (var message in _messageState.Messages)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                 if (message.Pinned)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-sm-8 col-md-6 col-lg-4 mt-1 mb-3");
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card");
            __builder.AddMarkupContent(16, "\n                        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-header d-flex justify-content-between");
            __builder.AddMarkupContent(19, "\n                            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-10 text-left");
            __builder.AddMarkupContent(22, "\n                                ");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "src", "/img/" + (
#nullable restore
#line 31 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                message.User.Avatar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "class", "rounded");
            __builder.AddAttribute(26, "alt", "staff image");
            __builder.AddAttribute(27, "width", "30");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                                ");
            __builder.AddContent(29, 
#nullable restore
#line 32 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                 message.User.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, " <br>\n                                ");
            __builder.OpenElement(31, "i");
            __builder.AddAttribute(32, "class", "small");
            __builder.AddContent(33, 
#nullable restore
#line 33 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                  message.Date.ToString("yyyy-MM-dd HH:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col text-right");
            __builder.AddMarkupContent(38, "\n                                ");
            __builder.OpenElement(39, "span");
            __builder.AddAttribute(40, "class", "oi oi-pin transform");
            __builder.AddAttribute(41, "aria-hidden", "true");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                                                                 e => Edit(message)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "card-body");
            __builder.AddMarkupContent(48, "\n                            ");
            __builder.AddContent(49, 
#nullable restore
#line 40 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                             message.MessageText

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, "\n\n");
#nullable restore
#line 42 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                             if (message.SubMessages != null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                                ");
            __builder.OpenComponent<ShutUp.Client.Components.ListSubMessagesPinned>(52);
            __builder.AddAttribute(53, "SubMessages", 
#nullable restore
#line 44 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                                                             message.SubMessages

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(54, "MessageId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 44 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                                                                                              message.MessageId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "CloseEventCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ShutUp.Shared.SubMessage>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ShutUp.Shared.SubMessage>(this, 
#nullable restore
#line 44 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                                                                                                                                      SendSubMessage

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(56, (__value) => {
#nullable restore
#line 44 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                              listSubMessages = (ShutUp.Client.Components.ListSubMessagesPinned)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "                        \n");
#nullable restore
#line 45 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "d-flex justify-content-end mt-4");
            __builder.AddMarkupContent(61, "\r\n                                    ");
            __Blazor.ShutUp.Client.Pages.Pinned.TypeInference.CreateCascadingValue_0(__builder, 62, 63, "MessageID", 64, 
#nullable restore
#line 49 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                                             message.MessageId

#line default
#line hidden
#nullable disable
            , 65, (__builder2) => {
                __builder2.AddMarkupContent(66, "\n                                        ");
                __builder2.OpenComponent<ShutUp.Client.Components.AnswerMessage>(67);
                __builder2.AddAttribute(68, "CloseEventCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ShutUp.Shared.SubMessage>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ShutUp.Shared.SubMessage>(this, 
#nullable restore
#line 50 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                                                                  SendSubMessage

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddComponentReferenceCapture(69, (__value) => {
#nullable restore
#line 50 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                              answerMessage = (ShutUp.Client.Components.AnswerMessage)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\n                                    ");
            }
            );
            __builder.AddMarkupContent(71, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 53 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n");
#nullable restore
#line 58 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(77, "\n\n");
#nullable restore
#line 62 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                 if (showWriteMessageBar)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "                    ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-sm-8 col-md-6 col-lg-4 mt-1 mb-3");
            __builder.AddMarkupContent(81, "\n                        ");
            __builder.OpenElement(82, "h6");
            __builder.AddAttribute(83, "class", "text-right text-green");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                                     Hide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(85, "<span class=\"oi oi-x\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\n                        ");
            __builder.OpenComponent<ShutUp.Client.Components.WriteMessageBar>(87);
            __builder.AddAttribute(88, "CloseEventCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<ShutUp.Shared.Message>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<ShutUp.Shared.Message>(this, 
#nullable restore
#line 66 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                                                      Send

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(89, (__value) => {
#nullable restore
#line 66 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                writeMessageBar = (ShutUp.Client.Components.WriteMessageBar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(90, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\n");
#nullable restore
#line 68 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                    ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "col-sm-8 col-md-6 col-lg-4 mt-1 mb-3");
            __builder.AddMarkupContent(95, "\n                        ");
            __builder.OpenElement(96, "h2");
            __builder.AddAttribute(97, "class", "text-green text-center mt-5 plus");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                                                                                ShowWriteMessageBar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(99, "<span class=\"oi oi-plus mt-5\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\n");
#nullable restore
#line 74 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(102, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\n");
#nullable restore
#line 78 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Pages\Pinned.razor"

  
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserStateContainer _userState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageApiService _messageApi { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageStateContainer _messageState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
namespace __Blazor.ShutUp.Client.Pages.Pinned
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
