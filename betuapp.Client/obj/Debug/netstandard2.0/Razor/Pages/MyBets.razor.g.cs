#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e837786bf9c54ef448e4d4f83758b70628c6f054"
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
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using betuapp.Client;
    using betuapp.Client.Shared;
    using betuapp.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayoutLoggedIn))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/mybets")]
    public class MyBets : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>MyBets Page</h1>\r\n\r\n");
            builder.OpenElement(1, "button");
            builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, CreateBet));
            builder.AddContent(3, "Create Bet");
            builder.CloseElement();
            builder.AddMarkupContent(4, "\r\n");
#line 13 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
 if (bets == null)
{

}

else
{

#line default
#line hidden
            builder.AddContent(5, "    ");
            builder.OpenElement(6, "table");
            builder.AddAttribute(7, "class", "table");
            builder.AddMarkupContent(8, "\r\n        ");
            builder.AddMarkupContent(9, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Description</th>\r\n                <th>DueDate</th>\r\n                <th>Tip</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            builder.OpenElement(10, "tbody");
            builder.AddMarkupContent(11, "\r\n");
#line 30 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
             foreach (var bet in bets)
            {

#line default
#line hidden
            builder.AddContent(12, "            ");
            builder.OpenElement(13, "tr");
            builder.AddMarkupContent(14, "\r\n                ");
            builder.OpenElement(15, "td");
            builder.AddContent(16, bet.Name);
            builder.AddContent(17, ".");
            builder.CloseElement();
            builder.AddMarkupContent(18, "\r\n                ");
            builder.OpenElement(19, "td");
            builder.AddContent(20, bet.Description);
            builder.CloseElement();
            builder.AddMarkupContent(21, "\r\n                ");
            builder.OpenElement(22, "td");
            builder.AddContent(23, bet.DueDate);
            builder.CloseElement();
            builder.AddMarkupContent(24, "\r\n                ");
            builder.OpenElement(25, "td");
            builder.AddContent(26, bet.Tip);
            builder.CloseElement();
            builder.AddMarkupContent(27, "\r\n                ");
            builder.OpenElement(28, "td");
            builder.OpenElement(29, "button");
            builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, () => GoToDetail(bet.Id)));
            builder.CloseElement();
            builder.AddContent(31, "Detail");
            builder.CloseElement();
            builder.AddMarkupContent(32, "\r\n");
#line 38 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
                 if (bet.Challenger.Id == this.authenticationstate.loggedInAccount.Id)
                {

#line default
#line hidden
            builder.AddContent(33, "                    ");
            builder.OpenElement(34, "td");
            builder.OpenElement(35, "button");
            builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, () => GoToEdit(bet.Id)));
            builder.CloseElement();
            builder.AddContent(37, "Edit");
            builder.CloseElement();
            builder.AddMarkupContent(38, "\r\n");
#line 41 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
                }

#line default
#line hidden
            builder.AddContent(39, "            ");
            builder.CloseElement();
            builder.AddMarkupContent(40, "\r\n");
#line 43 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
            }

#line default
#line hidden
            builder.AddContent(41, "        ");
            builder.CloseElement();
            builder.AddMarkupContent(42, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(43, "\r\n");
#line 46 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 49 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
           
    List<ExtentedBet> bets = new List<ExtentedBet>();

    protected override async Task OnInitAsync()
    {
        var loggedInAccountId = this.authenticationstate.loggedInAccount.Id;
        bets = await Http.GetJsonAsync<List<ExtentedBet>>("api/BetData/GetBetsByAccount/" + loggedInAccountId);
    }

    void GoToDetail(long betId)
    {
        this.detailState.ClickedBetDetail = this.bets.Where(x => x.Id == betId).First();
        this.uriHelper.NavigateTo("/betdetail");
    }

        void GoToEdit(long betId)
    {
        this.detailState.ClickedBetDetail = this.bets.Where(x => x.Id == betId).First();
        this.uriHelper.NavigateTo("/betedit");
    }

    private void CreateBet()
    {
        this.uriHelper.NavigateTo("/createbet");
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
