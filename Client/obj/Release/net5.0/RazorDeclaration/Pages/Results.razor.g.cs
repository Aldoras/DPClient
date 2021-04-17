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
#line 2 "E:\DPClientVS\Client\Pages\Results.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/results")]
    public partial class Results : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "E:\DPClientVS\Client\Pages\Results.razor"
       
    private bool ShowingResults { get; set; } = false;
    private List<Model.Result> SelectedResults;
    private List<Model.Result> ResultsData;

    protected override async Task OnInitializedAsync()
    {
        ResultsData = await Http.GetFromJsonAsync<List<Model.Result>>("sample-data/results.json");
    }

    protected void OnResultOpen(string raceName)
    {
        SelectedResults = ResultsData.Where(x => x.RaceName == raceName)
            .OrderBy(x => DateTime.ParseExact(x.Finish, "H:mm", CultureInfo.InvariantCulture) - DateTime.ParseExact(x.Start, "H:mm", CultureInfo.InvariantCulture))
            .ToList();
        ShowingResults = true;
    }
    protected void OnResultClose()
    {
        ShowingResults = false;
        SelectedResults = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
