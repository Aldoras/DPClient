#pragma checksum "E:\DPClientVS\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83556ba787aa5592c9c9e8bb3238871fa448fd8a"
// <auto-generated/>
#pragma warning disable 1591
namespace DPClientVS.Client.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddAttribute(2, "style", "position:fixed;z-index:1200");
            __builder.AddAttribute(3, "b-2coxwqipgl");
            __builder.OpenComponent<DPClientVS.Client.Shared.NavMenu>(4);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddAttribute(8, "b-2coxwqipgl");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\" style=\"z-index:1111;padding-top:0px\" b-2coxwqipgl></div>\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddAttribute(12, "b-2coxwqipgl");
            __builder.AddContent(13, 
#nullable restore
#line 15 "E:\DPClientVS\Client\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.AddMarkupContent(15, "<style b-2coxwqipgl>\r\n.sidebar {\r\n        width: 300px;\r\n        min-width:300px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
