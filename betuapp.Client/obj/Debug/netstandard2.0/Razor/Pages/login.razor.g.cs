#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1531f2b5c63ef72f408163a4719eb957b14c4090"
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
    using Microsoft.AspNetCore.Blazor.Services;
    using betuapp.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayoutLoggedOut))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public class login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<header>\r\n        <link href=\"..//css/forms.css\" rel=\"stylesheet\">\r\n        <link href=\"..//css/navbarLoggedOut.css\" rel=\"stylesheet\">\r\n    </header>\r\n\r\n");
            builder.OpenElement(1, "body");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.OpenElement(3, "div");
            builder.AddAttribute(4, "class", "formular");
            builder.AddMarkupContent(5, "\r\n        ");
            builder.AddMarkupContent(6, "<h1>Sign In</h1>\r\n        ");
            builder.OpenElement(7, "input");
            builder.AddAttribute(8, "type", "text");
            builder.AddAttribute(9, "name", "field1");
            builder.AddAttribute(10, "placeholder", "Username");
            builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(username));
            builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            builder.CloseElement();
            builder.AddMarkupContent(13, "\r\n        ");
            builder.OpenElement(14, "input");
            builder.AddAttribute(15, "type", "password");
            builder.AddAttribute(16, "name", "field2");
            builder.AddAttribute(17, "placeholder", "Password");
            builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(password));
            builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            builder.CloseElement();
            builder.AddMarkupContent(20, "\r\n        ");
            builder.OpenElement(21, "p");
            builder.AddAttribute(22, "class", "error");
            builder.AddContent(23, errormessage);
            builder.CloseElement();
            builder.AddMarkupContent(24, "\r\n        ");
            builder.OpenElement(25, "input");
            builder.AddAttribute(26, "type", "submit");
            builder.AddAttribute(27, "value", "Sign In");
            builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, Login));
            builder.CloseElement();
            builder.AddMarkupContent(29, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(30, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 24 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\login.razor"
 
    string username;
    string password;
    string errormessage;

    async Task Login()
    {
        LoginParameters parameter = new LoginParameters()
        {
            UserName = username,
            Password = password
        };

        await this.state.Login(parameter);
        var loginSuccessful = this.state.loggedInAccount.Username != null; 
        if (!loginSuccessful)
        {
            errormessage = "invalid username or email address, please try again!";
        }
        else
        {            
            this.uriHelper.NavigateTo("/MyBets");
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private betuapp.Client.States.AuthenticationState state { get; set; }
    }
}
#pragma warning restore 1591
