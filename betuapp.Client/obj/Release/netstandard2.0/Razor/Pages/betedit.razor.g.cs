#pragma checksum "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\betedit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c729c8ec0f175284b1f529b8bacaf04123593103"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/betedit")]
    public class betedit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<header>\r\n    <link href=\"..//css/createbet.css\" rel=\"stylesheet\">\r\n    <link href=\"..//css/general.css\" rel=\"stylesheet\">\r\n</header>\r\n\r\n\r\n\r\n");
            builder.OpenElement(1, "div");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.AddMarkupContent(3, "<a id=\"breadCrumbText\" href=\"/mybets\">MyBets</a>\r\n    ");
            builder.AddMarkupContent(4, "<a id=\"breadCrumbText\">/</a>\r\n    ");
            builder.OpenElement(5, "a");
            builder.AddAttribute(6, "id", "breadCrumbText");
            builder.AddAttribute(7, "href", "/betedit");
            builder.AddContent(8, "Edit ");
            builder.AddContent(9, detailState.ClickedBetDetail.Name);
            builder.CloseElement();
            builder.AddMarkupContent(10, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(11, "\r\n\r\n");
            builder.AddMarkupContent(12, "<h1>Edit Bet</h1>\r\n");
            builder.AddMarkupContent(13, "<label>Name:</label>\r\n");
            builder.OpenElement(14, "input");
            builder.AddAttribute(15, "type", "text");
            builder.AddAttribute(16, "name", "email");
            builder.AddAttribute(17, "placeholder", "Name");
            builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(Name));
            builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            builder.CloseElement();
            builder.AddMarkupContent(20, "\r\n");
            builder.AddMarkupContent(21, "<label>Description:</label>\r\n");
            builder.OpenElement(22, "textarea");
            builder.AddAttribute(23, "id", "descriptionArea");
            builder.AddAttribute(24, "type", "text");
            builder.AddAttribute(25, "name", "pass");
            builder.AddAttribute(26, "placeholder", "Description");
            builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(Description));
            builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Description = __value, Description));
            builder.CloseElement();
            builder.AddMarkupContent(29, "\r\n");
            builder.AddMarkupContent(30, "<label>DueDate:</label>\r\n");
            builder.OpenElement(31, "input");
            builder.AddAttribute(32, "type", "datetime");
            builder.AddAttribute(33, "name", "cpass");
            builder.AddAttribute(34, "placeholder", "DueDate");
            builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(DueDate));
            builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => DueDate = __value, DueDate));
            builder.CloseElement();
            builder.AddMarkupContent(37, "\r\n");
            builder.AddMarkupContent(38, "<label>Tip:</label>\r\n");
            builder.OpenElement(39, "div");
            builder.AddAttribute(40, "style", "display: flex;");
            builder.AddMarkupContent(41, "\r\n    ");
            builder.OpenElement(42, "input");
            builder.AddAttribute(43, "type", "number");
            builder.AddAttribute(44, "name", "cpass");
            builder.AddAttribute(45, "placeholder", "Tip");
            builder.AddAttribute(46, "style", "flex-grow: 1;");
            builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(Tip));
            builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Tip = __value, Tip));
            builder.CloseElement();
            builder.AddMarkupContent(49, "\r\n    ");
            builder.AddMarkupContent(50, "<div id=\"CHFdiv\">\r\n        <span style=\"display:table-cell; vertical-align:middle;\">CHF</span>\r\n    </div>\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(51, "\r\n\r\n");
            builder.AddMarkupContent(52, "<label>Acceptance Critereas:</label>\r\n");
            builder.OpenElement(53, "ul");
            builder.AddMarkupContent(54, "\r\n");
#line 40 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\betedit.razor"
     if (AcceptanceCritereas.Any())
    {
        foreach (var criterea in AcceptanceCritereas)
        {
            if (criterea.Text == null)
            {

#line default
#line hidden
            builder.AddMarkupContent(55, "                <li id=\"listpoint\"></li>\r\n");
#line 47 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\betedit.razor"
            }
            else
            {

#line default
#line hidden
            builder.AddContent(56, "                ");
            builder.OpenElement(57, "li");
            builder.AddAttribute(58, "id", "listpoint");
            builder.AddContent(59, criterea.Text);
            builder.CloseElement();
            builder.AddMarkupContent(60, "\r\n");
#line 51 "C:\Users\rafae\source\repos\betuapp\betuapp.Client\Pages\betedit.razor"
            }
        }
    }

#line default
#line hidden
            builder.CloseElement();
            builder.AddMarkupContent(61, "\r\n\r\n");
            builder.OpenElement(62, "div");
            builder.AddAttribute(63, "style", "display: flex;");
            builder.AddMarkupContent(64, "\r\n    ");
            builder.OpenElement(65, "input");
            builder.AddAttribute(66, "type", "text");
            builder.AddAttribute(67, "style", "flex-grow: 1;");
            builder.AddAttribute(68, "placeholder", "new criterea");
            builder.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(currentCriterea));
            builder.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentCriterea = __value, currentCriterea));
            builder.CloseElement();
            builder.AddMarkupContent(71, "\r\n    ");
            builder.OpenElement(72, "button");
            builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, AddCriterea));
            builder.AddAttribute(74, "id", "addCritereaButton");
            builder.AddContent(75, "+");
            builder.CloseElement();
            builder.AddMarkupContent(76, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(77, "\r\n\r\n\r\n");
            builder.OpenElement(78, "p");
            builder.AddAttribute(79, "class", "error");
            builder.AddContent(80, errormessage);
            builder.CloseElement();
            builder.AddMarkupContent(81, "\r\n");
            builder.OpenElement(82, "button");
            builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, Save));
            builder.AddAttribute(84, "id", "createButton");
            builder.AddContent(85, "Save");
            builder.CloseElement();
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