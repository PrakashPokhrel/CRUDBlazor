#pragma checksum "C:\Users\SIW\Source\Repos\CRUDBlazor\CRUDBlazor\Pages\Customer - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5b98fb598361247bd07da8edfd4849f9a21a57c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CRUDBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\SIW\Source\Repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SIW\Source\Repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SIW\Source\Repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SIW\Source\Repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SIW\Source\Repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SIW\Source\Repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SIW\Source\Repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using CRUDBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SIW\Source\Repos\CRUDBlazor\CRUDBlazor\_Imports.razor"
using CRUDBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SIW\Source\Repos\CRUDBlazor\CRUDBlazor\Pages\Customer - Copy.razor"
using CRUDBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SIW\Source\Repos\CRUDBlazor\CRUDBlazor\Pages\Customer - Copy.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SIW\Source\Repos\CRUDBlazor\CRUDBlazor\Pages\Customer - Copy.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Customer")]
    public class Customer___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\SIW\Source\Repos\CRUDBlazor\CRUDBlazor\Pages\Customer - Copy.razor"
       
    List<CustomerInfo> objCtmr;

    protected override async Task OnInitializedAsync()
    {
        string baseUrl= "https://localhost:44309/";
        HttpClient httpClient = new HttpClient();
        var h = await httpClient.GetAsync(baseUrl + "api/CustomerService/GetCustomer");
        string jsonContent = h.Content.ReadAsStringAsync().Result;
        objCtmr = JsonConvert.DeserializeObject<List<CustomerInfo>>(jsonContent);

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
