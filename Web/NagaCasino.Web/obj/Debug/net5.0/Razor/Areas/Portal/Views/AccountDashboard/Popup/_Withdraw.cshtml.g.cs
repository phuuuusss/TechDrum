#pragma checksum "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\AccountDashboard\Popup\_Withdraw.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "016842ead31ca29edc2313114de6a0316424db98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Portal_Views_AccountDashboard_Popup__Withdraw), @"mvc.1.0.view", @"/Areas/Portal/Views/AccountDashboard/Popup/_Withdraw.cshtml")]
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
#line 1 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using TechDrum.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using TechDrum.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using TechDrum.Web.Models.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using TechDrum.Web.Utils.Notification.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using TechDrum.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using TechDrum.Core.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using Invedia.Web.IUrlHelperUtils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using Invedia.Web.ITempDataDictionaryUtils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using EnumsNET;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"016842ead31ca29edc2313114de6a0316424db98", @"/Areas/Portal/Views/AccountDashboard/Popup/_Withdraw.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eae3cd7c5f504ec7b224d1e4808e92806345fd2", @"/Areas/Portal/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Portal_Views_AccountDashboard_Popup__Withdraw : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ETH", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("balance-form m-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal reveal insert-max witthdraw2modal"" id=""withdraw_modal_eth"" data-keyboard=""false"" data-backdrop=""static"" style="" padding: 3.33333rem 1rem; padding: 1rem; margin-top: 0% !important; top: 3% !important;  padding-left: 0rem !important;"">
    <div class=""content_modal"">
        <h4 style=""font-size: 20px;"">WITHDRAW</h4>
        <p>Available Withdraw: (<span id=""Available_Withdraw""></span><span id=""rateEth""></span>)</p>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "016842ead31ca29edc2313114de6a0316424db986790", async() => {
                WriteLiteral("\n            <label class=\"amount\">\n                <label for=\"cars\">Crypto</label>\n                <select id=\"check_wallet\" class=\"select-naga p-1\" onchange=\"checkwallet()\">\n");
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "016842ead31ca29edc2313114de6a0316424db987290", async() => {
                    WriteLiteral("ETH");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                WriteLiteral("                </select>\n            </label>\n\n            <label class=\"amount\">\n                Amount (NAGA)\n                <input placeholder=\" Amount*\" class=\"withdraw-value p-1\" ");
                WriteLiteral(@" id=""withdraw_amount_eth"" value="""" autocomplete=""off"" name=""amount"" step=""0.1"" type=""tel"" min=""0.02"" required pattern=""^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$"">
                <span id=""maxwithdraw"" class=""btn fill-max-amount"" onclick=""maxWidthETH()"">Max</span>
            </label>

            <label class=""amount"">
                Address Withdraw
                <input style=""width:100%"" id=""address_Widthdraw"" name=""address_Widthdraw"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1534, "\"", 1542, 0);
                EndWriteAttribute();
                WriteLiteral(" autocomplete=\"off\" required placeholder=\"Address\">\n            </label>\n\n");
#nullable restore
#line 27 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\AccountDashboard\Popup\_Withdraw.cshtml"
             if (Model.TwoFactorEnabled)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p class=\"m-0\">2FA Code: </p><input style=\"width:100%\" id=\"2fa-Widthdraw\" name=\"2FA-Widthdraw\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1794, "\"", 1802, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                <br />\n");
#nullable restore
#line 31 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\AccountDashboard\Popup\_Withdraw.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input style=\"width:100%\" id=\"2fa-Widthdraw p-1\" name=\"2FA-Widthdraw\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1970, "\"", 1978, 0);
                EndWriteAttribute();
                WriteLiteral(" hidden>\n                <br />\n");
#nullable restore
#line 36 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\AccountDashboard\Popup\_Withdraw.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <p class=""note"">Note: Due to Ethereum system high volume transaction and gas fee affect withdrawals system so Withdrawals Fee Policy change <span style=""font-style:italic;color:black;"">(Gas fee)</span></p>
            <p class=""note"">Min Withdraw <span style=""font-style:italic;"" ");
                WriteLiteral(">0.02</span> <span style=\"font-style:italic;\"> ETH</span></p>\n            <a class=\"link-naga note\"href=\"/policy\" target=\"_blank\">POLICY **</a>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <a id=""button_WidthdrawETH"" style=""height: auto; padding: 8px;"">Withdraw</a>
        <input style=""background: #f0f8ff00; border: none;"" class=""close-button"" data-dismiss=""modal"" data-close aria-label=""Close reveal"" value=""x"" type=""button"" />
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
