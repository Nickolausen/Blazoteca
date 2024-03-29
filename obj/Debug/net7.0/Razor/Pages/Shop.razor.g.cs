#pragma checksum "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c817b37749ed9e4aaf3b7753c3f439c07f37fd12"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/shop")]
    public partial class Shop : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Blazoteca 5F");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenElement(4, "section");
            __builder.AddAttribute(5, "id", "shop");
            __builder.AddAttribute(6, "class", "p-4");
            __builder.AddAttribute(7, "b-qp06d3d39a");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container");
            __builder.AddAttribute(10, "b-qp06d3d39a");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row d-flex align-items-center justify-content-center py-5");
            __builder.AddAttribute(13, "b-qp06d3d39a");
            __builder.AddMarkupContent(14, "<div class=\"col\" b-qp06d3d39a><h2 class=\"fs-1 fw-bolder\" b-qp06d3d39a>Shop</h2></div>\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col d-flex flex-row justify-content-end align-items-center");
            __builder.AddAttribute(17, "b-qp06d3d39a");
            __builder.OpenElement(18, "form");
            __builder.AddAttribute(19, "id", "form");
            __builder.AddAttribute(20, "b-qp06d3d39a");
            __builder.AddMarkupContent(21, "<label for=\"sortby\" class=\"pe-2\" b-qp06d3d39a>Filtra per:</label>\n                    ");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "id", "sortby");
            __builder.AddAttribute(24, "class", "form-select form-select-sm");
            __builder.AddAttribute(25, "aria-label", "Sortby selection");
            __builder.AddAttribute(26, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
                                                                                                                AggiornaFiltro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => AggiornaFiltro = __value, AggiornaFiltro));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(28, "b-qp06d3d39a");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "selected");
            __builder.AddAttribute(31, "value", "bottiglie");
            __builder.AddAttribute(32, "b-qp06d3d39a");
            __builder.AddContent(33, "-- Seleziona filtro --");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                        ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", "asc");
            __builder.AddAttribute(37, "b-qp06d3d39a");
            __builder.AddContent(38, "Prezzo (crescente)");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n                        ");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", "desc");
            __builder.AddAttribute(42, "b-qp06d3d39a");
            __builder.AddContent(43, "Prezzo (decrescente)");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n\n    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "container-fluid");
            __builder.AddAttribute(47, "b-qp06d3d39a");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row");
            __builder.AddAttribute(50, "b-qp06d3d39a");
#nullable restore
#line 28 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
                 if (ElencoBottiglie is not null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
                     for(int i = 0; i < ElencoBottiglie.Length; i++) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col-12 col-md-6 col-lg-4 col-xxl-3 pt-5 d-flex justify-content-center align-items-center");
            __builder.AddAttribute(53, "b-qp06d3d39a");
            __builder.OpenElement(54, "a");
            __builder.AddAttribute(55, "href", "/dettaglio/" + (
#nullable restore
#line 32 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
                                                 ElencoBottiglie[i].ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "class", "h-100");
            __builder.AddAttribute(57, "b-qp06d3d39a");
            __builder.OpenComponent<global::Blazoteca.Shared.Card>(58);
            __builder.AddAttribute(59, "NomeVino", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 34 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
                                              ElencoBottiglie[i].Nome

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(60, "AnnoProduzione", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 35 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
                                                    ElencoBottiglie[i].AnnoProduzione

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(61, "ProvinciaProduzione", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 36 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
                                                         ElencoBottiglie[i].ProvinciaProduzione

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(62, "Prezzo", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Double>(
#nullable restore
#line 37 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
                                            ElencoBottiglie[i].Prezzo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(63, "PercSconto", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 38 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
                                                ElencoBottiglie[i].PercentualeSconto

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(64, "ImgPath", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 39 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
                                             ElencoBottiglie[i].PercorsoImmagine

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
                     
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
#line 48 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
      

    [Parameter]
    public int MaxItems { get; set; }
    public Bottiglia[] ElencoBottiglie;
    

    public string SelectedFilter { get; set; } = "bottiglie";
    public string AggiornaFiltro { 
        get { return SelectedFilter; }
        set { SelectedFilter = value; this.FilterBy(); }
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\Shop.razor"
        

    protected override async Task OnInitializedAsync() {
        ElencoBottiglie = await DB.GetElencoBottiglie();
        MaxItems = ElencoBottiglie.Length;
        this.FilterBy();
    }

    public void FilterBy() 
    {
        //ElencoBottiglie = await http.GetFromJsonAsync<Bottiglia[]>("api/" + SelectedFilter);
        switch (SelectedFilter) {
            case "asc":
                ElencoBottiglie = ElencoBottiglie.OrderBy(b => b.Prezzo).ToArray();
            break;
            case "desc":
                ElencoBottiglie = ElencoBottiglie.OrderByDescending(b => b.Prezzo).ToArray();
            break;
            default:
            break;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DBBottiglie DB { get; set; }
    }
}
#pragma warning restore 1591
