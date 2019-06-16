#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\account.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76e269370ac8d302990691e0f237bcadae7f66f7"
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
    using betuapp.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayoutLoggedIn))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/account")]
    public class account : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<header>\r\n    <link href=\"..//css/account.css\" rel=\"stylesheet\">\r\n</header>\r\n\r\n\r\n");
            builder.AddMarkupContent(1, "<h1>My Account</h1>\r\n<br>\r\n\r\n");
            builder.OpenElement(2, "div");
            builder.AddAttribute(3, "id", "owedTipDiv");
            builder.AddMarkupContent(4, "\r\n    ");
            builder.OpenElement(5, "span");
            builder.AddAttribute(6, "id", "ownedTipCircle");
            builder.AddContent(7, DueTip);
            builder.CloseElement();
            builder.AddMarkupContent(8, "\r\n    ");
            builder.AddMarkupContent(9, "<span id=\"ownedTipText\">Owned Tip</span>\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(10, "\r\n\r\n");
            builder.AddMarkupContent(11, "<div id=\"anonymousPerson\">\r\n    <svg id=\"anonymousPersonImage\">\r\n        <rect class=\"icon\" width=\"230\" height=\"230\" style=\"fill:blue;stroke:black;stroke-width:5;opacity:0.5\"></rect>\r\n    </svg>\r\n</div>\r\n\r\n\r\n");
            builder.OpenElement(12, "table");
            builder.AddMarkupContent(13, "\r\n    ");
            builder.OpenElement(14, "tr");
            builder.AddMarkupContent(15, "\r\n        ");
            builder.AddMarkupContent(16, "<td><b style=\"margin-right: 90px;\">Firstname:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(17, "td");
            builder.AddContent(18, Firstname);
            builder.CloseElement();
            builder.AddMarkupContent(19, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(20, "\r\n    ");
            builder.OpenElement(21, "tr");
            builder.AddMarkupContent(22, "\r\n        ");
            builder.AddMarkupContent(23, "<td><b>Lastname:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(24, "td");
            builder.AddContent(25, Lastname);
            builder.CloseElement();
            builder.AddMarkupContent(26, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(27, "\r\n    ");
            builder.OpenElement(28, "tr");
            builder.AddMarkupContent(29, "\r\n        ");
            builder.AddMarkupContent(30, "<td><b>Username:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(31, "td");
            builder.AddContent(32, Username);
            builder.CloseElement();
            builder.AddMarkupContent(33, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(34, "\r\n    ");
            builder.OpenElement(35, "tr");
            builder.AddMarkupContent(36, "\r\n        ");
            builder.AddMarkupContent(37, "<td><b>Email:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(38, "td");
            builder.AddContent(39, Email);
            builder.CloseElement();
            builder.AddMarkupContent(40, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(41, "\r\n    ");
            builder.OpenElement(42, "tr");
            builder.AddMarkupContent(43, "\r\n        ");
            builder.AddMarkupContent(44, "<td><b>Bets Won:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(45, "td");
            builder.AddContent(46, BetsWon);
            builder.CloseElement();
            builder.AddMarkupContent(47, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(48, "\r\n    ");
            builder.OpenElement(49, "tr");
            builder.AddMarkupContent(50, "\r\n        ");
            builder.AddMarkupContent(51, "<td><b>Bets Lost:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(52, "td");
            builder.AddContent(53, BetsLost);
            builder.CloseElement();
            builder.AddMarkupContent(54, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(55, "\r\n    ");
            builder.OpenElement(56, "tr");
            builder.AddMarkupContent(57, "\r\n        ");
            builder.AddMarkupContent(58, "<td><b>Bets Open:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(59, "td");
            builder.AddContent(60, BetsOpen);
            builder.CloseElement();
            builder.AddMarkupContent(61, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(62, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 75 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\account.razor"
           
    public string Firstname;
    public string Lastname;
    public string Username;
    public string Email;
    public int BetsWon;
    public int BetsLost;
    public int BetsOpen;
    public long DueTip;

    protected override async Task OnInitAsync()
    {
        Firstname = this.authenticationState.loggedInAccount.Firstname;
        Lastname = this.authenticationState.loggedInAccount.Lastname;
        Username = this.authenticationState.loggedInAccount.Username;
        Email = this.authenticationState.loggedInAccount.Email;

        List<ExtentedBet> bets = await Http.GetJsonAsync<List<ExtentedBet>>("api/BetData/GetBetsByAccount/" + this.authenticationState.loggedInAccount.Id);

        foreach (var bet in bets.Where(x => x.IstAbgeschlossen))
        {
            if (bet.Challenger.Id == this.authenticationState.loggedInAccount.Id)
            {
                if (bet.ChallengerWon)
                {
                    BetsWon++;
                    DueTip += bet.Tip;
                }
                else
                {
                    BetsLost++;
                    DueTip -= bet.Tip;
                }
            }
            else
            {
                if (bet.ChallengerWon)
                {
                    BetsLost++;
                    DueTip -= bet.Tip;
                }
                else
                {
                    BetsWon++;
                    DueTip += bet.Tip;
                }
            }
        }

        BetsOpen = bets.Where(x => x.IstAbgeschlossen == false).Count();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private betuapp.Client.States.DetailState detailState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private betuapp.Client.States.AuthenticationState authenticationState { get; set; }
    }
}
#pragma warning restore 1591
