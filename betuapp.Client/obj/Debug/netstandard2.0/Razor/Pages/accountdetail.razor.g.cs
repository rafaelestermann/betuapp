#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\accountdetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aff6f71b86d1642ae616d465ebd0554a4230fd33"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/accountdetail")]
    public class accountdetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<head>\r\n    <link href=\"..//css/general.css\" rel=\"stylesheet\">\r\n    <link href=\"..//css/account.css\" rel=\"stylesheet\">\r\n</head>\r\n\r\n");
            builder.OpenElement(1, "div");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.AddMarkupContent(3, "<a id=\"breadCrumbText\" href=\"/partners\">Partners</a>\r\n    ");
            builder.AddMarkupContent(4, "<a id=\"breadCrumbText\">/</a>\r\n    ");
            builder.OpenElement(5, "a");
            builder.AddAttribute(6, "id", "breadCrumbText");
            builder.AddAttribute(7, "href", "/accountdetail");
            builder.AddContent(8, detailState.ClickedAccountDetail.Username);
            builder.CloseElement();
            builder.AddMarkupContent(9, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(10, "\r\n\r\n");
            builder.AddMarkupContent(11, "<h1>Account Detail</h1>\r\n\r\n");
            builder.AddMarkupContent(12, "<div id=\"anonymousPerson\">\r\n    <img src=\"..//pictures/anonymousperson.svg\" id=\"anonymousImage\" alt=\"anonymous person symbol\">\r\n</div>\r\n\r\n");
            builder.OpenElement(13, "table");
            builder.AddMarkupContent(14, "\r\n    ");
            builder.OpenElement(15, "tr");
            builder.AddMarkupContent(16, "\r\n        ");
            builder.AddMarkupContent(17, "<td><b style=\"margin-right: 90px;\">Firstname:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(18, "td");
            builder.AddContent(19, Firstname);
            builder.CloseElement();
            builder.AddMarkupContent(20, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(21, "\r\n    ");
            builder.OpenElement(22, "tr");
            builder.AddMarkupContent(23, "\r\n        ");
            builder.AddMarkupContent(24, "<td><b>Lastname:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(25, "td");
            builder.AddContent(26, Lastname);
            builder.CloseElement();
            builder.AddMarkupContent(27, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(28, "\r\n    ");
            builder.OpenElement(29, "tr");
            builder.AddMarkupContent(30, "\r\n        ");
            builder.AddMarkupContent(31, "<td><b>Username:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(32, "td");
            builder.AddContent(33, Username);
            builder.CloseElement();
            builder.AddMarkupContent(34, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(35, "\r\n    ");
            builder.OpenElement(36, "tr");
            builder.AddMarkupContent(37, "\r\n        ");
            builder.AddMarkupContent(38, "<td><b>Email:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(39, "td");
            builder.AddContent(40, Email);
            builder.CloseElement();
            builder.AddMarkupContent(41, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(42, "\r\n    ");
            builder.OpenElement(43, "tr");
            builder.AddMarkupContent(44, "\r\n        ");
            builder.AddMarkupContent(45, "<td><b>Bets Won:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(46, "td");
            builder.AddContent(47, BetsWon);
            builder.CloseElement();
            builder.AddMarkupContent(48, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(49, "\r\n    ");
            builder.OpenElement(50, "tr");
            builder.AddMarkupContent(51, "\r\n        ");
            builder.AddMarkupContent(52, "<td><b>Bets Lost:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(53, "td");
            builder.AddContent(54, BetsLost);
            builder.CloseElement();
            builder.AddMarkupContent(55, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(56, "\r\n    ");
            builder.OpenElement(57, "tr");
            builder.AddMarkupContent(58, "\r\n        ");
            builder.AddMarkupContent(59, "<td><b>Bets Open:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(60, "td");
            builder.AddContent(61, BetsOpen);
            builder.CloseElement();
            builder.AddMarkupContent(62, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(63, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 71 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\accountdetail.razor"
           
    public string Firstname;
    public string Lastname;
    public string Username;
    public string Email;
    public int BetsWon;
    public int BetsLost;
    public int BetsOpen;

    protected override async Task OnInitAsync()
    {
        Firstname = this.detailState.ClickedAccountDetail.Firstname;
        Lastname = this.detailState.ClickedAccountDetail.Lastname;
        Username = this.detailState.ClickedAccountDetail.Username;
        Email = this.detailState.ClickedAccountDetail.Email;

        List<ExtentedBet>
    bets = await Http.GetJsonAsync<List<ExtentedBet>>("api/BetData/GetBetsByAccount/" + this.detailState.ClickedAccountDetail.Id);

        foreach (var bet in bets.Where(x => x.IstAbgeschlossen))
        {
            if (bet.Challenger.Id == this.detailState.ClickedAccountDetail.Id)
            {
                if (bet.ChallengerWon)
                {
                    BetsWon++;
                }
                else
                {
                    BetsLost++;
                }
            }
            else
            {
                if (bet.ChallengerWon)
                {
                    BetsLost++;
                }
                else
                {
                    BetsWon++;
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
