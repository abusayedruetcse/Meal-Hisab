#pragma checksum "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\SignUp\AccountSignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "104099352f59624a0ca030d3ef4e0d90f3c5c3bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_SignUp_AccountSignUp), @"mvc.1.0.view", @"/Modules/Membership/Account/SignUp/AccountSignUp.cshtml")]
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
#line 1 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using MealHisab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"104099352f59624a0ca030d3ef4e0d90f3c5c3bd", @"/Modules/Membership/Account/SignUp/AccountSignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8602ea686e52cb9df8888bbf826dc27189c74926", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_SignUp_AccountSignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\SignUp\AccountSignUp.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.SignUp.FormTitle.ToString(Localizer);
    ViewData["PageId"] = "SignUp";
    Layout = MVC.Views.Shared._LayoutNoNavigation;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script id=\"Template_Membership_SignUpPanel\" type=\"text/template\">\r\n    <div>\r\n        <h3 class=\"page-title\">");
#nullable restore
#line 10 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\SignUp\AccountSignUp.cshtml"
                          Write(Texts.Forms.Membership.SignUp.FormTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p class=\"form-info\">");
#nullable restore
#line 11 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\SignUp\AccountSignUp.cshtml"
                        Write(Texts.Forms.Membership.SignUp.FormInfo.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <form id=""~_Form"" action="""">
            <div class=""s-Form"">
                <div class=""fieldset"">
                    <div id=""~_PropertyGrid""></div>
                    <div class=""clear""></div>
                </div>
                <div class=""buttons"">
                    <button id=""~_SubmitButton"" type=""submit"" class=""btn btn-primary"">
                        ");
#nullable restore
#line 20 "F:\FreeSoftBD\Solution\MealHisab\MealHisab\MealHisab\MealHisab.Web\Modules\Membership\Account\SignUp\AccountSignUp.cshtml"
                   Write(Texts.Forms.Membership.SignUp.SubmitButton.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </button>
                </div>
            </div>
        </form>
    </div>
</script>

<div class=""page-content"">
    <div id=""SignUpPanel"">
    </div>
</div>

<script type=""text/javascript"">
$(function() {
    new MealHisab.Membership.SignUpPanel($('#SignUpPanel')).init();
});
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
