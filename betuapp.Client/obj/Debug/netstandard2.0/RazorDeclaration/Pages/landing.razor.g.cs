#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\landing.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fc7d9a39cf22e35d609ca50d46fbc07b05d3fa2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace betuapp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using betuapp.Client;
    using betuapp.Client.Shared;
    using Microsoft.AspNetCore.Components.Layouts;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayoutLoggedOut))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class landing : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 37 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\landing.razor"
           
    async Task GetStarted()
    {
        this.uriHelper.NavigateTo("/registration");
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
    }
}
#pragma warning restore 1591
