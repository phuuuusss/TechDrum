#pragma checksum "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\TechDrum\Web\NagaCasino.Web\Areas\Portal\Views\AccountDashboard\Popup\_Tranfer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d98503dd614406092f257bd8bea7a7da89f81709"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Portal_Views_AccountDashboard_Popup__Tranfer), @"mvc.1.0.view", @"/Areas/Portal/Views/AccountDashboard/Popup/_Tranfer.cshtml")]
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
#line 1 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\TechDrum\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using TechDrum.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\TechDrum\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using TechDrum.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\TechDrum\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using TechDrum.Web.Models.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\TechDrum\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using TechDrum.Web.Utils.Notification.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\TechDrum\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using TechDrum.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\TechDrum\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using TechDrum.Core.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\TechDrum\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using Invedia.Web.IUrlHelperUtils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\TechDrum\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using Invedia.Web.ITempDataDictionaryUtils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\TechDrum\Web\NagaCasino.Web\Areas\Portal\Views\_ViewImports.cshtml"
using EnumsNET;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d98503dd614406092f257bd8bea7a7da89f81709", @"/Areas/Portal/Views/AccountDashboard/Popup/_Tranfer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eae3cd7c5f504ec7b224d1e4808e92806345fd2", @"/Areas/Portal/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Portal_Views_AccountDashboard_Popup__Tranfer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("balance-form m-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""modal reveal insert-max tranfer2modal"" id=""withdraw_modal_usdx"" data-keyboard=""false"" data-backdrop=""static"" style="" padding: 3.33333rem 1rem; padding: 1rem; margin-top: 0% !important; padding-left: 20px; padding-right: 20px; "">
    <div class=""content_modal"">
        <h4 style=""font-size: 20px;"">TRANSFER</h4>
        <p>Available Withdraw: (<span id=""Available_Transfer""></span>)</p>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d98503dd614406092f257bd8bea7a7da89f817096064", async() => {
                WriteLiteral("\n            <label class=\"amount\">\n                Amount\n                <input placeholder=\" Amount*\" class=\"withdraw-value\" id=\"Amount_Transfer\"");
                BeginWriteAttribute("value", " value=\"", 586, "\"", 594, 0);
                EndWriteAttribute();
                WriteLiteral(@" autocomplete=""off"" name=""amount"" step=""0.1"" type=""tel"" min=""0.02"" required pattern=""^[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)$"">
                <span id=""max"" class=""btn fill-max-amount"" onclick=""maxWidthVIP()"">Max</span>
            </label>
            <label class=""amount"">
                User Name To
                <input style=""width:100%"" id=""address_Widthdraw_vip"" name=""address-widthdraw-vip"" type=""text"" autocomplete=""off""");
                BeginWriteAttribute("value", " value=\"", 1027, "\"", 1035, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"User Name\" pattern=\"^[a-z0-9]{1,20}$\">\n            </label>\n            <label class=\"amount\">\n                Mail To\n                <input style=\"width:100%\" id=\"mail-user-to\" name=\"address-widthdraw-vip\" type=\"email\" autocomplete=\"off\"");
                BeginWriteAttribute("value", " value=\"", 1289, "\"", 1297, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Email\" readonly>\n\n            </label>\n                <div id=\"result\"></div>\n");
#nullable restore
#line 21 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\TechDrum\Web\NagaCasino.Web\Areas\Portal\Views\AccountDashboard\Popup\_Tranfer.cshtml"
             if (Model.TwoFactorEnabled)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p class=\"p-0\">2FA Code: </p><input style=\"width:100%\" id=\"2fa-widthdraw-vip\" name=\"2FA-Widthdraw\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1572, "\"", 1580, 0);
                EndWriteAttribute();
                WriteLiteral("> <br />\n");
#nullable restore
#line 24 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\TechDrum\Web\NagaCasino.Web\Areas\Portal\Views\AccountDashboard\Popup\_Tranfer.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input style=\"width:100%\" id=\"2fa-widthdraw-vip\" name=\"2FA-Widthdraw\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1732, "\"", 1740, 0);
                EndWriteAttribute();
                WriteLiteral(" hidden> <br />\n");
#nullable restore
#line 28 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\TechDrum\Web\NagaCasino.Web\Areas\Portal\Views\AccountDashboard\Popup\_Tranfer.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <p class=""note"">Min TRANSFER <span style=""font-style:italic;"" id=""Widthdraw_Min_USDX""></span> <span style=""font-style:italic;"">NAGA</span></p>
            <a class=""note link-naga""href=""/policy"" target=""_blank"">POLICY **</a>
            <a id=""button_widthdrawVIP"" style=""height: auto; padding: 8px;"">Transfer</a>
            <input style=""background: #f0f8ff00; border: none;"" class=""close-button"" data-dismiss=""modal"" data-close aria-label=""Close reveal"" value=""x"" type=""button"" />
        ");
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
            WriteLiteral("\n    </div>\n</div>\n");
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
