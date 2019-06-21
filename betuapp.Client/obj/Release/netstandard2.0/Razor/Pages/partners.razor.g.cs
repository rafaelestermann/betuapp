#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\partners.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09dfdd89dc81a55468aefd034db0934f42026844"
// <auto-generated/>
#pragma warning disable 1591
namespace betuapp.Client.Pages
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
    using betuapp.Shared;
    using Microsoft.AspNetCore.Components;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayoutLoggedIn))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/partners")]
    public class partners : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<head>\r\n    <link href=\"..//css/table.css\" rel=\"stylesheet\">\r\n</head>\r\n\r\n");
            builder.AddMarkupContent(1, "<h1>Partners Page</h1>\r\n");
#line 15 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\partners.razor"
 if (partnerAccounts == null)
{

}

else
{

#line default
#line hidden
            builder.AddContent(2, "    ");
            builder.OpenElement(3, "table");
            builder.AddAttribute(4, "class", "table");
            builder.AddMarkupContent(5, "\r\n        ");
            builder.AddMarkupContent(6, "<thead>\r\n            <tr>\r\n                <th>Firstname</th>\r\n                <th>Lastname</th>\r\n                <th>Username</th>\r\n                <th>Email</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            builder.OpenElement(7, "tbody");
            builder.AddMarkupContent(8, "\r\n");
#line 33 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\partners.razor"
             foreach (var account in partnerAccounts)
            {

#line default
#line hidden
            builder.AddContent(9, "                ");
            builder.OpenElement(10, "tr");
            builder.AddMarkupContent(11, "\r\n                    ");
            builder.OpenElement(12, "td");
            builder.AddContent(13, account.Firstname);
            builder.CloseElement();
            builder.AddMarkupContent(14, "\r\n                    ");
            builder.OpenElement(15, "td");
            builder.AddContent(16, account.Lastname);
            builder.CloseElement();
            builder.AddMarkupContent(17, "\r\n                    ");
            builder.OpenElement(18, "td");
            builder.AddContent(19, account.Username);
            builder.CloseElement();
            builder.AddMarkupContent(20, "\r\n                    ");
            builder.OpenElement(21, "td");
            builder.AddContent(22, account.Email);
            builder.CloseElement();
            builder.AddMarkupContent(23, "\r\n                    ");
            builder.OpenElement(24, "td");
            builder.OpenElement(25, "button");
            builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, () => GoToDetail(account.Id)));
            builder.AddAttribute(27, "id", "actionButton");
            builder.AddContent(28, "Detail");
            builder.CloseElement();
            builder.CloseElement();
            builder.AddMarkupContent(29, "\r\n                ");
            builder.CloseElement();
            builder.AddMarkupContent(30, "\r\n");
#line 42 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\partners.razor"
            }

#line default
#line hidden
            builder.AddContent(31, "        ");
            builder.CloseElement();
            builder.AddMarkupContent(32, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(33, "\r\n");
#line 45 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\partners.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 48 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\partners.razor"
           
    List<Account> partnerAccounts = new List<Account>();

    protected override async Task OnInitAsync()
    {
        var loggedInAccountId = this.authenticationstate.loggedInAccount.Id;
        partnerAccounts = await Http.GetJsonAsync<List<Account>>("api/AccountData/GetAllPartnerAccountsByAccountId/" + loggedInAccountId);
    }

    void GoToDetail(long accountId)
    {
        detailState.ClickedAccountDetail = partnerAccounts.Where(x => x.Id == accountId).First();
        this.uriHelper.NavigateTo("/accountdetail");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private betuapp.Client.States.DetailState detailState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private betuapp.Client.States.AuthenticationState authenticationstate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591