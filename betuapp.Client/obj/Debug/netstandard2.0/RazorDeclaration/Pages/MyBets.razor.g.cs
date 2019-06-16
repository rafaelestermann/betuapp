#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "085ed3f7ffec6c91add64719302747ee1606cdfa"
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
        }
        #pragma warning restore 1998
#line 89 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\MyBets.razor"
           
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
