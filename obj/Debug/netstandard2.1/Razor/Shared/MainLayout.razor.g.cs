#pragma checksum "C:\Users\rober\Source\Repos\Switchel_PWA\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe7db646a67899fc56a2bbf4a6fca8754eae3617"
// <auto-generated/>
#pragma warning disable 1591
namespace Switchel_PWA.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Switchel_PWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Switchel_PWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Switchel_PWA.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using MongoDB.Driver;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using MongoDB.Driver.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using MongoDB.Bson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Microsoft.Azure.Cosmos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Switchel_PWA.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Microsoft.EntityFrameworkCore.Cosmos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\rober\Source\Repos\Switchel_PWA\_Imports.razor"
using Switchel_PWA.Data;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Switchel_PWA.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "content px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddContent(12, 
#nullable restore
#line 13 "C:\Users\rober\Source\Repos\Switchel_PWA\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
