#pragma checksum "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Components\AnswerMessage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f49893cfcf67fec496c0d892e75d35f2b57e10e"
// <auto-generated/>
#pragma warning disable 1591
namespace ShutUp.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 1 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Components\AnswerMessage.razor"
using ShutUp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Components\AnswerMessage.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public partial class AnswerMessage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Components\AnswerMessage.razor"
 if (!showForm)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-sm btn-chat");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Components\AnswerMessage.razor"
                                                   ShowForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Skriv ett svar");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 7 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Components\AnswerMessage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Components\AnswerMessage.razor"
                  subMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", "col ml-5");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(11);
                __builder2.AddAttribute(12, "class", "text-box rounded");
                __builder2.AddAttribute(13, "placeholder", "Vad vill du svara?");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Components\AnswerMessage.razor"
                                                                                           subMessage.MessageText

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => subMessage.MessageText = __value, subMessage.MessageText))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => subMessage.MessageText));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\n    ");
                __builder2.OpenElement(18, "button");
                __builder2.AddAttribute(19, "class", "btn btn-chat");
                __builder2.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Components\AnswerMessage.razor"
                                             e => Send(subMessage)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(21, "Skicka");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n    ");
                __builder2.OpenElement(23, "button");
                __builder2.AddAttribute(24, "class", "btn btn-sm");
                __builder2.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Components\AnswerMessage.razor"
                                          Undo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(26, "Ångra");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n");
#nullable restore
#line 15 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Components\AnswerMessage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\admin\Desktop\ShutUp\Meddelandecentralen\ShutUp\Client\Components\AnswerMessage.razor"
        
    [Parameter]
    public EventCallback<SubMessage> CloseEventCallback { get; set; }

    [CascadingParameter(Name = "MessageId")]
    private int MessageId { get; set; }

    public SubMessage subMessage { get; set; } = new SubMessage();

    public bool showForm;

    protected override async Task OnInitializedAsync()
    {
        showForm = false;
    }

    public async Task Send(SubMessage subMessage)
    {
        subMessage.MessageId = MessageId;
        await CloseEventCallback.InvokeAsync(subMessage);
        subMessage.MessageText = "";
        showForm = false;
        StateHasChanged();
    }
    public void ShowForm()
    {
        showForm = true;
        StateHasChanged();
    }
    public void Undo()
    {
        subMessage.MessageText = "";
        showForm = false;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
