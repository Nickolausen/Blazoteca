#pragma checksum "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CardRecensione.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd8a41bd31dae16d87dddd6caf6f626b577b99be"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazoteca.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicho\Downloads\Blazoteca-GUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicho\Downloads\Blazoteca-GUI\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicho\Downloads\Blazoteca-GUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicho\Downloads\Blazoteca-GUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicho\Downloads\Blazoteca-GUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicho\Downloads\Blazoteca-GUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicho\Downloads\Blazoteca-GUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicho\Downloads\Blazoteca-GUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicho\Downloads\Blazoteca-GUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicho\Downloads\Blazoteca-GUI\_Imports.razor"
using Blazoteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicho\Downloads\Blazoteca-GUI\_Imports.razor"
using Blazoteca.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicho\Downloads\Blazoteca-GUI\_Imports.razor"
using Blazoteca.Data;

#line default
#line hidden
#nullable disable
    public partial class CardRecensione : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card w-100 w-sm-75 h-100");
            __builder.AddAttribute(2, "b-91mijsqxjf");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddAttribute(5, "b-91mijsqxjf");
            __builder.OpenElement(6, "blockquote");
            __builder.AddAttribute(7, "class", "blockquote mb-0");
            __builder.AddAttribute(8, "b-91mijsqxjf");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "b-91mijsqxjf");
#nullable restore
#line (4,17)-(4,32) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CardRecensione.razor"
__builder.AddContent(11, CorpoRecensione);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n            ");
            __builder.OpenElement(13, "footer");
            __builder.AddAttribute(14, "class", "blockquote-footer pt-2");
            __builder.AddAttribute(15, "b-91mijsqxjf");
#nullable restore
#line (5,53)-(5,66) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CardRecensione.razor"
__builder.AddContent(16, AccountSource);

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, " su ");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "class", "fst-italic");
            __builder.AddAttribute(20, "b-91mijsqxjf");
#nullable restore
#line (5,96)-(5,109) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CardRecensione.razor"
__builder.AddContent(21, ServiceSource);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CardRecensione.razor"
       

    [Parameter]
    public string AccountSource { get; set; }

    [Parameter]
    public string ServiceSource { get; set; }

    [Parameter]
    public string CorpoRecensione { get; set; }
    


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
