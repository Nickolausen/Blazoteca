#pragma checksum "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomNavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c15077f81c7a3bac2d2497cbfd2362aff643025"
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
    public partial class CustomNavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-dark bg-dark navbar-sticky-top");
            __builder.AddAttribute(2, "b-9chp4s6w9u");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container px-4 px-lg-5");
            __builder.AddAttribute(5, "b-9chp4s6w9u");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand\" href Match=\"NavLinkMatch.All\" b-9chp4s6w9u>Blazoteca</a>\n        ");
            __builder.AddMarkupContent(7, @"<button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"" b-9chp4s6w9u><span class=""navbar-toggler-icon"" b-9chp4s6w9u></span></button>
        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "collapse navbar-collapse");
            __builder.AddAttribute(10, "id", "navbarSupportedContent");
            __builder.AddAttribute(11, "b-9chp4s6w9u");
            __builder.OpenElement(12, "ul");
            __builder.AddAttribute(13, "class", "navbar-nav me-auto mb-2 mb-lg-0 ms-lg-4 d-flex");
            __builder.AddAttribute(14, "b-9chp4s6w9u");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "nav-item");
            __builder.AddAttribute(17, "b-9chp4s6w9u");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "class", "nav-link");
            __builder.AddAttribute(20, "href", "");
            __builder.AddAttribute(21, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 22 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomNavMenu.razor"
                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(23, "<span class=\"ms-2 ms-lg-0\" aria-current=\"page\" b-9chp4s6w9u>Home</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                \n                ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "nav-item");
            __builder.AddAttribute(27, "b-9chp4s6w9u");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
            __builder.AddAttribute(29, "class", "nav-link");
            __builder.AddAttribute(30, "href", "recensioni");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(32, "<span class=\"ms-2 ms-lg-0\" b-9chp4s6w9u>Recensioni</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n                ");
            __builder.OpenElement(34, "li");
            __builder.AddAttribute(35, "class", "nav-item");
            __builder.AddAttribute(36, "b-9chp4s6w9u");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
            __builder.AddAttribute(38, "class", "nav-link");
            __builder.AddAttribute(39, "href", "shop");
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(41, "<span class=\"ms-2 ms-lg-0\" b-9chp4s6w9u>Shop</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n\n            ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", "carrello");
            __builder.AddAttribute(45, "b-9chp4s6w9u");
            __builder.OpenElement(46, "form");
            __builder.AddAttribute(47, "class", "d-flex mb-2 mb-lg-0");
            __builder.AddAttribute(48, "b-9chp4s6w9u");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "btn");
            __builder.AddAttribute(51, "b-9chp4s6w9u");
            __builder.AddMarkupContent(52, "<i class=\"oi oi-cart\" b-9chp4s6w9u></i>\n                        Carrello\n                        ");
            __builder.OpenElement(53, "span");
            __builder.AddAttribute(54, "class", "badge bg-dark text-white ms-1 rounded-pill");
            __builder.AddAttribute(55, "b-9chp4s6w9u");
#nullable restore
#line (45,83)-(45,93) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomNavMenu.razor"
__builder.AddContent(56, ItemsCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomNavMenu.razor"
             if (sessione.UtenteLoggato) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "a");
            __builder.AddAttribute(58, "href", "login");
            __builder.AddAttribute(59, "b-9chp4s6w9u");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "class", "btn mx-3");
            __builder.AddAttribute(62, "b-9chp4s6w9u");
            __builder.AddMarkupContent(63, "<i class=\"bi bi-file-person-fill\" b-9chp4s6w9u></i>\n                        ");
#nullable restore
#line (53,26)-(53,40) 25 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomNavMenu.razor"
__builder.AddContent(64, utente.Account);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomNavMenu.razor"
            }
            else {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(65, "<a href=\"login\" b-9chp4s6w9u><button class=\"btn mx-3\" b-9chp4s6w9u><i class=\"bi bi-login\" b-9chp4s6w9u></i>\n                        Login\n                    </button></a>");
#nullable restore
#line 64 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomNavMenu.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomNavMenu.razor"
             if (sessione.UtenteLoggato) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "button");
            __builder.AddAttribute(67, "class", "btn");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomNavMenu.razor"
                                              AnnullaLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "b-9chp4s6w9u");
            __builder.AddMarkupContent(70, "<i class=\"bi bi-exit\" b-9chp4s6w9u></i>\n                    ");
            __builder.AddMarkupContent(71, "<span class=\"badge bg-dark text-white ms-1 rounded-pill\" b-9chp4s6w9u>Esci</span>");
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomNavMenu.razor"
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
#line 76 "C:\Users\nicho\Downloads\Blazoteca-GUI\Shared\CustomNavMenu.razor"
 
    [Parameter]
    public int ItemsCount { get; set; }

    protected override void OnInitialized() {
        ItemsCount = sessione.Articoli.Count;        
    }

    protected override void OnAfterRender(bool firstRender) {
        ItemsCount = sessione.Articoli.Count;
        StateHasChanged();

    }

    protected void AnnullaLogin() {
        sessione.UtenteLoggato = false;
        StateHasChanged();

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Utente utente { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Sessione sessione { get; set; }
    }
}
#pragma warning restore 1591