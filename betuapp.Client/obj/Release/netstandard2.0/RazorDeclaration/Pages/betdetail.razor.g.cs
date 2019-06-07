#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\betdetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02dc36fd0736f4e4e9c3ee47f97b7e9d3ce27080"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/betdetail")]
    public class betdetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 43 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\betdetail.razor"
           
    public string errormessage;
    public string Name;
    public string Description;
    public DateTime DueDate;
    public long Tip;
    public Account challenged;
    public string Evidence;
    public bool consentTrue;
    public bool consentFalse;
    public bool ConsentGiven;

    async Task GiveConsent()
    {
        ConsentGiven = true;
    }
    async Task GiveNotConsent()
    {
        ConsentGiven = false;
    }

    protected override async Task OnInitAsync()
    {
        this.Name = this.detailState.ClickedBetDetail.Name;
        this.Description = this.detailState.ClickedBetDetail.Description;
        this.DueDate = this.detailState.ClickedBetDetail.DueDate;
        this.Tip = this.detailState.ClickedBetDetail.Tip;
        this.challenged = this.detailState.ClickedBetDetail.Challenged;

        if (this.authenticationstate.loggedInAccount.Id == this.detailState.ClickedBetDetail.Challenger.Id)
        {
            ConsentGiven = this.detailState.ClickedBetDetail.ConsentChallengerGiven;
            if (this.detailState.ClickedBetDetail.ConsentChallengerGiven)
            {
                consentTrue = (this.detailState.ClickedBetDetail.ChallengerWonChallenger == true);
                consentFalse = !consentTrue;
            }
        }
        else
        {
            ConsentGiven = this.detailState.ClickedBetDetail.ConsentChallengedGiven;
            if (this.detailState.ClickedBetDetail.ConsentChallengedGiven)
            {
                consentTrue = (this.detailState.ClickedBetDetail.ChallengerWonChallenged == true);
                consentFalse = !consentTrue;
            }
        }
    }

    async Task Save()
    {
        if (ConsentGiven)
        {
            if (consentFalse == true && consentTrue == true)
            {
                errormessage = "invalid consent";
                return;
            }
            if (consentFalse == false && consentTrue == false)
            {
                errormessage = "invalid consent";
                return;
            }
        }

        var bet = this.detailState.ClickedBetDetail;
        bet.Evidence = this.Evidence;

        if(this.authenticationstate.loggedInAccount.Id == this.detailState.ClickedBetDetail.Challenger.Id)
        {
            bet.ConsentChallengerGiven = ConsentGiven;
        }
        else
        {
            bet.ConsentChallengedGiven = ConsentGiven;
        }

        if (this.authenticationstate.loggedInAccount.Id == this.detailState.ClickedBetDetail.Challenger.Id && ConsentGiven)
        {
            bet.ChallengerWonChallenger = this.consentTrue;
            bet.ConsentChallengerGiven = true;
        }
        if (this.authenticationstate.loggedInAccount.Id == this.detailState.ClickedBetDetail.Challenged.Id && ConsentGiven)
        {
            bet.ChallengerWonChallenged = this.consentTrue;
            bet.ConsentChallengedGiven = true;
        }

        if (bet.ChallengerWonChallenger == true && bet.ChallengerWonChallenger == bet.ChallengerWonChallenged && bet.ConsentChallengerGiven && bet.ConsentChallengedGiven)
        {
            bet.IstAbgeschlossen = true;
            bet.ChallengerWon = true;
        }
        if (bet.ChallengerWonChallenger == false && bet.ChallengerWonChallenger == bet.ChallengerWonChallenged && bet.ConsentChallengedGiven && bet.ConsentChallengerGiven)
        {
            bet.IstAbgeschlossen = true;
            bet.ChallengerWon = false;
        }

        if(bet.ConsentChallengedGiven != true || bet.ConsentChallengerGiven != true)
        {
            bet.IstAbgeschlossen = false;
        }

        if(bet.ChallengerWonChallenger != bet.ChallengerWonChallenged)
        {
            bet.IstAbgeschlossen = false;
        }

        var result = await Http.SendJsonAsync<ExtentedBet>(HttpMethod.Post, "api/BetData/UpdateBet", bet);
        this.uriHelper.NavigateTo("/MyBets");
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