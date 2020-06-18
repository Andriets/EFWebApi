#pragma checksum "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "487a6406d2d24b4df31573848531989af7ab0db8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
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
#line 2 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\FetchData.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\FetchData.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\FetchData.razor"
using DAL.Owner_Parameters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\FetchData.razor"
using ClassLibrary1.Interfaces.IServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\FetchData.razor"
using ClassLibrary1.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\FetchData.razor"
using BlazorApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\FetchData.razor"
using BlazorApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\FetchData.razor"
using BLL.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "D:\Study\2 курс\OOП\Entity Framework\EFWebApiV3\BlazorApp\Pages\FetchData.razor"
       

    protected string? Type;

    protected string[] Types =
    {
          "Window",
          "Door",
          "Both"
    };

    public decimal PriceTo
    {
        get => priceTo;
        set
        {
            priceTo = value;
            this.StateHasChanged();
        }
    }

    private decimal priceTo = 0;

    List<ProductView> products;
    List<ProductView> Searchproducts;
    private int pageNum = 1;
    private int pageSize = 2;
    protected override async Task OnInitializedAsync()
    {
        PagingParameters p = new PagingParameters
        {
            PageNumber = pageNum,
            PageSize = pageSize
        };
        products = await productService.GetAll(p);
    }
    public async Task NextPage()
    {
        pageNum++;
        if (Searchproducts != null)
        {
            await this.Search();
        }
        else
        {
            products = await productService.GetAll(new PagingParameters { PageNumber = pageNum, PageSize = pageSize });
        }
    }
    public async Task PrevPage()
    {
        if (pageNum > 1)
        {
            pageNum--;
            if (Searchproducts != null)
            {
                await this.Search();
            }
            else
            {
                products = await productService.GetAll(new PagingParameters { PageNumber = pageNum, PageSize = pageSize });
            }
        }
    }
    public async Task Search()
    {
        PagingParameters p = new PagingParameters
        {
            PageNumber = pageNum,
            PageSize = pageSize,
            Type = Type ?? "Both",
            Price = decimal.ToDouble(priceTo) == 0 ? 30000 : decimal.ToDouble(priceTo)
        };
        Searchproducts = await productService.GetByFilter(p);
        products = Searchproducts;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductService productService { get; set; }
    }
}
#pragma warning restore 1591
