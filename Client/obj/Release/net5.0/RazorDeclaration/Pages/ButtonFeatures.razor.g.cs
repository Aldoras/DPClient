// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "E:\DPClientVS\Client\Pages\ButtonFeatures.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/button-features")]
    public partial class ButtonFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "E:\DPClientVS\Client\Pages\ButtonFeatures.razor"
        SfButton ToggleButton;
    public string Content = "Play";
    public string IconCss = "e-btn-sb-icons e-play-icon";
    public void OnToggleClick(MouseEventArgs args)
    {
        if (ToggleButton.Content == "Play")
        {
            this.Content = "Pause";
            this.IconCss = "e-btn-sb-icons e-pause-icon";
        }
        else
        {
            this.Content = "Play";
            this.IconCss = "e-btn-sb-icons e-play-icon";
        }
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
