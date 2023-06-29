#pragma checksum "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "755dd0b3b95398517ebb4a3a6f2d4c263afcb2b1"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/recensioni")]
    public partial class Recensioni : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Recensioni");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenElement(4, "section");
            __builder.AddAttribute(5, "id", "about-us");
            __builder.AddAttribute(6, "b-ysffkezke9");
            __builder.AddMarkupContent(7, @"<div class=""title-wrapper d-flex justify-content-center align-items-center flex-column"" b-ysffkezke9><img src=""img/wine-banner.jpg"" class=""w-100 text-white"" alt b-ysffkezke9>

        <div class=""wrapper position-absolute text-center"" b-ysffkezke9><h2 class=""display-1 fw-bolder"" b-ysffkezke9>Recensioni</h2>
            <h4 class=""fs-4"" b-ysffkezke9>Parlano di noi...</h4></div></div>");
#nullable restore
#line 17 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor"
     if (ElencoRecensioni is not null) 
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container mt-5");
            __builder.AddAttribute(10, "b-ysffkezke9");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.AddAttribute(13, "b-ysffkezke9");
#nullable restore
#line 21 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor"
                 foreach (var recensione in ElencoRecensioni)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-12 col-sm-6 col-lg-4 d-flex justify-content-center pb-5");
            __builder.AddAttribute(16, "b-ysffkezke9");
            __builder.OpenComponent<Blazoteca.Shared.CardRecensione>(17);
            __builder.AddAttribute(18, "CorpoRecensione", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor"
                                             recensione.TestoRecensione

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "AccountSource", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor"
                                           recensione.Utente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ServiceSource", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor"
                                           recensione.Piattaforma

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<hr b-ysffkezke9>\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-wrapper w-100 w-sm-50 d-flex align-items-center justify-content-center flex-column p-4");
            __builder.AddAttribute(24, "b-ysffkezke9");
            __builder.AddMarkupContent(25, "<h3 class=\"fw-bolder\" b-ysffkezke9>Facci sapere la tua!</h3>\n        ");
            __builder.AddMarkupContent(26, "<h5 class=\"fs-6\" b-ysffkezke9>Complila il form sottostante</h5>\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-container h-100 mt-4 rounded");
            __builder.AddAttribute(29, "b-ysffkezke9");
            __builder.OpenElement(30, "form");
            __builder.AddAttribute(31, "id", "form");
            __builder.AddAttribute(32, "b-ysffkezke9");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group mt-3");
            __builder.AddAttribute(35, "b-ysffkezke9");
            __builder.AddMarkupContent(36, "<label for=\"InputNome\" b-ysffkezke9>Nome</label>\n                    ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "text");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "id", "InputNome");
            __builder.AddAttribute(41, "placeholder", "Inserisci il tuo nome");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor"
                                                                                 nuovaRecensione.Utente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovaRecensione.Utente = __value, nuovaRecensione.Utente));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(44, "b-ysffkezke9");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "form-group mt-3");
            __builder.AddAttribute(48, "b-ysffkezke9");
            __builder.AddMarkupContent(49, "<label for=\"InputEmail\" b-ysffkezke9>Indirizzo email</label>\n                    ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "email");
            __builder.AddAttribute(52, "class", "form-control");
            __builder.AddAttribute(53, "id", "InputEmail");
            __builder.AddAttribute(54, "aria-describedby", "emailHelp");
            __builder.AddAttribute(55, "placeholder", "Digita qui email");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor"
                                                                                   nuovaRecensione.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovaRecensione.Email = __value, nuovaRecensione.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(58, "b-ysffkezke9");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n                    ");
            __builder.AddMarkupContent(60, "<small id=\"emailHelp\" class=\"form-text text-muted\" b-ysffkezke9>Non condividiamo la tua mail con terze parti.</small>");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n                ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "form-group mt-3");
            __builder.AddAttribute(64, "b-ysffkezke9");
            __builder.AddMarkupContent(65, "<label for=\"InputOggetto\" b-ysffkezke9>Oggetto</label>\n                    ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "text");
            __builder.AddAttribute(68, "class", "form-control");
            __builder.AddAttribute(69, "id", "InputOggetto");
            __builder.AddAttribute(70, "placeholder", "Inserisci oggetto della recensione");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor"
                                                                                    nuovaRecensione.Oggetto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovaRecensione.Oggetto = __value, nuovaRecensione.Oggetto));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(73, "b-ysffkezke9");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n                ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "form-group mt-3");
            __builder.AddAttribute(77, "b-ysffkezke9");
            __builder.AddMarkupContent(78, "<label for=\"InputCorpo\" b-ysffkezke9>Corpo</label>\n                    ");
            __builder.OpenElement(79, "textarea");
            __builder.AddAttribute(80, "class", "textarea form-control");
            __builder.AddAttribute(81, "id", "InputCorpo");
            __builder.AddAttribute(82, "placeholder", "Inserisci il corpo della recensione");
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor"
                                                                                  nuovaRecensione.TestoRecensione

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nuovaRecensione.TestoRecensione = __value, nuovaRecensione.TestoRecensione));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(85, "b-ysffkezke9");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\n                \n                ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "btn-wrapper text-center");
            __builder.AddAttribute(89, "b-ysffkezke9");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "type", "submit");
            __builder.AddAttribute(92, "class", "btn mt-3");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor"
                                                                     AggiungiRecensione

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "b-ysffkezke9");
            __builder.AddMarkupContent(95, "<i class=\"bi bi-send\" b-ysffkezke9></i>\n                        ");
            __builder.AddMarkupContent(96, "<span b-ysffkezke9>Scrivi</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\nicho\Downloads\Blazoteca-GUI\Pages\Recensioni.razor"
       
    private Recensione[] ElencoRecensioni;
    private Recensione nuovaRecensione;
    
    protected override async Task OnInitializedAsync() {
        //ElencoRecensioni = await http.GetFromJsonAsync<Recensione[]>("api/recensioni");
        ElencoRecensioni = await DB.GetElencoRecensioni();
        
        nuovaRecensione = new Recensione();
    }

    protected async Task AggiungiRecensione() {
        var risultato = await DB.AggiungiRecensione(nuovaRecensione);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DBBottiglie DB { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Messaggio msg { get; set; }
    }
}
#pragma warning restore 1591