#pragma checksum "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "741d986335f8d1dd35b220661130e257ecd77137"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
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
#line 1 "D:\Рабочий стол\MUG\MUG\Views\_ViewImports.cshtml"
using MUG.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"741d986335f8d1dd35b220661130e257ecd77137", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae0e8222b4bb49ea17459781bba2e192a52e3e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MUG.Models.OrderDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""order-conf""style=""display: none; font-size: 1px; color: #fefefe; line-height: 1px; font-family: Open Sans, Helvetica, Arial, sans-serif; max-height: 0px; max-width: 0px; opacity: 0; overflow: hidden;"">
        For what reason would it be advisable for me to think about business content? That might be little bit risky to have crew member like them.
    </div>
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
        <tr>
            <td align=""center"" style=""background-color: #eeeeee;"" bgcolor=""#eeeeee"">
                <table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width:600px;"">
                    <tr>
                        <td align=""center"" style=""padding: 35px 35px 20px 35px; background-color: #ffffff;"" bgcolor=""#ffffff"">
                            <table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width:600px;"">
                                <tr>
                               ");
            WriteLiteral(@"     <td align=""center"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 24px; padding-top: 25px;""> <img src=""https://img.icons8.com/carbon-copy/100/000000/checked-checkbox.png"" width=""125"" height=""120"" style=""display: block; border: 0px;"" /><br>
                                        <h2 style=""font-size: 30px; font-weight: 800; line-height: 36px; color: #333333; margin: 0;""> Please confirm your order </h2>
                                    </td>
                                </tr>
                                <tr>
                                    <td align=""left"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 24px; padding-top: 10px;"">
                                        <p style=""font-size: 16px; font-weight: 400; line-height: 24px; color: #777777;""> You can choose multiple of additions and if it is already contains in coffee you order we don't add it </p>
        ");
            WriteLiteral(@"                            </td>
                                </tr>
                                <tr>
                                    <td align=""left"" style=""padding-top: 20px;"">
                                        <table cellspacing=""0"" cellpadding=""0"" border=""0"" width=""100%"">
                                            <tr>
                                                <td width=""75%"" align=""left"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 24px; padding: 15px 10px 5px 10px;"">
                                                    Coffee: ");
#nullable restore
#line 29 "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml"
                                                       Write(Model.ProductItem.productName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </td>
                                                <td width=""25%"" align=""left"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 24px; padding: 15px 10px 5px 10px;"">
                                                    ");
#nullable restore
#line 32 "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml"
                                               Write(Model.ProductItem.cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width=""75%"" align=""left"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 600; line-height: 30px; padding: 5px 10px;"">
                                                    Additions:
                                                </td>
                                                <td width=""25%"" align=""left"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 24px; padding: 5px 10px;"">
                                                    
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width=""75%"" align=""left"" style=""font-family: Open Sans, H");
            WriteLiteral("elvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 24px; padding: 5px 10px;\">\r\n                                                    ");
#nullable restore
#line 45 "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml"
                                               Write(Model.AdditionsItem1?.additionName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </td>
                                                <td width=""25%"" align=""left"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 24px; padding: 5px 10px;"">
                                                    ");
#nullable restore
#line 48 "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml"
                                               Write(Model.AdditionsItem1?.cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width=""75%"" align=""left"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 24px; padding: 5px 10px;"">
                                                    ");
#nullable restore
#line 53 "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml"
                                               Write(Model.AdditionsItem2?.additionName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </td>
                                                <td width=""25%"" align=""left"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 24px; padding: 5px 10px;"">
                                                    ");
#nullable restore
#line 56 "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml"
                                               Write(Model.AdditionsItem2?.cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width=""75%"" align=""left"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 24px; padding: 5px 10px;"">
                                                    ");
#nullable restore
#line 61 "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml"
                                               Write(Model.AdditionsItem3?.additionName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </td>
                                                <td width=""25%"" align=""left"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 24px; padding: 5px 10px;"">
                                                    ");
#nullable restore
#line 64 "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml"
                                               Write(Model.AdditionsItem3?.cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </td>
                                            </tr>
                                            
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td align=""left"" style=""padding-top: 20px;"">
                                        <table cellspacing=""0"" cellpadding=""0"" border=""0"" width=""100%"">
                                            <tr>
                                                <td width=""75%"" align=""left"" style=""font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 800; line-height: 24px; padding: 10px; border-top: 3px solid #eeeeee; border-bottom: 3px solid #eeeeee;"">
                                                    TOTAL
                                                </td>
                                                <td width=""25%"" align=""lef");
            WriteLiteral("t\" style=\"font-family: Open Sans, Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 800; line-height: 24px; padding: 10px; border-top: 3px solid #eeeeee; border-bottom: 3px solid #eeeeee;\">\r\n                                                     ");
#nullable restore
#line 79 "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml"
                                                Write(Model.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td align=""center"" height=""100%"" valign=""top"" width=""100%"" style=""padding: 0 35px 35px 35px; background-color: #ffffff;"" bgcolor=""#ffffff"">
                            <table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width:660px;"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "741d986335f8d1dd35b220661130e257ecd7713714411", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"prodId\"");
                BeginWriteAttribute("value", " value=\"", 8460, "\"", 8489, 1);
#nullable restore
#line 92 "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml"
WriteAttributeValue("", 8468, Model.ProductItem.id, 8468, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"hidden\" name=\"addition1\"");
                BeginWriteAttribute("value", " value=\"", 8566, "\"", 8599, 1);
#nullable restore
#line 93 "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml"
WriteAttributeValue("", 8574, Model.AdditionsItem1?.id, 8574, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"hidden\" name=\"addition2\"");
                BeginWriteAttribute("value", " value=\"", 8676, "\"", 8709, 1);
#nullable restore
#line 94 "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml"
WriteAttributeValue("", 8684, Model.AdditionsItem2?.id, 8684, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"hidden\" name=\"addition3\"");
                BeginWriteAttribute("value", " value=\"", 8786, "\"", 8819, 1);
#nullable restore
#line 95 "D:\Рабочий стол\MUG\MUG\Views\Order\Order.cshtml"
WriteAttributeValue("", 8794, Model.AdditionsItem3?.id, 8794, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <input type=\"submit\" value=\"Order\"/>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </table>\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MUG.Models.OrderDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
