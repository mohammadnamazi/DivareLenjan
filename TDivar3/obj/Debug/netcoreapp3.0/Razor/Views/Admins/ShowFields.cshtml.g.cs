#pragma checksum "F:\DivarPRJCT\TDivar3\TDivar3\Views\Admins\ShowFields.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0817d83708f3018796ff75a5d651b9c56b5c641"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_ShowFields), @"mvc.1.0.view", @"/Views/Admins/ShowFields.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0817d83708f3018796ff75a5d651b9c56b5c641", @"/Views/Admins/ShowFields.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Admins_ShowFields : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccessLayer.Entites.Advert>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-padding"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Admins\ShowFields.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0817d83708f3018796ff75a5d651b9c56b5c6413412", async() => {
                WriteLiteral("\r\n    <div dir=\"rtl\">\r\n        <div>\r\n            <h2>");
#nullable restore
#line 9 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Admins\ShowFields.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n            <h4 class=\"pull-right\">تاریخ آگهی : ");
#nullable restore
#line 10 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Admins\ShowFields.cshtml"
                                           Write(Model.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n            <h4 class=\"pull-left\">بازدید : ");
#nullable restore
#line 11 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Admins\ShowFields.cshtml"
                                      Write(Model.Seen);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n        </div>\r\n\r\n        <div class=\"clearfix\"></div>\r\n\r\n        <div class=\"mg-top-30\">\r\n            <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 423, "\"", 499, 2);
                WriteAttributeValue("", 433, "document.getElementById(\'showmobile\').innerHTML=", 433, 48, true);
#nullable restore
#line 17 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Admins\ShowFields.cshtml"
WriteAttributeValue("", 481, Model.User.Mobile, 481, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn-red pull-right\">نمایش شماره تلفن</a>\r\n        </div>\r\n\r\n        <div class=\"clearfix\"></div>\r\n\r\n        <h4 id=\"showmobile\"></h4>\r\n\r\n        <div class=\"clearfix\"></div>\r\n\r\n        <div class=\"mg-top-30\">\r\n            <p>");
#nullable restore
#line 27 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Admins\ShowFields.cshtml"
          Write(Model.Des);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"clearfix\"></div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 33 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Admins\ShowFields.cshtml"
       Write(await Component.InvokeAsync("AdminFieldComponent", Model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"Pic\">\r\n            ");
#nullable restore
#line 37 "F:\DivarPRJCT\TDivar3\TDivar3\Views\Admins\ShowFields.cshtml"
       Write(await Component.InvokeAsync("AdminGalleryComponent", Model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccessLayer.Entites.Advert> Html { get; private set; }
    }
}
#pragma warning restore 1591
