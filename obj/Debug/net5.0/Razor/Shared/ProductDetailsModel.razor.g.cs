#pragma checksum "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Shared\ProductDetailsModel.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53be4f5e5202c5a70899fdb18297cd6df4211661"
// <auto-generated/>
#pragma warning disable 1591
namespace ECommerceApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\_Imports.razor"
using ECommerceApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\_Imports.razor"
using ECommerceApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class ProductDetailsModel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "cus-modal modal-overlay");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Shared\ProductDetailsModel.razor"
                                               CloseModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-z2gkku9gxv");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "modal-content");
            __builder.AddAttribute(6, "b-z2gkku9gxv");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddAttribute(9, "b-z2gkku9gxv");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "class", "w-200 col-6");
            __builder.AddAttribute(12, "src", 
#nullable restore
#line 4 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Shared\ProductDetailsModel.razor"
                                           Product.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "alt", 
#nullable restore
#line 4 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Shared\ProductDetailsModel.razor"
                                                                   Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "b-z2gkku9gxv");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-6");
            __builder.AddAttribute(18, "b-z2gkku9gxv");
            __builder.OpenElement(19, "h4");
            __builder.AddAttribute(20, "b-z2gkku9gxv");
            __builder.AddContent(21, 
#nullable restore
#line 6 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Shared\ProductDetailsModel.razor"
                     Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "p");
            __builder.AddAttribute(24, "b-z2gkku9gxv");
            __builder.AddContent(25, 
#nullable restore
#line 7 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Shared\ProductDetailsModel.razor"
                    Product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "p");
            __builder.AddAttribute(28, "b-z2gkku9gxv");
            __builder.AddContent(29, "Price: ");
            __builder.AddContent(30, 
#nullable restore
#line 8 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Shared\ProductDetailsModel.razor"
                           Product.Price.ToString("C2")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "p");
            __builder.AddAttribute(33, "b-z2gkku9gxv");
            __builder.AddContent(34, "Description : ");
            __builder.AddContent(35, 
#nullable restore
#line 9 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Shared\ProductDetailsModel.razor"
                                  Product.LongDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "sort-btn mt-4");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Shared\ProductDetailsModel.razor"
                                                CloseModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "b-z2gkku9gxv");
            __builder.AddContent(41, "Close");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Shared\ProductDetailsModel.razor"
       
    [Parameter] public Product Product { get; set; }
    [Parameter] public EventCallback OnClose { get; set; }

    private async Task CloseModal()
    {
        await OnClose.InvokeAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591