#pragma checksum "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c9ef3f3298375dcdba1c175134873b2a1c22ef9"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/dettaglio/{ID:int}")]
    public partial class Dettaglio : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
 if (bot is not null) 
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-5 pt-4");
            __builder.AddAttribute(2, "b-an7i3lrfic");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddAttribute(5, "b-an7i3lrfic");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-12 col-md-4 position-relative d-flex justify-content-center");
            __builder.AddAttribute(8, "b-an7i3lrfic");
#nullable restore
#line 12 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
                 if (bot.PercentualeSconto != 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<span class=\"badge badge-secondary text-uppercase\" b-an7i3lrfic>Offerta</span>");
#nullable restore
#line 15 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "class", "w-100");
            __builder.AddAttribute(12, "src", 
#nullable restore
#line 16 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
                                        bot.PercorsoImmagine

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "b-an7i3lrfic");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-12 col-md-8 mt-3 mt-md-0");
            __builder.AddAttribute(17, "b-an7i3lrfic");
            __builder.OpenElement(18, "h1");
            __builder.AddAttribute(19, "class", "fw-bold");
            __builder.AddAttribute(20, "b-an7i3lrfic");
#nullable restore
#line (20,38)-(20,46) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
__builder.AddContent(21, bot.Nome);

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, " - ");
#nullable restore
#line (20,50)-(20,68) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
__builder.AddContent(23, bot.AnnoProduzione);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                ");
            __builder.OpenElement(25, "h2");
            __builder.AddAttribute(26, "class", "text-secondary fs-5 fw-lighter text-uppercase");
            __builder.AddAttribute(27, "b-an7i3lrfic");
#nullable restore
#line (21,76)-(21,99) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
__builder.AddContent(28, bot.ProvinciaProduzione);

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, " - ");
#nullable restore
#line (21,103)-(21,124) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
__builder.AddContent(30, bot.RegioneProduzione);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                <hr b-an7i3lrfic>\n                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "mb-3 d-flex flex-row align-items-center");
            __builder.AddAttribute(34, "b-an7i3lrfic");
            __builder.AddMarkupContent(35, "<i class=\"fs-4 bi bi-thermometer-half\" b-an7i3lrfic></i>\n                    ");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "ms-2 fs-5 fw-bold");
            __builder.AddAttribute(38, "b-an7i3lrfic");
#nullable restore
#line (25,55)-(25,85) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
__builder.AddContent(39, bot.Gradazione.ToString("0.0"));

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "°");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                ");
            __builder.OpenElement(42, "p");
            __builder.AddAttribute(43, "class", "text-secondary");
            __builder.AddAttribute(44, "b-an7i3lrfic");
#nullable restore
#line (27,44)-(27,59) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
__builder.AddContent(45, bot.Descrizione);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "mb-3 d-flex flex-row align-items-center");
            __builder.AddAttribute(49, "b-an7i3lrfic");
#nullable restore
#line 29 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
                     if (bot.PercentualeSconto == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "span");
            __builder.AddAttribute(51, "class", "fs-3 fw-bold");
            __builder.AddAttribute(52, "b-an7i3lrfic");
#nullable restore
#line (31,53)-(31,117) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
__builder.AddContent(53, Prezzo.ToString("C", CultureInfo.CreateSpecificCulture("it-IT")));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "span");
            __builder.AddAttribute(55, "class", "small old-price text-decoration-line-through fs-5 text-secondary");
            __builder.AddAttribute(56, "b-an7i3lrfic");
#nullable restore
#line (35,105)-(35,172) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
__builder.AddContent(57, FullPrice.ToString("C", CultureInfo.CreateSpecificCulture("it-IT")));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n                        ");
            __builder.OpenElement(59, "span");
            __builder.AddAttribute(60, "class", "ms-2 fw-bolder fs-3");
            __builder.AddAttribute(61, "b-an7i3lrfic");
#nullable restore
#line (36,60)-(36,124) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
__builder.AddContent(62, Prezzo.ToString("C", CultureInfo.CreateSpecificCulture("it-IT")));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n                ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "d-flex justify-content-center justify-content-md-start pt-3");
            __builder.AddAttribute(66, "b-an7i3lrfic");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "class", "btn text-center");
            __builder.AddAttribute(69, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
                                                              AggiungiArticolo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "b-an7i3lrfic");
            __builder.AddMarkupContent(71, "<i class=\"bi bi-cart3\" b-an7i3lrfic></i>\n                        ");
            __builder.AddMarkupContent(72, "<span b-an7i3lrfic>Aggiungi al carrello</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n                    ");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "class", "btn text-center mx-3");
            __builder.AddAttribute(76, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
                                                                   TornaIndietro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "b-an7i3lrfic");
            __builder.AddMarkupContent(78, "<i class=\"bi bi-arrow-up-left-circle\" b-an7i3lrfic></i>\n                        ");
            __builder.AddMarkupContent(79, "<span b-an7i3lrfic>Torna all\'elenco</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
       
    [Parameter]
    public int ID { get; set; }
    private Bottiglia bot;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Dettaglio.razor"
        

    protected override async Task OnInitializedAsync() {
        bot = await DB.GetBottiglia(ID);
        Prezzo = bot.Prezzo;
    }

    public double FullPrice { get; set; }
    public double Prezzo { 
        get
        {
            return FullPrice - (double)(FullPrice * bot.PercentualeSconto / 100);
        } 
        set
        {
            FullPrice = value;
        } 
    }

    protected void AggiungiArticolo() {
        sessione.Articoli.Add(ID);
    }

    protected void TornaIndietro() {
         NavigationManager.NavigateTo("/shop");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Sessione sessione { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DBBottiglie DB { get; set; }
    }
}
#pragma warning restore 1591