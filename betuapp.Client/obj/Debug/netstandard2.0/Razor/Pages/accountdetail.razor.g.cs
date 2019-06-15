#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\accountdetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0a3f00dd7f31f6ca72628800c7f6183e48d630d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/accountdetail")]
    public class accountdetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<head>\r\n        <link href=\"..//css/general.css\" rel=\"stylesheet\">\r\n    </head>\r\n\r\n");
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
            builder.AddMarkupContent(10, "\r\n\r\n<br>\r\n");
            builder.OpenElement(11, "table");
            builder.AddMarkupContent(12, "\r\n    ");
            builder.OpenElement(13, "tr");
            builder.AddMarkupContent(14, "\r\n        ");
            builder.AddMarkupContent(15, "<td><b>Firstname:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(16, "td");
            builder.AddContent(17, Firstname);
            builder.CloseElement();
            builder.AddMarkupContent(18, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(19, "\r\n    ");
            builder.OpenElement(20, "tr");
            builder.AddMarkupContent(21, "\r\n        ");
            builder.AddMarkupContent(22, "<td><b>Lastname:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(23, "td");
            builder.AddContent(24, Lastname);
            builder.CloseElement();
            builder.AddMarkupContent(25, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(26, "\r\n    ");
            builder.OpenElement(27, "tr");
            builder.AddMarkupContent(28, "\r\n        ");
            builder.AddMarkupContent(29, "<td><b>Username:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(30, "td");
            builder.AddContent(31, Username);
            builder.CloseElement();
            builder.AddMarkupContent(32, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(33, "\r\n    ");
            builder.OpenElement(34, "tr");
            builder.AddMarkupContent(35, "\r\n        ");
            builder.AddMarkupContent(36, "<td><b>Email:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(37, "td");
            builder.AddContent(38, Email);
            builder.CloseElement();
            builder.AddMarkupContent(39, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(40, "\r\n    ");
            builder.OpenElement(41, "tr");
            builder.AddMarkupContent(42, "\r\n        ");
            builder.AddMarkupContent(43, "<td><b>Bets Won:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(44, "td");
            builder.AddContent(45, BetsWon);
            builder.CloseElement();
            builder.AddMarkupContent(46, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(47, "\r\n    ");
            builder.OpenElement(48, "tr");
            builder.AddMarkupContent(49, "\r\n        ");
            builder.AddMarkupContent(50, "<td><b>Bets Lost:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(51, "td");
            builder.AddContent(52, BetsLost);
            builder.CloseElement();
            builder.AddMarkupContent(53, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(54, "\r\n    ");
            builder.OpenElement(55, "tr");
            builder.AddMarkupContent(56, "\r\n        ");
            builder.AddMarkupContent(57, "<td><b>Bets Open:</b></td>\r\n        <td></td>\r\n        <td></td>\r\n        ");
            builder.OpenElement(58, "td");
            builder.AddContent(59, BetsOpen);
            builder.CloseElement();
            builder.AddMarkupContent(60, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(61, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 65 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\accountdetail.razor"
           
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

        List<ExtentedBet> bets = await Http.GetJsonAsync<List<ExtentedBet>>("api/BetData/GetBetsByAccount/" + this.detailState.ClickedAccountDetail.Id);

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
