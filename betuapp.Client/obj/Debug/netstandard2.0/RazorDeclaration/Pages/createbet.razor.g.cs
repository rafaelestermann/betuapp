#pragma checksum "C:\Users\sirh3e\source\repos\betuapp\betuapp.Client\Pages\createbet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8ac1ef9dec3f320c9837dc9a65c1dbf546ade1a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/createbet")]
    public class createbet : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 61 "C:\Users\sirh3e\source\repos\betuapp\betuapp.Client\Pages\createbet.razor"
           
    public List<Account> challengeableAccounts = new List<Account>();
    public string Name;
    public string Description;
    public long Tip;
    public DateTime DueDate;
    public string errormessage;
    public long? selectedChallenged;
    public List<AcceptanceCriterea> AcceptanceCritereas;
    public string currentCriterea;

    async Task AddCriterea()
    {
        AcceptanceCritereas.Add(new AcceptanceCriterea()
        {
            Text = currentCriterea
        });

    currentCriterea = "";
    }

    async Task Create()
    {
        //VALIDATION
        if (!IsValidSqlDatetime(DueDate.ToString()))
        {
            errormessage = "DueDate is not valid";
            return;
        }

        if (selectedChallenged == null)
        {
            errormessage = "Challenged is not selected";
            return;
        }


        Bet bet = new Bet();
        bet.ChallengerId = this.state.loggedInAccount.Id;
        bet.ChallengedId = selectedChallenged.Value;
        bet.Description = Description;
        bet.Name = Name;
        bet.DueDate = DueDate;
        bet.Tip = Tip;

        var result = await Http.SendJsonAsync<Bet>(HttpMethod.Post, "api/BetData/CreateBet", bet);
        AcceptanceCritereas.ForEach(criterea => criterea.BetId = result.Id);
        var result2 = await Http.SendJsonAsync<List<AcceptanceCriterea>>(HttpMethod.Post, "api/BetData/CreateAcceptanceCritereas", AcceptanceCritereas);
        this.uriHelper.NavigateTo("/MyBets");
    }

    protected override async Task OnInitAsync()
    {
        AcceptanceCritereas = new List<AcceptanceCriterea>();
        DueDate = DateTime.Now;
        var loggedInAccountId = this.state.loggedInAccount.Id;
        challengeableAccounts = await Http.GetJsonAsync<List<Account>>("api/AccountData/Accounts");
        challengeableAccounts = challengeableAccounts.Where(x => x.Id != loggedInAccountId).ToList();

    }

    private bool IsValidSqlDatetime(string someval)
    {
        bool valid = false;
        DateTime testDate = DateTime.MinValue;
        DateTime minDateTime = DateTime.MaxValue;
        DateTime maxDateTime = DateTime.MinValue;

        minDateTime = new DateTime(1753, 1, 1);
        maxDateTime = new DateTime(9999, 12, 31, 23, 59, 59, 997);

        if (DateTime.TryParse(someval, out testDate))
        {
            if (testDate >= minDateTime && testDate <= maxDateTime)
            {
                valid = true;
            }
        }
        return valid;

    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private betuapp.Client.States.AuthenticationState state { get; set; }
    }
}
#pragma warning restore 1591
