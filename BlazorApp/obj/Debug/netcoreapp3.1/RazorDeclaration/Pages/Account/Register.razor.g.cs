#pragma checksum "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\Account\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f22d58594cd56b586648a3572b0154d70a5e35f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\Account\Register.razor"
using BlazorApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\Account\Register.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\Account\Register.razor"
       
    public RegisterViewModel RegisterViewModel { get; set; }
    public string Succes;
    protected override void OnInitialized()
    {
        RegisterViewModel = new RegisterViewModel();
    }
    protected async Task Create()
    {
        var res = await _accountService.Register(RegisterViewModel);
        if (res.Success)
        {
            NavigationManager.NavigateTo("/Login");
        }
        else
        {
            RegisterViewModel = new RegisterViewModel();
            Succes = res.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountService _accountService { get; set; }
    }
}
#pragma warning restore 1591
