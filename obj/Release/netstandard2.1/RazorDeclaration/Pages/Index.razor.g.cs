#pragma checksum "C:\Users\rober\Source\Repos\Switchel_PWA\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cd64d5d70a80d5d62784fcf01edbfa686a3f5c6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Switchel_PWA.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\rober\Source\Repos\Switchel_PWA\Pages\Index.razor"
       

    public class OpenOrder
    {
        public string recipient { get; set; }
        public string productName { get; set; }
        public DateTime day { get; set; }
        public string status { get; set; }
    }

    List<OpenOrder> openOrders = new List<OpenOrder>();

    OpenOrder test;

    List<OpenOrder> tests = new List<OpenOrder>();

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await js.InvokeVoidAsync("initializeCounterComponent");
        }
    }

    protected override async Task OnInitializedAsync()
    {
        if (await localStorage.GetItemAsync<List<OpenOrder>>("openOrders") ==  null)
        {
            test = new OpenOrder();
            test.recipient = " ";
            test.productName = " ";
            test.day = DateTime.Today;

            tests.Add(test);

            await localStorage.SetItemAsync("openOrders", tests);
            var openOrders = await localStorage.GetItemAsync<List<OpenOrder>>("openOrders");
        }
        else
        {
            openOrders = await localStorage.GetItemAsync<List<OpenOrder>>("openOrders");
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
