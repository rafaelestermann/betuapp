#pragma checksum "C:\Users\sirh3e\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "964bbea0facec31d5d7e7e339d5937f229992aa1"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/mybets")]
    public class MyBets : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<head>\r\n    <link href=\"..//css/table.css\" rel=\"stylesheet\">\r\n</head>\r\n\r\n");
            builder.AddMarkupContent(1, "<h1>MyBets Page</h1>\r\n\r\n");
#line 15 "C:\Users\sirh3e\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
 if (bets == null)
{

}

else
{

#line default
#line hidden
            builder.AddContent(2, "    ");
            builder.OpenElement(3, "div");
            builder.AddAttribute(4, "style", "margin-bottom: 17px;");
            builder.AddMarkupContent(5, "\r\n        ");
            builder.AddMarkupContent(6, "<h2 id=\"betsDescriptionHeader\">Open Bets</h2>\r\n        ");
            builder.OpenElement(7, "button");
            builder.AddAttribute(8, "id", "createButton");
            builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, CreateBet));
            builder.AddContent(10, "Create Bet");
            builder.CloseElement();
            builder.AddMarkupContent(11, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(12, "\r\n    ");
            builder.OpenElement(13, "table");
            builder.AddAttribute(14, "class", "table");
            builder.AddMarkupContent(15, "\r\n        ");
            builder.AddMarkupContent(16, @"<thead>
            <tr>
                <th>Name</th>
                <th>Description</th>
                <th>DueDate</th>
                <th>Tip</th>
                <th></th>
                <th></th>
            </tr>
        </thead>
        ");
            builder.OpenElement(17, "tbody");
            builder.AddMarkupContent(18, "\r\n");
#line 38 "C:\Users\sirh3e\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
             foreach (var bet in bets.Where(x => !x.IstAbgeschlossen))
            {

#line default
#line hidden
            builder.AddContent(19, "                ");
            builder.OpenElement(20, "tr");
            builder.AddMarkupContent(21, "\r\n                    ");
            builder.OpenElement(22, "td");
            builder.OpenElement(23, "strong");
            builder.AddContent(24, bet.Name);
            builder.CloseElement();
            builder.CloseElement();
            builder.AddMarkupContent(25, "\r\n                    ");
            builder.OpenElement(26, "td");
            builder.AddContent(27, bet.Description);
            builder.CloseElement();
            builder.AddMarkupContent(28, "\r\n                    ");
            builder.OpenElement(29, "td");
            builder.AddContent(30, bet.DueDate.Date);
            builder.CloseElement();
            builder.AddMarkupContent(31, "\r\n                    ");
            builder.OpenElement(32, "td");
            builder.AddContent(33, bet.Tip);
            builder.CloseElement();
            builder.AddMarkupContent(34, "\r\n                    ");
            builder.OpenElement(35, "td");
            builder.OpenElement(36, "button");
            builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, () => GoToDetail(bet.Id)));
            builder.AddAttribute(38, "id", "actionButton");
            builder.AddContent(39, "Detail");
            builder.CloseElement();
            builder.CloseElement();
            builder.AddMarkupContent(40, "\r\n");
#line 46 "C:\Users\sirh3e\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
                     if (bet.Challenger.Id == this.authenticationstate.loggedInAccount.Id)
                    {

#line default
#line hidden
            builder.AddContent(41, "                        ");
            builder.OpenElement(42, "td");
            builder.OpenElement(43, "button");
            builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, () => GoToEdit(bet.Id)));
            builder.AddAttribute(45, "id", "actionButton");
            builder.AddContent(46, "Edit");
            builder.CloseElement();
            builder.CloseElement();
            builder.AddMarkupContent(47, "\r\n");
#line 49 "C:\Users\sirh3e\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
                    }
                    else
                    {

#line default
#line hidden
            builder.AddMarkupContent(48, "                        <td></td>\r\n");
#line 53 "C:\Users\sirh3e\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
                    }

#line default
#line hidden
            builder.AddContent(49, "                ");
            builder.CloseElement();
            builder.AddMarkupContent(50, "\r\n");
#line 55 "C:\Users\sirh3e\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
            }

#line default
#line hidden
            builder.AddContent(51, "        ");
            builder.CloseElement();
            builder.AddMarkupContent(52, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(53, "\r\n    <br>\r\n    <br>\r\n    ");
            builder.AddMarkupContent(54, "<h2 id=\"betsDescriptionHeader\">Closed Bets</h2>\r\n");
            builder.AddContent(55, "    ");
            builder.OpenElement(56, "table");
            builder.AddAttribute(57, "class", "table");
            builder.AddMarkupContent(58, "\r\n        ");
            builder.AddMarkupContent(59, @"<thead>
            <tr>
                <th>Name</th>
                <th>Description</th>
                <th>DueDate</th>
                <th>Tip</th>
                <th></th>
                <th></th>
            </tr>
        </thead>
        ");
            builder.OpenElement(60, "tbody");
            builder.AddMarkupContent(61, "\r\n");
#line 74 "C:\Users\sirh3e\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
             foreach (var bet in bets.Where(x => x.IstAbgeschlossen))
            {

#line default
#line hidden
            builder.AddContent(62, "                ");
            builder.OpenElement(63, "tr");
            builder.AddMarkupContent(64, "\r\n                    ");
            builder.OpenElement(65, "td");
            builder.OpenElement(66, "strong");
            builder.AddContent(67, bet.Name);
            builder.CloseElement();
            builder.CloseElement();
            builder.AddMarkupContent(68, "\r\n                    ");
            builder.OpenElement(69, "td");
            builder.AddContent(70, bet.Description);
            builder.CloseElement();
            builder.AddMarkupContent(71, "\r\n                    ");
            builder.OpenElement(72, "td");
            builder.AddContent(73, bet.DueDate.Date);
            builder.CloseElement();
            builder.AddMarkupContent(74, "\r\n                    ");
            builder.OpenElement(75, "td");
            builder.AddContent(76, bet.Tip);
            builder.CloseElement();
            builder.AddMarkupContent(77, "\r\n                    ");
            builder.OpenElement(78, "td");
            builder.OpenElement(79, "button");
            builder.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, () => GoToDetail(bet.Id)));
            builder.AddAttribute(81, "id", "actionButton");
            builder.AddContent(82, "Detail");
            builder.CloseElement();
            builder.CloseElement();
            builder.AddMarkupContent(83, "\r\n                ");
            builder.CloseElement();
            builder.AddMarkupContent(84, "\r\n");
#line 83 "C:\Users\sirh3e\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
            }

#line default
#line hidden
            builder.AddContent(85, "        ");
            builder.CloseElement();
            builder.AddMarkupContent(86, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(87, "\r\n");
#line 86 "C:\Users\sirh3e\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 89 "C:\Users\sirh3e\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
           
    List<ExtentedBet> bets = new List<ExtentedBet>();
    List<AcceptanceCriterea> critereas;

    protected override async Task OnInitAsync()
    {
        var loggedInAccountId = this.authenticationstate.loggedInAccount.Id;
        bets = await Http.GetJsonAsync<List<ExtentedBet>>("api/BetData/GetBetsByAccount/" + loggedInAccountId);
        critereas = await Http.GetJsonAsync<List<AcceptanceCriterea>>("api/BetData/AcceptanceCritereas/");
    }

    void GoToDetail(long betId)
    {
        this.detailState.ClickedBetAcceptanceCritereas = critereas.Where(x => x.BetId == betId).ToList();
        this.detailState.ClickedBetDetail = this.bets.Where(x => x.Id == betId).First();
        this.uriHelper.NavigateTo("/betdetail");
    }

    void GoToEdit(long betId)
    {
        this.detailState.ClickedBetAcceptanceCritereas = critereas.Where(x => x.BetId == betId).ToList();
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
