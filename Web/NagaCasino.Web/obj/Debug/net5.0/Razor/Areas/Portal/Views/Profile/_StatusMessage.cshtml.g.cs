#pragma checksum "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\Profile\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4872bcc2fc03883633526244d5c6977610b3f3bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Portal_Views_Profile__StatusMessage), @"mvc.1.0.view", @"/Areas/Portal/Views/Profile/_StatusMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4872bcc2fc03883633526244d5c6977610b3f3bd", @"/Areas/Portal/Views/Profile/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eae3cd7c5f504ec7b224d1e4808e92806345fd2", @"/Areas/Portal/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Portal_Views_Profile__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\Profile\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 139, "\"", 196, 4);
            WriteAttributeValue("", 147, "alert", 147, 5, true);
            WriteAttributeValue(" ", 152, "alert-", 153, 7, true);
#nullable restore
#line 6 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\Profile\_StatusMessage.cshtml"
WriteAttributeValue("", 159, statusMessageClass, 159, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 178, "alert-dismissible", 179, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n        ");
#nullable restore
#line 8 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\Profile\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 10 "D:\Me\Source Code\Code New\.NET FRAMEWORK\Code New\New folder\Web\NagaCasino.Web\Areas\Portal\Views\Profile\_StatusMessage.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
