#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Shared\MainLayoutLoggedOut.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d4b7011ec6a7ce7ee7eba1473624a85ed67508d"
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
    public class MainLayoutLoggedOut : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<head>\r\n    <link href=\"..//css/navbarLoggedOut.css\" rel=\"stylesheet\">\r\n</head>\r\n\r\n");
            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "style", "padding-bottom: 110px;");
            builder.AddMarkupContent(3, "\r\n    ");
            builder.OpenComponent<betuapp.Client.Shared.NavMenuLoggedOut>(4);
            builder.CloseComponent();
            builder.AddMarkupContent(5, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(6, "\r\n\r\n");
            builder.OpenElement(7, "div");
            builder.AddAttribute(8, "class", "main");
            builder.AddMarkupContent(9, "\r\n    ");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", "content px-4");
            builder.AddMarkupContent(12, "\r\n        ");
            builder.AddContent(13, Body);
            builder.AddMarkupContent(14, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(15, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
