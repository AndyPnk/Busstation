#pragma checksum "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Passenger\Passenger.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3664a86d8f61c64ebc7475cdabe459157033687"
// <auto-generated/>
#pragma warning disable 1591
namespace AirlineUI.Pages.Passenger
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
#line 3 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Passenger\Passenger.razor"
using AirlineUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Passenger\Passenger.razor"
using AirlineUI.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/passenger")]
    public partial class Passenger : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Passenger</h1>\r\n");
#nullable restore
#line 9 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Passenger\Passenger.razor"
 if (passengers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 12 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Passenger\Passenger.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>LastName</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 23 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Passenger\Passenger.razor"
             foreach (var passenger in passengers)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 26 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Passenger\Passenger.razor"
                     passenger.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 27 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Passenger\Passenger.razor"
                     passenger.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 29 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Passenger\Passenger.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 32 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Passenger\Passenger.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\User\Desktop\Doker\Airline\AirlineUI\Pages\Passenger\Passenger.razor"
       
   IEnumerable<PassengerViewModel> passengers;

    protected override async Task OnInitializedAsync()
    {
       passengers=await passengerService.GetAllPassengerAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PassengerService passengerService { get; set; }
    }
}
#pragma warning restore 1591
