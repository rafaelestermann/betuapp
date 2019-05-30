#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\createbet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f001a95afaac75ed256a7a10961cd80fba3e2e64"
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
    using Microsoft.AspNetCore.Blazor.Services;
    using Microsoft.AspNetCore.Components.Layouts;
    using betuapp.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayoutLoggedIn))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/createbet")]
    public class createbet : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<header>\r\n    <link href=\"..//css/createbet.css\" rel=\"stylesheet\">\r\n</header>\r\n\r\n");
            builder.AddMarkupContent(1, "<div id=\"BreadCrumb\">\r\n    <a href=\"/mybets\">MyBets</a>\r\n    <a href=\"/createbet\">Create Bet</a>\r\n</div>\r\n\r\n");
            builder.AddMarkupContent(2, "<h1>Create Bet</h1>\r\n");
            builder.OpenElement(3, "input");
            builder.AddAttribute(4, "type", "text");
            builder.AddAttribute(5, "name", "email");
            builder.AddAttribute(6, "placeholder", "Name");
            builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(Name));
            builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            builder.CloseElement();
            builder.AddMarkupContent(9, "a\r\n");
            builder.OpenElement(10, "input");
            builder.AddAttribute(11, "type", "text");
            builder.AddAttribute(12, "name", "pass");
            builder.AddAttribute(13, "placeholder", "Description");
            builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(Description));
            builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Description = __value, Description));
            builder.CloseElement();
            builder.AddMarkupContent(16, "\r\n");
            builder.OpenElement(17, "input");
            builder.AddAttribute(18, "type", "text");
            builder.AddAttribute(19, "name", "pass");
            builder.AddAttribute(20, "placeholder", "Acceptance Critereas");
            builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(Description));
            builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Description = __value, Description));
            builder.CloseElement();
            builder.AddMarkupContent(23, "\r\n");
            builder.OpenElement(24, "input");
            builder.AddAttribute(25, "type", "datetime");
            builder.AddAttribute(26, "name", "cpass");
            builder.AddAttribute(27, "placeholder", "DueDate");
            builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(DueDate));
            builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => DueDate = __value, DueDate));
            builder.CloseElement();
            builder.AddMarkupContent(30, "\r\n");
            builder.OpenElement(31, "input");
            builder.AddAttribute(32, "type", "number");
            builder.AddAttribute(33, "name", "cpass");
            builder.AddAttribute(34, "placeholder", "Tip");
            builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(Tip));
            builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Tip = __value, Tip));
            builder.CloseElement();
            builder.AddMarkupContent(37, "\r\n");
            builder.OpenElement(38, "select");
            builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(selectedChallenged));
            builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedChallenged = __value, selectedChallenged));
            builder.AddMarkupContent(41, "\r\n    ");
            builder.AddMarkupContent(42, "<option>Select Challenged</option>\r\n\r\n");
#line 28 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\createbet.razor"
     foreach (var acco in challengeableAccounts)
    {

#line default
#line hidden
            builder.AddContent(43, "        ");
            builder.OpenElement(44, "option");
            builder.AddAttribute(45, "value", acco.Id);
            builder.AddContent(46, acco.Firstname + " " + acco.Lastname);
            builder.CloseElement();
            builder.AddMarkupContent(47, "\r\n");
#line 31 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\createbet.razor"
    }

#line default
#line hidden
            builder.CloseElement();
            builder.AddMarkupContent(48, "\r\n");
            builder.OpenElement(49, "button");
            builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, Create));
            builder.AddContent(51, "Create");
            builder.CloseElement();
            builder.AddMarkupContent(52, "\r\n");
            builder.OpenElement(53, "p");
            builder.AddAttribute(54, "class", "error");
            builder.AddContent(55, errormessage);
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 36 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\createbet.razor"
           
    public List<Account> challengeableAccounts = new List<Account>();
    public string Name;
    public string Description;
    public long Tip;
    public DateTime DueDate;
    public string errormessage;
    public long? selectedChallenged;

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
        this.uriHelper.NavigateTo("/MyBets");
    }

    protected override async Task OnInitAsync()
    {
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
