#pragma checksum "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12f0fe93f90113513905b6f0068a60efcf6c72eb"
// <auto-generated/>
#pragma warning disable 1591
namespace WebAssembly.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using WebAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using WebAssembly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        Hello, ");
                __builder2.AddContent(3, 
#nullable restore
#line 9 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Shared\LoginDisplay.razor"
                context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(4, "!\r\n        ");
                __builder2.OpenElement(5, "button");
                __builder2.AddAttribute(6, "class", "nav-link btn btn-link");
                __builder2.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Shared\LoginDisplay.razor"
                                                        BeginSignOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(8, "Log out");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n    ");
            }
            ));
            __builder.AddAttribute(10, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, "<a href=\"authentication/login\">Log in</a>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\files\Github\Compilateur\Compilateur\Compilateur\WebAssembly\WebAssembly\Shared\LoginDisplay.razor"
      
    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591