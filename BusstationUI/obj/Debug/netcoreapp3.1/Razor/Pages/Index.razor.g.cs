#pragma checksum "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff6c1c235d77e731b611f251f4ea4261ede0c46d"
// <auto-generated/>
#pragma warning disable 1591
namespace AirlineUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\_Imports.razor"
using AirlineUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\_Imports.razor"
using AirlineUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Index.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Index.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Wizzair</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Index.razor"
                  passenger

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Index.razor"
                                             Insert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.FluentValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.AddMarkupContent(10, "<label>Name</label>\r\n    ");
                __builder2.OpenElement(11, "input");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Index.razor"
                        passenger.name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => passenger.name = __value, passenger.name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n\r\n    <br>\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(15, "<label>LastName</label>\r\n    ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Index.razor"
                        passenger.lastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => passenger.lastName = __value, passenger.lastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n    <br>\r\n    <br>\r\n\r\n    ");
                __builder2.AddMarkupContent(20, "<button type=\"submit\">By ticket now</button>\r\n    <br>\r\n    <br>\r\n    ");
                __builder2.AddContent(21, 
#nullable restore
#line 28 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Index.razor"
     Error

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(22, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Index.razor"
       
    private string Error="";
    private PassengerViewModel passenger = new PassengerViewModel();
  
    public async Task Insert()
    {
       
        var result = await passengerService.AddPassengerAsync(passenger);
        if (result.IsSuccessStatusCode)
            navigationManager.NavigateTo("/passenger");
        //passenger = new PassengerViewModel();
        else
            Error = result.StatusCode.ToString();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PassengerService passengerService { get; set; }
    }
}
#pragma warning restore 1591
