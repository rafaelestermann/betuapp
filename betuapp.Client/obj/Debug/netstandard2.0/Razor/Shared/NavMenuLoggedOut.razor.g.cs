#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Shared\NavMenuLoggedOut.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a835ef02451ea4351e1d27017ee58e3fd02c48d"
// <auto-generated/>
#pragma warning disable 1591
namespace betuapp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using betuapp.Client;
    using betuapp.Client.Shared;
    public class NavMenuLoggedOut : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, @"<header class=""header"">
    <div style=""background-color: red;"" id=""navLogo""></div>
    <input class=""menu-btn"" type=""checkbox"" id=""menu-btn"">
    <label class=""menu-icon"" for=""menu-btn""><span class=""navicon""></span></label>
    <ul class=""menu"">
        <li><a href=""/"">Home</a></li>
        <li class=""two""><a href=""/about"">About</a></li>
        <li class=""three""><a href=""/login"">Sign In</a></li>
        <li class=""four""><a href=""/registration"" id=""SignUpButton"">Sign Up</a></li>
    </ul>
</header>");
        }
        #pragma warning restore 1998
#line 14 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Shared\NavMenuLoggedOut.razor"
           
    async Task ReloadPage()
    {
        this.uriHelper.NavigateTo("/");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
    }
}
#pragma warning restore 1591
