#pragma checksum "C:\Y23\app\Surveymatic\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7672d62a7a072b7f8d7748c8827c6870c97e339e"
// <auto-generated/>
#pragma warning disable 1591
namespace Surveymatic.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Y23\app\Surveymatic\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Y23\app\Surveymatic\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Y23\app\Surveymatic\_Imports.razor"
using Surveymatic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Y23\app\Surveymatic\_Imports.razor"
using Surveymatic.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-s9kp10hdbq");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-s9kp10hdbq");
            __builder.OpenComponent<Surveymatic.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-s9kp10hdbq");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-s9kp10hdbq");
            __builder.OpenComponent<Surveymatic.Shared.AccessControl>(14);
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n              \r\n            ");
            __builder.AddMarkupContent(16, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-s9kp10hdbq>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "content px-4");
            __builder.AddAttribute(20, "b-s9kp10hdbq");
            __builder.AddContent(21, 
#nullable restore
#line 17 "C:\Y23\app\Surveymatic\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
