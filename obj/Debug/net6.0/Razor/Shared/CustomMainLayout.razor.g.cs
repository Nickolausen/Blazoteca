#pragma checksum "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomMainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1498100a9e409774786c6531137f34d3821d26c9"
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
    public partial class CustomMainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazoteca.Shared.CustomNavMenu>(0);
            __builder.AddAttribute(1, "ItemsCount", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomMainLayout.razor"
                           ItemsCount

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n\n");
            __builder.OpenElement(3, "main");
            __builder.AddAttribute(4, "b-z8srr0w22p");
#nullable restore
#line (7,6)-(7,10) 24 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomMainLayout.razor"
__builder.AddContent(5, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n");
            __builder.OpenComponent<Blazoteca.Shared.Footer>(7);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomMainLayout.razor"
 
    public int ItemsCount { get; set; }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomMainLayout.razor"
        
    
    protected override void OnAfterRender(bool firstRender) {
        ItemsCount = sessione.Articoli.Count;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Sessione sessione { get; set; }
    }
}
#pragma warning restore 1591
