#pragma checksum "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbc3717f51f713bfd8fff3174aa6193d964f7787"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Papeletas_PapeletasPolicia), @"mvc.1.0.view", @"/Views/Papeletas/PapeletasPolicia.cshtml")]
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
#line 1 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\_ViewImports.cshtml"
using ProyTransitoCoreMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\_ViewImports.cshtml"
using ProyTransitoCoreMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbc3717f51f713bfd8fff3174aa6193d964f7787", @"/Views/Papeletas/PapeletasPolicia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5650d55b2fc177894114b6d5918cf188856e7cb4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Papeletas_PapeletasPolicia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyTransitoCoreMVC.Models.Papeleta>>
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
#line 3 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
  
    ViewData["Title"] = "PapeletasPolicia";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>PapeletasPolicia</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc3717f51f713bfd8fff3174aa6193d964f77874903", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayNameFor(model => model.Fechapap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayNameFor(model => model.Pagado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayNameFor(model => model.Fechapago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayNameFor(model => model.Eliminado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayNameFor(model => model.CodinfNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayNameFor(model => model.CodpolNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayNameFor(model => model.NroplaNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fechapap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pagado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fechapago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayFor(modelItem => item.Eliminado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodinfNavigation.Codinf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodpolNavigation.Codpol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
           Write(Html.DisplayFor(modelItem => item.NroplaNavigation.Nropla));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc3717f51f713bfd8fff3174aa6193d964f778711771", async() => {
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
#line 64 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
                                       WriteLiteral(item.Nropap);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc3717f51f713bfd8fff3174aa6193d964f778713993", async() => {
                WriteLiteral("Details");
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
#line 65 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
                                          WriteLiteral(item.Nropap);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbc3717f51f713bfd8fff3174aa6193d964f778716221", async() => {
                WriteLiteral("Delete");
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
#line 66 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
                                         WriteLiteral(item.Nropap);

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
#line 69 "C:\Users\franc\OneDrive\Documentos\IDAT\C#\Semana 02\SlnTransitoCoreMVC\ProyTransitoCoreMVC\Views\Papeletas\PapeletasPolicia.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyTransitoCoreMVC.Models.Papeleta>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
