#pragma checksum "D:\Fall 2021\.NET Web Development\Northwind Traders\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fef86123220c1f21a8129ac22728a5d097457386"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Fall 2021\.NET Web Development\Northwind Traders\Views\_ViewImports.cshtml"
using Northwind_Traders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Fall 2021\.NET Web Development\Northwind Traders\Views\Product\Index.cshtml"
using Northwind_Traders.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fef86123220c1f21a8129ac22728a5d097457386", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045b7d0bf11c42129fa4d1d4a45f88139b15ba3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"bg-primary m-1 p-1 text-white\"><h4>Products</h4></div>\r\n<ul class=\"list-group\">\r\n");
#nullable restore
#line 7 "D:\Fall 2021\.NET Web Development\Northwind Traders\Views\Product\Index.cshtml"
     foreach (Product p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">\r\n            <h5>");
#nullable restore
#line 10 "D:\Fall 2021\.NET Web Development\Northwind Traders\Views\Product\Index.cshtml"
           Write(p.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <ul class=\"list-group m-2\">\r\n                <li class=\"list-group-item\">\r\n                    Unit Price: $");
#nullable restore
#line 13 "D:\Fall 2021\.NET Web Development\Northwind Traders\Views\Product\Index.cshtml"
                            Write(p.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li class=\"list-group-item\">\r\n                    Units in Stock: ");
#nullable restore
#line 16 "D:\Fall 2021\.NET Web Development\Northwind Traders\Views\Product\Index.cshtml"
                               Write(p.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n        </li>\r\n");
#nullable restore
#line 20 "D:\Fall 2021\.NET Web Development\Northwind Traders\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
