#pragma checksum "F:\DivarPRJCT\TDivar3\TDivar3\Views\Shared\Components\VisitComponent\ShowVisit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1a2bb23a85f0a754a014b7a628df2962a61f070"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VisitComponent_ShowVisit), @"mvc.1.0.view", @"/Views/Shared/Components/VisitComponent/ShowVisit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1a2bb23a85f0a754a014b7a628df2962a61f070", @"/Views/Shared/Components/VisitComponent/ShowVisit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_VisitComponent_ShowVisit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataAccessLayer.Entites.Visit>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 12 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
         if (Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-6 col-lg-offset-3 col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2 col-xs-10 col-xs-offset-1"">

                <div class=""alert alert-danger text-center"">
                    <h5 class=""text-center"">هنوز بازدیدی از آگهی ها نداشته اید</h5>
                </div>

            </div>
");
#nullable restore
#line 21 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
        }
        else
        {
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-md-3 col-sm-6 col-xs-12\">\r\n                    <div class=\"thumbnail\">\r\n                        ");
#nullable restore
#line 28 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
                    Write(await Component.InvokeAsync("FirstImageComponent", item.Advert.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        <div class=\"caption\">\r\n                            <h3 class=\"text-center\">");
#nullable restore
#line 31 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
                                               Write(item.Advert.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <h5 class=\"text-center\">");
#nullable restore
#line 32 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
                                               Write(item.Advert.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1041, "\"", 1102, 4);
            WriteAttributeValue("", 1048, "/HomeF/Adverts/", 1048, 15, true);
#nullable restore
#line 33 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
WriteAttributeValue("", 1063, item.Advert.Id, 1063, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1078, "?title=", 1078, 7, true);
#nullable restore
#line 33 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
WriteAttributeValue("", 1085, item.Advert.Name, 1085, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-red btn-block text-center\">نمایش جزئیات</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 37 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Shared\Components\VisitComponent\ShowVisit.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataAccessLayer.Entites.Visit>> Html { get; private set; }
    }
}
#pragma warning restore 1591