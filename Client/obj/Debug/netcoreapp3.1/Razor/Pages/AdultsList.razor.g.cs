#pragma checksum "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd8586ea02ec0cadd9d981258796b0767a4a80fb"
// <auto-generated/>
#pragma warning disable 1591
namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DNPHandin4\DNPHandin4\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DNPHandin4\DNPHandin4\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DNPHandin4\DNPHandin4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DNPHandin4\DNPHandin4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DNPHandin4\DNPHandin4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DNPHandin4\DNPHandin4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DNPHandin4\DNPHandin4\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DNPHandin4\DNPHandin4\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DNPHandin4\DNPHandin4\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
using DNPHandin4.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
using DNPHandin4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AdultsList")]
    public partial class AdultsList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Adults List</h1>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by Adult Id: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
                                                         (arg) => Filter(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddMarkupContent(10, "\r\n    Filtered by Sex:\r\n    ");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "class", "form-control selectpicker");
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
                                                           (arg) => FilteredBySex(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "style", "width:100");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "option");
            __builder.AddContent(17, "F");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "option");
            __builder.AddContent(20, "M");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "option");
            __builder.AddContent(23, "Other");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 19 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
 if (adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "    ");
            __builder.AddMarkupContent(28, "<p>\r\n        <em>List is loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 24 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
}
else if (!adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "    ");
            __builder.AddMarkupContent(30, "<p>\r\n        The file is empty, no list displayed...\r\n    </p>\r\n");
#nullable restore
#line 30 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "    ");
            __builder.OpenElement(32, "table");
            __builder.AddAttribute(33, "class", "table");
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddMarkupContent(35, @"<thead>
            <tr>
                <th>Adult ID</th>
                <th>Job Title</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Hair Color</th>
                <th>Eye Color</th>
                <th>Age</th>
                <th>Weight</th>
                <th>Sex</th>
                <th>Remove</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(36, "tbody");
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 49 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
             foreach (var item in adultsToShow)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "            ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 52 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 53 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
                     item.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 54 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 55 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 56 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 57 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 58 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 59 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 60 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.OpenElement(68, "td");
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
                                        () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(72, "\r\n                        <i class=\"oi oi-trash\" style=\"color:red\"></i>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 67 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 70 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "D:\DNPHandin4\DNPHandin4\Client\Pages\AdultsList.razor"
       
    private IList<Adult> allAdults;
    private IList<Adult> adultsToShow;

    private int? filteredById;
    private string? filterBySex;

    protected override async Task OnInitializedAsync()
    {
        allAdults = await AdultsService.GetAdults();
        adultsToShow = allAdults;
    }
    private async Task RemoveAdult(int id)
    {
        Adult adultToRemove = allAdults.First(a => a.Id == id);
        await AdultsService.RemoveAdult(id);
        adultsToShow.Remove(adultToRemove);
    }
    private void Filter(ChangeEventArgs changeEventArgs)
    {
        filteredById = null;
        try
        {
            filteredById = int.Parse(changeEventArgs.Value.ToString());
        } catch (Exception e)
        {

        }
        ExecuteFilter();
    }

    private void FilteredBySex(ChangeEventArgs args)
    {
        filterBySex = null;
        try
        {
            filterBySex = args.Value.ToString();
        } catch (Exception e)
        {

        }
        ExecuteFilter();
    }
    private void ExecuteFilter()
    {
        adultsToShow = allAdults.Where(t =>
        (filteredById != null && t.Id == filteredById || filteredById == null) && (filterBySex != null && t.Sex == filterBySex || filterBySex == null)).ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsService AdultsService { get; set; }
    }
}
#pragma warning restore 1591
