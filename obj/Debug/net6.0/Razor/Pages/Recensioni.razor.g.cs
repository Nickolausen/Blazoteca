#pragma checksum "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\Pages\Recensioni.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93433d9d5d8a086c63a0da0e33d85c0035200c3e"
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
#line 1 "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\_Imports.razor"
using Blazoteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\_Imports.razor"
using Blazoteca.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\_Imports.razor"
using Blazoteca.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/recensioni")]
    public partial class Recensioni : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Recensioni");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "section");
            __builder.AddAttribute(5, "id", "about-us");
            __builder.AddAttribute(6, "b-ysffkezke9");
            __builder.AddMarkupContent(7, @"<div class=""title-wrapper d-flex justify-content-center align-items-center flex-column"" b-ysffkezke9><img src=""img/wine-banner.jpg"" class=""w-100 text-white"" alt b-ysffkezke9>

        <div class=""wrapper position-absolute text-center"" b-ysffkezke9><h2 class=""display-1 fw-bolder"" b-ysffkezke9>Recensioni</h2>
            <h4 class=""fs-4"" b-ysffkezke9>Parlano di noi...</h4></div></div>


    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container mt-5");
            __builder.AddAttribute(10, "b-ysffkezke9");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.AddAttribute(13, "b-ysffkezke9");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-12 col-sm-6 col-lg-4 d-flex justify-content-center pb-5");
            __builder.AddAttribute(16, "b-ysffkezke9");
            __builder.OpenComponent<global::Blazoteca.Shared.CardRecensione>(17);
            __builder.AddAttribute(18, "CorpoRecensione", "Spedizione veloce, ampia possibilità di scelta e assistenza sempre disponibile.");
            __builder.AddAttribute(19, "AccountSource", "Michele Mambelli");
            __builder.AddAttribute(20, "ServiceSource", "Facebook");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-12 col-sm-6 col-lg-4 d-flex justify-content-center pb-5");
            __builder.AddAttribute(24, "b-ysffkezke9");
            __builder.OpenComponent<global::Blazoteca.Shared.CardRecensione>(25);
            __builder.AddAttribute(26, "CorpoRecensione", "I migliori del settore.");
            __builder.AddAttribute(27, "AccountSource", "Pasquale Santini");
            __builder.AddAttribute(28, "ServiceSource", "Recensioni Google");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-12 col-sm-6 col-lg-4 d-flex justify-content-center pb-5");
            __builder.AddAttribute(32, "b-ysffkezke9");
            __builder.OpenComponent<global::Blazoteca.Shared.CardRecensione>(33);
            __builder.AddAttribute(34, "CorpoRecensione", "Esperienza positiva. La scelta dei vini é abbastanza varia per essere un enoteca online e con una qualità medio-alta.");
            __builder.AddAttribute(35, "AccountSource", "Francesco Buda");
            __builder.AddAttribute(36, "ServiceSource", "Trustpilot");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-12 col-sm-6 col-lg-4 d-flex justify-content-center pb-5");
            __builder.AddAttribute(40, "b-ysffkezke9");
            __builder.OpenComponent<global::Blazoteca.Shared.CardRecensione>(41);
            __builder.AddAttribute(42, "CorpoRecensione", "Ho ordinato più volte del vino e qualche volta anche amari, arrivati ghiacciati e pronti al consumo.");
            __builder.AddAttribute(43, "AccountSource", "Marco Crogioli");
            __builder.AddAttribute(44, "ServiceSource", "Recensioni Google");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n\r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-12 col-sm-6 col-lg-4 d-flex justify-content-center pb-5");
            __builder.AddAttribute(48, "b-ysffkezke9");
            __builder.OpenComponent<global::Blazoteca.Shared.CardRecensione>(49);
            __builder.AddAttribute(50, "CorpoRecensione", "Ottimo servizio personalizzato in base alle preferenze ed esigenze del cliente!");
            __builder.AddAttribute(51, "AccountSource", "Pietro Gallo");
            __builder.AddAttribute(52, "ServiceSource", "Twitter");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            \r\n            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-12 col-sm-6 col-lg-4 d-flex justify-content-center pb-5");
            __builder.AddAttribute(56, "b-ysffkezke9");
            __builder.OpenComponent<global::Blazoteca.Shared.CardRecensione>(57);
            __builder.AddAttribute(58, "CorpoRecensione", "Consigliatissimo!");
            __builder.AddAttribute(59, "AccountSource", "Domenico Bini");
            __builder.AddAttribute(60, "ServiceSource", "Recensioni Google");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n    <hr b-ysffkezke9>\r\n    ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "form-wrapper w-100 w-sm-50 d-flex align-items-center justify-content-center flex-column p-4");
            __builder.AddAttribute(64, "b-ysffkezke9");
            __builder.AddMarkupContent(65, "<h3 class=\"fw-bolder\" b-ysffkezke9>Facci sapere la tua!</h3>\r\n        ");
            __builder.AddMarkupContent(66, "<h5 class=\"fs-6\" b-ysffkezke9>Complila il form sottostante</h5>\r\n        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form-container h-100 mt-4 rounded");
            __builder.AddAttribute(69, "b-ysffkezke9");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(70);
            __builder.AddAttribute(71, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 68 "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\Pages\Recensioni.razor"
                             msg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(73, "DataAnnotationValidator");
                __builder2.AddAttribute(74, "b-ysffkezke9");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.AddMarkupContent(76, "<div class=\"form-group mt-3\" b-ysffkezke9><label for=\"InputNome\" b-ysffkezke9>Nome</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"InputNome\" placeholder=\"Inserisci il tuo nome\" b-ysffkezke9></div>\r\n                ");
                __builder2.AddMarkupContent(77, @"<div class=""form-group mt-3"" b-ysffkezke9><label for=""InputEmail"" b-ysffkezke9>Indirizzo email</label>
                    <input type=""email"" class=""form-control"" id=""InputEmail"" aria-describedby=""emailHelp"" placeholder=""Digita qui email"" b-ysffkezke9>
                    <small id=""emailHelp"" class=""form-text text-muted"" b-ysffkezke9>Non condividiamo la tua mail con terze parti.</small></div>
                ");
                __builder2.AddMarkupContent(78, @"<div class=""form-group mt-3"" b-ysffkezke9><label for=""InputOggetto"" b-ysffkezke9>Oggetto</label>
                    <input type=""text"" class=""form-control"" id=""InputOggetto"" placeholder=""Inserisci oggetto della recensione"" b-ysffkezke9></div>
                ");
                __builder2.AddMarkupContent(79, @"<div class=""form-group mt-3"" b-ysffkezke9><label for=""InputCorpo"" b-ysffkezke9>Corpo</label>
                    <input type=""text"" class=""form-control"" id=""InputCorpo"" placeholder=""Inserisci il corpo della recensione"" b-ysffkezke9></div>
                
                ");
                __builder2.AddMarkupContent(80, @"<div class=""btn-wrapper text-center"" b-ysffkezke9><button type=""submit"" class=""btn mt-3"" b-ysffkezke9><svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" viewBox=""0 0 16 16"" b-ysffkezke9><path d=""M15.854.146a.5.5 0 0 1 .11.54l-5.819 14.547a.75.75 0 0 1-1.329.124l-3.178-4.995L.643 7.184a.75.75 0 0 1 .124-1.33L15.314.037a.5.5 0 0 1 .54.11ZM6.636 10.07l2.761 4.338L14.13 2.576 6.636 10.07Zm6.787-8.201L1.591 6.602l4.339 2.76 7.494-7.493Z"" b-ysffkezke9></path></svg>
                        <span b-ysffkezke9>Scrivi</span></button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\nicholas.magi\Documents\GitHub\Blazoteca\Pages\Recensioni.razor"
       
    private Recensione[]? ElencoRecensioni;
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Messaggio msg { get; set; }
    }
}
#pragma warning restore 1591
