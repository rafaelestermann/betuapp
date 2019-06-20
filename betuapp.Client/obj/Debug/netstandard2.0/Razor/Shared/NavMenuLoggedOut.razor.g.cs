#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Shared\NavMenuLoggedOut.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e9c6630ba1aebee7951a690b0359fac32c76905"
// <auto-generated/>
#pragma warning disable 1591
namespace betuapp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using betuapp.Client;
    using betuapp.Client.Shared;
    using Microsoft.AspNetCore.Components;
    public class NavMenuLoggedOut : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "header");
            builder.AddAttribute(1, "class", "header");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.OpenElement(3, "img");
            builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, ReloadPage));
            builder.AddAttribute(5, "src", "..//Logo/Logo_OnlyText.svg");
            builder.AddAttribute(6, "id", "navLogo");
            builder.CloseElement();
            builder.AddMarkupContent(7, "\r\n    <input class=\"menu-btn\" type=\"checkbox\" id=\"menu-btn\">\r\n    ");
            builder.AddMarkupContent(8, "<label class=\"menu-icon\" for=\"menu-btn\"><span class=\"navicon\"></span></label>\r\n    ");
            builder.AddMarkupContent(9, @"<ul class=""menu"">
        <li><a href=""/"">Home</a></li>
        <li class=""two""><a href=""/about"">About</a></li>
        <li class=""three""><a href=""/login"">Sign In</a></li>
        <li class=""four""><a href=""/registration"" id=""SignUpButton"">Sign Up</a></li>
    </ul>
");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 15 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Shared\NavMenuLoggedOut.razor"
           
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
