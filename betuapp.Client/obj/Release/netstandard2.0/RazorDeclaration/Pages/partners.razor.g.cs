#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\partners.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09dfdd89dc81a55468aefd034db0934f42026844"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/partners")]
    public class partners : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 48 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\partners.razor"
           
    List<Account> partnerAccounts = new List<Account>();

    protected override async Task OnInitAsync()
    {
        var loggedInAccountId = this.authenticationstate.loggedInAccount.Id;
        partnerAccounts = await Http.GetJsonAsync<List<Account>>("api/AccountData/GetAllPartnerAccountsByAccountId/" + loggedInAccountId);
    }

    void GoToDetail(long accountId)
    {
        detailState.ClickedAccountDetail = partnerAccounts.Where(x => x.Id == accountId).First();
        this.uriHelper.NavigateTo("/accountdetail");
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
