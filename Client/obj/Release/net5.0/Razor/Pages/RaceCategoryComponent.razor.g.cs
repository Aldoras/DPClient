#pragma checksum "E:\DPClientVS\Client\Pages\RaceCategoryComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93501283e17a6a74a1b08b54e2820efa52f6129b"
// <auto-generated/>
#pragma warning disable 1591
namespace DPClientVS.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\DPClientVS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DPClientVS\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DPClientVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\DPClientVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\DPClientVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\DPClientVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\DPClientVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\DPClientVS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\DPClientVS\Client\_Imports.razor"
using DPClientVS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\DPClientVS\Client\_Imports.razor"
using DPClientVS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\DPClientVS\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
    public partial class RaceCategoryComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 1 "E:\DPClientVS\Client\Pages\RaceCategoryComponent.razor"
     Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Startovní číslo</th>\r\n            <th>Jméno</th>\r\n            <th>Příjmení</th>\r\n            <th>Ročník</th>\r\n            <th>Pohlaví</th></tr></thead>\r\n    ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 13 "E:\DPClientVS\Client\Pages\RaceCategoryComponent.razor"
         foreach (Model.Registrations registration in Registrations)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 16 "E:\DPClientVS\Client\Pages\RaceCategoryComponent.razor"
                     registration.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 17 "E:\DPClientVS\Client\Pages\RaceCategoryComponent.razor"
                     registration.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 18 "E:\DPClientVS\Client\Pages\RaceCategoryComponent.razor"
                     registration.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 19 "E:\DPClientVS\Client\Pages\RaceCategoryComponent.razor"
                     registration.Birthday

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 20 "E:\DPClientVS\Client\Pages\RaceCategoryComponent.razor"
                     registration.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "E:\DPClientVS\Client\Pages\RaceCategoryComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "E:\DPClientVS\Client\Pages\RaceCategoryComponent.razor"
 
    [Parameter]
    public string Category { get; set; }
    [Parameter]
    public List<Model.Registrations> Registrations { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
