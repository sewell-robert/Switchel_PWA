#pragma checksum "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cd64d5d70a80d5d62784fcf01edbfa686a3f5c6"
// <auto-generated/>
#pragma warning disable 1591
namespace Switchel_PWA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\_Imports.razor"
using Switchel_PWA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\_Imports.razor"
using Switchel_PWA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\_Imports.razor"
using Switchel_PWA.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"opener\">\r\n    <h4 id=\"test\">Welcome to the Shawnee Switchel Digital Shop!</h4>\r\n    <p>Stop by every once and a while to get the latest on what\'s happening.</p>\r\n</div>\r\n\r\n");
            __builder.AddMarkupContent(1, "<a href=\"updates\" class=\"btn btn-dark btn-outline-light mb-2\">VIEW UPDATES</a>\r\n");
            __builder.AddMarkupContent(2, "<a href=\"order\" class=\"btn btn-outline-light mb-2 ml-auto btn-order\">PLACE ORDER</a>\r\n<br>\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card shadow");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-body");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, "<h4>Open Orders</h4>\r\n        <hr>\r\n");
#nullable restore
#line 18 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\Pages\Index.razor"
         if (openOrders.Count > 1)
        {
            foreach (var order in openOrders)
            {
                if (!string.IsNullOrWhiteSpace(order.recipient))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                    ");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, 
#nullable restore
#line 24 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\Pages\Index.razor"
                        order.recipient

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " order for ");
            __builder.AddContent(14, 
#nullable restore
#line 24 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\Pages\Index.razor"
                                                   order.productName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " was successfully submitted on ");
            __builder.AddContent(16, 
#nullable restore
#line 24 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\Pages\Index.razor"
                                                                                                    order.day

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, "!");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "<br>\r\n");
#nullable restore
#line 25 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\Pages\Index.razor"
                }
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "            ");
            __builder.AddMarkupContent(20, "<p>There are no open orders at this time.</p>\r\n");
#nullable restore
#line 31 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.AddMarkupContent(24, "<button id=\"notifications\" class=\"btn btn-dark\" hidden>Don\'t Click ME!</button>");
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Bobby's Ultrabook\source\repos\Switchel_PWA\Pages\Index.razor"
       

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
