#pragma checksum "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d934101ee52d7c6094f6ce018e8df317c5ac32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Walkers_ManageWalks), @"mvc.1.0.view", @"/Views/Walkers/ManageWalks.cshtml")]
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
#line 1 "C:\Users\Pinto\workspace\SQL\DogGo\Views\_ViewImports.cshtml"
using DogGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pinto\workspace\SQL\DogGo\Views\_ViewImports.cshtml"
using DogGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d934101ee52d7c6094f6ce018e8df317c5ac32", @"/Views/Walkers/ManageWalks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b50fd1f91f777ae09abf39d99992ea9d25da6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Walkers_ManageWalks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DogGo.Models.Walks>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ManageWalks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Confirm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
  
    ViewData["Title"] = "ManageWalks";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <h1>ManageWalks</h1>

    <div class=""row mt-5"">
        <section class=""mr-5"">
            <h2 class=""text-center"">Confirm Appointments</h2>

            <hr class=""mt-5"" />
            <div class=""clearfix""></div>

            <div class=""col border border-dark container h-auto"">
");
#nullable restore
#line 17 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                 foreach(Walks walk in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                     if (walk.WalkStatusId == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card m-2\" style=\"width: 18rem;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89d934101ee52d7c6094f6ce018e8df317c5ac325932", async() => {
                WriteLiteral("\r\n                                <div class=\"card-body\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "89d934101ee52d7c6094f6ce018e8df317c5ac326287", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 24 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => walk.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <div class=\"form-group\">");
#nullable restore
#line 25 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                                                       Write(walk.Dog.Owner.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                    <div class=\"form-group\">");
#nullable restore
#line 26 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                                                       Write(walk.Dog.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                    <div class=\"form-group\">");
#nullable restore
#line 27 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                                                       Write(walk.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89d934101ee52d7c6094f6ce018e8df317c5ac329009", async() => {
                    WriteLiteral("Confirm");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 32 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </section>

        <section class=""ml-2"">
            <h2 class=""text-center"">My Appointments</h2>

            <hr class=""mt-5"" />
            <div class=""clearfix""></div>

            <table class=""table table-striped w-auto"">
                <thead>
                    <tr>                    
                        <th>
                            ");
#nullable restore
#line 47 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                       Write(Html.DisplayNameFor(model => model.Dog.Owner.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 50 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                       Write(Html.DisplayNameFor(model => model.Dog.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 53 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                       Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 56 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 59 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                       Write(Html.DisplayName("Completed"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 65 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
             foreach (var item in Model) 
            {
                if(item.WalkStatusId != 1)
                {                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>                    \r\n                        <td>\r\n                            ");
#nullable restore
#line 71 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Dog.Owner.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 74 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Dog.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 76 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                         if(item.WalkStatusId == 2)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        TBD\r\n                                    </td>\r\n");
#nullable restore
#line 81 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        ");
#nullable restore
#line 85 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                      \r\n                                    </td>\r\n");
#nullable restore
#line 87 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 89 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 91 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                         if(item.WalkStatusId == 2)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        <button>");
#nullable restore
#line 94 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                                           Write(Html.ActionLink("Complete", "CompleteWalk", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                                    </td>\r\n");
#nullable restore
#line 96 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        ");
#nullable restore
#line 100 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                                   Write(Html.Display("Yes"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>                                    \r\n");
#nullable restore
#line 102 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 104 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </section>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 113 "C:\Users\Pinto\workspace\SQL\DogGo\Views\Walkers\ManageWalks.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DogGo.Models.Walks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
