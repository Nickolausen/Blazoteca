#pragma checksum "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Carrello.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "935b7a4417789cc33a900da9592bb5f3cb7364d9"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazoteca.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicho\Documents\GitHub\Blazoteca\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicho\Documents\GitHub\Blazoteca\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicho\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicho\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicho\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicho\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicho\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicho\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicho\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicho\Documents\GitHub\Blazoteca\_Imports.razor"
using Blazoteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicho\Documents\GitHub\Blazoteca\_Imports.razor"
using Blazoteca.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicho\Documents\GitHub\Blazoteca\_Imports.razor"
using Blazoteca.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/carrello")]
    public partial class Carrello : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "pt-5 pb-5");
            __builder.AddAttribute(2, "b-jyc1m5lllj");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddAttribute(5, "b-jyc1m5lllj");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row w-100");
            __builder.AddAttribute(8, "b-jyc1m5lllj");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-lg-12 col-md-12 col-12");
            __builder.AddAttribute(11, "b-jyc1m5lllj");
            __builder.AddMarkupContent(12, "<h3 class=\"display-5 mb-2 text-center\" b-jyc1m5lllj>Carrello</h3>\r\n            ");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "id", "shoppingCart");
            __builder.AddAttribute(15, "class", "table table-condensed table-responsive");
            __builder.AddAttribute(16, "b-jyc1m5lllj");
            __builder.AddMarkupContent(17, @"<thead b-jyc1m5lllj><tr b-jyc1m5lllj><th style=""width:60%"" b-jyc1m5lllj>Prodotti</th>
                        <th style=""width:12%"" b-jyc1m5lllj>Prezzo</th>
                        <th style=""width:10%"" b-jyc1m5lllj>Q.tà</th>
                        <th style=""width:16%"" b-jyc1m5lllj></th></tr></thead>
                ");
            __builder.OpenElement(18, "tbody");
            __builder.AddAttribute(19, "b-jyc1m5lllj");
            __builder.OpenElement(20, "tr");
            __builder.AddAttribute(21, "b-jyc1m5lllj");
            __builder.OpenComponent<Blazoteca.Shared.CardCarrello>(22);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "tr");
            __builder.AddAttribute(25, "b-jyc1m5lllj");
            __builder.OpenComponent<Blazoteca.Shared.CardCarrello>(26);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "tr");
            __builder.AddAttribute(29, "b-jyc1m5lllj");
            __builder.OpenComponent<Blazoteca.Shared.CardCarrello>(30);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n            ");
            __builder.AddMarkupContent(32, @"<div class=""d-flex justify-content-between pt-3"" b-jyc1m5lllj><div b-jyc1m5lllj><h4 b-jyc1m5lllj>Totale:</h4>
                    <h1 b-jyc1m5lllj>$99.00</h1></div>


                <button type=""submit"" class=""btn mt-3 h-50"" b-jyc1m5lllj><i class=""oi oi-cart"" b-jyc1m5lllj></i>
                    <span b-jyc1m5lllj>Acquista</span></button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591