#pragma checksum "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acf07cb9f2af33c73b2f66475d21d697ac484a1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\_ViewImports.cshtml"
using MicrogreensWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\_ViewImports.cshtml"
using MicrogreensWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acf07cb9f2af33c73b2f66475d21d697ac484a1f", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c70187445bf5771ea367a1055aa76e4cf5841cc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MicrogreensWebsite.Models.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br></br>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf07cb9f2af33c73b2f66475d21d697ac484a1f4764", async() => {
                WriteLiteral("\r\n        <input type=\"submit\" class=\"btn btn-success\" value=\"Add New Product\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>



<table class=""table text-dark table-hover"" style="" border: 1px solid black; border-radius: 10px;"" >
    <thead>
        <tr style=""background-color:lightgreen "">
            <th style="" border: 1px solid black; border-radius: 10px;"">
                ");
#nullable restore
#line 20 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 23 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 26 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style =\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 29 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductSuppliedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 32 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 35 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th >\r\n            <th style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 38 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 41 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsOnSale));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 44 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 47 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Farmer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\" border: 1px solid black; border-radius: 10px;\" ></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 53 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"text-dark\">\r\n            <td style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 56 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n                <td style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 59 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n                <td style=\" border: 1px solid black; border-radius: 10px;\">\r\n");
            WriteLiteral("\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2720, "\"", 2757, 1);
#nullable restore
#line 65 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
WriteAttributeValue("", 2726, Url.Content(item.ProductImage), 2726, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"150\" , width=\"150\">\r\n\r\n            </td style=\" border: 1px solid black; border-radius: 10px;\">\r\n            <td style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 69 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductSuppliedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 72 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 75 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 78 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 81 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsOnSale));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 84 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
#nullable restore
#line 87 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Farmer.FarmerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td style=\" border: 1px solid black; border-radius: 10px;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf07cb9f2af33c73b2f66475d21d697ac484a1f15172", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
                                       WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf07cb9f2af33c73b2f66475d21d697ac484a1f17377", async() => {
                WriteLiteral("Detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
                                          WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf07cb9f2af33c73b2f66475d21d697ac484a1f19587", async() => {
                WriteLiteral("Delete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
                                         WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 95 "C:\Users\jatinder\source\repos\MicrogreensWebsiteVersion2 - Copy\MicrogreensWebsite\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MicrogreensWebsite.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
