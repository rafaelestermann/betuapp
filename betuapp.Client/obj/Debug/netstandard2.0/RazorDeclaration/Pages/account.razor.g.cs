#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\account.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "213d00ba757cdb4e84a264df1793c5170e19e7d5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/account")]
    public class account : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 78 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\account.razor"
           
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
