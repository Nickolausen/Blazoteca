#pragma checksum "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e96768e8a4b854400652676cdbe919670f7db71"
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
    public partial class InEvidenza : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "id", "in-evidenza");
            __builder.AddAttribute(2, "class", "p-4");
            __builder.AddMarkupContent(3, "<h2 class=\"display-6 fw-bolder\">In evidenza</h2>\n\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container-fluid");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
#nullable restore
#line 9 "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor"
             if (ElencoBottiglie is not null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor"
                 for(int i = 1; i < MaxItems; i++) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-12 col-md-6 col-lg-4 col-xxl-3 pt-5 d-flex justify-content-center align-items-center");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "href", "/dettaglio/" + (
#nullable restore
#line 13 "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor"
                                             ElencoBottiglie[i].ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "class", "h-100");
            __builder.OpenComponent<global::Blazoteca.Shared.Card>(13);
            __builder.AddAttribute(14, "NomeVino", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 15 "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor"
                                          ElencoBottiglie[i].Nome

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "AnnoProduzione", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 16 "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor"
                                                ElencoBottiglie[i].AnnoProduzione

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ProvinciaProduzione", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 17 "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor"
                                                     ElencoBottiglie[i].ProvinciaProduzione

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "Prezzo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Double>(
#nullable restore
#line 18 "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor"
                                        ElencoBottiglie[i].Prezzo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "PercSconto", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 19 "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor"
                                            ElencoBottiglie[i].PercentualeSconto

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "ImgPath", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 20 "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor"
                                         ElencoBottiglie[i].PercorsoImmagine

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor"
       
    [Parameter]
    public int MaxItems { get; set; }    
    private Bottiglia[] ElencoBottiglie; 
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\nicho\Documents\GitHub\Blazoteca\Shared\InEvidenza.razor"
        
    
    protected override async Task OnInitializedAsync() {
        ElencoBottiglie = await DB.GetElencoBottiglie();
        MaxItems = ElencoBottiglie.Length;
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DBBottiglie DB { get; set; }
    }
}
#pragma warning restore 1591
