#pragma checksum "C:\Users\nicho\Documents\GitHub\Blazoteca\Pages\ChiSiamo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "171a5c01fbbea2949efd31bb16e764f0657d1b65"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/chi-siamo")]
    public partial class ChiSiamo : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Blazoteca.Shared.Hero>(0);
            __builder.AddAttribute(1, "Title", (object)("Chi siamo"));
            __builder.AddAttribute(2, "Subtitle", (object)("Un\'importante storia di successi alle spalle"));
            __builder.AddAttribute(3, "ImgPath1", (object)("./img/sedeopenday.jpg"));
            __builder.AddAttribute(4, "ImgPath2", (object)("./img/sedeopenday.jpg"));
            __builder.AddAttribute(5, "ImgPath3", (object)("./img/sedeopenday.jpg"));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.AddMarkupContent(7, "<section class=\"p-3\" b-9fy280aeix><p class=\"mt-4 text-center fs-4\" b-9fy280aeix>L\'I.T.T. \"Blaise Pascal\" offre massime competenze <span class=\"important\" b-9fy280aeix>informatiche</span>, <span class=\"important\" b-9fy280aeix>elettroniche</span>, in <span class=\"important\" b-9fy280aeix>automazione</span> e in<br b-9fy280aeix><span class=\"important\" b-9fy280aeix>telecomunicazioni</span> a livello <span class=\"important\" b-9fy280aeix>provinciale</span> sin dal 1959.</p>\r\n\r\n    <p class=\"mt-4 text-center fs-4\" b-9fy280aeix>Le discipline tecniche, grazie al <span class=\"important\" b-9fy280aeix>30% delle ore di lezione</span> dedicate alle attività di laboratorio,<br b-9fy280aeix>\r\n    guidano lo studente nel percorso che dall’<span class=\"important\" b-9fy280aeix>analisi del problema</span> porta<br b-9fy280aeix>alla <span class=\"important\" b-9fy280aeix>progettazione</span> ed alla <span class=\"important\" b-9fy280aeix>implementazione</span> della <span class=\"important\" b-9fy280aeix>soluzione</span></p>\r\n\r\n    <div class=\"container-fluid mt-4 px-0\" b-9fy280aeix><div class=\"row\" b-9fy280aeix><div class=\"col-12 col-md-4\" b-9fy280aeix><img class=\"w-100\" src=\"./img/olinfo.png\" b-9fy280aeix></div>\r\n            <div class=\"col-12 col-md-4 mt-4 mt-md-0\" b-9fy280aeix><img class=\"w-100\" src=\"./img/SR.png\" b-9fy280aeix>\r\n                <video autoplay muted loop class=\"w-100 mt-3\" b-9fy280aeix><source src=\"./media/video-lab-2.mp4\" type=\"video/mp4\" b-9fy280aeix></video></div>\r\n            <div class=\"col-12 col-md-4 mt-4 mt-md-0\" b-9fy280aeix><video autoplay muted loop class=\"w-100\" b-9fy280aeix><source src=\"./media/video-lab.mp4\" type=\"video/mp4\" b-9fy280aeix></video>\r\n                <img class=\"w-100 mt-3\" src=\"./img/showcase-1.jpeg\" b-9fy280aeix></div></div></div>\r\n    <hr class=\"mt-5\" b-9fy280aeix>\r\n    <h2 class=\"mt-3 fw-bold fs-2\" b-9fy280aeix>Informazioni generali</h2>\r\n    <div class=\"container-fluid px-0 fs-5 mt-3\" b-9fy280aeix><div class=\"row\" b-9fy280aeix><div class=\"col-12 col-md-6\" b-9fy280aeix><i class=\"bi bi-geo-alt-fill\" b-9fy280aeix></i> P.le Macrelli, 100 – 47521 Cesena (FC)<br b-9fy280aeix>\r\n                <i class=\"bi bi-telephone-fill\" b-9fy280aeix></i> tel. +39 0547 22792 (plesso Pascal)  –  +39 0547 631656 (plesso Comandini)<br b-9fy280aeix>\r\n                <i class=\"bi bi-braces\" b-9fy280aeix></i> <span class=\"important\" b-9fy280aeix>CODICE SCUOLA</span>: FOIS01100L<br b-9fy280aeix>\r\n                <i class=\"bi bi-envelope\" b-9fy280aeix></i> <span class=\"important\" b-9fy280aeix>EMAIL PROTOCOLLO</span>: fois01100l@istruzione.it<br b-9fy280aeix></div>\r\n            <div class=\"col-12 col-md-6\" b-9fy280aeix><i class=\"bi bi-envelope\" b-9fy280aeix></i> <span class=\"important\" b-9fy280aeix>POSTA CERTIFICATA</span>: fois01100l@pec.istruzione.it<br b-9fy280aeix>\r\n                <i class=\"bi bi-braces\" b-9fy280aeix></i> <span class=\"important\" b-9fy280aeix>CODICE IPA</span>: iisspc<br b-9fy280aeix>\r\n                <i class=\"bi bi-person-square\" b-9fy280aeix></i> <span class=\"important\" b-9fy280aeix>CODICE FISCALE</span>: 90076540401<br b-9fy280aeix>\r\n                <i class=\"bi bi-braces\" b-9fy280aeix></i> <span class=\"important\" b-9fy280aeix>CODICE UNIVOCO FATTURAZIONE</span>:  UFBAPW<br b-9fy280aeix></div></div></div></section>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
