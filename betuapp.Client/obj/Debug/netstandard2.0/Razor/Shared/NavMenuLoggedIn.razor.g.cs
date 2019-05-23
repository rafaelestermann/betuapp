#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Shared\NavMenuLoggedIn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b298d36de4adb0cd4644fb9bf431d52eb17f0bee"
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
    public class NavMenuLoggedIn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddMarkupContent(1, "\r\n    ");
            builder.AddMarkupContent(2, "<p class=\"aligncenter\">\r\n        <img src=\"..//Logo/Logo_NoText.svg\" style=\"height: 145px; width: 145px; margin-top: 30px\" vertical-align: middle;\">\r\n    </p>\r\n\r\n    ");
            builder.OpenElement(3, "ul");
            builder.AddMarkupContent(4, "\r\n        ");
            builder.OpenElement(5, "li");
            builder.AddAttribute(6, "class", "nav-item px-3");
            builder.AddMarkupContent(7, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(8);
            builder.AddAttribute(9, "class", "nav-link");
            builder.AddAttribute(10, "href", "mybets");
            builder.AddAttribute(11, "Match", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(NavLinkMatch.All));
            builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(13, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> MyBets\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(14, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(15, "\r\n        ");
            builder.OpenElement(16, "li");
            builder.AddAttribute(17, "class", "nav-item px-3");
            builder.AddMarkupContent(18, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            builder.AddAttribute(20, "class", "nav-link");
            builder.AddAttribute(21, "href", "partners");
            builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(23, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Partners\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(24, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(25, "\r\n        ");
            builder.OpenElement(26, "li");
            builder.AddAttribute(27, "class", "nav-item px-3");
            builder.AddMarkupContent(28, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            builder.AddAttribute(30, "class", "nav-link");
            builder.AddAttribute(31, "href", "account");
            builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(33, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Account\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(34, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(35, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(36, "\r\n    ");
            builder.OpenElement(37, "p");
            builder.AddAttribute(38, "class", "aligncenter");
            builder.AddMarkupContent(39, "\r\n        ");
            builder.OpenElement(40, "form");
            builder.AddMarkupContent(41, "\r\n            ");
            builder.OpenElement(42, "input");
            builder.AddAttribute(43, "type", "submit");
            builder.AddAttribute(44, "value", "Sign Out");
            builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, Logout));
            builder.CloseElement();
            builder.AddMarkupContent(46, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(47, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(48, "\r\n\r\n\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 35 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Shared\NavMenuLoggedIn.razor"
           
    string name;
    protected override void OnInit()
    {
        name = this.state.loggedInAccount.Username;
    }

    async Task Logout()
    {
        this.state.Logout();
        this.uriHelper.NavigateTo("/");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private betuapp.Client.States.AuthenticationState state { get; set; }
    }
}
#pragma warning restore 1591
