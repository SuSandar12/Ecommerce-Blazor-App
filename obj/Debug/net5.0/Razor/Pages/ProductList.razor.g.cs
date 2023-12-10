#pragma checksum "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f5c26892b8fe84d02bf9198ec1446d95041ff3f"
// <auto-generated/>
#pragma warning disable 1591
namespace ECommerceApp.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/productlist")]
    public partial class ProductList : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "px-4");
            __builder.AddMarkupContent(2, "<h3 class=\"text-center p-2 text-uppercase\">Product List</h3>\r\n\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "mb-2 sort-btn");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
                                            SortByPriceAsc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Sort by Price (Asc)");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "mb-2 sort-btn");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
                                            SortByPriceDesc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Sort by Price (Desc)");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
#nullable restore
#line 10 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
             foreach (var product in sortedProducts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-md-4 mb-3");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card product");
            __builder.AddAttribute(19, "style", "cursor:pointer;");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
                                                                                () => ShowProductDetails(product)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(21, "img");
            __builder.AddAttribute(22, "src", 
#nullable restore
#line 14 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
                                   product.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "class", "card-img-top");
            __builder.AddAttribute(24, "alt", 
#nullable restore
#line 14 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
                                                                                 product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "card-body");
            __builder.OpenElement(28, "p");
            __builder.AddContent(29, 
#nullable restore
#line 16 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
                                product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "p");
            __builder.AddContent(32, 
#nullable restore
#line 17 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
                                product.Price.ToString("C2")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "p");
            __builder.AddContent(35, 
#nullable restore
#line 18 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
                                product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
 if (selectedProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ECommerceApp.Shared.ProductDetailsModel>(36);
            __builder.AddAttribute(37, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Product>(
#nullable restore
#line 27 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
                                 selectedProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 27 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
                                                           CloseModal

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 28 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\00_Code\Suzy\Blazor Demo\ECommerceApp\Pages\ProductList.razor"
       
    List<Product> products = new List<Product>
    {
        new Product { Name = "Product 1", Price = 170.00, ImageUrl = "/assets/images/product1.jpg", Description = "Description 1", Type = "Perfume", LongDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
        new Product { Name = "Product 2", Price = 150.00, ImageUrl = "/assets/images/product2.jpg", Description = "Description 2", Type = "Perfume",  LongDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book."},
        new Product { Name = "Product 3", Price = 200.00, ImageUrl = "/assets/images/product3.jpg", Description = "Description 3", Type = "Perfume",  LongDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book." },
        
    };

    List<Product> sortedProducts;
    Product selectedProduct;

    protected override void OnInitialized()
    {
        sortedProducts = new List<Product>(products);
    }

     private void SortByPriceAsc()
    {
        sortedProducts = sortedProducts.OrderBy(p => p.Price).ToList();
    }

    private void SortByPriceDesc()
    {
        sortedProducts = sortedProducts.OrderByDescending(p => p.Price).ToList();
    }
    private void ShowProductDetails(Product product)
    {
        selectedProduct = product;
    StateHasChanged();
    }

    private void CloseModal()
    {
        selectedProduct = null;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
