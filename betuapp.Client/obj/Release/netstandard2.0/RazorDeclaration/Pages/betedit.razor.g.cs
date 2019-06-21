#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\betedit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c729c8ec0f175284b1f529b8bacaf04123593103"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/betedit")]
    public class betedit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 65 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\betedit.razor"
           
    public string Name;
    public string Description;
    public long Tip;
    public DateTime DueDate;
    public string errormessage;
    public Account challenged;
    public List<AcceptanceCriterea> AcceptanceCritereas;
    public string currentCriterea;

    protected async Task SaveBet()
    {
        var result = await this.Http.SendJsonAsync<ExtentedBet>(HttpMethod.Post, "api/BetData/UpdateBet", this.detailState.ClickedBetDetail);
        this.uriHelper.NavigateTo("/MyBets");
    }

    async Task AddCriterea()
    {
        AcceptanceCritereas.Add(new AcceptanceCriterea()
        {
            Text = currentCriterea
        });

        currentCriterea = "";
    }

    protected override async Task OnInitAsync()
    {
        AcceptanceCritereas = new List<AcceptanceCriterea>();
        this.Name = this.detailState.ClickedBetDetail.Name;
        this.Description = this.detailState.ClickedBetDetail.Description;
        this.DueDate = this.detailState.ClickedBetDetail.DueDate;
        this.Tip = this.detailState.ClickedBetDetail.Tip;
        this.challenged = this.detailState.ClickedBetDetail.Challenged;
        AcceptanceCritereas = this.detailState.ClickedBetAcceptanceCritereas;
    }

    async Task Save()
    {
        //VALIDATION
        if (!IsValidSqlDatetime(DueDate.ToString()))
        {
            errormessage = "DueDate is not valid";
            return;
        }

        ExtentedBet bet = this.detailState.ClickedBetDetail;
        bet.Description = Description;
        bet.Name = Name;
        bet.DueDate = DueDate;
        bet.Tip = Tip;
        bet.Id = this.detailState.ClickedBetDetail.Id;

        var result = await Http.SendJsonAsync<ExtentedBet>(HttpMethod.Post, "api/BetData/UpdateBet", bet);
        AcceptanceCritereas.ForEach(criterea => criterea.BetId = result.Id);
        var result2 = await Http.SendJsonAsync<List<AcceptanceCriterea>>(HttpMethod.Post, "api/BetData/CreateAcceptanceCritereas", AcceptanceCritereas);
        this.uriHelper.NavigateTo("/MyBets");
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private betuapp.Client.States.DetailState detailState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private betuapp.Client.States.AuthenticationState authenticationstate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
