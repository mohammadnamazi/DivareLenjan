#pragma checksum "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dea7850b315cfd4d4e0d7d8eb88d42094fb609c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeF_ShowAdverts), @"mvc.1.0.view", @"/Views/HomeF/ShowAdverts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea7850b315cfd4d4e0d7d8eb88d42094fb609c5", @"/Views/HomeF/ShowAdverts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeF_ShowAdverts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataAccessLayer.Entites.Advert>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
  
    ViewData["Title"] = "ShowAdverts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container-fluid\">\r\n\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 11 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
             if (ViewBag.MyCount == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-6 col-lg-offset-3 col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2 col-xs-10 col-xs-offset-1"">

                    <div class=""alert alert-danger text-center"">
                        <h5 class=""text-center"">در حال حاضر آگهی برای این شهر وجود ندارد</h5>
                    </div>

                </div>
");
#nullable restore
#line 20 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
            }
            else
            {
                foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-md-3 col-sm-2 col-xs-12\">\r\n\r\n                        <div class=\"thumbnail\">\r\n\r\n                            ");
#nullable restore
#line 29 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
                        Write(await Component.InvokeAsync("FirstImageComponent", item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            <div class=\"caption\">\r\n\r\n                                <h3 class=\"text-center\">");
#nullable restore
#line 33 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <h5 class=\"text-center\">");
#nullable restore
#line 34 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
                                                   Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1137, "\"", 1167, 2);
            WriteAttributeValue("", 1144, "/HomeF/Adverts/", 1144, 15, true);
#nullable restore
#line 35 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
WriteAttributeValue("", 1159, item.Id, 1159, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-red btn-block text-center\">نمایش جزئیات</a>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 40 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 44 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
         if (ViewBag.MyCount != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row text-center\">\r\n\r\n                <div class=\"pageination\">\r\n\r\n");
#nullable restore
#line 50 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
                     for (int i = 1; i < ViewBag.PageCount; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("class", " class=\"", 1627, "\"", 1676, 1);
#nullable restore
#line 52 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
WriteAttributeValue("", 1635, ((int)ViewBag.PageId == i)?"active":"", 1635, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1677, "\"", 1731, 4);
            WriteAttributeValue("", 1684, "/Home/ShowAdverts/", 1684, 18, true);
#nullable restore
#line 52 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
WriteAttributeValue("", 1702, ViewBag.CityId, 1702, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1717, "?pageNumber=", 1717, 12, true);
#nullable restore
#line 52 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
WriteAttributeValue("", 1729, i, 1729, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
                                                                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 53 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 58 "F:\DivarPRJCT\TDivar3\TDivar3\Views\HomeF\ShowAdverts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataAccessLayer.Entites.Advert>> Html { get; private set; }
    }
}
#pragma warning restore 1591