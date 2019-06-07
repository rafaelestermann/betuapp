#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\landing.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73006882e782c63f6f92bc57dcdfcf4f96d9e773"
// <auto-generated/>
#pragma warning disable 1591
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
            builder.AddMarkupContent(0, "<head>\r\n    <link href=\"..//css/landing.css\" rel=\"stylesheet\">\r\n</head>\r\n\r\n");
            builder.OpenElement(1, "body");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.OpenElement(3, "div");
            builder.AddAttribute(4, "id", "landingcontainer");
            builder.AddMarkupContent(5, "\r\n        <img src=\"..//logo/Logo_NoText.svg\" class=\"icon-logo\" alt=\"icon from bet u\">\r\n        ");
            builder.AddMarkupContent(6, "<h1>\r\n            <img src=\"..//logo/Logo_OnlyText.svg\" class=\"icon-text\" alt=\"icon from bet u\" height=\"30%\">\r\n        </h1>\r\n        ");
            builder.AddMarkupContent(7, "<p>easy, accessible</p>\r\n        ");
            builder.OpenElement(8, "button");
            builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, GetStarted));
            builder.AddContent(10, "Get Started");
            builder.CloseElement();
            builder.AddMarkupContent(11, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(12, "\r\n    ");
            builder.AddMarkupContent(13, @"<div class=""container"">
        <div class=""row"">
            <div class=""column-1"">
                <video autoplay=""autoplay"">
                    <source src=""..//video/betU.mp4"">
                </video>
            </div>
        </div>
    </div>
");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 29 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\landing.razor"
           
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